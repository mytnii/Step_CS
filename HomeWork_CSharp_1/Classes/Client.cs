

namespace Classes
{
    public class Client
    {
        private int _customerCode;
        private string? _lastName;
        private string? _firstName;
        private string? _patronumic;
        private string? _adres;
        private string? _phoneNumber;
        private int _orderQuantity;
        private long _totalOrders;
        private ClientType _type;

        public enum ClientType
        {
            Inconsiderable,
            So_So, 
            Significant, 
            Topmost
        }
        public Client
            (
            int customerCode, string lastName, string firstName,
            string patronumic, string adres, string phoneNumber,
            int orderQuantity, long totalOrders
            )
        {
            this._customerCode = customerCode;
            this._lastName = lastName;
            this._firstName = firstName;
            this._patronumic = patronumic;
            this._adres = adres;
            this._phoneNumber = phoneNumber;
            this._orderQuantity = orderQuantity;
            this._totalOrders = totalOrders;

            if (this._totalOrders < 1000)
            {
                this._type = ClientType.Inconsiderable;
            }
            else if (this._totalOrders > 1000 && this._totalOrders <= 5000)
            {
                this._type = ClientType.So_So;
            }
            else if (this._totalOrders > 5000 && this._totalOrders <= 25000)
            {
                this._type = ClientType.Significant;
            }
            else
            {
                this._type = ClientType.Topmost;
            }
        }

        public void PrintClient()
        {
            Console.WriteLine
                (
                $"{this._customerCode,10} {this._lastName,15} {this._firstName,15}" +
                $"{this._patronumic,15} {this._adres,15} {this._phoneNumber,15}" +
                $"{this._orderQuantity,10} {this._totalOrders,10} {this._type, 15}\n"
                );
        }
    }
}
