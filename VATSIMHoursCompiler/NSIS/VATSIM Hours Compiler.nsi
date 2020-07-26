############################################################################################
#      NSIS Installation Script created by NSIS Quick Setup Script Generator v1.39.18
#               Entirely Edited with NullSoft Scriptable Installation System                
#              by Vlasis K. Barkas aka Red Wine red_wine@freemail.gr Sep 2006               
############################################################################################

!define APP_NAME "VATSIM Hours Compiler"
!define COMP_NAME "Lenny Colton"
!define VERSION "1.3.0.0"
!define COPYRIGHT "� 2020 Lenny Colton - All Rights Reserved"
!define DESCRIPTION "A simple tool to view the hours accrued by VATSIM members on various ATC positions or position groups. The data is tabulated and can be exported as a .csv file."
!define INSTALLER_NAME "D:\Lenny\Documents\Visual Studio Projects\VATSIMHoursCompiler\VATSIMHoursCompiler\NSIS\VATSIMHoursCompiler-1.4-Setup.exe"
!define MAIN_APP_EXE "VATSIMHoursCompiler.exe"
!define INSTALL_TYPE "SetShellVarContext all"
!define REG_ROOT "HKLM"
!define REG_APP_PATH "Software\Microsoft\Windows\CurrentVersion\App Paths\${MAIN_APP_EXE}"
!define UNINSTALL_PATH "Software\Microsoft\Windows\CurrentVersion\Uninstall\${APP_NAME}"

!define REG_START_MENU "Start Menu Folder"

var SM_Folder

######################################################################

VIProductVersion  "${VERSION}"
VIAddVersionKey "ProductName"  "${APP_NAME}"
VIAddVersionKey "CompanyName"  "${COMP_NAME}"
VIAddVersionKey "LegalCopyright"  "${COPYRIGHT}"
VIAddVersionKey "FileDescription"  "${DESCRIPTION}"
VIAddVersionKey "FileVersion"  "${VERSION}"

######################################################################

SetCompressor ZLIB
Name "${APP_NAME}"
Caption "${APP_NAME}"
OutFile "${INSTALLER_NAME}"
BrandingText "${APP_NAME}"
XPStyle on
InstallDirRegKey "${REG_ROOT}" "${REG_APP_PATH}" ""
InstallDir "$PROGRAMFILES\VATSIM Hours Compiler"

######################################################################

!include "MUI.nsh"
!include "MUI2.nsh"

!define MUI_ABORTWARNING
!define MUI_UNABORTWARNING

!define MUI_ICON "D:\Lenny\Documents\Visual Studio Projects\VATSIMHoursCompiler\VATSIMHoursCompiler\vatsimuk blips.ico"
!define MUI_HEADERIMAGE
!define MUI_HEADERIMAGE_BITMAP "D:\Lenny\Documents\Visual Studio Projects\VATSIMHoursCompiler\VATSIMHoursCompiler\vatsimuk blips.png"
!define MUI_HEADERIMAGE_RIGHT

!insertmacro MUI_PAGE_WELCOME

!ifdef LICENSE_TXT
!insertmacro MUI_PAGE_LICENSE "${LICENSE_TXT}"
!endif

!insertmacro MUI_PAGE_DIRECTORY

!ifdef REG_START_MENU
!define MUI_STARTMENUPAGE_DEFAULTFOLDER "VATSIM Hours Compiler"
!define MUI_STARTMENUPAGE_REGISTRY_ROOT "${REG_ROOT}"
!define MUI_STARTMENUPAGE_REGISTRY_KEY "${UNINSTALL_PATH}"
!define MUI_STARTMENUPAGE_REGISTRY_VALUENAME "${REG_START_MENU}"
!insertmacro MUI_PAGE_STARTMENU Application $SM_Folder
!endif

!insertmacro MUI_PAGE_INSTFILES

!define MUI_FINISHPAGE_RUN "$INSTDIR\${MAIN_APP_EXE}"
!insertmacro MUI_PAGE_FINISH

!insertmacro MUI_UNPAGE_CONFIRM

!insertmacro MUI_UNPAGE_INSTFILES

!insertmacro MUI_UNPAGE_FINISH

!insertmacro MUI_LANGUAGE "English"

