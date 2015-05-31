using System;
namespace CSharp6.Models
{
    public class User
    {
        public User(int id, string firstName, string lastName, DateTime birth, decimal document, string city, string state)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Birth = birth;
            Document = document;
            Address = new Address
            {
                State = state,
                City = city
            };
        }

        public User(int id, string firstName, string lastName, DateTime birth, decimal document)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Birth = birth;
            Document = document;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birth { get; set; }
        public decimal Document { get; set; }
        public Address Address { get; set; }
        public string UserName => FirstName + " " + LastName;
    }
} 