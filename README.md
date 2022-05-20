![Explorestart](https://socialify.git.ci/Hope-IT-Works/Explorestart/image?description=1&font=Inter&logo=https%3A%2F%2Fraw.githubusercontent.com%2FHope-IT-Works%2FExplorestart%2Fmain%2Fresources%2Flogo%2Fexplorestart.svg&name=1&owner=1&pattern=Solid&theme=Light)
# Explorestart
simple tool to restart explorer.exe on Windows

**WARNING:** This tool kills explorer.exe and therefore all running data transfers etc. Use at your own risk.

## Download
| Name | Description | OS | Arch | Download |
| --- | --- | --- | --- | --- |
| `explorestart-portable-v1.0.exe` | Portable | Windows 10 or higher | x86 and x64 | [Download](https://github.com/Hope-IT-Works/Explorestart/releases/download/v1.0/explorestart-portable-v1.0.exe) |
| `explorestart-setup-v1.0.exe` | Setup | Windows 10 or higher | x86 and x64 | [Download](https://github.com/Hope-IT-Works/Explorestart/releases/download/v1.0/explorestart-setup-v1.0.exe) |

## Anti-Virus false positives
Some anti-virus softwares are detecting Explorestart as virus. These warnings can be ignored and you can add exceptions for Explorestart in your anti-virus software.

This has probably has to do with these reasons:
- executable is not signed with a EV Code Signing certificate
- executable runs embedded PowerShell code
 
[VirusTotal result](https://www.virustotal.com/gui/file/ec1ee254229b1a1665469f18e766a631b346a537f4846b7da79cfe6950978dab/detection)

e.g. [Microsft Windows-Security](https://www.microsoft.com/en-us/wdsi/threats/malware-encyclopedia-description?name=Trojan%3aWin32%2fWacatac.B!ml&threatid=2147735505):

![image](https://user-images.githubusercontent.com/52013820/169492306-5d5627aa-db1f-4b78-abe5-456c874d4905.png)
