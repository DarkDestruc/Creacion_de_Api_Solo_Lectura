namespace Tarea.Models.Services
{

    public class ContactRepository
        {
            public Contact[] GetAllContacts()
            {
                return new Contact[]
                {
            new Contact
            {
                IdEstudiante= 1,
                NameStudent = "Glenn Block",
                Edad = 29
            },
            new Contact
            {
                IdEstudiante = 2,
                NameStudent = "Dan Roth",
                Edad=29
            },
                };
            }
        }
    }

