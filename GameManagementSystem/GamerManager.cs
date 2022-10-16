using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagementSystem
{
    internal class GamerManager : IGamerService
    {
        UserValidationManager userValidationManager;
        NewEStateUserValidationManager newEStateUserValidationManager;

        public GamerManager(UserValidationManager userValidationManager)
        {
            this.userValidationManager= userValidationManager;
        }

        public GamerManager(NewEStateUserValidationManager newEStateUserValidationManager)
        {
            this.newEStateUserValidationManager = newEStateUserValidationManager;
        }

        public void Add(Gamer gamer)
        {
            if (userValidationManager.Validate(gamer) == true)
            {
                Console.WriteLine("Doğrulama Başarılı");
            }
            else
            {
                Console.WriteLine("Doğrulama  Başarısız");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt Silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt Güncellendi");
        }
    }
}
