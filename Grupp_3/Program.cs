

namespace Grupp_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Operation operation = new Operation();
                Console.Write(" Hej och välkommen till Applicationen !\n\tHär får du skriva ditt person nummer : ");
                string personnummer = Console.ReadLine();

                string result = operation.PersonnummerToCurrent(personnummer);
                if(result == null)
                {
                    Console.WriteLine($" person nummers är minder än vanligt fall !\n\t => {personnummer}");
                    return;
                }
                bool trust = operation.IsValidpersonnummer(result);
                if(trust != true)
                {
                    Console.WriteLine($" person nummers är fel  !\n\t => {personnummer}");
                    return;
                }
                Console.WriteLine($"\n\n Rätt person nummer !\n personen med den personnummer =>  [ {personnummer} ]  är en =>  {operation.Gender(personnummer)}\n\n\n\n");
            }
            catch(Exception e)
            {
                Console.WriteLine($"Oj vi fick Error ! \n{e.Message}");
            }
        }
    }
}