namespace Grupp_3
{
    public class Operation : IOperation
    {
        public long PersonnummerToInt(string personnummer)
        {
            // om personnummer varit 12 sif så det tar bort första 19 
            // person nummert ska vara 10 sif
            long result = 0;
            personnummer = personnummer.Replace("-","");
            if(personnummer.Length > 10)
            {
                personnummer = personnummer.Substring(2);
                result = Convert.ToInt64(personnummer);
                return result;
            }
            if(personnummer.Length < 10)
            {
                return 0;
            }
            result = Convert.ToInt64(personnummer);
            return result;
        }
        public bool IsValidPersonnummer(long personnummer)
        {

        }
        public string Gender(long personnummer)
        {

        }

    }
}