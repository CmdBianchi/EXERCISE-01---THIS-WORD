using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EXERCISE_01___THIS_WORD{
    //----------------------START | OBJ RETANGULO------------------------//
    class Product {
        public string Name;
        public double Price;
        public int Amount;
        public Product(string name, double price)  {
            Name = name;
            Price = price;            
        }
        public Product(string name, double price, int amount) : this(name, price) {
            Amount = amount;
        }
        //------------------------- MET. CLASS ----------------------------//
        public double TotalValueStock(){
            return Price * Amount;
        }
        public void AddProduct(int amount) {
            Amount += amount;
        }
        public void RemoveProduct(int amount) {
            Amount -= amount;
        }
        public override string ToString() {
            return Name
                + "| $ " + Price.ToString("F2") + "| " + Amount + "  Unidades | Total: $ " + TotalValueStock().ToString("F2");
        }     
    }
    //--------------------------- END --------------------------------//
}
