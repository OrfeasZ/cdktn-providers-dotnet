using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.ProductCatalogTrialOffer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.productCatalogTrialOffer.ProductCatalogTrialOfferEndBehavior")]
    public class ProductCatalogTrialOfferEndBehavior : stripe.ProductCatalogTrialOffer.IProductCatalogTrialOfferEndBehavior
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/product_catalog_trial_offer#transition ProductCatalogTrialOffer#transition}.</summary>
        [JsiiProperty(name: "transition", typeJson: "{\"fqn\":\"stripe.productCatalogTrialOffer.ProductCatalogTrialOfferEndBehaviorTransition\"}")]
        public stripe.ProductCatalogTrialOffer.IProductCatalogTrialOfferEndBehaviorTransition Transition
        {
            get;
            set;
        }
    }
}
