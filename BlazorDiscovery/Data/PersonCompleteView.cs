using System.ComponentModel.DataAnnotations;

namespace BlazorDiscovery.Data
{
    public class PersonCompleteView
    {
        public PersonCompleteView(PersonModel person)
        {
            Id = person.Id.ToString();
            Name = person.Name;
            BirthDate = person.BirthDate;
            Document = Mask(person.Document);
            Address = new PersonCompleteViewAddress(person.Address);
            Phone = person.Phone;
            Email = person.Email;
            RegisterDate = person.RegisterDate;
            LastModificationDate = person.LastModificationDate ?? DateTime.MinValue;
        }

        private static string Mask(string document)
        {
            return document.Length == 11
                ? $"{document[..3]}.{document.Substring(3, 3)}.{document.Substring(6, 3)}-{document.Substring(9, 2)}"
                : document;
        }

        public string Id { get; set; }
        [Required(ErrorMessage = "Nome é obrigatório.")]
        [MinLength(3, ErrorMessage = "Nome deve ter mais que 3 caracteres.")]
        [MaxLength(60, ErrorMessage = "Nome deve ter menos que 80 caracteres.")]
        public string Name { get; set; }
        public DateOnly BirthDate { get; set; }
        public string Document { get; set; }
        public PersonCompleteViewAddress Address { get; init; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime LastModificationDate { get; set; } = DateTime.MinValue;

        public class PersonCompleteViewAddress
        {
            public PersonCompleteViewAddress(PersonModel.PersonModelAddress address)
            {
                Street = address.Street;
                Number = address.Number;
                City = address.City;
                State = address.State;
                ZipCode = address.ZipCode;
            }

            public string Street { get; set; }
            public string Number { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string ZipCode { get; set; }
        }
    }
}
