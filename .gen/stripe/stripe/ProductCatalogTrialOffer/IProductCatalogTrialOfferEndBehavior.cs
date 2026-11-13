using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.ProductCatalogTrialOffer
{
    [JsiiInterface(nativeType: typeof(IProductCatalogTrialOfferEndBehavior), fullyQualifiedName: "stripe.productCatalogTrialOffer.ProductCatalogTrialOfferEndBehavior")]
    public interface IProductCatalogTrialOfferEndBehavior
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/product_catalog_trial_offer#transition ProductCatalogTrialOffer#transition}.</summary>
        [JsiiProperty(name: "transition", typeJson: "{\"fqn\":\"stripe.productCatalogTrialOffer.ProductCatalogTrialOfferEndBehaviorTransition\"}")]
        stripe.ProductCatalogTrialOffer.IProductCatalogTrialOfferEndBehaviorTransition Transition
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IProductCatalogTrialOfferEndBehavior), fullyQualifiedName: "stripe.productCatalogTrialOffer.ProductCatalogTrialOfferEndBehavior")]
        internal sealed class _Proxy : DeputyBase, stripe.ProductCatalogTrialOffer.IProductCatalogTrialOfferEndBehavior
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/product_catalog_trial_offer#transition ProductCatalogTrialOffer#transition}.</summary>
            [JsiiProperty(name: "transition", typeJson: "{\"fqn\":\"stripe.productCatalogTrialOffer.ProductCatalogTrialOfferEndBehaviorTransition\"}")]
            public stripe.ProductCatalogTrialOffer.IProductCatalogTrialOfferEndBehaviorTransition Transition
            {
                get => GetInstanceProperty<stripe.ProductCatalogTrialOffer.IProductCatalogTrialOfferEndBehaviorTransition>()!;
            }
        }
    }
}
