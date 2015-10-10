Param([string]$path='.')

nunit-console  (Join-Path $path \src\CalculatorDemo\Tests\bin\Debug\Tests.dll) /xml=build/TestResults.xml














