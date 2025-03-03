using System.Net.Mail;
using System.Text.RegularExpressions;

namespace ContactManager
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public Contact(string firstName, string lastName, string email, string phoneNumber)
        {
            if(string.IsNullOrWhiteSpace(firstName))
            {
                throw new ArgumentException("imie nie może byc puste!", nameof(firstName));
            }
            if(string.IsNullOrWhiteSpace(lastName)) {
                throw new ArgumentException("nazwisko nie może byc puste!", nameof(lastName)); 
            }
            if (!isValidEmail(email))
            {
                throw new ArgumentException("nieprawidłowy format adresu email!", nameof(email));
            }
            if (!isValidPhoneNumber(phoneNumber))
            {
                throw new ArgumentException("nieprawidłowy numer telefonu, dozwolone są tylko cyfry!", nameof(phoneNumber));
            }

            
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;

        }

      

        public override string ToString()
        {
            return $"Imię: {FirstName}, Naziwsko: {LastName}, Email: {Email}, PhoneNumber: {PhoneNumber}";
        }

        private bool isValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        }

        private bool isValidPhoneNumber(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, @"^\d+$");
        }
    }
}
