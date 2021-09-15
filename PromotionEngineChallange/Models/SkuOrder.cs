using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngineChallange.Models
{
    public class SkuOrder : SkuItem
    {
        public int Quantity { get; set; }

        public SkuOrder(string id)
        {
            this.SKUID = id;
            switch (id)
            {
                case "A":
                    this.Price = 50m;

                    break;
                case "B":
                    this.Price = 30m;

                    break;
                case "C":
                    this.Price = 20m;

                    break;
                case "D":
                    this.Price = 15m;
                    break;
            }
        }
    }
}
