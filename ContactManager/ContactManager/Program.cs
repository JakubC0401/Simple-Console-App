
class Program
{
    static void Main(string[] args)
    {
        List<Contact> contacts = new List<Contact>();

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
                    AddContact(contacts);
                    break;
                case "2":
                    ShowAllContacts(contacts);
                    break;
                case "3":
                    FindContactByName(contacts);
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
    private static void AddContact(List<Contact> contacts)
    {
        Console.WriteLine("\n ___DODAJ NOWY KONTAKT___");
        Console.WriteLine("Podaj imię: ");
        string firstName = Console.ReadLine();
        Console.WriteLine("Podaj nazwisko: ");
        string lastName = Console.ReadLine();
        Console.WriteLine("Podaj adres email: ");
        string email = Console.ReadLine();
        Console.WriteLine("Podaj numer telefonu: ");
        string phoneNumer = Console.ReadLine();

        contacts.Add(new Contact(firstName, lastName, email, phoneNumer));
        Console.WriteLine("Kontakt został pomyślnie dodany!");
    }
    private static void FindContactByName(List<Contact> contacts)
    {
        throw new NotImplementedException();
    }

    private static void ShowAllContacts(List<Contact> contacts)
    {
        throw new NotImplementedException();
    }


}