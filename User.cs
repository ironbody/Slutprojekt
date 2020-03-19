namespace Slutprojekt
{
    public class User
    {
        // This class could probably be a singleton but I don't know how to make it one at the moment 

        private static uint _money;

        public static uint Money
        {
            get
            {
                return _money;
            }
        }

        public User(uint money)
        {
            _money = money;
        }

        public static void AddMoney(uint amount)
        {
            _money += amount;
        }
        public static void RemoveMoney(uint amount)
        {
            _money -= amount;
        }
    }
}