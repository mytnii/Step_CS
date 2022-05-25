

namespace Classes
{
    public class Request
    {
        private int _orderCode;
        private DateTime _dateOfOrder;
        private string? _listOfGoods;
        private double _orderValue;
        private PayType _payType;

        public enum PayType
        {
            Cash, 
            Check, 
            Credit
        }
        public double Sum(double productPrice, int productQuantity)
        {
            double sum = 0;
            for(int i = 0; i < productQuantity; i++)
            {
                sum += productPrice;
            }

            return sum;

        }

        public Request
            (
            int orderCode, double productPrice, int productQuantity, 
            string listOfGoods, PayType payType
            )
        {
            this._orderCode = orderCode;
            this._dateOfOrder = DateTime.Now;
            this._listOfGoods = listOfGoods;
            this._orderValue = Sum(productPrice, productQuantity);
            this._payType = payType;
        }

        public void PrintRequest()
        {
            Console.WriteLine
                (
                $"{this._orderCode,10} {this._dateOfOrder,20}" +
                $"{this._listOfGoods,15} {this._orderValue,10} {this._payType, 10}\n"
                );
        }
    }
}
