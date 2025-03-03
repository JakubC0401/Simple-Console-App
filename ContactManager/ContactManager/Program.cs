namespace ContactManager
{

    class Program
    {
        static void Main(string[] args)
        {
            IContactManager contactManager = new ContactManager();


            string userInput;

            string filePath = "contacts.json";

            Console.WriteLine("______APLIKACJA DO ZARZĄDZANIA KONTAKTAMI______");

            do
            {
                Console.WriteLine("\n Wybierz jedną z opcji: ");
                Console.WriteLine("1. Dodaj nowy kontakt");
                Console.WriteLine("2. Wyświetl wszystkie kontakty");
                Console.WriteLine("3. Wyszukaj kontakt po imieniu");
                Console.WriteLine("4. Zapisz kontakty do pliku");
                Console.WriteLine("5. Wczytaj kontakty z pliku");
                Console.WriteLine("6. Wyjdź z aplikacji");

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
                        contactManager.SaveToFile(filePath); 
                        break;
                    case "5":
                        contactManager.LoadFromFile(filePath);
                        break;
                    case "6":
                        Console.WriteLine("Dziękujemy za skorzystanie z aplikacji!");
                        break;
                    default:
                        Console.WriteLine("niepoprawnie wybrano opcje");
                        break;
                }

            } while (userInput != "6");

        }





    }
}