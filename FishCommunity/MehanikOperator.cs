using System;

namespace FishCommunity
{
    class MehanikOperator :IRemoteControl, IDisportal// класс Механик-Оператор реализует интерфейс - пульт управления
    {
        private int disportal;

        public void Moving(IDisportal disportal)
        { 
            Console.WriteLine("Оператор выполняет перемешение");
        
            throw new NotImplementedException();
        }


        public void TakeDisportal()
        {
            if (disportal < 0)
                Console.WriteLine("Выполнено ");
            throw new NotImplementedException();
          
        }

        public void TakeDisportal(int disportal)
        {

            throw new NotImplementedException();

        }
    }

}
//if (disportal < 0)
//    throw new ArgumentOutOfRangeException();// переместить нельзя меньше 0        
//if (disportal >= _availability)
//{
//    _availability = 0;
//    Done();//перемещение выполнено
//    return;
//}
//_availability -= disportal;