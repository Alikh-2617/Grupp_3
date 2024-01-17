 public bool IsValidPersonnummer(string personnummer)
    {
        // Kontrollera om längden är korrekt (12 tecken inklusive bindestreck)
        // if (personnummer.Length != 13)
        // {
        //     return false;
        // }

        // Kontrollera om de första 8 tecknen är siffror
        for (int i = 0; i < 8; i++)
        {
            if (!char.IsDigit(personnummer[i]))
            {
                return false;
            }
        }

        // Kontrollera om det nionde tecknet är ett bindestreck
        if (personnummer[8] != '-')
        {
            return false;
        }

        // Kontrollera om de sista fyra tecknen är siffror
        for (int i = 9; i < 13; i++)
        {
            if (!char.IsDigit(personnummer[i]))
            {
                return false;
            }
        }

        // Kontrollera kontrollsiffran
        int[] weights = { 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1 };
        int sum = 0;

        for (int i = 0; i < 12; i++)
        {
            // int.pars konvertera till int base 32 men person nummert är längre än inte base 32  
            int digit = int.Parse(personnummer[i].ToString());
            sum += digit * weights[i];

            if (digit > 4)
            {
                sum -= 9;
            }
        }

        return sum % 10 == 0;
    }