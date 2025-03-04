namespace ContactManager.Tests
{
    public class ContactTest
    {
        [Fact]
        public void Constructor_SetsAllPropertiesCorrectly()
        {
            // Arrange
            string firstName = "Jan";
            string lastName = "Kowalski";
            string email = "jan@wp.pl";
            string phoneNumber = "1234567890";

            // Act
            Contact contact = new Contact(firstName, lastName, email, phoneNumber );

            // Assert
            Assert.Equal( firstName, contact.FirstName );
            Assert.Equal( lastName, contact.LastName );
            Assert.Equal( email, contact.Email );
            Assert.Equal( phoneNumber, contact.PhoneNumber );
        }

        [Fact]
        public void ToString_ReturnsCorrectString()
        {
            // Arrange
            string firstName = "Jan";
            string lastName = "Kowalski";
            string email = "jan@wp.pl";
            string phoneNumber = "1234567890";
            Contact testContact = new Contact(firstName, lastName, email, phoneNumber);

            // Act
            var result = testContact.ToString();

            // Assert
            Assert.Equal("Imię: Jan, Naziwsko: Kowalski, Email: jan@wp.pl, PhoneNumber: 1234567890", result );
        }

        [Theory]
        [InlineData("")]
        [InlineData("      ")]
        [InlineData(null)]
        public void Constructor_ThrowsExceptionWhenFirstNameIsNullOrEmpty(string invalidFirstName)
        {
            // Arange
            string lastName = "Kowalski";
            string email = "jan@wp.pl";
            string phoneNumber = "1234567890";

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Contact(invalidFirstName, lastName, email, phoneNumber));
        }

        [Theory]
        [InlineData("")]
        [InlineData("      ")]
        [InlineData(null)]
        public void Constructor_ThrowsExceptionWhenLastNameIsNullOrEmpty(string invalidLastName)
        {
            // Arange
            string firstName = "Jan";
            string email = "jan@wp.pl";
            string phoneNumber = "1234567890";

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Contact(firstName, invalidLastName, email, phoneNumber));
        }

        [Theory]
        [InlineData("jan.nowak@com")]
        [InlineData("jan.nowak@.com")]
        [InlineData("jan.nowak.com")]
        [InlineData("jan.nowak@com.")]
        [InlineData("@example.com")]
        [InlineData("")]
        public void Constructor_ThrowsExceptionWhenInvalidEmail(string invalidEmail)
        {
            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Contact("Jan", "Nowak", invalidEmail, "565787123"));
        }

        [Theory]
        [InlineData("123abc")]
        [InlineData("123-456")]
        [InlineData("(123)456")]
        [InlineData("")]
        public void Constructor_ThrowsExceptionWhenInvalidPhoneNumber(string invalidPhoneNumer)
        {
            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Contact("Jan", "Nowak", "jan@wp.pl", invalidPhoneNumer));
        }

    }
}
