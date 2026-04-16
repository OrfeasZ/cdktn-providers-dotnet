using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Price
{
    [JsiiInterface(nativeType: typeof(IPriceProductData), fullyQualifiedName: "stripe.price.PriceProductData")]
    public interface IPriceProductData
    {
        /// <summary>The product's name, meant to be displayable to the customer.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#name Price#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Whether the product is currently available for purchase. Defaults to `true`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#active Price#active}
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

        /// <summary>The identifier for the product. Must be unique. If not provided, an identifier will be randomly generated.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#id Price#id}
        ///
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Set of [key-value pairs](https://stripe.com/docs/api/metadata) that you can attach to an object. This can be useful for storing additional information about the object in a structured format. Individual keys can be unset by posting an empty value to them. All keys can be unset by posting an empty value to `metadata`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#metadata Price#metadata}
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

        /// <summary>An arbitrary string to be displayed on your customer's credit card or bank statement.</summary>
        /// <remarks>
        /// While most banks display this information consistently, some may display it incorrectly or not at all. This may be up to 22 characters. The statement description may not include <c>&lt;</c>, <c>&gt;</c>, <c>\</c>, <c>\"</c>, <c>'</c> characters, and will appear on your customer's statement in capital letters. Non-ASCII characters are automatically stripped.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#statement_descriptor Price#statement_descriptor}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#tax_code Price#tax_code}
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

        /// <summary>A label that represents units of this product.</summary>
        /// <remarks>
        /// When set, this will be included in customers' receipts, invoices, Checkout, and the customer portal.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#unit_label Price#unit_label}
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

        [JsiiTypeProxy(nativeType: typeof(IPriceProductData), fullyQualifiedName: "stripe.price.PriceProductData")]
        internal sealed class _Proxy : DeputyBase, stripe.Price.IPriceProductData
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The product's name, meant to be displayable to the customer.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#name Price#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Whether the product is currently available for purchase. Defaults to `true`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#active Price#active}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "active", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Active
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The identifier for the product. Must be unique. If not provided, an identifier will be randomly generated.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#id Price#id}
            ///
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Set of [key-value pairs](https://stripe.com/docs/api/metadata) that you can attach to an object. This can be useful for storing additional information about the object in a structured format. Individual keys can be unset by posting an empty value to them. All keys can be unset by posting an empty value to `metadata`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#metadata Price#metadata}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Metadata
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>An arbitrary string to be displayed on your customer's credit card or bank statement.</summary>
            /// <remarks>
            /// While most banks display this information consistently, some may display it incorrectly or not at all. This may be up to 22 characters. The statement description may not include <c>&lt;</c>, <c>&gt;</c>, <c>\</c>, <c>\"</c>, <c>'</c> characters, and will appear on your customer's statement in capital letters. Non-ASCII characters are automatically stripped.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#statement_descriptor Price#statement_descriptor}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "statementDescriptor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StatementDescriptor
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A [tax code](https://stripe.com/docs/tax/tax-categories) ID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#tax_code Price#tax_code}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "taxCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TaxCode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A label that represents units of this product.</summary>
            /// <remarks>
            /// When set, this will be included in customers' receipts, invoices, Checkout, and the customer portal.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#unit_label Price#unit_label}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "unitLabel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UnitLabel
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
