using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Product
{
    [JsiiInterface(nativeType: typeof(IProductTaxDetails), fullyQualifiedName: "stripe.product.ProductTaxDetails")]
    public interface IProductTaxDetails
    {
        /// <summary>The ID of a tax location with type `performance`, representing where the performance takes place.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/product#performance_location Product#performance_location}
        /// </remarks>
        [JsiiProperty(name: "performanceLocation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PerformanceLocation
        {
            get
            {
                return null;
            }
        }

        /// <summary>A [tax code](https://docs.stripe.com/tax/tax-categories) ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/product#tax_code Product#tax_code}
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

        [JsiiTypeProxy(nativeType: typeof(IProductTaxDetails), fullyQualifiedName: "stripe.product.ProductTaxDetails")]
        internal sealed class _Proxy : DeputyBase, stripe.Product.IProductTaxDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The ID of a tax location with type `performance`, representing where the performance takes place.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/product#performance_location Product#performance_location}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "performanceLocation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PerformanceLocation
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A [tax code](https://docs.stripe.com/tax/tax-categories) ID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/product#tax_code Product#tax_code}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "taxCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TaxCode
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
