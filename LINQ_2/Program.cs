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
        }
    }
}
