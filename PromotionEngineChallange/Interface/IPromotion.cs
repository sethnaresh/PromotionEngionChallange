using PromotionEngineChallange.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngineChallange.Interface
{
    interface IPromotion
    {
        List<SkuOrder> GetPrice(List<SkuOrder> items);
    }
}
