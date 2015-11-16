# AlipayIntegrationMVC
阿里官方的支付宝实时到账的代码示例里DotNet平台（C#语言）只有ASP.NET（WebForm）版本的，没有ASP.NET MVC版本的。所以就写了这个ASP.NET MVC的版本，欢迎有爱的童鞋fork。

一些注意事项

1. 调试前请先在保证AlipayConfig.cs和PaymentController.cs的SubmitAlipay方法里的配置参数均已经更新成正确的参数。 
2. 调试需要用服务器调试，不要用localhost调试，要用申请账号的域名调试。 
3. 关于return_url和notify_url的说明：
  * return_url是支付完毕后，从支付宝跳转回来的页面，可以理解为是一个同步的接口，只返回一次，商家支付完毕后的业务逻辑主要在这个页面实现。这个接口可以通过http get方法直接取得交易结果的相关详细信息，比如商户订单号，支付宝交易号，交易状态等等。 
  * notifiy_url是个异步通知的接口页面，支付宝会在48小时内将支付结果主动post到这个页面，如果失败则会多次尝试，直到成功为止。这个接口的主要用处是可以减少了订单支付信息不完整（比如用户支付完毕但是没能成功的返回商家网站）情况的出现，从而避免了因为没有支付信息需要人工完成的订单对账工作。 
  * 不要假设return_url会先于notify_url发生，支付宝不保证这2个返回的先后顺序，所以在return_url也要判断交易是否已经处理过。 

