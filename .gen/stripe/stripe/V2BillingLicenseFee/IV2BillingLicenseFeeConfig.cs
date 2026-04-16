using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2BillingLicenseFee
{
    [JsiiInterface(nativeType: typeof(IV2BillingLicenseFeeConfig), fullyQualifiedName: "stripe.v2BillingLicenseFee.V2BillingLicenseFeeConfig")]
    public interface IV2BillingLicenseFeeConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Three-letter ISO currency code, in lowercase. Must be a supported currency.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_license_fee#currency V2BillingLicenseFee#currency}
        /// </remarks>
        [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}")]
        string Currency
        {
            get;
        }

        /// <summary>A customer-facing name for the License Fee.</summary>
        /// <remarks>
        /// This name is used in Stripe-hosted products like the Customer Portal and Checkout. It does not show up on Invoices. Maximum length of 250 characters.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_license_fee#display_name V2BillingLicenseFee#display_name}
        /// </remarks>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        string DisplayName
        {
            get;
        }

        /// <summary>The Licensed Item that this License Fee binds to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_license_fee#licensed_item V2BillingLicenseFee#licensed_item}
        /// </remarks>
        [JsiiProperty(name: "licensedItem", typeJson: "{\"primitive\":\"string\"}")]
        string LicensedItem
        {
            get;
        }

        /// <summary>The interval for assessing service.</summary>
        /// <remarks>
        /// For example, a monthly license fee with a rate of $1 for the first 10 "workloads" and $2 thereafter means "$1 per workload up to 10 workloads during a month of service." This is similar to but distinct from billing interval; the service interval deals with the rate at which the customer accumulates fees, while the billing interval in Cadence deals with the rate the customer is billed.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_license_fee#service_interval V2BillingLicenseFee#service_interval}
        /// </remarks>
        [JsiiProperty(name: "serviceInterval", typeJson: "{\"primitive\":\"string\"}")]
        string ServiceInterval
        {
            get;
        }

        /// <summary>The length of the interval for assessing service.</summary>
        /// <remarks>
        /// For example, set this to 3 and <c>service_interval</c> to <c>\"month\"</c> in order to specify quarterly service.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_license_fee#service_interval_count V2BillingLicenseFee#service_interval_count}
        /// </remarks>
        [JsiiProperty(name: "serviceIntervalCount", typeJson: "{\"primitive\":\"number\"}")]
        double ServiceIntervalCount
        {
            get;
        }

        /// <summary>The Stripe Tax tax behavior - whether the license fee is inclusive or exclusive of tax.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_license_fee#tax_behavior V2BillingLicenseFee#tax_behavior}
        /// </remarks>
        [JsiiProperty(name: "taxBehavior", typeJson: "{\"primitive\":\"string\"}")]
        string TaxBehavior
        {
            get;
        }

        /// <summary>An internal key you can use to search for a particular license fee. Maximum length of 200 characters.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_license_fee#lookup_key V2BillingLicenseFee#lookup_key}
        /// </remarks>
        [JsiiProperty(name: "lookupKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LookupKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Set of [key-value pairs](/docs/api/metadata) that you can attach to an object.</summary>
        /// <remarks>
        /// This can be useful for storing additional information about the object in a structured format.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_license_fee#metadata V2BillingLicenseFee#metadata}
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
        /// In volume-based tiering, the maximum quantity within a period determines the per-unit price. In graduated tiering, the pricing changes as the quantity grows into new tiers. Can only be set if <c>tiers</c> is set.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_license_fee#tiering_mode V2BillingLicenseFee#tiering_mode}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_license_fee#tiers V2BillingLicenseFee#tiers}
        /// </remarks>
        [JsiiProperty(name: "tiers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.v2BillingLicenseFee.V2BillingLicenseFeeTiers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Cannot be set if <c>tiers</c> is provided.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_license_fee#unit_amount V2BillingLicenseFee#unit_amount}
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

        [JsiiTypeProxy(nativeType: typeof(IV2BillingLicenseFeeConfig), fullyQualifiedName: "stripe.v2BillingLicenseFee.V2BillingLicenseFeeConfig")]
        internal sealed class _Proxy : DeputyBase, stripe.V2BillingLicenseFee.IV2BillingLicenseFeeConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Three-letter ISO currency code, in lowercase. Must be a supported currency.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_license_fee#currency V2BillingLicenseFee#currency}
            /// </remarks>
            [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}")]
            public string Currency
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>A customer-facing name for the License Fee.</summary>
            /// <remarks>
            /// This name is used in Stripe-hosted products like the Customer Portal and Checkout. It does not show up on Invoices. Maximum length of 250 characters.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_license_fee#display_name V2BillingLicenseFee#display_name}
            /// </remarks>
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
            public string DisplayName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The Licensed Item that this License Fee binds to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_license_fee#licensed_item V2BillingLicenseFee#licensed_item}
            /// </remarks>
            [JsiiProperty(name: "licensedItem", typeJson: "{\"primitive\":\"string\"}")]
            public string LicensedItem
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The interval for assessing service.</summary>
            /// <remarks>
            /// For example, a monthly license fee with a rate of $1 for the first 10 "workloads" and $2 thereafter means "$1 per workload up to 10 workloads during a month of service." This is similar to but distinct from billing interval; the service interval deals with the rate at which the customer accumulates fees, while the billing interval in Cadence deals with the rate the customer is billed.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_license_fee#service_interval V2BillingLicenseFee#service_interval}
            /// </remarks>
            [JsiiProperty(name: "serviceInterval", typeJson: "{\"primitive\":\"string\"}")]
            public string ServiceInterval
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The length of the interval for assessing service.</summary>
            /// <remarks>
            /// For example, set this to 3 and <c>service_interval</c> to <c>\"month\"</c> in order to specify quarterly service.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_license_fee#service_interval_count V2BillingLicenseFee#service_interval_count}
            /// </remarks>
            [JsiiProperty(name: "serviceIntervalCount", typeJson: "{\"primitive\":\"number\"}")]
            public double ServiceIntervalCount
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>The Stripe Tax tax behavior - whether the license fee is inclusive or exclusive of tax.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_license_fee#tax_behavior V2BillingLicenseFee#tax_behavior}
            /// </remarks>
            [JsiiProperty(name: "taxBehavior", typeJson: "{\"primitive\":\"string\"}")]
            public string TaxBehavior
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>An internal key you can use to search for a particular license fee. Maximum length of 200 characters.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_license_fee#lookup_key V2BillingLicenseFee#lookup_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lookupKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LookupKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Set of [key-value pairs](/docs/api/metadata) that you can attach to an object.</summary>
            /// <remarks>
            /// This can be useful for storing additional information about the object in a structured format.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_license_fee#metadata V2BillingLicenseFee#metadata}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Metadata
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Defines whether the tiered price should be graduated or volume-based.</summary>
            /// <remarks>
            /// In volume-based tiering, the maximum quantity within a period determines the per-unit price. In graduated tiering, the pricing changes as the quantity grows into new tiers. Can only be set if <c>tiers</c> is set.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_license_fee#tiering_mode V2BillingLicenseFee#tiering_mode}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tieringMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TieringMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>tiers block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_license_fee#tiers V2BillingLicenseFee#tiers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tiers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.v2BillingLicenseFee.V2BillingLicenseFeeTiers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Tiers
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The per-unit amount to be charged, represented as a decimal string in minor currency units with at most 12 decimal places.</summary>
            /// <remarks>
            /// Cannot be set if <c>tiers</c> is provided.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_license_fee#unit_amount V2BillingLicenseFee#unit_amount}
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
