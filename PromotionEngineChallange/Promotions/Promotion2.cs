using PromotionEngineChallange.Models;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngineChallange.Promotions
{
    public class Promotion2
    {
        public Promotion2()
        {

        }

        public List<SkuOrder> GetPrice(List<SkuOrder> list)
        {
            if (list.Where(f => f.SKUID == "B" && f.Quantity > 0).Count() > 0)
            {
                var sku = list.Where(f => f.SKUID == "B" && f.Quantity > 0).First();
                if (sku.Quantity > 1)
                {
                    int quotient = sku.Quantity / 2;
                    int remainder = sku.Quantity % 2;
                    int index = list.IndexOf(sku);
                    sku.Price = (quotient * 45) + ((remainder) * 30);
                    list[index].Price = sku.Price;
                }
            }
            else
            {
                if (list.Where(f => f.SKUID == "B" && f.Quantity > 0).Count() == 0)
                {
                    var skuB = list.Where(f => f.SKUID == "B").First();
                    int skuBIndex = list.IndexOf(skuB);
                    list[skuBIndex].Price = 0;
                }
            }
            return list;
        }
    }
}
