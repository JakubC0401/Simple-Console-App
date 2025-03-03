

namespace ContactManager
{
    class ContactManager: IContactManager
    {
        List<Contact> contacts = new List<Contact>();
        public void AddContact()
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
        public void DisplayAllContacts()
        {
            Console.WriteLine("\n ___LISTA KONTAKTÓW:___");

            if (contacts.Count == 0)
            {
                Console.WriteLine("Lista kontaktów jest pusta");
                return;
            }
            foreach (Contact contact in contacts)
            {
                Console.WriteLine(contact);
            }


        }
        public void FindContactByName()
        {
            Console.WriteLine("\n ___WYSZUKIWANIE KONTAKTU___");
            Console.WriteLine("Podaj imię do wyszukania: ");
            string searchName = Console.ReadLine();

            var foundContacts = contacts.FindAll(c => c.FirstName.Contains(searchName, StringComparison.OrdinalIgnoreCase)).ToList();

            if (foundContacts.Count == 0)
            {
                Console.WriteLine("Brak takiego kontaktu");
                return;
            }

            if (foundContacts.Count > 0)
            {
                if (contacts.Count == 1)
                {
                    Console.WriteLine($"Znaleziono: {contacts.Count} pasujący kontakt");
                }
                else
                {
                    foreach (Contact contact in foundContacts)
                    {
                        Console.WriteLine($"Znaleziono: {contacts.Count} pasujących kontaktów");
                        Console.WriteLine(contact);
                    }
                }
            }

        }

    }
}
