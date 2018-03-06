using System.Threading.Tasks;
using Microsoft.AspNet.WebHooks;
using Newtonsoft.Json.Linq;

namespace PayPalReceiver.WebHooks
{
    public class PayPalWebHookHandler : WebHookHandler
    {
        public PayPalWebHookHandler()
        {
            this.Receiver = PaypalWebHookReceiver.ReceiverName;
        }

        public override Task ExecuteAsync(string generator, WebHookHandlerContext context)
        {
            // For more information about PayPal WebHook payloads, please see 
            // 'https://developer.paypal.com/docs/integration/direct/webhooks/'
            JObject entry = context.GetDataOrDefault<JObject>();

            return Task.FromResult(true);
        }
    }
}
