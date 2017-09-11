using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DrivingLicense.Infrastrucure
{
    public class RandomMessed
    {
        Random Rad = new Random(); // shemtxveviti ricxvis generatori
        public RandomMessed(int Sawyisi_Nomeri, int Random_Raod, List<int> List_Random)
        {
            int R;
            int[] RandomM = new int[Random_Raod + 1];

            for (int i = 1; i <= Random_Raod; i++)

                RandomM[i] = i;

            int Mtvleli = Random_Raod;

            for (int j = Sawyisi_Nomeri; j <= Random_Raod; j++, Mtvleli--)
            {

                R = Rad.Next(Sawyisi_Nomeri, Mtvleli);

                List_Random.Add(RandomM[R]);


                RandomM[R] = RandomM[Mtvleli];

            }
        }
    }
}