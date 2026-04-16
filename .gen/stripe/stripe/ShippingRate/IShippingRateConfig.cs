using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.ShippingRate
{
    [JsiiInterface(nativeType: typeof(IShippingRateConfig), fullyQualifiedName: "stripe.shippingRate.ShippingRateConfig")]
    public interface IShippingRateConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The name of the shipping rate, meant to be displayable to the customer. This will appear on CheckoutSessions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/shipping_rate#display_name ShippingRate#display_name}
        /// </remarks>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        string DisplayName
        {
            get;
        }

        /// <summary>delivery_estimate block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/shipping_rate#delivery_estimate ShippingRate#delivery_estimate}
        /// </remarks>
        [JsiiProperty(name: "deliveryEstimate", typeJson: "{\"fqn\":\"stripe.shippingRate.ShippingRateDeliveryEstimate\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.ShippingRate.IShippingRateDeliveryEstimate? DeliveryEstimate
        {
            get
            {
                return null;
            }
        }

        /// <summary>fixed_amount block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/shipping_rate#fixed_amount ShippingRate#fixed_amount}
        /// </remarks>
        [JsiiProperty(name: "fixedAmount", typeJson: "{\"fqn\":\"stripe.shippingRate.ShippingRateFixedAmount\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.ShippingRate.IShippingRateFixedAmount? FixedAmount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Set of [key-value pairs](https://stripe.com/docs/api/metadata) that you can attach to an object. This can be useful for storing additional information about the object in a structured format. Individual keys can be unset by posting an empty value to them. All keys can be unset by posting an empty value to `metadata`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/shipping_rate#metadata ShippingRate#metadata}
        /// </remarks>
        [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Metadata
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies whether the rate is considered inclusive of taxes or exclusive of taxes. One of `inclusive`, `exclusive`, or `unspecified`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/shipping_rate#tax_behavior ShippingRate#tax_behavior}
        /// </remarks>
        [JsiiProperty(name: "taxBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TaxBehavior
        {
            get
            {
                return null;
            }
        }

        /// <summary>A [tax code](https://stripe.com/docs/tax/tax-categories) ID. The Shipping tax code is `txcd_92010001`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/shipping_rate#tax_code ShippingRate#tax_code}
        /// </remarks>
        [JsiiProperty(name: "taxCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TaxCode
        {
            get
            {
                return null;
            }
        }

        /// <summary>The type of calculation to use on the shipping rate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/shipping_rate#type ShippingRate#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IShippingRateConfig), fullyQualifiedName: "stripe.shippingRate.ShippingRateConfig")]
        internal sealed class _Proxy : DeputyBase, stripe.ShippingRate.IShippingRateConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The name of the shipping rate, meant to be displayable to the customer. This will appear on CheckoutSessions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/shipping_rate#display_name ShippingRate#display_name}
            /// </remarks>
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
            public string DisplayName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>delivery_estimate block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/shipping_rate#delivery_estimate ShippingRate#delivery_estimate}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deliveryEstimate", typeJson: "{\"fqn\":\"stripe.shippingRate.ShippingRateDeliveryEstimate\"}", isOptional: true)]
            public stripe.ShippingRate.IShippingRateDeliveryEstimate? DeliveryEstimate
            {
                get => GetInstanceProperty<stripe.ShippingRate.IShippingRateDeliveryEstimate?>();
            }

            /// <summary>fixed_amount block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/shipping_rate#fixed_amount ShippingRate#fixed_amount}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fixedAmount", typeJson: "{\"fqn\":\"stripe.shippingRate.ShippingRateFixedAmount\"}", isOptional: true)]
            public stripe.ShippingRate.IShippingRateFixedAmount? FixedAmount
            {
                get => GetInstanceProperty<stripe.ShippingRate.IShippingRateFixedAmount?>();
            }

            /// <summary>Set of [key-value pairs](https://stripe.com/docs/api/metadata) that you can attach to an object. This can be useful for storing additional information about the object in a structured format. Individual keys can be unset by posting an empty value to them. All keys can be unset by posting an empty value to `metadata`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/shipping_rate#metadata ShippingRate#metadata}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Metadata
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Specifies whether the rate is considered inclusive of taxes or exclusive of taxes. One of `inclusive`, `exclusive`, or `unspecified`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/shipping_rate#tax_behavior ShippingRate#tax_behavior}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "taxBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TaxBehavior
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A [tax code](https://stripe.com/docs/tax/tax-categories) ID. The Shipping tax code is `txcd_92010001`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/shipping_rate#tax_code ShippingRate#tax_code}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "taxCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TaxCode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The type of calculation to use on the shipping rate.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/shipping_rate#type ShippingRate#type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
