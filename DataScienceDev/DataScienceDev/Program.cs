using System;
using System.Collections.Generic;

namespace DataScienceDev
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ratings by Users list
            var data = new List<UserPreferance>();
            data.Add(new UserPreferance(1, 101, 2.5));
            data.Add(new UserPreferance(4, 103, 3.0));
            data.Add(new UserPreferance(1, 103, 3.0));
            data.Add(new UserPreferance(1, 104, 3.5));
            data.Add(new UserPreferance(1, 105, 2.5));
            data.Add(new UserPreferance(1, 106, 3.0));
            data.Add(new UserPreferance(2, 101, 3.0));
            data.Add(new UserPreferance(4, 106, 4.5));
            data.Add(new UserPreferance(2, 103, 1.5));
            data.Add(new UserPreferance(5, 102, 4.0));
            data.Add(new UserPreferance(2, 105, 3.5));
            data.Add(new UserPreferance(2, 106, 3.0));
            data.Add(new UserPreferance(3, 101, 2.5));
            data.Add(new UserPreferance(3, 102, 3.0));
            data.Add(new UserPreferance(3, 104, 3.5));
            data.Add(new UserPreferance(3, 106, 4.0));
            data.Add(new UserPreferance(4, 102, 3.5));
            data.Add(new UserPreferance(2, 104, 5.0));
            data.Add(new UserPreferance(4, 104, 4.0));
            data.Add(new UserPreferance(4, 105, 2.5));
            data.Add(new UserPreferance(6, 104, 5.0));
            data.Add(new UserPreferance(5, 101, 3.0));
            data.Add(new UserPreferance(5, 103, 2.0));
            data.Add(new UserPreferance(5, 104, 3.0));
            data.Add(new UserPreferance(5, 105, 2.0));
            data.Add(new UserPreferance(5, 106, 3.0));
            data.Add(new UserPreferance(6, 101, 3.0));
            data.Add(new UserPreferance(6, 102, 4.0));
            data.Add(new UserPreferance(1, 102, 3.5));
            data.Add(new UserPreferance(6, 105, 3.5));
            data.Add(new UserPreferance(6, 106, 3.0));
            data.Add(new UserPreferance(7, 102, 4.5));
            data.Add(new UserPreferance(7, 104, 4.0));
            data.Add(new UserPreferance(7, 105, 1.0));
            data.Add(new UserPreferance(2, 102, 3.5));

            Dictionary<int, List<UserPreferance>> dictionary = new Dictionary<int, List<UserPreferance>>();

            //Sort all userPreferance data by UserID from low to high
            Console.WriteLine("Sort the list by UserId ascending:");
            data.Sort((x, y) => x.UserId.CompareTo(y.UserId));
            foreach (UserPreferance u in data)
            {
                Console.WriteLine("UserId = " + u.UserId);
            }

            // Sets data into Dictionary
            for (int i = 1; i < 8; i++)
            {
                var listRating = new List<UserPreferance>();
                foreach (UserPreferance u in data)
                {
                    if (u.UserId == i)
                    {
                        listRating.Add(u);
                    }
                }
                dictionary.Add(i, listRating);
            }

            // Prints all users in console
            Console.WriteLine("Print all users in dictionary");
            foreach (var userId in dictionary) { Console.WriteLine("key: " + userId.Key); }
        }

        public class UserPreferance
        {
            public Int32 UserId { get; private set; }
            public Int32 ProductId { get; private set; }
            public Double Rating { get; private set; }

            // additional properties
            // private List<OrderItem> _items;

            public UserPreferance(Int32 userId, Int32 productId, Double rating)
            {
                UserId = userId;
                ProductId = productId;
                Rating = rating;
            }
        }
    }
}
