using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Coupon
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.coupon.CouponCurrencyOptions")]
    public class CouponCurrencyOptions : stripe.Coupon.ICouponCurrencyOptions
    {
        /// <summary>Amount (in the `currency` specified) that will be taken off the subtotal of any invoices for this customer.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/coupon#amount_off Coupon#amount_off}
        /// </remarks>
        [JsiiProperty(name: "amountOff", typeJson: "{\"primitive\":\"number\"}")]
        public double AmountOff
        {
            get;
            set;
        }

        /// <summary>Key for this entry.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/coupon#key Coupon#key}
        /// </remarks>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }
    }
}
