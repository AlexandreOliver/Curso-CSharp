using System;

namespace Atividade3.Entities
{
    public class Client
    {
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public DateTime birthDate { get; set; }

        public Client(string name, string email, DateTime birthdate)
        {
            Name = name;
            Email = email;
            birthDate = birthdate;
        }
    }
}