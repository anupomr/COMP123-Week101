using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
Name: Anupom Roy
Date: 
Des: New power datatype
version: 0.3 overloaded the > and < operators
*/
namespace COMP123_Week101
{

    /// <summary>
    /// The Power
    /// </summary>
    public class Power
    {
        public string Name { get; set; }
        public int Rank { get; set; }

        public Power(string name, int Rank)

        {
            this.Name = name;
            this.Rank = Rank;

        }
        /// <summary>
        /// this method overload
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns> Return </returns>
        public static bool operator >(Power lhs, Power rhs)
        {
            return (lhs.Rank > rhs.Rank);
        }
        /// <summary>
        ///  this method overload
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns></returns>
        public static bool operator <(Power lhs, Power rhs)
        {
            return (lhs.Rank < rhs.Rank);
        }
    }
}