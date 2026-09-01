using System;
using System.Collections.Generic;
using System.Text;

namespace G_ASP_NET_83_ADVC_03
{
    public class ListOperations
    {
        public static List<T2> Transform<T1,T2>(List<T1> list, Func<T1,T2> action) { 
        
         List<T2> transformed = new List<T2>();
            if (list.Count == 0)
                return transformed;
            foreach (T1 item in list) {
                transformed.Add(action(item));
            
            }
            return transformed;
        
        }

    }
}
