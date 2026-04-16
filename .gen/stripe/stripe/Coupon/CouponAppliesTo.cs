using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Coupon
{
    [JsiiByValue(fqn: "stripe.coupon.CouponAppliesTo")]
    public class CouponAppliesTo : stripe.Coupon.ICouponAppliesTo
    {
        /// <summary>An array of Product IDs that this Coupon will apply to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/coupon#products Coupon#products}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "products", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Products
        {
            get;
            set;
        }
    }
}
