using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Review_Management_Using_LINQ
{
    public class Management
    {
        public readonly DataTable dataTable = new DataTable();

        public void TopRecords(List<ProductReview> listProductReview)
        {
            var recordedData = (from productReviews in listProductReview   //LINQ querry
                                orderby productReviews.Rating descending  //these 2 lines retreive the records which are having highest rating
                                select productReviews).Take(3);  //gives highest top 3 records

            foreach (var list in recordedData)  //To check whether I have retreived proper records or not
            {
                Console.WriteLine("ProductId:-" + list.ProductId + " UserId:-" + list.UserId + " Ratings:-" + list.Rating + " Review:-" + list.Review + " IsLike:-" + list.isLike);
            }
        }

        public void SelectedRecords(List<ProductReview> listProductReview)
        {
            var recordedData = from productReviews in listProductReview
                               where (productReviews.ProductId == 1 || productReviews.ProductId == 4 || productReviews.ProductId == 9) && productReviews.Rating > 3
                               select productReviews;
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductId:-" + list.ProductId + " UserId:-" + list.UserId + " Ratings:-" + list.Rating + " Review:-" + list.Review + " IsLike:-" + list.isLike);
            }
        }

        public void RetrieveCountOfRecords(List<ProductReview> listProductReview)
        {
            var recordedData = listProductReview.GroupBy(x => x.ProductId).Select(x => new { ProductId = x.Key, Count = x.Count() });
            Console.WriteLine("\nProduct id and count = ");
            foreach (var list in recordedData)
            {
                Console.WriteLine(list.ProductId + " = " + list.Count);
            }
        }

        public void RetrieveProductIdAndReview(List<ProductReview> listProductReviews)
        {
            //lambda syntax
            var recordData = listProductReviews.Select(x => new { ProductId = x.ProductId, Review = x.Review });
            Console.WriteLine("\nProduct id and review = ");
            foreach (var list in recordData)
            {
                Console.WriteLine(list.ProductId + "------" + list.Review);
            }
        }

        public void SkipTopFiveRecords(List<ProductReview> listProductReview)
        {
            var recordedData = (from productReview in listProductReview
                                select productReview).Skip(5);
            Console.WriteLine("\nTop 5 records from list = ");
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductId:-" + list.ProductId + " UserId:-" + list.UserId + " Ratings:-" + list.Rating + " Review:-" + list.Review + " IsLike:-" + list.isLike);
            }
        }

        public DataTable CreateTable(List<ProductReview> listProductReview)
        {
            dataTable.Columns.Add("ProductId");
            dataTable.Columns.Add("UserId");
            dataTable.Columns.Add("Rating");
            dataTable.Columns.Add("Review");
            dataTable.Columns.Add("isLike");
            return dataTable;
        }

        public void RetrieveRecordsWithIsLikeValueTrue(DataTable table)
        {
            var recordData = from productReview in table.AsEnumerable()
                             where (productReview.Field<string>("isLike") == true.ToString())
                             select productReview;
            
            var recordedData = table.AsEnumerable().Where(x => x.Field<string>("isLike") == true.ToString());
            Console.WriteLine("\nRecords with isLike value is true = ");
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductId:-" + list.Field<string>("ProductId") + " UserId:-" + list.Field<string>("UserId") + " Ratings:-" + list.Field<string>("Rating") + " Review:-" + list.Field<string>("Review") + " IsLike:-" + list.Field<string>("isLike"));
            }
        }

        public void FindAvrageRating(List<ProductReview> listProductReviews)
        {
            //lambda syntax
            var recordedData = listProductReviews.GroupBy(x => x.ProductId).Select(x => new { ProductId = x.Key, Average = x.Average(y => y.Rating) });
            Console.WriteLine("\nAverage rating of ProductId = ");
            foreach (var list in recordedData)
            {
                Console.WriteLine(list.ProductId + "------" + list.Average);
            }
        }
    }
}
