using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Coupon
{
    [JsiiInterface(nativeType: typeof(ICouponScript), fullyQualifiedName: "stripe.coupon.CouponScript")]
    public interface ICouponScript
    {
        /// <summary>The configuration values of the script. The keys and values are specific to the script implementation.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/coupon#configuration Coupon#configuration}
        /// </remarks>
        [JsiiProperty(name: "configuration", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        System.Collections.Generic.IDictionary<string, string> Configuration
        {
            get;
        }

        /// <summary>The script implementation ID for this coupon.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/coupon#id Coupon#id}
        ///
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        string Id
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICouponScript), fullyQualifiedName: "stripe.coupon.CouponScript")]
        internal sealed class _Proxy : DeputyBase, stripe.Coupon.ICouponScript
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The configuration values of the script. The keys and values are specific to the script implementation.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/coupon#configuration Coupon#configuration}
            /// </remarks>
            [JsiiProperty(name: "configuration", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
            public System.Collections.Generic.IDictionary<string, string> Configuration
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            }

            /// <summary>The script implementation ID for this coupon.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/coupon#id Coupon#id}
            ///
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
            public string Id
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
