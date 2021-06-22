<img src="https://socialify.git.ci/n0tic/SteamServerCreationTool/image?description=1&font=Inter&forks=1&issues=1&language=1&owner=1&pattern=Floating%20Cogs&pulls=1&stargazers=1&theme=Light" alt="Banner" width="768"/>

<p align="center">
  <img alt="GitHub release (latest by date including pre-releases)" src="https://img.shields.io/github/v/release/n0tic/SteamServerCreationTool?color=seagreen&include_prereleases">
  <img src="https://img.shields.io/badge/status-Beta-blue" />
  <img alt="GitHub all releases" src="https://img.shields.io/github/downloads/n0tic/SteamServerCreationTool/total?color=orange&label=downloads">
  <img alt="GitHub last commit" src="https://img.shields.io/github/last-commit/n0tic/SteamServerCreationTool?color=crimson">
  <img alt="Visitor Count" src="https://visitor-badge.glitch.me/badge?page_id=n0tic.SteamServerCreationTool">
</p>

### WIP : NOTE : Work In Progress
NOTE: Before updating SSCT Steam Server Creation Tool - Backup your server data/settings!
If prompted with "Load Data Error!"-dialogue, simply install servers on the same location. A new settings file will be created.

---------------------------------------------------------------------------------------------------------------------------------

![Image Preview](http://bytevaultstudio.se/ShareX/SteamServerCreationTool_qSXUhdDBoe.png)
![Image Preview](http://bytevaultstudio.se/ShareX/SteamServerCreationTool_RiPqPqSR34.png)

# Steam Server Creation Tool #
Steam Server Creation Tool is a simple GUI based server installation tool. It's an easy and quick tool to install and manage servers. It "automates" the usage of SteamCMD to install servers extrapolated from Steam's API. This application is designed around an "always up to date" idea and should work forever, even if steam adds/remove servers.

# How does it work?
[![YoutubeImage](http://bytevaultstudio.se/ShareX/youtubeX.png)](https://youtu.be/54oPT-_8D4U)

The Image above will take you to a Youtube video.

The application is requesting a full list of applications from the Steam's API so it will always stay up-to-date with what steam has to offer.
It extrapolates servers from that list, creates a database with name and reference ID which the application then uses.

- Application fetch app list from:
  - API: https://api.steampowered.com/ISteamApps/GetAppList/v2
- Application fetch steamcmd from:
  - Website: https://developer.valvesoftware.com/wiki/SteamCMD
  - Direct: https://steamcdn-a.akamaihd.net/client/installer/steamcmd.zip

# StartServerScript?
NOTE: This is not a required/needed feature to run most servers.

Inside the root folder of the created server there will be a generated batch (.bat) file called "StartServerScript.bat".
This file will be a supplement for the server. This script will automatically update the server and validate files before trying to start the server.
If the server crash while started with the StartServerScript, the server will automatically restart.

Before this script can be used correctly it will will need to be updated with valid information. 
You need to edit rows 19, 20, 21. In this case I demo the valheim server.
```
SET serverExecutablePath=D:\Valheim Server
SET serverExecutableFileName=valheim_server.exe
SET serverLaunchOptions=-nographics -batchmode -name "MyFirstServer" -port 2456 -world "DedicatedServer" -password "SomePasswordHere"
```
From what we can see above we have the valheim server located at the "D:\" drive and inside the folder "Valheim Server".
The server is set to launch the file "valheim_server.exe" with the launch options:

-nographics -batchmode -name "MyFirstServer" -port 2456 -world "DedicatedServer" -password "SomePasswordHere"

If this would be valid information, the script would then run the server and monitor that process. If this window is closed or the server has crashed, the server will automatically be restarted as the StartServerScript is protecting the process. In order to stop the server from restarting you need to close the StartServerScript first - Alternatively, select Y to terminate the process; When prompted.

NOTE: If there are any problems connecting to the server, server crashes or the server is miss configured. You'll need to configure that yourself by looking up a guide. This has nothing to do with the script itself. Good luck!
  
# Requirements
- Internet Connection
- .NET Framework 4.5 (Windows 10 Standard)
- Newtonsoft Json (Included)

# Bugs?
- None reported / None found

# Disclamer
Newtonsoft Json:
```
The MIT License (MIT)

Copyright (c) 2007 James Newton-King

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
```

All files are provided as-is with no express or implied warranty. No liability for content in external links.

I'm not affiliated, associated, endorsed by, or in any way officially connected with Steam, Valve or any of its subsidiaries or its affiliates. SSCT | Steam Server Creation Tool and all its content is provided "as is" and "with all faults." I makes no representations or warranties of any kind concerning the safety, suitability, inaccuracies, typographical errors, or other components mishaps. I guarantee no accuracy or completeness of any information or usage on or in this project or found by following any link in this readme. There are inherent dangers in the use of any software, and you are solely responsible for determining whether this software is compatible with your equipment and other softwares installed on your equipment. You are also solely responsible for the protection of your equipment and backup of your data, and I will be liable for any damages you may suffer in connection with using, modifying, or distributing SSCT | Steam Server Creation Tool.

# More Previews!
![Image Preview](http://bytevaultstudio.se/ShareX/SteamServerCreationTool_qSXUhdDBoe.png)
![Image Preview](http://bytevaultstudio.se/ShareX/SteamServerCreationTool_RiPqPqSR34.png)
![Image Preview](http://bytevaultstudio.se/ShareX/SteamServerCreationTool_WEZZCA4Zsd.png)
![Image Preview](http://bytevaultstudio.se/ShareX/SteamServerCreationTool_nhdkKNVqnc.png)
