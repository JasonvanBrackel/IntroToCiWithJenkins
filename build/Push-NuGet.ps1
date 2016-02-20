$rootPath = (Get-Location).Path
$packagePath = $rootPath + '\package'

$buildPath = $rootPath + '\build'
$nugetPath = $buildPath + '\Nuget'
$env:Path += $nugetPath

$package = (Get-ChildItem $packagePath).FullName

& $nugetPath\nuget.exe push "$package" bc2b9384-b184-47dc-8ae3-ecfa7e874266