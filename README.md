
Introduction To Continuous Integration and Deployment with Jenkins
=========================

Prerequisites for this demo:

1. Java 1.7 or higher
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

```
C:\code\IntroToCiWithJenkins\servers> .\start-selenium-grid.batstart-selenium-grid.bat

C:\code\IntroToCiWithJenkins\servers>"C:\Program Files\Java\jre1.8.0_72\bin\java.exe" -Dwebdriver.chrome.driver=.\chromedriver.exe -Dwebdriver.ie.driver=.\iedriverserver.exe -jar .\selenium-server-standalone-2.52.0.jar -hub
16:47:51.008 INFO - Launching a standalone Selenium Server
16:47:52.132 INFO - Java: Oracle Corporation 25.72-b15
16:47:52.132 INFO - OS: Windows 8 6.2 amd64
16:47:52.163 INFO - v2.52.0, with Core v2.52.0. Built from revision 4c2593c
16:47:52.225 INFO - Driver class not found: com.opera.core.systems.OperaDriver
16:47:52.225 INFO - Driver provider com.opera.core.systems.OperaDriver is not registered
16:47:52.225 INFO - Driver provider org.openqa.selenium.safari.SafariDriver registration is skipped:
registration capabilities Capabilities [{browserName=safari, version=, platform=MAC}] does not match the current platform WIN8
16:47:53.553 INFO - RemoteWebDriver instances should connect to: http://127.0.0.1:4444/wd/hub
16:47:53.553 INFO - Selenium Server is up and running
16:48:26.669 INFO - Executing: org.openqa.selenium.remote.server.handler.GetAllSessions@5721ad38)
16:48:26.671 INFO - Done: org.openqa.selenium.remote.server.handler.GetAllSessions@5721ad38
```

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




















