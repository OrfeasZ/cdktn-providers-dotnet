using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AiGateway
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.aiGateway.AiGatewayStripeUsageEvents")]
    public class AiGatewayStripeUsageEvents : cloudflare.AiGateway.IAiGatewayStripeUsageEvents
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_gateway#payload AiGateway#payload}.</summary>
        [JsiiProperty(name: "payload", typeJson: "{\"primitive\":\"string\"}")]
        public string Payload
        {
            get;
            set;
        }
    }
}
