using System;

namespace Questrade.ResharperBenefits.Domain
{
    public class Person
    {
        public Person()
        {
            
        }

        public int test { get; set; }

        public Person(int personId, string firstName, string lastName)
        {
            Id = personId;
            FirstName = firstName;
            LastName = lastName;
        }

        public int Id { get; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        
        
        public void UpdatePerson(string firstName, string lastName)
        {
            try
            {
                FirstName = firstName;
                LastName = lastName;
            }
            catch (CustomException e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
