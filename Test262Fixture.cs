using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using Jint.Compiler;
using Jint.Test262.Support;
using Jint.Tests.Support;

namespace Jint.Test262
{
    public abstract class Test262Fixture : TestBase
    {
        private static readonly TimeSpan ScriptTimeout = TimeSpan.FromSeconds(5);

        private static readonly string _basePath;
        private static readonly string _libPath;
        private static readonly Dictionary<string, string> _includeCache = new Dictionary<string, string>();

        protected override string BasePath
        {
            get { return _basePath; }
        }

        static Test262Fixture()
        {
            var assemblyDirectory = new DirectoryInfo(Path.GetDirectoryName(typeof(TestBase).Assembly.Location));

            _basePath = assemblyDirectory.Parent.Parent.FullName;
            _libPath = Path.Combine(_basePath, "Lib");
            _basePath = Path.Combine(_basePath, "Tests");

            // We don't need the assembly stored to disk.
            DynamicAssemblyManager.SaveAssembly = false;
        }

        protected override string GetInclude(string file)
        {
            string source;

            if (!_includeCache.TryGetValue(file, out source))
            {
                source = File.ReadAllText(Path.Combine(_libPath, file));

                _includeCache.Add(file, source);
            }

            return source;
        }

        protected Test262Fixture(string testsPath)
            : base(testsPath)
        {
        }

        protected override JintEngine CreateContext(Action<string> errorAction)
        {
            var engine = base.CreateContext(errorAction);

            engine.DisableSecurity();
            engine.Run(GetInclude("framework.js") + GetInclude("environment.js"));

            return engine;
        }

        protected override object RunFile(JintEngine ctx, string fileName)
        {
            if (Debugger.IsAttached)
                return base.RunFile(ctx, fileName);
            else
                return Timeout.Run(() => base.RunFile(ctx, fileName), ScriptTimeout);
        }

        protected override object RunScript(JintEngine ctx, string script)
        {
            if (Debugger.IsAttached)
                return base.RunScript(ctx, script);
            else
                return Timeout.Run(() => base.RunScript(ctx, script), ScriptTimeout);
        }
    }
}
