using System;


namespace FishCommunity
{
    class SockeyeSalmon: GenusSalmon// класс Нерка наследуется от класса СООБЩЕСТВА вида НЕРКА
    {
       
        public SockeyeSalmon(GenusSalmon genusSalmon) : base(genusSalmon)
        {
            _availability = 365;
            _disportal = 365;
        }

        public override void Moving(IDisportal disportal)
        {
            Console.WriteLine($"рыба Нерка  перегружается в отсек сообщества Нерка ");
            base.Moving(disportal);
        }

        
    }
}
