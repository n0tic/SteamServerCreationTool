<img src="https://socialify.git.ci/n0tic/SteamServerCreationTool/image?description=1&font=Inter&forks=1&issues=1&language=1&owner=1&pattern=Floating%20Cogs&pulls=1&stargazers=1&theme=Light" alt="Banner" width="768"/>

<p align="center">
  <img src="https://img.shields.io/badge/status-Alpha-blue" />
  <img alt="GitHub all releases" src="https://img.shields.io/github/downloads/n0tic/SteamServerCreationTool/total?color=orange&label=downloads">
  <img alt="GitHub release (latest by date including pre-releases)" src="https://img.shields.io/github/v/release/n0tic/SteamServerCreationTool?color=seagreen&include_prereleases">
  <img alt="GitHub last commit" src="https://img.shields.io/github/last-commit/n0tic/SteamServerCreationTool?color=crimson">
  <img alt="Visitor Count" src="https://visitor-badge.glitch.me/badge?page_id=n0tic.SteamServerCreationTool">
</p>

![Image Preview](http://bytevaultstudio.se/ShareX/SteamServerCreationTool_D6oDqkanhq.png)

Steam Server Creation Tool is a simple GUI based server installation tool.
It automates downloading and the usage of SteamCMD to install servers extrapolated from SteamAPI so it will always stay up-to-date with what steam has to offer. This should keep the application up-to-date, forever.

# How does it work?
The application is requesting a full list of applications from the steams API so it will always stay up-to-date with what steam has to offer.
It extrapolates servers from that list using the keyword "server", creates a database with IDs and names which the application then uses.

Step-by-Step, how do I use this application:
- Install and reference "steamcmd.exe" automatically by pressing "Install SteamCMD" button and selecting a install directory.
- Additionally you can locate "steamcmd.exe" manually by using the button "Locate SteamCMD".
  - If you don't already have "steamcmd.exe" on your system you can download it manually:
    - Direct download: https://steamcdn-a.akamaihd.net/client/installer/steamcmd.zip
    - Page with download link: https://developer.valvesoftware.com/wiki/SteamCMD
- "steamcmd.exe" has been located by the application. Whats the next step?
  - Step one: Find your desired server in the list and select it. Information bellow should update with "App ID, App Name" etc.
  - Step two: Click on the button "Create Server" and a dialogue/form will open. Give the server a name, install directory and complete creation by pressing "Install Server".
  - Step three: The cmd window (Black box window) will appear and install the server. The cmd window will disappear once the install has completed. 
    - Closing the cmd window (Black box window) prematurely will result in installation failure. However, SSCT have no way of detecting a successful installation so be careful. Let the installation window (cmd) close itself.
  - Step four: Once the server has been installed your next mission will be to setup the server and if the idea is to lauch a server publicly, you need to open specific ports related to the server. If you run any firewalls you may need to accept them there too.
  
# Requirements
- Internet Connection
- .NET Framework 4.7.2 (+System.IO.Compression)
- Newtonsoft Json (Included)

# Bugs?
I've noticed the application not getting a response from the API causing the application to end up looping forever. Will look into this in the future.

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
![Image Preview](https://bytevaultstudio.se/ShareX/SteamServerCreationTool_lz8vSbVBwZ.png)
![Image Preview](https://bytevaultstudio.se/ShareX/SteamServerCreationTool_Rch61lrBjM.png)
![Image Preview](https://bytevaultstudio.se/ShareX/SteamServerCreationTool_tJykqy2oIW.png)
![Image Preview](https://bytevaultstudio.se/ShareX/SteamServerCreationTool_01I8ZZKSgG.png)
Gif: [https://bytevaultstudio.se/ShareX/aie4rcXY8C.gif](https://bytevaultstudio.se/ShareX/aie4rcXY8C.gif)
