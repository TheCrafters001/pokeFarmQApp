; Script generated by the Inno Script Studio Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "Pok�Farm Q Desktop App"
#define MyAppVersion "1.1.0"
#define MyAppPublisher "TheCrafters001"
#define MyAppExeName "PokeFarm.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{B17E16B7-C20B-4B2E-AFE3-3BEE20003C15}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
DefaultDirName={autopf}\TheCrafters001\{#MyAppName}
DefaultGroupName=TheCrafters001\{#MyAppName}
AllowNoIcons=yes
LicenseFile=..\..\licenses\mit.rtf
OutputBaseFilename=PokeFarmSetup
Compression=lzma
SolidCompression=yes
DisableWelcomePage=False
WizardStyle=modern
AppCopyright=Copyright (c) 2023 TheCrafters001
PrivilegesRequired=lowest
PrivilegesRequiredOverridesAllowed=dialog

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked; OnlyBelowVersion: 0,6.1

[Files]
Source: "..\PokeFarm\PokeFarm\bin\Release\net6.0-windows\PokeFarm.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\PokeFarm\PokeFarm\bin\Release\net6.0-windows\Microsoft.Web.WebView2.Core.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\PokeFarm\PokeFarm\bin\Release\net6.0-windows\Microsoft.Web.WebView2.WinForms.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\PokeFarm\PokeFarm\bin\Release\net6.0-windows\Microsoft.Web.WebView2.Wpf.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\PokeFarm\PokeFarm\bin\Release\net6.0-windows\PokeFarm.deps.json"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\PokeFarm\PokeFarm\bin\Release\net6.0-windows\PokeFarm.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\PokeFarm\PokeFarm\bin\Release\net6.0-windows\PokeFarm.dll.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\PokeFarm\PokeFarm\bin\Release\net6.0-windows\PokeFarm.runtimeconfig.json"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files
Source: "..\PokeFarm\PokeFarm\bin\Release\net6.0-windows\runtimes\win-arm64\native\WebView2Loader.dll"; DestDir: "{app}\runtimes\win-arm64\native"; Flags: ignoreversion
Source: "..\PokeFarm\PokeFarm\bin\Release\net6.0-windows\runtimes\win-x64\native\WebView2Loader.dll"; DestDir: "{app}\runtimes\win-x64\native"; Flags: ignoreversion
Source: "..\PokeFarm\PokeFarm\bin\Release\net6.0-windows\runtimes\win-x86\native\WebView2Loader.dll"; DestDir: "{app}\runtimes\win-x86\native"; Flags: ignoreversion

; NOTE: Auto Update Files
Source: "..\PokeFarm\PokeFarm\bin\Release\net6.0-windows\AutoUpdater.NET.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\PokeFarm\PokeFarm\bin\Release\net6.0-windows\ar\AutoUpdater.NET.resources.dll"; DestDir: "{app}\ar"; Flags: ignoreversion
Source: "..\PokeFarm\PokeFarm\bin\Release\net6.0-windows\cs\AutoUpdater.NET.resources.dll"; DestDir: "{app}\cs"; Flags: ignoreversion
Source: "..\PokeFarm\PokeFarm\bin\Release\net6.0-windows\da\AutoUpdater.NET.resources.dll"; DestDir: "{app}\da"; Flags: ignoreversion
Source: "..\PokeFarm\PokeFarm\bin\Release\net6.0-windows\de\AutoUpdater.NET.resources.dll"; DestDir: "{app}\de"; Flags: ignoreversion
Source: "..\PokeFarm\PokeFarm\bin\Release\net6.0-windows\es\AutoUpdater.NET.resources.dll"; DestDir: "{app}\es"; Flags: ignoreversion
Source: "..\PokeFarm\PokeFarm\bin\Release\net6.0-windows\fr\AutoUpdater.NET.resources.dll"; DestDir: "{app}\fr"; Flags: ignoreversion
Source: "..\PokeFarm\PokeFarm\bin\Release\net6.0-windows\it\AutoUpdater.NET.resources.dll"; DestDir: "{app}\it"; Flags: ignoreversion
Source: "..\PokeFarm\PokeFarm\bin\Release\net6.0-windows\ja-JP\AutoUpdater.NET.resources.dll"; DestDir: "{app}\ja-JP"; Flags: ignoreversion
Source: "..\PokeFarm\PokeFarm\bin\Release\net6.0-windows\ko\AutoUpdater.NET.resources.dll"; DestDir: "{app}\ko"; Flags: ignoreversion
Source: "..\PokeFarm\PokeFarm\bin\Release\net6.0-windows\lv\AutoUpdater.NET.resources.dll"; DestDir: "{app}\lv"; Flags: ignoreversion
Source: "..\PokeFarm\PokeFarm\bin\Release\net6.0-windows\nl\AutoUpdater.NET.resources.dll"; DestDir: "{app}\nl"; Flags: ignoreversion
Source: "..\PokeFarm\PokeFarm\bin\Release\net6.0-windows\pl\AutoUpdater.NET.resources.dll"; DestDir: "{app}\pl"; Flags: ignoreversion
Source: "..\PokeFarm\PokeFarm\bin\Release\net6.0-windows\pt\AutoUpdater.NET.resources.dll"; DestDir: "{app}\pt"; Flags: ignoreversion
Source: "..\PokeFarm\PokeFarm\bin\Release\net6.0-windows\pt-BR\AutoUpdater.NET.resources.dll"; DestDir: "{app}\pt-BR"; Flags: ignoreversion
Source: "..\PokeFarm\PokeFarm\bin\Release\net6.0-windows\ru\AutoUpdater.NET.resources.dll"; DestDir: "{app}\ru"; Flags: ignoreversion
Source: "..\PokeFarm\PokeFarm\bin\Release\net6.0-windows\sk\AutoUpdater.NET.resources.dll"; DestDir: "{app}\sk"; Flags: ignoreversion
Source: "..\PokeFarm\PokeFarm\bin\Release\net6.0-windows\sv\AutoUpdater.NET.resources.dll"; DestDir: "{app}\sv"; Flags: ignoreversion
Source: "..\PokeFarm\PokeFarm\bin\Release\net6.0-windows\th\AutoUpdater.NET.resources.dll"; DestDir: "{app}\th"; Flags: ignoreversion
Source: "..\PokeFarm\PokeFarm\bin\Release\net6.0-windows\tr\AutoUpdater.NET.resources.dll"; DestDir: "{app}\tr"; Flags: ignoreversion
Source: "..\PokeFarm\PokeFarm\bin\Release\net6.0-windows\zh\AutoUpdater.NET.resources.dll"; DestDir: "{app}\zh"; Flags: ignoreversion
Source: "..\PokeFarm\PokeFarm\bin\Release\net6.0-windows\zh-TW\AutoUpdater.NET.resources.dll"; DestDir: "{app}\zh-TW"; Flags: ignoreversion

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{group}\{cm:UninstallProgram,{#MyAppName}}"; Filename: "{uninstallexe}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: quicklaunchicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

[Dirs]
Name: "{app}\runtimes"
Name: "{app}\runtimes\win-arm64"
Name: "{app}\runtimes\win-arm64\native"
Name: "{app}\runtimes\win-x64"
Name: "{app}\runtimes\win-x64\native"
Name: "{app}\runtimes\win-x86"
Name: "{app}\runtimes\win-x86\native"

Name: "{app}\ar"
Name: "{app}\cs"
Name: "{app}\da"
Name: "{app}\de"
Name: "{app}\es"
Name: "{app}\fr"
Name: "{app}\it"
Name: "{app}\ja-JP"
Name: "{app}\ko"
Name: "{app}\lv"
Name: "{app}\nl"
Name: "{app}\pl"
Name: "{app}\pt"
Name: "{app}\pt-BR"
Name: "{app}\ru"
Name: "{app}\sk"
Name: "{app}\sv"
Name: "{app}\th"
Name: "{app}\tr"
Name: "{app}\zh"
Name: "{app}\zh-TW"
