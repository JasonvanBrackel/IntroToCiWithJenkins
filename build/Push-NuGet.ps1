$rootPath = (Get-Location).Path
$packagePath = $rootPath + '\package'

$buildPath = $rootPath + '\build'
$nugetPath = $buildPath + '\Nuget'
$env:Path += $nugetPath

$package = (Get-ChildItem $packagePath).FullName

& $nugetPath\nuget.exe push "$package" eeab1b48-bbd7-4fe8-b5c0-bef25a6b5a6b