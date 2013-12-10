@echo off

pushd "%~dp0"

powershell -file ".\Generate Tests.ps1"

pause

popd
