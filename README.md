# Grupp_3

.NET Console App - School Assignment Beskrivning

Detta projekt är en .NET Console App skapat som en del av en skoluppgift. Applikationen har tre grundläggande funktioner, och varje funktion har motsvarande xUnit-test.

  Funktion 1: tar in en string och kontrollera om den string innehåller rätt andra siffror.\n
  Funktion 2: tar in ett int värde(person nummer) och kontrollera om det är rätt värde (person nummer)\n
  Funktion 3: tar in ett int värde (person nummer) och konfigurerat om det är till en kvinna eller män.\n
xUnit Tester

För att säkerställa korrekt funktionalitet har tre xUnit-tester skapats för de tre funktionerna.\n

  Tester för Funktion 1: \n
  Tester för Funktion 2: \n
  Tester för Funktion 3: \n

Git Actions Workflow För xunit branch : \n
Beskrivning: Detta jobb körs vid varje push till huvudgrenen.\n

För Main branch : vi hade två jobs : \n
  Jobb 1: Kör xUnit Tester \n

Beskrivning: Detta jobb körs vid varje push till huvudgrenen. \n
  Jobb 2: Bygg och Publicera till Docker Hub \n

Beskrivning: Detta jobb körs endast om xUnit-testerna är framgångsrika och triggar en push till huvudgrenen. \n
  vi försökte att injekta Docker hub credential med hjälp av Github secrets. \n

Gruppens medlemmar : \n

mikael jonsson,
Helen Mehari,
Oscar Löf,
Ali khawari

