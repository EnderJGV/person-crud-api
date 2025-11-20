namespace Person.Models
{
    public class PersonModel
    {
        public PersonModel(string name, string gender, string document, string email = "IsNotEmail", int phone = 0, string address = "IsNotAddress", string city = "IsNotCity", string state = "IsNotState", string zipCode = "IsNotZipCode", DateTime birthDate = default)
        {
            Id = Guid.NewGuid();
            Deleted_at = null;
            Name = name;
            Gender = gender;
            Document = document;
            Email = email.ToLower();
            Phone = phone;
            Address = address;
            City = city;
            State = state;
            ZipCode = zipCode;
            IsActive = true;
            BirthDate = birthDate;        

            Created_at = DateTime.UtcNow;
            Updated_at = DateTime.UtcNow;
        }

        public Guid Id { get; init; }
        public string Name { get; private set; }

        public string Gender { get; set; } = string.Empty;
        public string Document { get; private set; } = string.Empty;
        public string Email { get; private set; } = string.Empty;
        public int Phone { get; private set; } = int.MinValue;
        public string Address { get; private set; } = string.Empty;
        public string City { get; private set; } = string.Empty;
        public string State { get; private set;} = string.Empty;
        public string ZipCode {get; private set;} = string.Empty;

        public DateTime BirthDate {get; set;}
        public bool IsActive {get; set;} = true;

        public DateTime? Deleted_at { get; private set;}

        public DateTime Created_at {get; set; } = DateTime.UtcNow;
        public DateTime Updated_at {get; set; } = DateTime.UtcNow;

        public void ChangeName(string name)
        {
            Name = name;
        }

        public void ChangeDocument(string document)
        {
            Document = document;
        }

        public void ChangeEmail(string email)
        {
            Email = email;
        }

        public void ChangePhone(int phone)
        {
            Phone = phone;
        }

        public void ChangeAddress(string address)
        {
            Address = address;
        }

        public void ChangeCity(string city)
        {
            City = city;
        }

        public void ChangeState(string state)
        {
            State = state;
        }

        public void ChangeZipCode(string zipCode)
        {
            ZipCode = zipCode;
        }

        public void SetInactive()
        {
            IsActive = false;
            Deleted_at = DateTime.UtcNow;
            Updated_at = DateTime.UtcNow;
        }

    }
}