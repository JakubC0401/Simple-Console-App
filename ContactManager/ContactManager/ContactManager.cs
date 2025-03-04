

using System.Text.Json;

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

        public void SaveToFile(string filePath)
        {
            try
            {
                var json = JsonSerializer.Serialize(contacts, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, json);

                Console.WriteLine($"Kontakt został zapisany do pliku: {filePath} ");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Bład w czasie zapisywania danych do pliku: {ex.Message} ");
            }
        }
        public void LoadFromFile(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    var json = File.ReadAllText(filePath);
                    contacts = JsonSerializer.Deserialize<List<Contact>>(json) ?? new List<Contact>();
                    Console.WriteLine($"Kontakty zostały wczytane z pliku: {filePath} ");
                }
                else
                {

                    Console.WriteLine($"Plik o podanej ścieżce: {filePath} nie istnieje :( ");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Bład w czasie wczytywania danych z pliku: {ex.Message} ");
            }
        }

        public void RemoveContactByNameAndSurname()
        {
            Console.WriteLine("___USUWANIE KONTAKTU___");
            Console.WriteLine("Podaj imię: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko: ");
            string lastName = Console.ReadLine();

            var contactToRemove = contacts.Find(c => c.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase) && c.LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase));

            if (contactToRemove == null)
            {
                Console.WriteLine("Nie znaleziono kontaktu");
                return;
            }

            Console.WriteLine( $"Czy to jest kontakt który chcesz usunąć: " + contactToRemove.ToString());

            Console.WriteLine("Potwierdzasz usunięcie powyższego kontaktu: ");
            Console.WriteLine("Y - tak");
            Console.WriteLine("N - nie");
                
            string userInput = Console.ReadLine();

           

            switch (userInput.ToUpper())
            {
                case "Y":
                    contacts.Remove(contactToRemove);
                    Console.WriteLine("usunięto kontakt: " + contactToRemove);
                    break;
                case "N":
                    Console.WriteLine("nie usunięto żadnego kontaktu");
                    break;
                default:
                    Console.WriteLine("podano niepoprawną komendę");
                    break;   
            }

        }
    }
}
