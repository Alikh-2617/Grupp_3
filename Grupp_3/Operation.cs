namespace Grupp_3
{
    public class Operation : IOperation
    {
        public bool IsValidPersonnummer(string personnummer)
        {
        // Kontrollera längd och format
        if (personnummer.Length != 13 || !personnummer.Substring(6, 1).Equals("-"))
        {
            return false;
        }


        // Kontrollera månaden
        int month = int.Parse(personnummer.Substring(2, 2));
        if (month < 1 || month > 12)
        {
            return false;
        }
        return true;
        }
        public bool IsValidPersunnummer(string personnummer)
        {

        // Kontrollera om de första 8 tecknen är siffror  900426 3597
        for (int i = 0; i < 8; i++)
        {
            if (!char.IsDigit(personnummer[i]))
            {
                return false;
            }
        }

        // Kontrollera om det nionde tecknet är ett bindestreck
        if (personnummer[8] == '-')
        {
            personnummer = personnummer.Replace("-","");
        }

        // Kontrollera om de sista fyra tecknen är siffror
        for (int i = 9; i < 13; i++)
        {
            if (!char.IsDigit(personnummer[i]))
            {
                return false;
            }
        }
        return true;
        }
        public string? PersonnummerToCurrent(string personnummer)
        {
            // om personnummer varit 12 sif så det tar bort första 19 
            // person nummert ska vara 10 sif
            long result = 0;
            personnummer = personnummer.Replace("-","");
            if(personnummer.Length > 10)
            {
                personnummer = personnummer.Substring(2);
                return personnummer;
            }
            if(personnummer.Length < 10)
            {
                return null;
            }
            return personnummer;
        }
        public string Gender(string personnummer)
        {    
            // "Oscar", säga till om person nummret tillhör man eller kvinna ! 
            int GenderNr = int.Parse(personnummer.Substring(8, 1));
    
            if (GenderNr % 2 == 0)
            {
                return "Kvinna";
            }
            return "Man";
        }

        public bool IsValidpersonnummer(string personnummer)
        {
            int totalInt = 0;   

            for (int i = 0; i < personnummer.Length; i++) 
            {
                int f = int.Parse(personnummer[i].ToString());

                if (i % 2 == 0) 
                {
                    f *= 2;
                    if (f > 9) 
                    {
                        f = f % 10 + f / 10;  
                    }
                }
                totalInt += f;
                f = 0;
            }
            if (totalInt % 10 == 0) 
            {
                return true;
            }
            return false;
        }
    }
}