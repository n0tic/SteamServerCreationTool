# SSCT | Steam Server Creation Tool
![](http://bytevaultstudio.se/ShareX/notepad%2B%2B_nF3TcZTIkp.png)

Steam Server Creation Tool is a simple GUI based server installation tool for servers hosted at steam. 
It automates downloading and the usage of steamCMD to install servers extrapolated from steams API so it will always dynamically stay up-to-date if there are any servers added or removed.

# How does it work?
The only thing you NEED in order to get going with the application is "steamcmd.exe".
This application comes with auto-downlaod-and-reference feature so just press "Install SteamCMD".
This application is completely portable so it doesn't add or make any changes to regedit or such.
The application uses json data to store and load your data between sessions. The data will be in app root folder.

Step-by-Step, how do I use this application:
- Install and reference "steamcmd.exe" automatically by pressing "Install SteamCMD" button and selecting a install directory.
- Additionally you can locate "steamcmd.exe" manually by using the button "Locate SteamCMD".
  - If you don't already have "steamcmd.exe" on your system you can download it manually:
    - Direct download: https://steamcdn-a.akamaihd.net/client/installer/steamcmd.zip
    - Page with download link: https://developer.valvesoftware.com/wiki/SteamCMD
- "steamcmd.exe" has been located by the application. Whats the next step?
  - Step one: Find your desired server in the list and select it. Information bellow should update with "App ID, App Name" etc.
  - Step two: Click on the textfield to get the folder browser dialogue to open. Create or select a desired install folder.
  - Step three: Click "Install Server" button to start the installation of the server. The cmd window (Black box window) will disappear once the install is completed. 
    - Closing the cmd window (Black box window) prematurely will result in installation failure. SSCT have no way of detecting a successful installation so be careful.
  - Step four: Once the server has been installed your next mission will be to setup the server and if the idea is to lauch a server publicly, you need to open server-specific ports. If you run any firewalls you may need to accept them there too.
  
# Requirements
- Internet Connection
- .NET Framework 4.7.2
- System.IO.Compression (.Net 4.5+ should suffice)
- Newtonsoft Json

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

# Usage Preview
![](http://bytevaultstudio.se/ShareX/5kpfjOOoKz.gif)
