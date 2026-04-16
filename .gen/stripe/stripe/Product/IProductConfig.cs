using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Product
{
    [JsiiInterface(nativeType: typeof(IProductConfig), fullyQualifiedName: "stripe.product.ProductConfig")]
    public interface IProductConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The product's name, meant to be displayable to the customer.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#name Product#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Whether the product is currently available for purchase. Defaults to `true`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#active Product#active}
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

        /// <summary>default_price_data block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#default_price_data Product#default_price_data}
        /// </remarks>
        [JsiiProperty(name: "defaultPriceData", typeJson: "{\"fqn\":\"stripe.product.ProductDefaultPriceData\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Product.IProductDefaultPriceData? DefaultPriceData
        {
            get
            {
                return null;
            }
        }

        /// <summary>The product's description, meant to be displayable to the customer.</summary>
        /// <remarks>
        /// Use this field to optionally store a long form explanation of the product being sold for your own rendering purposes.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#description Product#description}
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

        /// <summary>A list of up to 8 URLs of images for this product, meant to be displayable to the customer.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#images Product#images}
        /// </remarks>
        [JsiiProperty(name: "images", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Images
        {
            get
            {
                return null;
            }
        }

        /// <summary>marketing_features block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#marketing_features Product#marketing_features}
        /// </remarks>
        [JsiiProperty(name: "marketingFeatures", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.product.ProductMarketingFeatures\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MarketingFeatures
        {
            get
            {
                return null;
            }
        }

        /// <summary>Set of [key-value pairs](https://stripe.com/docs/api/metadata) that you can attach to an object. This can be useful for storing additional information about the object in a structured format. Individual keys can be unset by posting an empty value to them. All keys can be unset by posting an empty value to `metadata`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#metadata Product#metadata}
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

        /// <summary>package_dimensions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#package_dimensions Product#package_dimensions}
        /// </remarks>
        [JsiiProperty(name: "packageDimensions", typeJson: "{\"fqn\":\"stripe.product.ProductPackageDimensions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Product.IProductPackageDimensions? PackageDimensions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether this product is shipped (i.e., physical goods).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#shippable Product#shippable}
        /// </remarks>
        [JsiiProperty(name: "shippable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Shippable
        {
            get
            {
                return null;
            }
        }

        /// <summary>An arbitrary string to be displayed on your customer's credit card or bank statement.</summary>
        /// <remarks>
        /// While most banks display this information consistently, some may display it incorrectly or not at all. This may be up to 22 characters. The statement description may not include <c>&lt;</c>, <c>&gt;</c>, <c>\</c>, <c>\"</c>, <c>'</c> characters, and will appear on your customer's statement in capital letters. Non-ASCII characters are automatically stripped. It must contain at least one letter. Only used for subscription payments.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#statement_descriptor Product#statement_descriptor}
        /// </remarks>
        [JsiiProperty(name: "statementDescriptor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StatementDescriptor
        {
            get
            {
                return null;
            }
        }

        /// <summary>A [tax code](https://stripe.com/docs/tax/tax-categories) ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#tax_code Product#tax_code}
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

        /// <summary>The type of the product.</summary>
        /// <remarks>
        /// Defaults to <c>service</c> if not explicitly specified, enabling use of this product with Subscriptions and Plans. Set this parameter to <c>good</c> to use this product with Orders and SKUs. On API versions before <c>2018-02-05</c>, this field defaults to <c>good</c> for compatibility reasons.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#type Product#type}
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

        /// <summary>A label that represents units of this product.</summary>
        /// <remarks>
        /// When set, this will be included in customers' receipts, invoices, Checkout, and the customer portal.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#unit_label Product#unit_label}
        /// </remarks>
        [JsiiProperty(name: "unitLabel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UnitLabel
        {
            get
            {
                return null;
            }
        }

        /// <summary>A URL of a publicly-accessible webpage for this product.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#url Product#url}
        /// </remarks>
        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Url
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IProductConfig), fullyQualifiedName: "stripe.product.ProductConfig")]
        internal sealed class _Proxy : DeputyBase, stripe.Product.IProductConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The product's name, meant to be displayable to the customer.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#name Product#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Whether the product is currently available for purchase. Defaults to `true`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#active Product#active}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "active", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Active
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>default_price_data block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#default_price_data Product#default_price_data}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "defaultPriceData", typeJson: "{\"fqn\":\"stripe.product.ProductDefaultPriceData\"}", isOptional: true)]
            public stripe.Product.IProductDefaultPriceData? DefaultPriceData
            {
                get => GetInstanceProperty<stripe.Product.IProductDefaultPriceData?>();
            }

            /// <summary>The product's description, meant to be displayable to the customer.</summary>
            /// <remarks>
            /// Use this field to optionally store a long form explanation of the product being sold for your own rendering purposes.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#description Product#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A list of up to 8 URLs of images for this product, meant to be displayable to the customer.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#images Product#images}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "images", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Images
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>marketing_features block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#marketing_features Product#marketing_features}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "marketingFeatures", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.product.ProductMarketingFeatures\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? MarketingFeatures
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Set of [key-value pairs](https://stripe.com/docs/api/metadata) that you can attach to an object. This can be useful for storing additional information about the object in a structured format. Individual keys can be unset by posting an empty value to them. All keys can be unset by posting an empty value to `metadata`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#metadata Product#metadata}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Metadata
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>package_dimensions block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#package_dimensions Product#package_dimensions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "packageDimensions", typeJson: "{\"fqn\":\"stripe.product.ProductPackageDimensions\"}", isOptional: true)]
            public stripe.Product.IProductPackageDimensions? PackageDimensions
            {
                get => GetInstanceProperty<stripe.Product.IProductPackageDimensions?>();
            }

            /// <summary>Whether this product is shipped (i.e., physical goods).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#shippable Product#shippable}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "shippable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Shippable
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>An arbitrary string to be displayed on your customer's credit card or bank statement.</summary>
            /// <remarks>
            /// While most banks display this information consistently, some may display it incorrectly or not at all. This may be up to 22 characters. The statement description may not include <c>&lt;</c>, <c>&gt;</c>, <c>\</c>, <c>\"</c>, <c>'</c> characters, and will appear on your customer's statement in capital letters. Non-ASCII characters are automatically stripped. It must contain at least one letter. Only used for subscription payments.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#statement_descriptor Product#statement_descriptor}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "statementDescriptor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StatementDescriptor
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A [tax code](https://stripe.com/docs/tax/tax-categories) ID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#tax_code Product#tax_code}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "taxCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TaxCode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The type of the product.</summary>
            /// <remarks>
            /// Defaults to <c>service</c> if not explicitly specified, enabling use of this product with Subscriptions and Plans. Set this parameter to <c>good</c> to use this product with Orders and SKUs. On API versions before <c>2018-02-05</c>, this field defaults to <c>good</c> for compatibility reasons.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#type Product#type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A label that represents units of this product.</summary>
            /// <remarks>
            /// When set, this will be included in customers' receipts, invoices, Checkout, and the customer portal.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#unit_label Product#unit_label}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "unitLabel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UnitLabel
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A URL of a publicly-accessible webpage for this product.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#url Product#url}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Url
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
