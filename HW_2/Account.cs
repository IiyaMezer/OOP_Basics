namespace HW_2
{
    
    internal class Account
    {
        private int _Id;
        private decimal _Cash;
        private enum _Type
        {
            VIP = 1, //особые условие
            Normal = 2, //обычные условия
            Corp = 3, //корпоративные условия(зарплатная карта)
            Comp = 4, //счет компании
        }  

        public int Id
        { 
            get => _Id; 
            set => _Id = value; 
        }
        public decimal Cash 
        {
            get => _Cash;
            set => _Cash = value;
        }

        public void Writeinfo(int id, decimal cash, int Type)
        {
            Console.WriteLine()
        }
        

    }
}
