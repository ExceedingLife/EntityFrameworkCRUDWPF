using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCRUDWPF
{
    public class CRUD
    {
        //get the entity framework model context that was created.
        private EntityFrameworkDBEntities framework = null;

        public CRUD()
        {
            framework = new EntityFrameworkDBEntities();
        }

        public Person GetPersonById(int personId)
        {
            return framework.People.Find(personId);
        }

        public List<Person> GetAllPeopleByList()
        {
            return framework.People.ToList();
        }

        public void CreatePerson(Person person)
        {
            if(person != null)
            {                
                framework.People.Add(person);
                //framework.Entry(person).State = System.Data.Entity.EntityState.Added;
                framework.SaveChanges();
            }
        }

        public void UpdatePerson(Person person)
        {
            Person getPerson = GetPersonById(person.Id);
            if(person != null)
            {
                getPerson.FirstName = person.FirstName;
                getPerson.LastName = person.LastName;
                getPerson.Age = person.Age;
                getPerson.ProgrammingLanguage = person.ProgrammingLanguage;
                getPerson.DateCreated = person.DateCreated;
                framework.SaveChanges();
            }
        }

        public void DeletePerson(int personId)
        {
            Person removePerson = framework.People.Find(personId);
            if(removePerson != null)
            {
                framework.People.Remove(removePerson);
                //framework.Entry(removePerson).State = System.Data.Entity.EntityState.Deleted;
                framework.SaveChanges();
            }
        }
    }
}