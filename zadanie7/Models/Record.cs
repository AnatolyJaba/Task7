namespace zadanie7.Models
{
    public class Record
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public Record(string name, string secondName, string lastName, string phoneNumber, DateTime birthDate)
        {
            Name = name;
            SecondName = secondName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            BirthDate = birthDate;
        }
    }
}
