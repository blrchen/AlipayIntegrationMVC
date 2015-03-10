using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlipayIntegrationMVC.ViewModels
{
    public class AlipayReturnViewModel
    {
        //商户订单号
        public string out_trade_no { get; set; }
        //支付宝交易号
        public string trade_no { get; set; }
        //交易状态
        public string trade_status { get; set; }
        public string message { get; set; }
    }
}