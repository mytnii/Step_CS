

namespace Classes
{
    public class Article
    {
        private int _productCode;
        public string? _productName;
        public double _productPrice;
        private ArticleType _type;

        public static string ProductName
        {
            get;
        }

        public enum ArticleType
        {
            HouseholdChemicals,
            Foods,
            Clothes,
            Furniture
        }

        public static double ProductPrice
        {
            get;
        }
        public Article(int productCode, string productName, double productPrice, ArticleType type)
        {
            this._productCode = productCode;
            this._productName = productName;
            this._productPrice = productPrice;
            this._type = type;
        }

        public void PrintArticle()
        {
            Console.WriteLine
                (
                $"{this._productCode, 10} {this._productName, 15} {this._productPrice, 10} {this._type, 20}\n"
                );
        }
    }
}
