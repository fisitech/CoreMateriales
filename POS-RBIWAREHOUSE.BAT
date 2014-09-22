rem  Corre el comando remoto de compresion en Portal 
REM psexec \\portal "c:\ftp\localuser\aerotec\comprimir.bat"

rem Copia archivo RAR a disco local L y Si existe lo sobreescribe
REM copy \\portal\aerotec\po.rar L:\rbi\amex\pos\ /Y

rem Descomprime
REM set path="C:\Program Files\WinRAR\";%path%
L:
cd \rbi\amex\pos\
REM unrar e -o+ L:\rbi\amex\pos\po.rar


rem Importa archivo a Excel

copy  \\RBIWAREHOUSE\FTP\po.xls L:\rbiinbon\amex\pos\
copy  \\RBIWAREHOUSE\FTP\po.xls L:\labinal\
copy  \\RBIWAREHOUSE\FTP\poc.xls L:\rbiinbon\amex\pos\
copy  \\RBIWAREHOUSE\FTP\poc.xls L:\labinal\
Start L:\labinal.xls
