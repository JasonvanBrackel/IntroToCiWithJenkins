$rootPath = (Get-Location).Path
$projectPath = $rootPath + '\src\CalculatorDemo\CalculatorDemo'
$binPath = $projectPath + 'bin'
$buildPath = $rootPath + '\build'
$nugetPath = $buildPath + '\Nuget'
$env:Path += $nugetPath
$packagePath = $rootPath + '\package'
if(Test-Path $packagePath)
{
    Remove-Item $packagePath -Recurse
}
mkdir $packagePath
nuget.exe pack $projectPath\root.csproj -Verbosity detailed -OutputDirectory $packagePath -IncludeReferencedProjects -Build -Prop Configuration=Release