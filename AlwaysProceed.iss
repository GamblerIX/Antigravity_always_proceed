[Setup]
AppName=AlwaysProceed Clicker
AppVersion=1.0.0
DefaultDirName={autopf}\AlwaysProceed
DefaultGroupName=AlwaysProceed
OutputBaseFilename=AlwaysProceed_Setup
OutputDir=Output
Compression=lzma
SolidCompression=yes
PrivilegesRequired=admin

[Files]
Source: "publish\AlwaysProceed.exe"; DestDir: "{app}"; Flags: ignoreversion

[Icons]
Name: "{group}\AlwaysProceed Clicker"; Filename: "{app}\AlwaysProceed.exe"
Name: "{commondesktop}\AlwaysProceed Clicker"; Filename: "{app}\AlwaysProceed.exe"
