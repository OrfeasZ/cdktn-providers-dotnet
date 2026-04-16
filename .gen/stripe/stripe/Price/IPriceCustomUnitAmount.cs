using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Price
{
    [JsiiInterface(nativeType: typeof(IPriceCustomUnitAmount), fullyQualifiedName: "stripe.price.PriceCustomUnitAmount")]
    public interface IPriceCustomUnitAmount
    {
        /// <summary>The maximum unit amount the customer can specify for this item.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#maximum Price#maximum}
        /// </remarks>
        [JsiiProperty(name: "maximum", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Maximum
        {
            get
            {
                return null;
            }
        }

        /// <summary>The minimum unit amount the customer can specify for this item. Must be at least the minimum charge amount.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#minimum Price#minimum}
        /// </remarks>
        [JsiiProperty(name: "minimum", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Minimum
        {
            get
            {
                return null;
            }
        }

        /// <summary>The starting unit amount which can be updated by the customer.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#preset Price#preset}
        /// </remarks>
        [JsiiProperty(name: "preset", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Preset
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPriceCustomUnitAmount), fullyQualifiedName: "stripe.price.PriceCustomUnitAmount")]
        internal sealed class _Proxy : DeputyBase, stripe.Price.IPriceCustomUnitAmount
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The maximum unit amount the customer can specify for this item.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#maximum Price#maximum}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maximum", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Maximum
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The minimum unit amount the customer can specify for this item. Must be at least the minimum charge amount.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#minimum Price#minimum}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "minimum", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Minimum
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The starting unit amount which can be updated by the customer.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#preset Price#preset}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "preset", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Preset
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
