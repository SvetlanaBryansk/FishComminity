using System;

namespace FishCommunity
{
    class Keta : ViewKetaCommunity// класс рыба Кета наледуется от СООБЩЕСТВА вида КЕТА
    {
        

        public Keta(GenusSalmon genusSalmon): base(genusSalmon)
        {
            _availability = 150;// наличие кеты
            _disportal = 150;// выгрузка кеты
        }
        public override void Moving(IDisportal disportal)
        {
            Console.WriteLine($"рыба Кета перегружается в отсек сообщества Кета");
            base.Moving(disportal);
        }
        
    }  
}
