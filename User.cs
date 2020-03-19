namespace Slutprojekt
{
    public class User
    {
        private uint _money;

        public uint Money
        {
            get
            {
                return _money;
            }
            set
            {
                if (value <= 0)
                {
                    _money = 0;
                    return;
                }
                _money = value;
            }
        }

        public User(uint money)
        {
            _money = money;
        }

        public void AddMoney(uint amount)
        {
            _money += amount;
        }
        public void RemoveMoney(uint amount)
        {
            _money -= amount;
        }
    }
}