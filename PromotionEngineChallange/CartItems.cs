using PromotionEngineChallange.Models;
using PromotionEngineChallange.Promotions;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngineChallange
{
    public class CartItems
    {
        List<SkuOrder> items;

        public CartItems(List<SkuOrder> _items)
        {
            items =_items;
        }

        public List<SkuOrder> FinalPrice()
        {
            items = new Promotion1().GetPrice(items);
            items = new Promotion2().GetPrice(items);
            items = new Promotion3().GetPrice(items);

            return items;
        }
    }
}
