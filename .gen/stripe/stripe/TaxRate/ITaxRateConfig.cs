using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TaxRate
{
    [JsiiInterface(nativeType: typeof(ITaxRateConfig), fullyQualifiedName: "stripe.taxRate.TaxRateConfig")]
    public interface ITaxRateConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The display name of the tax rate, which will be shown to users.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/tax_rate#display_name TaxRate#display_name}
        /// </remarks>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        string DisplayName
        {
            get;
        }

        /// <summary>This specifies if the tax rate is inclusive or exclusive.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/tax_rate#inclusive TaxRate#inclusive}
        /// </remarks>
        [JsiiProperty(name: "inclusive", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Inclusive
        {
            get;
        }

        /// <summary>This represents the tax rate percent out of 100.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/tax_rate#percentage TaxRate#percentage}
        /// </remarks>
        [JsiiProperty(name: "percentage", typeJson: "{\"primitive\":\"number\"}")]
        double Percentage
        {
            get;
        }

        /// <summary>Flag determining whether the tax rate is active or inactive (archived).</summary>
        /// <remarks>
        /// Inactive tax rates cannot be used with new applications or Checkout Sessions, but will still work for subscriptions and invoices that already have it set.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/tax_rate#active TaxRate#active}
        /// </remarks>
        [JsiiProperty(name: "active", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Active
        {
            get
            {
                return null;
            }
        }

        /// <summary>Two-letter country code ([ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2)).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/tax_rate#country TaxRate#country}
        /// </remarks>
        [JsiiProperty(name: "country", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Country
        {
            get
            {
                return null;
            }
        }

        /// <summary>An arbitrary string attached to the tax rate for your internal use only.</summary>
        /// <remarks>
        /// It will not be visible to your customers.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/tax_rate#description TaxRate#description}
        /// </remarks>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>The jurisdiction for the tax rate.</summary>
        /// <remarks>
        /// You can use this label field for tax reporting purposes. It also appears on your customer’s invoice.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/tax_rate#jurisdiction TaxRate#jurisdiction}
        /// </remarks>
        [JsiiProperty(name: "jurisdiction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Jurisdiction
        {
            get
            {
                return null;
            }
        }

        /// <summary>Set of [key-value pairs](https://stripe.com/docs/api/metadata) that you can attach to an object. This can be useful for storing additional information about the object in a structured format. Individual keys can be unset by posting an empty value to them. All keys can be unset by posting an empty value to `metadata`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/tax_rate#metadata TaxRate#metadata}
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

        /// <summary>[ISO 3166-2 subdivision code](https://en.wikipedia.org/wiki/ISO_3166-2), without country prefix. For example, \"NY\" for New York, United States.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/tax_rate#state TaxRate#state}
        /// </remarks>
        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? State
        {
            get
            {
                return null;
            }
        }

        /// <summary>The high-level tax type, such as `vat` or `sales_tax`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/tax_rate#tax_type TaxRate#tax_type}
        /// </remarks>
        [JsiiProperty(name: "taxType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TaxType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ITaxRateConfig), fullyQualifiedName: "stripe.taxRate.TaxRateConfig")]
        internal sealed class _Proxy : DeputyBase, stripe.TaxRate.ITaxRateConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The display name of the tax rate, which will be shown to users.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/tax_rate#display_name TaxRate#display_name}
            /// </remarks>
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
            public string DisplayName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>This specifies if the tax rate is inclusive or exclusive.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/tax_rate#inclusive TaxRate#inclusive}
            /// </remarks>
            [JsiiProperty(name: "inclusive", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Inclusive
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>This represents the tax rate percent out of 100.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/tax_rate#percentage TaxRate#percentage}
            /// </remarks>
            [JsiiProperty(name: "percentage", typeJson: "{\"primitive\":\"number\"}")]
            public double Percentage
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Flag determining whether the tax rate is active or inactive (archived).</summary>
            /// <remarks>
            /// Inactive tax rates cannot be used with new applications or Checkout Sessions, but will still work for subscriptions and invoices that already have it set.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/tax_rate#active TaxRate#active}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "active", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Active
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Two-letter country code ([ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2)).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/tax_rate#country TaxRate#country}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "country", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Country
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>An arbitrary string attached to the tax rate for your internal use only.</summary>
            /// <remarks>
            /// It will not be visible to your customers.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/tax_rate#description TaxRate#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The jurisdiction for the tax rate.</summary>
            /// <remarks>
            /// You can use this label field for tax reporting purposes. It also appears on your customer’s invoice.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/tax_rate#jurisdiction TaxRate#jurisdiction}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "jurisdiction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Jurisdiction
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Set of [key-value pairs](https://stripe.com/docs/api/metadata) that you can attach to an object. This can be useful for storing additional information about the object in a structured format. Individual keys can be unset by posting an empty value to them. All keys can be unset by posting an empty value to `metadata`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/tax_rate#metadata TaxRate#metadata}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Metadata
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>[ISO 3166-2 subdivision code](https://en.wikipedia.org/wiki/ISO_3166-2), without country prefix. For example, \"NY\" for New York, United States.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/tax_rate#state TaxRate#state}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? State
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The high-level tax type, such as `vat` or `sales_tax`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/tax_rate#tax_type TaxRate#tax_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "taxType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TaxType
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
