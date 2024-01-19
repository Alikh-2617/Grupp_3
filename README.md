# Grupp_3
  
.NET Console App - School Assignment Beskrivning

Detta projekt är en .NET Console App skapat som en del av en skoluppgift. Applikationen har tre grundläggande funktioner, och varje funktion har motsvarande xUnit-test. Applicationen används för att kontroll av svenskt personnummer. 

Svenskt personnummer är centralt för många administrativa och identifikationsändamål, inklusive myndighetskontakter, hälso- och sjukvård, samt banktransaktioner. Skatteverket tilldelar alla personer som är folkbokföra i Sverige ett identifieringsnummer. Utöver dess funktion för identifiering används personnumret också för att beräkna ålder och kontrollera giltighet i olika sammanhang. Det är viktigt att notera att personnummer i Sverige utgår från noggranna regler och skyddsåtgärder för att säkerställa personlig integritet och säkerhet som regleras i folkbokföringslagen .

    Funktion 1: tar in en string och kontrollera om den string innehåller rätt andra siffror.
    Funktion 2: tar in ett int värde(person nummer) och kontrollera om det är rätt värde (person nummer) 
    Funktion 3: tar in ett int värde (person nummer) och konfigurerat om det är till en kvinna eller män. xUnit Tester
    Funktion 4: kontrollerar giltigheten av ett personnummer utifrån att månaden är inom intervallet 1-12.


För att säkerställa korrekt funktionalitet har tre xUnit-tester skapats för de tre funktionerna.

    Tester för Funktion 1: 
    Tester för Funktion 2: 
    Tester för Funktion 3: 

Git Actions Workflow För xunit branch : 
Beskrivning: Detta jobb körs vid varje push till huvudgrenen.

För Main branch : vi hade två jobs : 
    Jobb 1: Kör xUnit Tester

Beskrivning: Detta jobb körs vid varje push till huvudgrenen.
    Jobb 2: Bygg och Publicera till Docker Hub

Beskrivning: Detta jobb körs endast om xUnit-testerna är framgångsrika och triggar en push till huvudgrenen.
    vi försökte att injekta Docker hub credential med hjälp av Github secrets.

Gruppens medlemmar :

Mikael Jonsson,
Helen Mehari,
Oscar Löf,
Ali khawari

