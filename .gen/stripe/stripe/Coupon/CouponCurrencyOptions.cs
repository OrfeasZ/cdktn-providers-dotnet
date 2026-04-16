using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Coupon
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.coupon.CouponCurrencyOptions")]
    public class CouponCurrencyOptions : stripe.Coupon.ICouponCurrencyOptions
    {
        /// <summary>A positive integer representing the amount to subtract from an invoice total.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/coupon#amount_off Coupon#amount_off}
        /// </remarks>
        [JsiiProperty(name: "amountOff", typeJson: "{\"primitive\":\"number\"}")]
        public double AmountOff
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/coupon#key Coupon#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }
    }
}
