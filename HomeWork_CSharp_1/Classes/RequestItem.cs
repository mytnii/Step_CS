

namespace Classes
{
    public class RequestItem
    {
        private string? _product;
        public int _productQuantity;

       public  static int ProductQuantity
        {
            get;
        }

        public RequestItem(string product, int productQuantity)
        {
            this._product = product;
            this._productQuantity = productQuantity;
        }

        public void PrintRequestItem()
        {
            Console.WriteLine($"{this._product, 15} {this._productQuantity, 10}\n");
        }
    }
}
