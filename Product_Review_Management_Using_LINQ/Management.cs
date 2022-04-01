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
    }
}
