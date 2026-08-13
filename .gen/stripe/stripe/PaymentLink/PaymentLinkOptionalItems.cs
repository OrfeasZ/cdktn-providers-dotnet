using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentLink
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.paymentLink.PaymentLinkOptionalItems")]
    public class PaymentLinkOptionalItems : stripe.PaymentLink.IPaymentLinkOptionalItems
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#price PaymentLink#price}.</summary>
        [JsiiProperty(name: "price", typeJson: "{\"primitive\":\"string\"}")]
        public string Price
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#quantity PaymentLink#quantity}.</summary>
        [JsiiProperty(name: "quantity", typeJson: "{\"primitive\":\"number\"}")]
        public double Quantity
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#adjustable_quantity PaymentLink#adjustable_quantity}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "adjustableQuantity", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkOptionalItemsAdjustableQuantity\"}", isOptional: true)]
        public stripe.PaymentLink.IPaymentLinkOptionalItemsAdjustableQuantity? AdjustableQuantity
        {
            get;
            set;
        }
    }
}
