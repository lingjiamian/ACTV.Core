color B

del  .PublishFiles\*.*   /s /q

dotnet restore

dotnet build

cd ACTV.Core.Api

dotnet publish -o ..\ACTV.Core.Api\bin\Debug\net5.0\

md ..\.PublishFiles

xcopy ..\ACTV.Core.Api\bin\Debug\net5.0\*.* ..\.PublishFiles\ /s /e 

echo "Successfully!!!! ^ please see the file .PublishFiles"

cmd