######################################################################

Section -MainProgram

; Check to see if already installed
  ReadRegStr $R0 ${REG_ROOT} "${UNINSTALL_PATH}" "UninstallString"
  IfFileExists $R0 +1 NotInstalled
  MessageBox MB_YESNO "${APP_NAME} is already installed. Uninstall the existing version?" /SD IDYES IDNO Quit
    Pop $R1
  StrCmp $R1 2 Quit +1
  StrCpy $R2 "_?=$INSTDIR"
  StrCpy $R3 "$R0 $R2"
  ExecWait $R3
  Goto NotInstalled
Quit:
  Quit

NotInstalled:
  ${INSTALL_TYPE}
  SetOverwrite ifnewer
  SetOutPath "$INSTDIR"
  File "D:\Lenny\Documents\Visual Studio Projects\VATSIMHoursCompiler\VATSIMHoursCompiler\bin\Release\Microsoft.Bcl.AsyncInterfaces.dll"
  File "D:\Lenny\Documents\Visual Studio Projects\VATSIMHoursCompiler\VATSIMHoursCompiler\bin\Release\System.Buffers.dll"
  File "D:\Lenny\Documents\Visual Studio Projects\VATSIMHoursCompiler\VATSIMHoursCompiler\bin\Release\System.Memory.dll"
  File "D:\Lenny\Documents\Visual Studio Projects\VATSIMHoursCompiler\VATSIMHoursCompiler\bin\Release\System.Numerics.Vectors.dll"
  File "D:\Lenny\Documents\Visual Studio Projects\VATSIMHoursCompiler\VATSIMHoursCompiler\bin\Release\System.Runtime.CompilerServices.Unsafe.dll"
  File "D:\Lenny\Documents\Visual Studio Projects\VATSIMHoursCompiler\VATSIMHoursCompiler\bin\Release\System.Text.Encodings.Web.dll"
  File "D:\Lenny\Documents\Visual Studio Projects\VATSIMHoursCompiler\VATSIMHoursCompiler\bin\Release\System.Text.Json.dll"
  File "D:\Lenny\Documents\Visual Studio Projects\VATSIMHoursCompiler\VATSIMHoursCompiler\bin\Release\System.Threading.Tasks.Extensions.dll"
  File "D:\Lenny\Documents\Visual Studio Projects\VATSIMHoursCompiler\VATSIMHoursCompiler\bin\Release\System.ValueTuple.dll"
  File "D:\Lenny\Documents\Visual Studio Projects\VATSIMHoursCompiler\VATSIMHoursCompiler\bin\Release\VATSIMHoursCompiler.exe"
  File "D:\Lenny\Documents\Visual Studio Projects\VATSIMHoursCompiler\VATSIMHoursCompiler\bin\Release\VATSIMHoursCompiler.exe.config"
SectionEnd

######################################################################

Section -Icons_Reg
SetOutPath "$INSTDIR"
WriteUninstaller "$INSTDIR\uninstall.exe"

!ifdef REG_START_MENU
!insertmacro MUI_STARTMENU_WRITE_BEGIN Application
CreateDirectory "$SMPROGRAMS\$SM_Folder"
CreateShortCut "$SMPROGRAMS\$SM_Folder\${APP_NAME}.lnk" "$INSTDIR\${MAIN_APP_EXE}"
CreateShortCut "$DESKTOP\${APP_NAME}.lnk" "$INSTDIR\${MAIN_APP_EXE}"
CreateShortCut "$SMPROGRAMS\$SM_Folder\Uninstall ${APP_NAME}.lnk" "$INSTDIR\uninstall.exe"

!ifdef WEB_SITE
WriteIniStr "$INSTDIR\${APP_NAME} website.url" "InternetShortcut" "URL" "${WEB_SITE}"
CreateShortCut "$SMPROGRAMS\$SM_Folder\${APP_NAME} Website.lnk" "$INSTDIR\${APP_NAME} website.url"
!endif
!insertmacro MUI_STARTMENU_WRITE_END
!endif

