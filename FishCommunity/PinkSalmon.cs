using System;


namespace FishCommunity
{
    class PinkSalmon: ViewPinkSalmonCommunity// класс рыба Горбуша наследуется от СООБЩЕСТВА вида ГОРБУША
    {
       

        public PinkSalmon(GenusSalmon genusSalmon) : base(genusSalmon)
        {
            _availability = 235;
            _disportal = 235;
        }
        public override void Moving(IDisportal disportal)
        {
            Console.WriteLine($"рыба Горбуша  перегружается в отсек сообщества Горбуша ");
            base.Moving(disportal);
        }

        
    }
}
