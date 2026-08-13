using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiByValue(fqn: "stripe.paymentIntent.PaymentIntentRadarOptions")]
    public class PaymentIntentRadarOptions : stripe.PaymentIntent.IPaymentIntentRadarOptions
    {
        /// <summary>A [Radar Session](https://docs.stripe.com/radar/radar-session) is a snapshot of the browser metadata and device details that help Radar make more accurate predictions on your payments.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#session PaymentIntent#session}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "session", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Session
        {
            get;
            set;
        }
    }
}
