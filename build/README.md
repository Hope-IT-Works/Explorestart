# How to build
What you need:
- [ps2exe.ps1](https://github.com/MScholtes/Win-PS2EXE/blob/master/ps2exe.ps1)
- [Explorestart.ps1](https://github.com/Hope-IT-Works/Explorestart/blob/main/src/Explorestart.ps1)
- [Explorestart.ico](https://github.com/Hope-IT-Works/Explorestart/blob/main/resources/logo/explorestart.ico)

Start PowerShell, navigate to a folder with the files from above and execute the following command:
```powershell
.\ps2exe.ps1 -inputFile ".\Explorestart.ps1" -outputFile ".\Explorestart.exe" -STA -noConsole -iconFile ".\Explorestart.ico" -title "Explorestart" -description "simple tool to restart explorer.exe" -company "Hope-IT-Works" -product "Explorestart" -copyright "Copyright © 2022 Tobias Meyer" -trademark "Explorestart™; Hope-IT-Works™" -version "1.0.0.0" -noOutput -noError -UNICODEEncoding
```
