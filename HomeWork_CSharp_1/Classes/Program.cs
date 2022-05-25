/*
   Описать структуру Article, 
   содержащую следующие поля:
   код товара; название товара; цену товара.

   Описать структуру Client содержащую поля: 
   код клиента; ФИО; адрес; телефон; 
   количество заказов осуществленных клиентом; 
   общая сумма заказов клиента.

   Описать структуру RequestItem содержащую поля: 
   товар; количество единиц товара.

   Описать структуру Request содержащую поля: 
   код заказа; клиент; дата заказа; 
   перечень заказанных товаров; 
   сумма заказа (реализовать вычисляемым свойством).

   Описать перечисление ArticleType определяющее типы товаров, 
   и добавить соответствующее поле в структуру Article.

   Описать перечисление ClientType определяющее важность клиента, 
   и добавить соответствующее поле в структуру Client.

   Описать перечисление PayType определяющее форму оплаты клиентом заказа, 
   и добавить соответствующее поле в структуру Request.
 */

global using System;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Article article = new Article
                (
                012345,
                "Яблоко",
                1000,
                Article.ArticleType.Foods
                );

            article.PrintArticle();

            Client client = new Client
                (
                123456,
                "Аверкиев",
                "Роман",
                "Евгеньевич",
                "Неизвестно",
                "+79991233456",
                3,
                2000
                );

            client.PrintClient();

            RequestItem requestItem = new RequestItem(article._productName, 3);

            requestItem.PrintRequestItem();

            Request request = new Request
                (
                345678, article._productPrice, requestItem._productQuantity,
                article._productName, Request.PayType.Cash
                );

            request.PrintRequest();
        }
    }
}