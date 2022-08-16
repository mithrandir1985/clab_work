using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Model
    {
       private static  List<Model> _models = new List<Model>();
        public int Number { get; set; }
        public string Date { get; set; }
        public int invintory { get; set; }
        public string itemname { get; set; }
        public int  count { get; set; }
        public double price { get; set; }
        public void save() {
            _models.Add(this);
           // Console.WriteLine("save");

           
        }
     public static List<Model> getall() {
           return _models ;
          
        }
    }
}
