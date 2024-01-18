namespace Grupp_3
{
    public interface IOperation
    {
        public string PersonnummerToCurrent(string personnummer);
        public bool IsValidPersonnummer(string personnummer);
        public string Gender(string personnummer);
    }
}