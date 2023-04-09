@ECHO OFF

ECHO Build and publish
dotnet publish Feladatok/WinFormExpl/WinFormExpl.csproj -o Feladatok/WinFormExpl/bin/publish

ECHO Minden teszt futtatása, kivéve IMSc
SET RootPath=.\TestFiles
SET AppId=%~dp0\Feladatok\WinFormExpl\bin\publish\WinFormExpl.exe
dotnet test c:\sznikak\winforms-hf-uitest-binaries\WinFormExpl-Test.dll --filter ClassName~Feladat1
dotnet test c:\sznikak\winforms-hf-uitest-binaries\WinFormExpl-Test.dll --filter ClassName~Feladat2
dotnet test c:\sznikak\winforms-hf-uitest-binaries\WinFormExpl-Test.dll --filter ClassName~Feladat3
dotnet test c:\sznikak\winforms-hf-uitest-binaries\WinFormExpl-Test.dll --filter ClassName~Feladat4