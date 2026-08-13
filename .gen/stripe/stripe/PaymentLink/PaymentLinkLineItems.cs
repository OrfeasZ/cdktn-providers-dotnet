using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentLink
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.paymentLink.PaymentLinkLineItems")]
    public class PaymentLinkLineItems : stripe.PaymentLink.IPaymentLinkLineItems
    {
        /// <summary>The quantity of the line item being purchased.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#quantity PaymentLink#quantity}
        /// </remarks>
        [JsiiProperty(name: "quantity", typeJson: "{\"primitive\":\"number\"}")]
        public double Quantity
        {
            get;
            set;
        }

        /// <summary>When set, provides configuration for this item’s quantity to be adjusted by the customer during checkout.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#adjustable_quantity PaymentLink#adjustable_quantity}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "adjustableQuantity", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkLineItemsAdjustableQuantity\"}", isOptional: true)]
        public stripe.PaymentLink.IPaymentLinkLineItemsAdjustableQuantity? AdjustableQuantity
        {
            get;
            set;
        }

        /// <summary>The ID of the [Price](https://docs.stripe.com/api/prices) or [Plan](https://docs.stripe.com/api/plans) object. One of `price` or `price_data` is required.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#price PaymentLink#price}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "price", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Price
        {
            get;
            set;
        }

        /// <summary>Data used to generate a new [Price](https://docs.stripe.com/api/prices) object inline. One of `price` or `price_data` is required.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#price_data PaymentLink#price_data}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "priceData", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkLineItemsPriceData\"}", isOptional: true)]
        public stripe.PaymentLink.IPaymentLinkLineItemsPriceData? PriceData
        {
            get;
            set;
        }
    }
}
