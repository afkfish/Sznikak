@ECHO OFF

ECHO Build and publish
dotnet publish Feladatok/WinFormExpl/WinFormExpl.csproj -o Feladatok/WinFormExpl/bin/publish

ECHO Minden teszt futtatása, kivéve IMSc
SET RootPath=.\TestFiles
SET AppId=%~dp0\Feladatok\WinFormExpl\bin\publish\WinFormExpl.exe
REM dotnet test ..\winforms-hf-uitest-binaries\WinFormExpl-Test.dll --filter ClassName~Feladat5
dotnet test c:\sznikak\winforms-hf-uitest-binaries\WinFormExpl-Test.dll --filter Name~TestDirsDisplayed
dotnet test c:\sznikak\winforms-hf-uitest-binaries\WinFormExpl-Test.dll --filter Name~TestDirsCanBeOpen
dotnet test c:\sznikak\winforms-hf-uitest-binaries\WinFormExpl-Test.dll --filter Name~TestParentFolderShown
dotnet test c:\sznikak\winforms-hf-uitest-binaries\WinFormExpl-Test.dll --filter Name~TestParentFolderDoupleClickNavigatesToParent
dotnet test c:\sznikak\winforms-hf-uitest-binaries\WinFormExpl-Test.dll --filter Name~TestParentFolderIsNotDisplayedInRoot