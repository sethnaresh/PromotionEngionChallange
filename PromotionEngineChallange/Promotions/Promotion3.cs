using PromotionEngineChallange.Models;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngineChallange.Promotions
{
    public class Promotion3
    {

        public Promotion3()
        {

        }

        public List<SkuOrder> GetPrice(List<SkuOrder> list)
        {
            if (list.Where(f => f.SKUID == "C" && f.Quantity > 0).Count() > 0 && list.Where(f => f.SKUID == "D" && f.Quantity > 0).Count() > 0)
            {
                var skuC = list.Where(f => f.SKUID == "C").First();
                int skuCIndex = list.IndexOf(skuC);
                var skuD = list.Where(f => f.SKUID == "D").First();
                int skuDIndex = list.IndexOf(skuD);
                if (skuC.Quantity > 0 && skuD.Quantity > 0)
                {
                    if (skuC.Quantity == skuD.Quantity)
                    {
                        skuC.Price = 0;
                        skuD.Price = skuD.Quantity * 30;
                    }
                    else if (skuC.Quantity > skuD.Quantity)
                    {
                        int difference = skuC.Quantity - skuD.Quantity;
                        skuC.Price = difference * 20;
                        skuD.Price = skuD.Quantity * 30;
                    }
                    else if (skuC.Quantity < skuD.Quantity)
                    {
                        int difference = skuD.Quantity - skuC.Quantity;
                        skuC.Price = 0;
                        skuD.Price = (skuC.Quantity * 30) + (difference * 15);
                    }
                }
            }
            else
            {
                if (list.Where(f => f.SKUID == "C" && f.Quantity > 0).Count() == 0)
                {
                    var skuC = list.Where(f => f.SKUID == "C").First();
                    int skuCIndex = list.IndexOf(skuC);
                    list[skuCIndex].Price = 0;
                }
                if (list.Where(f => f.SKUID == "D" && f.Quantity > 0).Count() == 0)
                {
                    var skuD = list.Where(f => f.SKUID == "D").First();
                    int skuDIndex = list.IndexOf(skuD);
                    list[skuDIndex].Price = 0;
                }
            }
            return list;
        }
    }
}
