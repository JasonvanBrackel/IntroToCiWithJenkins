Param([string]$path)

if(!(Test-Path $path))
{
    $path = ./
}

nunit-console $path + '\src\CalculatorDemo\Tests\bin\Debug\Tests.dll /xml=build/TestResults.xml'














