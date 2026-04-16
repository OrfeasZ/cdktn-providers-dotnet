using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Coupon
{
    [JsiiInterface(nativeType: typeof(ICouponCurrencyOptions), fullyQualifiedName: "stripe.coupon.CouponCurrencyOptions")]
    public interface ICouponCurrencyOptions
    {
        /// <summary>A positive integer representing the amount to subtract from an invoice total.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/coupon#amount_off Coupon#amount_off}
        /// </remarks>
        [JsiiProperty(name: "amountOff", typeJson: "{\"primitive\":\"number\"}")]
        double AmountOff
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/coupon#key Coupon#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICouponCurrencyOptions), fullyQualifiedName: "stripe.coupon.CouponCurrencyOptions")]
        internal sealed class _Proxy : DeputyBase, stripe.Coupon.ICouponCurrencyOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>A positive integer representing the amount to subtract from an invoice total.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/coupon#amount_off Coupon#amount_off}
            /// </remarks>
            [JsiiProperty(name: "amountOff", typeJson: "{\"primitive\":\"number\"}")]
            public double AmountOff
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/coupon#key Coupon#key}.</summary>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
