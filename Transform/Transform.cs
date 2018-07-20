using System;
using System.Linq;
using System.Collections.Generic;

namespace Transform
{
    public static class Transform 
    {
        public delegate int map(int value);
        public static List<int> Map(this int[] value, map item)
        {
            List<int> mapList = new List<int>();
            foreach(int x in value)
            {
                mapList.Add(item(x));
            }

            return mapList;
            //throw new NotImplementedException();
        }
    }
}
