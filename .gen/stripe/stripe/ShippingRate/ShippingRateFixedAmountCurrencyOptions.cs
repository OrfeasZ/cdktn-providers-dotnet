using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.ShippingRate
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.shippingRate.ShippingRateFixedAmountCurrencyOptions")]
    public class ShippingRateFixedAmountCurrencyOptions : stripe.ShippingRate.IShippingRateFixedAmountCurrencyOptions
    {
        /// <summary>A non-negative integer in cents representing how much to charge.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/shipping_rate#amount ShippingRate#amount}
        /// </remarks>
        [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"number\"}")]
        public double Amount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/shipping_rate#key ShippingRate#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }

        /// <summary>Specifies whether the rate is considered inclusive of taxes or exclusive of taxes. One of `inclusive`, `exclusive`, or `unspecified`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/shipping_rate#tax_behavior ShippingRate#tax_behavior}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "taxBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TaxBehavior
        {
            get;
            set;
        }
    }
}
