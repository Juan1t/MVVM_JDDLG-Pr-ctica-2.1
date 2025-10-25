using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MVVM_JDDLG.MVVM.Models;

namespace MVVM_JDDLG.MVVM.ViewsModels
{
    internal class PersonViewModelcs
    {
        public Person person { get; set; }

        public PersonViewModelcs()
        {
            person = new Person()
            {
                Name = "John Doe",
                Age = 19,
                Married = true,
                Birthday = new DateTime(2006, 08, 25),
                Weight = 70,
                LunchTime = new TimeSpan(12, 30, 0)
            };
        }

    }
}
