﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sheng.WeixinConstruction.Infrastructure
{
    public class GetCampaign_ShakingLotteryGiftWinningListArgs : GetItemListArgs
    {
        public Guid CampaignId
        {
            get;
            set;
        }

        public Guid? PeriodId
        {
            get;
            set;
        }
    }
}
