using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2CoreEventDestination
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.v2CoreEventDestination.V2CoreEventDestinationWebhookEndpoint")]
    public class V2CoreEventDestinationWebhookEndpoint : stripe.V2CoreEventDestination.IV2CoreEventDestinationWebhookEndpoint
    {
        /// <summary>The URL where Stripe sends matching events.</summary>
        /// <remarks>
        /// Live mode requires HTTPS; sandbox mode also supports HTTP. Returned only when explicitly included.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_core_event_destination#url V2CoreEventDestination#url}
        /// </remarks>
        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        public string Url
        {
            get;
            set;
        }
    }
}
