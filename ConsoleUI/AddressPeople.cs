using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class AddressPeople
    {
        public static void GiveAddress(PersonModel person)
        {
            Console.WriteLine($"firstName : {person.FirstName} \nlastname : {person.LastName}\nemail address: {person.EmailAddress}");
        }
    }
}
