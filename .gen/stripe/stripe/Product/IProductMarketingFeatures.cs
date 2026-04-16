using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Product
{
    [JsiiInterface(nativeType: typeof(IProductMarketingFeatures), fullyQualifiedName: "stripe.product.ProductMarketingFeatures")]
    public interface IProductMarketingFeatures
    {
        /// <summary>The marketing feature name. Up to 80 characters long.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#name Product#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IProductMarketingFeatures), fullyQualifiedName: "stripe.product.ProductMarketingFeatures")]
        internal sealed class _Proxy : DeputyBase, stripe.Product.IProductMarketingFeatures
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The marketing feature name. Up to 80 characters long.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#name Product#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
