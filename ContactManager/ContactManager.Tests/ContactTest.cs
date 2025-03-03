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
            Contact contact = new Contact(firstName, lastName, email, phoneNumber);

            // Act
            var result = contact.ToString();

            // Assert
            Assert.Equal("Imię: Jan, Naziwsko: Kowalski, Email: jan@wp.pl, PhoneNumber: 1234567890", result );
        }
    }
}
