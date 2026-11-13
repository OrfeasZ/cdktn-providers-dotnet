using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.ProductCatalogTrialOffer
{
    [JsiiInterface(nativeType: typeof(IProductCatalogTrialOfferEndBehaviorTransition), fullyQualifiedName: "stripe.productCatalogTrialOffer.ProductCatalogTrialOfferEndBehaviorTransition")]
    public interface IProductCatalogTrialOfferEndBehaviorTransition
    {
        /// <summary>The new price to use at the end of the trial offer period.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/product_catalog_trial_offer#price ProductCatalogTrialOffer#price}
        /// </remarks>
        [JsiiProperty(name: "price", typeJson: "{\"primitive\":\"string\"}")]
        string Price
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IProductCatalogTrialOfferEndBehaviorTransition), fullyQualifiedName: "stripe.productCatalogTrialOffer.ProductCatalogTrialOfferEndBehaviorTransition")]
        internal sealed class _Proxy : DeputyBase, stripe.ProductCatalogTrialOffer.IProductCatalogTrialOfferEndBehaviorTransition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The new price to use at the end of the trial offer period.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/product_catalog_trial_offer#price ProductCatalogTrialOffer#price}
            /// </remarks>
            [JsiiProperty(name: "price", typeJson: "{\"primitive\":\"string\"}")]
            public string Price
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
