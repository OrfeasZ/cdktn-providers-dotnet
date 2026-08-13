using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentLink
{
    [JsiiByValue(fqn: "stripe.paymentLink.PaymentLinkShippingOptions")]
    public class PaymentLinkShippingOptions : stripe.PaymentLink.IPaymentLinkShippingOptions
    {
        /// <summary>The ID of the Shipping Rate to use for this shipping option.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#shipping_rate PaymentLink#shipping_rate}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "shippingRate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ShippingRate
        {
            get;
            set;
        }
    }
}
