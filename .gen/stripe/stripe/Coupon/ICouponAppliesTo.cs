using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Coupon
{
    [JsiiInterface(nativeType: typeof(ICouponAppliesTo), fullyQualifiedName: "stripe.coupon.CouponAppliesTo")]
    public interface ICouponAppliesTo
    {
        /// <summary>A list of product IDs this coupon applies to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/coupon#products Coupon#products}
        /// </remarks>
        [JsiiProperty(name: "products", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Products
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICouponAppliesTo), fullyQualifiedName: "stripe.coupon.CouponAppliesTo")]
        internal sealed class _Proxy : DeputyBase, stripe.Coupon.ICouponAppliesTo
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>A list of product IDs this coupon applies to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/coupon#products Coupon#products}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "products", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Products
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
