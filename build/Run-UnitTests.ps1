Param([string]$path=$env:Workspace)

nunit-console  (Join-Path $path \src\CalculatorDemo\Tests\bin\Debug\Tests.dll) /xml=build/TestResults.xml














