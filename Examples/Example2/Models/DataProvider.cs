using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example2.Models
{
    public class DataProvider
    {
        public string GetUserPicture(int id)
        {
            if (id > 0)
                return "pic.jpeg";
            else
                return string.Empty;
        }
    }
}
