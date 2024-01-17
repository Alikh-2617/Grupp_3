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

        return true;
    }