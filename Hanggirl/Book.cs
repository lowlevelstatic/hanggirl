using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanggirl
{
    class Book
    {
        private readonly String[] strings = CreateStrings();

        public int Length
        {
            get
            {
                return strings.Length;
            }
        }

        public Book()
        {
            CreateStrings();
        }

        public String GetString(int key)
        {
            return strings[key];
        }

        private static String[] CreateStrings()
        {
            return new string[]{
            "secretive", 
            "copper", 
            "unite", 
            "decisive", 
            "explain",
            "branch",
            "notice",
            "educated",
            "truck",
            "tenuous",
            "neat",
            "hum",
            "street",
            "identify",
            "raspy",
            "knotty",
            "productive",
            "wry",
            "credit",
            "curly",
            };
        }
    }
}
