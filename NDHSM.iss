[Setup]
AppName=NDHSM Clicker
AppVersion=1.0.0
DefaultDirName={autopf}\NDHSM
DefaultGroupName=NDHSM
OutputBaseFilename=NDHSM_Setup
Compression=lzma
SolidCompression=yes
PrivilegesRequired=admin

[Files]
Source: "publish\NDHSM.exe"; DestDir: "{app}"; Flags: ignoreversion

[Icons]
Name: "{group}\NDHSM Clicker"; Filename: "{app}\NDHSM.exe"
Name: "{commondesktop}\NDHSM Clicker"; Filename: "{app}\NDHSM.exe"
