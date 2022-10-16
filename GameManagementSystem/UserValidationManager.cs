using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagementSystem
{
    internal class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear==2000 && gamer.FirstName=="Nazif" && gamer.LastName=="Balcı" && gamer.Id==1)
            {
                return true;
            }
            else
            {
                return false;   
            }
        }
    }
}
