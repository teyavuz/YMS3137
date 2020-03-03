using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA_SOLID.DIP.BAD
{
    public class BadRestaurant
    {
        private BadFish barbun = new BadFish();
        private BadPoultry duck = new BadPoultry();

        public string GenerateInstructions()
        {
            return barbun.GetFishCookingInstructions() + " " + duck.GetPoultryCookingInstructions();
        }

    }
}
