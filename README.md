
Introduction To Continuous Integration and Deployment with Jenkins
=========================

Prerequisites for this demo:

1. Java 1.7
2. nunit
3. Some version of the Google Chrome Browser. (optionally IE and FireFox)
4. Visual Studio to run the tests
5. Set your default browser to Chrome.

The tests that hit the other web drivers (e.g. FireFox,IE) are commented out to keep this demo simple.  
Uncomment these tests and install the browsers on the web driver target to for this functionality

Make sure that nunit and java bin diregtories are in your environment %Path% variable:
(Example paths:)
c:\Program Files (x86)\NUnit 2.6.3\bin; C:\Program Files (x86)\Java\jre7\bin

Download the respostory and extract the archive

1. Open a command window and change directory to the "severs" subdirectory (<root>servers)

start-selenium-grid.bat
Aug 22, 2014 9:30:49 AM org.openqa.grid.selenium.GridLauncher main
INFO: Launching a standalone server
09:30:50.336 INFO - Java: Oracle Corporation 24.65-b04
09:30:50.337 INFO - OS: Windows 7 6.1 x86
09:30:50.342 INFO - v2.39.0, with Core v2.39.0. Built from revision ff23eac
09:30:50.397 INFO - Default driver org.openqa.selenium.iphone.IPhoneDriver registration is skipped: registration capabilities Capabilities [{platform=MAC, browserName=iPhone, version=}] does not match with current platform: VISTA
09:30:50.408 INFO - Default driver org.openqa.selenium.iphone.IPhoneDriver registration is skipped: registration capabilities Capabilities [{platform=MAC, browserName=iPad, version=}] does not match with current platform: VISTA
09:30:50.432 INFO - RemoteWebDriver instances should connect to: http://127.0.0.1:4444/wd/hub
09:30:50.433 INFO - Version Jetty/5.1.x
09:30:50.433 INFO - Started HttpContext[/selenium-server/driver,/selenium-server/driver]
09:30:50.434 INFO - Started HttpContext[/selenium-server,/selenium-server]
09:30:50.434 INFO - Started HttpContext[/,/]
09:30:50.651 INFO - Started org.openqa.jetty.jetty.servlet.ServletHandler@17906f4
09:30:50.651 INFO - Started HttpContext[/wd,/wd]
09:30:50.654 INFO - Started SocketListener on 0.0.0.0:4444
09:30:50.654 INFO - Started org.openqa.jetty.jetty.Server@17599cc

The server is now running & listening for requests on port 4444 of the local host.

2. Start the application 
  a. Open the calculator solution in visual studio.  (<root>\src\CalculatorDemo)
  b. Edit the port number in the test that the root project will use when it launches the site.  This is found
     in the \src\CalculatorDemo\Tests\CalculatorDemoTests.cs -  Driver.Url = "http://localhost:57568/Home/Index";
  c.  Right click the solution and select
  "debug" > "start new instance".  The calculator application will start in the browser.

3. Run Tests. The batch file directory contains the test runner: <root>\<build>\run-unit-tests.bat  
nunit-console src\CalculatorDemo\Tests\bin\Debug\Tests.dll /xml=build/TestResults.xml
Start a Powershell Command window (not Powershell ISE) and change the dirctory to the root of the application.
PS \yourroot>  build\run-unit-tests.bat




















