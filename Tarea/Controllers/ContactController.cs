using Microsoft.AspNetCore.Mvc;
using Tarea.Models;
using ContactManager.Services;

namespace Tarea.Controllers
{
    public class ContactController : Controller
    {
        public Contact[] Get()
        {
            return new Contact[]
            {
                new Contact
                {
                    IdEstudiante=123,
                    NameStudent= "Gabriel Ch",
                    Edad=28,
                },
        
        new Contact
        {
            IdEstudiante=456,
            NameStudent="Leah Ch",
            Edad=29,
        },
        
            };
        }
    }
}
