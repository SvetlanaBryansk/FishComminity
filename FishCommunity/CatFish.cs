using System;

namespace FishCommunity
{
    class CatFish : ViewCatFishCommunity// класс рыба Кижучь  наследуется от класса СООБЩЕСТВО КИЖУЧЬ
    {

        public CatFish(IRemoteControl remoteControl) : base(remoteControl)

        {
            _availability = 250;
            _disportal = 250;
        }

        public override void Moving(IDisportal disportal)
        {
            Console.WriteLine($"рыба Кижучь перегружается в отсек сообщества Кижучь");
            base.Moving(disportal);
        }

        
    }
}
