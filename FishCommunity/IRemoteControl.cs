using System;


namespace FishCommunity
{
    interface IRemoteControl//Пульт управления
    {
        void MehanikOperator()//механик оператор
        {
            Console.WriteLine("Была включена панель управления");
        }
    }
}
