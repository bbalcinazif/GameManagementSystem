namespace GameManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer 
            { 
                Id = 1, BirthYear = 2000, FirstName = "Nazif", LastName = "Balcı" 
            }
            );
        }
    }
}