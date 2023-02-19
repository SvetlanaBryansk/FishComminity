using System;


namespace FishCommunity


{
    class GenusSalmon : IDisportal, IRemoteControl //класс Род Лососевые :
    {
        protected int _availability;//наличие
        protected int _disportal;//выбытие

        protected IRemoteControl _remoteControl; // пульт управления



        public GenusSalmon(IRemoteControl remoteControl) => _remoteControl = remoteControl;


        public virtual void Moving(IDisportal disportal)
        {
            _remoteControl.MehanikOperator();
            disportal.TakeDisportal(_disportal);
        }

        public virtual void TakeDisportal(int disportal)
        {
            _remoteControl.MehanikOperator();
            if (disportal < 0)
                throw new ArgumentOutOfRangeException();// переместить нельзя меньше 0        
            if (disportal >= _availability)
            {
                _availability = 0;
                Done();//перемещение выполнено
                return;
            }
            _availability -= disportal;
        }
        public virtual void Done() { }
    }
}
        


