using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDEMO.Models
{
    public class Product
    {
        public int id { get; internal set; }
        public int Id { get; internal set; }
        public string name { get; internal set; }
        public int price { get; internal set; }
       
    }
}
