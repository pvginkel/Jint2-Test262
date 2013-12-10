Function MakeIdentifier([string]$Name)
{
    $Result = ""

    if ([Char]::IsDigit($Name[0]))
    {
        $Result += "_"
    }

    for ($I = 0; $I -lt $Name.Length; $I++)
    {
        $C = $Name.Substring($I, 1)

        if ($C -ne "_" -and -not [Char]::IsLetterOrDigit($C))
        {
            $Result += "_"
        }
        elseif ($Result -eq "")
        {
            $Result += $C.ToUpper()
        }
        else
        {
            $Result += $C
        }
    }

    return $Result
}

Function ParseScript([string]$Script)
{
    $Attributes = @{ }

    $InComments = $False

    foreach ($Line in [IO.File]::ReadAllLines($Script))
    {
        if ($InComments)
        {
            if ($Line.Contains("*/"))
            {
                $InComments = $False
            }
            else
            {
                if ($Line -match "(@[^ ]+)(?: (.*))?")
                {
                    $Attributes.Add($Matches[1], $Matches[2])
                }
            }
        }
        elseif ($Line.Contains("/*"))
        {
            $InComments = $True
        }
    }

    return $Attributes
}

Function StringEncode([string]$Value)
{
    return $Value.Replace("\", "\\").Replace("`"", "\`"")
}

$Encoding = New-Object System.Text.UTF8Encoding -ArgumentList $True
$Root = Split-Path -Path $MyInvocation.MyCommand.Definition -Parent
$Tests = $Root + "\Tests"

$Targets = @{ }

foreach ($Path in (Get-ChildItem -Path $Tests -Include "*.js" -Recurse))
{
    $Path = $Path.FullName.Substring($Tests.Length + 1)
    
    $Pos = $Path.LastIndexOf("\")
    $Directory = $Path.Substring(0, $Pos)
    $File = $Path.Substring($Pos + 1)

    if (-not $Targets.ContainsKey($Directory))
    {
        $Target = @{
            "Directory" = $Directory;
            "Tests" = @( )
        }

        $Targets.Add($Directory, $Target)
    }
    else
    {
        $Target = $Targets.get_Item($Directory)
    }

    $Target.Tests += $File
}

foreach ($Target in $Targets.Values)
{
    $Pos = $Target.Directory.LastIndexOf("\")

    if ($Pos -eq -1)
    {
        $Directory = $Null
        $File = $Target.Directory
    }
    else
    {
        $Directory = $Target.Directory.Substring(0, $Pos)
        $File = $Target.Directory.Substring($Pos + 1)
    }

    $Sb = New-Object System.Text.StringBuilder

    [void]$Sb.AppendLine("//------------------------------------------------------------------------------")
    [void]$Sb.AppendLine("// <auto-generated>")
    [void]$Sb.AppendLine("//     This code was generated by a tool.")
    [void]$Sb.AppendLine("//")
    [void]$Sb.AppendLine("//     Changes to this file may cause incorrect behavior and will be lost if")
    [void]$Sb.AppendLine("//     the code is regenerated.")
    [void]$Sb.AppendLine("// </auto-generated>")
    [void]$Sb.AppendLine("//------------------------------------------------------------------------------")
    [void]$Sb.AppendLine()
    [void]$Sb.AppendLine("using System;")
    [void]$Sb.AppendLine("using System.Collections.Generic;")
    [void]$Sb.AppendLine("using System.Linq;")
    [void]$Sb.AppendLine("using System.Text;")
    [void]$Sb.AppendLine("using NUnit.Framework;")
    [void]$Sb.AppendLine()

    $Ns = ""
    if ($Directory -ne $Null)
    {
        foreach ($Item in $Directory.Split("\"))
        {
            $Ns += "." + (MakeIdentifier -Name $Item)
        }
    }

    [void]$Sb.AppendLine("namespace Jint.Test262" + $Ns)
    [void]$Sb.AppendLine("{")

    $Class = (MakeIdentifier -Name $File) + "Fixture"

    [void]$Sb.AppendLine("    [TestFixture]")
    [void]$Sb.AppendLine("    public class " + $Class + " : Test262Fixture")
    [void]$Sb.AppendLine("    {")
    [void]$Sb.AppendLine("        public " + $Class + "()")
    [void]$Sb.AppendLine("            : base(`"" + (StringEncode -Value $Target.Directory) + "`")")
    [void]$Sb.AppendLine("        {")
    [void]$Sb.AppendLine("        }")

    $Names = @( )

    foreach ($Test in $Target.Tests)
    {
        $Attributes = ParseScript -Script ($Tests + "\" + $Target.Directory + "\" + $Test)

        [void]$Sb.AppendLine()

        $Name = $Test.Substring(0, $Test.Length - 3)

        $TestLine = "[Test"

        if ($Attributes.ContainsKey("@description"))
        {
            $TestLine += "(Description = `"" + (StringEncode -Value $Attributes.get_Item("@description")) + "`")"
        }

        $TestLine += "]"

        [void]$Sb.AppendLine("        " + $TestLine)

        if ($Attributes.ContainsKey("@negative"))
        {
            [void]$Sb.AppendLine("        [ExpectedException]")
        }

        $Name = MakeIdentifier -Name $Name

        for ($I = 0; ; $I++)
        {
            $Proposal = $Name
            if ($I -gt 0)
            {
                $Proposal += "_" + $I
            }

            if (-not ($Names -contains $Proposal))
            {
                $Name = $Proposal
                $Names += $Name
                break
            }
        }

        [void]$Sb.AppendLine("        public void " + $Name + "()")
        [void]$Sb.AppendLine("        {")
        [void]$Sb.AppendLine("            RunFile(`"" + $Test + "`");")
        [void]$Sb.AppendLine("        }")
    }

    [void]$Sb.AppendLine("    }")
    [void]$Sb.AppendLine("}")

    $TargetPath = $Root

    if ($Directory -ne $Null)
    {
        $NiceDirectory = ""

        foreach ($Item in $Directory.Split("\"))
        {
            if ($NiceDirectory -ne "")
            {
                $NiceDirectory += "\"
            }

            $NiceDirectory += $Item.Substring(0, 1).ToUpper() + $Item.Substring(1)
        }

        if (-not (Test-Path -Path $NiceDirectory))
        {
            [void](New-Item -ItemType Directory -Path $NiceDirectory)
        }

        $TargetPath += "\" + $NiceDirectory
    }

    $TargetPath += "\" + $Class + ".cs"

    [IO.File]::WriteAllText($TargetPath, $Sb.ToString(), $Encoding)
}