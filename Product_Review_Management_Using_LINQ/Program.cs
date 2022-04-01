using System;

namespace Product_Review_Management_Using_LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product Review Management Problem Using LINQ");

            List<ProductReview> productReviewList = new List<ProductReview>()
            {
             //UC-1
            new ProductReview() { ProductId = 1, UserId = 1, Rating = 5, Review = "Good", isLike=true},
            new ProductReview() { ProductId = 2, UserId = 1, Rating = 4, Review = "Good", isLike=true },
            new ProductReview() { ProductId = 3, UserId = 1, Rating = 7, Review = "Good", isLike=true },
            new ProductReview() { ProductId = 4, UserId = 1, Rating = 8, Review = "Good", isLike=true },
            new ProductReview() { ProductId = 5, UserId = 1, Rating = 10, Review = "Nice", isLike=true },
            new ProductReview() { ProductId = 6, UserId = 1, Rating = 9, Review = "Nice", isLike=true },
            new ProductReview() { ProductId = 7, UserId = 1, Rating = 6, Review = "Good", isLike=true },
            new ProductReview() { ProductId = 8, UserId = 1, Rating = 7, Review = "Good", isLike=false},
            new ProductReview() { ProductId = 9, UserId = 1, Rating = 8, Review = "Good", isLike=false },
            new ProductReview() { ProductId = 10, UserId = 1, Rating = 2, Review = "Bad", isLike=false },
            new ProductReview() { ProductId = 11, UserId = 1, Rating = 1, Review = "Bad", isLike=false },
            new ProductReview() { ProductId = 12, UserId = 1, Rating = 5, Review = "Good", isLike=true },
            new ProductReview() { ProductId = 13, UserId = 1, Rating = 5, Review = "Good", isLike=true },
            new ProductReview() { ProductId = 14, UserId = 1, Rating = 2, Review = "Bad", isLike=true },
            new ProductReview() { ProductId = 15, UserId = 1, Rating = 5, Review = "Good", isLike=true },
            new ProductReview() { ProductId = 16, UserId = 1, Rating = 5, Review = "Good", isLike=true }
            };

           /* Console.WriteLine("Rows in the table = ");
            foreach (var list in productReviewList)
            {
                Console.WriteLine("Product id = " + list.ProductId + "User id = " + list.UserId + "Rating is = " + list.Rating + " Review is = " + list.Review + " isLike = " + list.isLike);
            }*/


            Management management = new Management();

            //UC-2
            //management.TopRecords(productReviewList);

            //UC-3
            //management.SelectedRecords(productReviewList);

            //UC-4
            //management.RetrieveCountOfRecords(productReviewList);

            //UC-5
            //management.RetrieveProductIdAndReview(productReviewList);

            //UC-6
            management.SkipTopFiveRecords(productReviewList);

        }
    }

}