namespace ContactManager
{

    class Program
    {
        static void Main(string[] args)
        {
            IContactManager contactManager = new ContactManager();


            string userInput;

            Console.WriteLine("______APLIKACJA DO ZARZĄDZANIA KONTAKTAMI______");

            do
            {
                Console.WriteLine("\n Wybierz jedną z opcji: ");
                Console.WriteLine("1. Dodaj nowy kontakt");
                Console.WriteLine("2. Wyświetl wszystkie kontakty");
                Console.WriteLine("3. Wyszukaj kontakt po imieniu");
                Console.WriteLine("4. Wyjdź z aplikacji");

                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        contactManager.AddContact();
                        break;
                    case "2":
                        contactManager.DisplayAllContacts();
                        break;
                    case "3":
                        contactManager.FindContactByName();
                        break;
                    case "4":
                        Console.WriteLine("Dziękujemy za skorzystanie z aplikacji!");
                        break;
                    default:
                        Console.WriteLine("niepoprawnie wybrano opcje");
                        break;
                }

            } while (userInput != "4");

        }





    }
}