!ifndef REG_START_MENU
CreateDirectory "$SMPROGRAMS\VATSIM Hours Compiler"
CreateShortCut "$SMPROGRAMS\VATSIM Hours Compiler\${APP_NAME}.lnk" "$INSTDIR\${MAIN_APP_EXE}"
CreateShortCut "$DESKTOP\${APP_NAME}.lnk" "$INSTDIR\${MAIN_APP_EXE}"
CreateShortCut "$SMPROGRAMS\VATSIM Hours Compiler\Uninstall ${APP_NAME}.lnk" "$INSTDIR\uninstall.exe"

!ifdef WEB_SITE
WriteIniStr "$INSTDIR\${APP_NAME} website.url" "InternetShortcut" "URL" "${WEB_SITE}"
CreateShortCut "$SMPROGRAMS\VATSIM Hours Compiler\${APP_NAME} Website.lnk" "$INSTDIR\${APP_NAME} website.url"
!endif
!endif

WriteRegStr ${REG_ROOT} "${REG_APP_PATH}" "" "$INSTDIR\${MAIN_APP_EXE}"
WriteRegStr ${REG_ROOT} "${UNINSTALL_PATH}"  "DisplayName" "${APP_NAME}"
WriteRegStr ${REG_ROOT} "${UNINSTALL_PATH}"  "UninstallString" "$INSTDIR\uninstall.exe"
WriteRegStr ${REG_ROOT} "${UNINSTALL_PATH}"  "DisplayIcon" "$INSTDIR\${MAIN_APP_EXE}"
WriteRegStr ${REG_ROOT} "${UNINSTALL_PATH}"  "DisplayVersion" "${VERSION}"
WriteRegStr ${REG_ROOT} "${UNINSTALL_PATH}"  "Publisher" "${COMP_NAME}"

!ifdef WEB_SITE
WriteRegStr ${REG_ROOT} "${UNINSTALL_PATH}"  "URLInfoAbout" "${WEB_SITE}"
!endif
SectionEnd

######################################################################

Section Uninstall
${INSTALL_TYPE}
Delete "$INSTDIR\Microsoft.Bcl.AsyncInterfaces.dll"
Delete "$INSTDIR\System.Buffers.dll"
Delete "$INSTDIR\System.Memory.dll"
Delete "$INSTDIR\System.Numerics.Vectors.dll"
Delete "$INSTDIR\System.Runtime.CompilerServices.Unsafe.dll"
Delete "$INSTDIR\System.Text.Encodings.Web.dll"
Delete "$INSTDIR\System.Text.Json.dll"
Delete "$INSTDIR\System.Threading.Tasks.Extensions.dll"
Delete "$INSTDIR\System.ValueTuple.dll"
Delete "$INSTDIR\VATSIMHoursCompiler.exe"
Delete "$INSTDIR\VATSIMHoursCompiler.exe.config"
 
 
Delete "$INSTDIR\uninstall.exe"
!ifdef WEB_SITE
Delete "$INSTDIR\${APP_NAME} website.url"
!endif

RmDir "$INSTDIR"

!ifdef REG_START_MENU
!insertmacro MUI_STARTMENU_GETFOLDER "Application" $SM_Folder
Delete "$SMPROGRAMS\$SM_Folder\${APP_NAME}.lnk"
Delete "$SMPROGRAMS\$SM_Folder\Uninstall ${APP_NAME}.lnk"
!ifdef WEB_SITE
Delete "$SMPROGRAMS\$SM_Folder\${APP_NAME} Website.lnk"
!endif
Delete "$DESKTOP\${APP_NAME}.lnk"

RmDir "$SMPROGRAMS\$SM_Folder"
!endif

!ifndef REG_START_MENU
Delete "$SMPROGRAMS\VATSIM Hours Compiler\${APP_NAME}.lnk"
Delete "$SMPROGRAMS\VATSIM Hours Compiler\Uninstall ${APP_NAME}.lnk"
!ifdef WEB_SITE
Delete "$SMPROGRAMS\VATSIM Hours Compiler\${APP_NAME} Website.lnk"
!endif
Delete "$DESKTOP\${APP_NAME}.lnk"

RmDir "$SMPROGRAMS\VATSIM Hours Compiler"
!endif

DeleteRegKey ${REG_ROOT} "${REG_APP_PATH}"
DeleteRegKey ${REG_ROOT} "${UNINSTALL_PATH}"
SectionEnd

######################################################################

