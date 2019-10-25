using System.Collections.Generic;

namespace Questrade.ResharperBenefits.Domain
{
    public class User
    {
        public User()
        {
            Persons = new List<Person>();
        }

        public User(int id, string firstName, string lastName) : this()
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public int Id { get; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public IEnumerable<Person> Persons { get; set; }

        public void UpdateUser(string firstName, string lastName, IEnumerable<Person> persons)
        {
            FirstName = firstName;
            LastName = lastName;
            Persons = new List<Person>(persons);
        }
    }
}
