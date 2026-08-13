using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentLink
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.paymentLink.PaymentLinkCustomFieldsLabel")]
    public class PaymentLinkCustomFieldsLabel : stripe.PaymentLink.IPaymentLinkCustomFieldsLabel
    {
        /// <summary>Custom text for the label, displayed to the customer. Up to 50 characters.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#custom PaymentLink#custom}
        /// </remarks>
        [JsiiProperty(name: "custom", typeJson: "{\"primitive\":\"string\"}")]
        public string Custom
        {
            get;
            set;
        }

        /// <summary>The type of the label.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#type PaymentLink#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}
