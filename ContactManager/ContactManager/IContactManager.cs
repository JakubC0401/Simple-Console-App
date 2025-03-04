namespace ContactManager
{
    interface IContactManager
    {
        void AddContact();
        void DisplayAllContacts();
        void FindContactByName();
        void RemoveContactByNameAndSurname();
        void SaveToFile(string filePath);
        void LoadFromFile(string filePath);
    }
}
