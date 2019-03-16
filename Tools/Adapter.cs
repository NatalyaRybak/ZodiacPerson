using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZodiacPerson.Models;

namespace ZodiacPerson.Tools
{
    class Adapter
    {
        internal static Person CreatePerson(string firstName, string lastName, string email, DateTime birthDate)
        {
            return new Person(firstName, lastName, email, birthDate);
        }
    }
}
