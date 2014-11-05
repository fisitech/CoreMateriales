echo off
"%programfiles(x86)%\Microsoft SQL Server\100\DTS\Binn\DTExec.exe" /F c:\temp\Materiales.dtsx  /DECRYPT 123 /SET \Package.Variables[User::filepath].Properties[Value];"c:\temp\materiales.csv" /REP N
echo %ERRORLEVEL%
pause
