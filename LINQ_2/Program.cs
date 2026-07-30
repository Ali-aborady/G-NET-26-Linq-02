using LINQ_2.Models;
using System.Diagnostics.Metrics;
using System.Net.NetworkInformation;
using System.Xml.Linq;
using static LINQ_2.DataSources.Source;

namespace LINQ_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1

            //var result = ProductList
            //            .OrderByDescending(p => p.UnitPrice)
            //            .Take(3);

            #endregion

            #region Question 2

            //var result = ProductList
            //            .Skip(5)
            //            .Take(5);

            #endregion

            #region Question 3
            //var result = ProductList
            //            .OrderBy(p => p.UnitPrice)
            //            .TakeWhile(p => p.UnitPrice < 25);

            #endregion

            #region Question 4

            //var result = ProductList
            //            .Where(p => p.Category == "Seafood")
            //            .All(p => p.UnitsInStock > 0);

            #endregion

            #region Question 5

            //int[] ids = { 3, 9, 13, 18 };

            //bool result = ids.Contains(9);

            #endregion

            #region Question 6

            //var result = ProductList
            //            .GroupBy(p => p.Category)
            //            .Select(g => new
            //            {
            //                Category = g.Key,
            //                Count = g.Count()
            //            });

            #endregion

            #region Question 7

            //var result = ProductList
            //        .GroupBy(p => p.Category)
            //        .Select(g => new
            //        {
            //            Category = g.Key,
            //            Products = g.Select(p => p.ProductName)
            //        });

            #endregion

            #region Question 8

            //var result = ProductList
            //    .GroupBy(p => p.Category)
            //    .Where(g => g.Count() > 3)
            //    .Select(g => g.Key);

            #endregion

            #region Question 9

            //var result = from c in CustomerList
            //             group c by c.Country into g
            //             select new
            //             {
            //                 Country = g.Key,
            //                 Count = g.Count(),
            //                 TotalOrderValue = g.Sum(c => c.Orders.Sum(o => o.Total))
            //             };
            #endregion

            #region Question 10

            //var result = ProductList.Sum(p => p.UnitsInStock);

            #endregion

            #region Question 11

            //var min = ProductList.Min(p => p.UnitPrice);
            //var max = ProductList.Max(p => p.UnitPrice);

            #endregion

            #region Question 12

            //var result = ProductList
            //             .Select(p => p.Category)
            //             .Distinct();    

            #endregion

            #region Question 13

            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };

            //var result = setA.Except(setB);

            #endregion

            #region Question 14

            //string[] list1 = { "Germany", "France", "UK", "Spain" };
            //string[] list2 = { "france", "SPAIN", "Italy" };

            //var result = list1
            //    .Except(list2, StringComparer.OrdinalIgnoreCase);

            #endregion
        }
    }
} 
