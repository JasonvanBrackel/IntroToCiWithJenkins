acs registercloud -Url https://apps.apprenda.mck603 -alias mck
acs connectcloud -cloudalias mck -user jason@vanbrackel.net -password apprendaadmin -Remember
ECHO "Removing application calculator"
acs removeapplication -AppAlias calculator
ECHO "Deploying application calculator"
acs newapplication -AppAlias calculator -AppName calculator -Package .\build\Calculator.zip -Stage sandbox