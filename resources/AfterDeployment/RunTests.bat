set /p path=<D:\smart_csharp_mini\resources\AfterDeployment\PathToNunitConsole.txt
start cmd.exe /k %path% D:\smart_csharp_mini\AutotestApp.ApiTest\bin\Debug\AutotestApp.ApiTest.dll --work=D:\smart_csharp_mini\resources\AfterDeployment\XML\HTMLxUnitGenerator-master\HTMLxUnitGenerator\bin --result=TestResult.xml
.xml;format=nunit3