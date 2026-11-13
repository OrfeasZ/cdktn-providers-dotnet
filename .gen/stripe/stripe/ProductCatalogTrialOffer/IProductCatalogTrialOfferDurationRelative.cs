using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.ProductCatalogTrialOffer
{
    [JsiiInterface(nativeType: typeof(IProductCatalogTrialOfferDurationRelative), fullyQualifiedName: "stripe.productCatalogTrialOffer.ProductCatalogTrialOfferDurationRelative")]
    public interface IProductCatalogTrialOfferDurationRelative
    {
        /// <summary>The number of iterations of the price's interval for this trial offer.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/product_catalog_trial_offer#iterations ProductCatalogTrialOffer#iterations}
        /// </remarks>
        [JsiiProperty(name: "iterations", typeJson: "{\"primitive\":\"number\"}")]
        double Iterations
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IProductCatalogTrialOfferDurationRelative), fullyQualifiedName: "stripe.productCatalogTrialOffer.ProductCatalogTrialOfferDurationRelative")]
        internal sealed class _Proxy : DeputyBase, stripe.ProductCatalogTrialOffer.IProductCatalogTrialOfferDurationRelative
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The number of iterations of the price's interval for this trial offer.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/product_catalog_trial_offer#iterations ProductCatalogTrialOffer#iterations}
            /// </remarks>
            [JsiiProperty(name: "iterations", typeJson: "{\"primitive\":\"number\"}")]
            public double Iterations
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
