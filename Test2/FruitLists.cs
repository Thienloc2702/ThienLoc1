using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    public class FruitLists : List<Fruits>
    {
        public void Create()
        {
            do
            {
                String fruit_id = Utils.getString(" Input Fruit's ID: ");
                String fruit_name = Utils.getString(" Input Fruits Name: ");
                String origin_name = Utils.getString(" Input origin's Name: ");
                int price = Utils.getInteger(" Input Fruit's priceL ");





            } while (true);
        }
    }
}
