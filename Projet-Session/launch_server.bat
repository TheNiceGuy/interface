@echo off
mode 150,40
Server\Server\bin\x64\Debug\Server.exe --nogui --address 127.0.0.1 --port 1420 -d "database.accdb"
pause