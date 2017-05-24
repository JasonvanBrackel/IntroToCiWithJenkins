
acs registercloud -Url https://apps.apprenda.jvb -alias apprenda
acs connectcloud -cloudalias apprenda -user jvanbrackel@apprenda.com -password password -Remember
ECHO "Removing application calculator"
acs removeapplication -AppAlias calculator
ECHO "Deploying application calculator"
acs newapplication -AppAlias calculator -AppName calculator -Package .\build\Calculator.zip -Stage sandbox