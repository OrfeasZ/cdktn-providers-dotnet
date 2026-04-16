using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Product
{
    [JsiiInterface(nativeType: typeof(IProductDefaultPriceDataCurrencyOptionsCustomUnitAmount), fullyQualifiedName: "stripe.product.ProductDefaultPriceDataCurrencyOptionsCustomUnitAmount")]
    public interface IProductDefaultPriceDataCurrencyOptionsCustomUnitAmount
    {
        /// <summary>Pass in `true` to enable `custom_unit_amount`, otherwise omit `custom_unit_amount`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#enabled Product#enabled}
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        /// <summary>The maximum unit amount the customer can specify for this item.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#maximum Product#maximum}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#minimum Product#minimum}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#preset Product#preset}
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

        [JsiiTypeProxy(nativeType: typeof(IProductDefaultPriceDataCurrencyOptionsCustomUnitAmount), fullyQualifiedName: "stripe.product.ProductDefaultPriceDataCurrencyOptionsCustomUnitAmount")]
        internal sealed class _Proxy : DeputyBase, stripe.Product.IProductDefaultPriceDataCurrencyOptionsCustomUnitAmount
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Pass in `true` to enable `custom_unit_amount`, otherwise omit `custom_unit_amount`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#enabled Product#enabled}
            /// </remarks>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>The maximum unit amount the customer can specify for this item.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#maximum Product#maximum}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maximum", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Maximum
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The minimum unit amount the customer can specify for this item. Must be at least the minimum charge amount.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#minimum Product#minimum}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "minimum", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Minimum
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The starting unit amount which can be updated by the customer.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#preset Product#preset}
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
