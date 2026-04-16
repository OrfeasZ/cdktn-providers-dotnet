using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2BillingRateCardRate
{
    [JsiiInterface(nativeType: typeof(IV2BillingRateCardRateConfig), fullyQualifiedName: "stripe.v2BillingRateCardRate.V2BillingRateCardRateConfig")]
    public interface IV2BillingRateCardRateConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The Metered Item that this rate binds to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_rate_card_rate#metered_item V2BillingRateCardRate#metered_item}
        /// </remarks>
        [JsiiProperty(name: "meteredItem", typeJson: "{\"primitive\":\"string\"}")]
        string MeteredItem
        {
            get;
        }

        /// <summary>Path parameter: rate_card_id.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_rate_card_rate#rate_card_id V2BillingRateCardRate#rate_card_id}
        /// </remarks>
        [JsiiProperty(name: "rateCardId", typeJson: "{\"primitive\":\"string\"}")]
        string RateCardId
        {
            get;
        }

        /// <summary>Set of [key-value pairs](/docs/api/metadata) that you can attach to an object.</summary>
        /// <remarks>
        /// This can be useful for storing additional information about the object in a structured format.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_rate_card_rate#metadata V2BillingRateCardRate#metadata}
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

        /// <summary>Defines whether the tiered price should be graduated or volume-based.</summary>
        /// <remarks>
        /// In volume-based tiering, the maximum quantity within a period determines the per-unit price. In graduated tiering, the pricing changes as the quantity grows into new tiers. One of <c>unit_amount</c>, <c>tiers</c>, or <c>custom_pricing_unit_amount</c> is required.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_rate_card_rate#tiering_mode V2BillingRateCardRate#tiering_mode}
        /// </remarks>
        [JsiiProperty(name: "tieringMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TieringMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>tiers block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_rate_card_rate#tiers V2BillingRateCardRate#tiers}
        /// </remarks>
        [JsiiProperty(name: "tiers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.v2BillingRateCardRate.V2BillingRateCardRateTiers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Tiers
        {
            get
            {
                return null;
            }
        }

        /// <summary>The per-unit amount to be charged, represented as a decimal string in minor currency units with at most 12 decimal places.</summary>
        /// <remarks>
        /// One of <c>unit_amount</c>, <c>tiers</c>, or <c>custom_pricing_unit_amount</c> is required.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_rate_card_rate#unit_amount V2BillingRateCardRate#unit_amount}
        /// </remarks>
        [JsiiProperty(name: "unitAmount", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UnitAmount
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IV2BillingRateCardRateConfig), fullyQualifiedName: "stripe.v2BillingRateCardRate.V2BillingRateCardRateConfig")]
        internal sealed class _Proxy : DeputyBase, stripe.V2BillingRateCardRate.IV2BillingRateCardRateConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The Metered Item that this rate binds to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_rate_card_rate#metered_item V2BillingRateCardRate#metered_item}
            /// </remarks>
            [JsiiProperty(name: "meteredItem", typeJson: "{\"primitive\":\"string\"}")]
            public string MeteredItem
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Path parameter: rate_card_id.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_rate_card_rate#rate_card_id V2BillingRateCardRate#rate_card_id}
            /// </remarks>
            [JsiiProperty(name: "rateCardId", typeJson: "{\"primitive\":\"string\"}")]
            public string RateCardId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Set of [key-value pairs](/docs/api/metadata) that you can attach to an object.</summary>
            /// <remarks>
            /// This can be useful for storing additional information about the object in a structured format.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_rate_card_rate#metadata V2BillingRateCardRate#metadata}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Metadata
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Defines whether the tiered price should be graduated or volume-based.</summary>
            /// <remarks>
            /// In volume-based tiering, the maximum quantity within a period determines the per-unit price. In graduated tiering, the pricing changes as the quantity grows into new tiers. One of <c>unit_amount</c>, <c>tiers</c>, or <c>custom_pricing_unit_amount</c> is required.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_rate_card_rate#tiering_mode V2BillingRateCardRate#tiering_mode}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tieringMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TieringMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>tiers block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_rate_card_rate#tiers V2BillingRateCardRate#tiers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tiers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.v2BillingRateCardRate.V2BillingRateCardRateTiers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Tiers
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The per-unit amount to be charged, represented as a decimal string in minor currency units with at most 12 decimal places.</summary>
            /// <remarks>
            /// One of <c>unit_amount</c>, <c>tiers</c>, or <c>custom_pricing_unit_amount</c> is required.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_rate_card_rate#unit_amount V2BillingRateCardRate#unit_amount}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "unitAmount", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UnitAmount
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
