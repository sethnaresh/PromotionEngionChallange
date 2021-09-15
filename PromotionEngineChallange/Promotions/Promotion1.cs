using PromotionEngineChallange.Interface;
using PromotionEngineChallange.Models;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngineChallange.Promotions
{
    public class Promotion1 : IPromotion
    {
        public Promotion1()
        {
        }

        public List<SkuOrder> GetPrice(List<SkuOrder> list)
        {
            if (list.Where(f => f.SKUID == "A" && f.Quantity > 0).Count() > 0)
            {
                var sku = list.Where(f => f.SKUID == "A" && f.Quantity > 0).First();
                if (sku.Quantity > 2)
                {
                    int quotient = sku.Quantity / 3;
                    int remainder = sku.Quantity % 3;
                    int index = list.IndexOf(sku);
                    sku.Price = (quotient * 130) + ((remainder) * 50);
                    list[index].Price = sku.Price;
                    
                }
            }
            else
            {
                if (list.Where(f => f.SKUID == "A" && f.Quantity > 0).Count() == 0)
                {
                    var skuA = list.Where(f => f.SKUID == "A").First();
                    int skuAIndex = list.IndexOf(skuA);
                    list[skuAIndex].Price = 0;
                }
            }
            return list;
        }
    }
}
