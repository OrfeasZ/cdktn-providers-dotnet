using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.ProductCatalogTrialOffer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.productCatalogTrialOffer.ProductCatalogTrialOfferEndBehaviorTransition")]
    public class ProductCatalogTrialOfferEndBehaviorTransition : stripe.ProductCatalogTrialOffer.IProductCatalogTrialOfferEndBehaviorTransition
    {
        /// <summary>The new price to use at the end of the trial offer period.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/product_catalog_trial_offer#price ProductCatalogTrialOffer#price}
        /// </remarks>
        [JsiiProperty(name: "price", typeJson: "{\"primitive\":\"string\"}")]
        public string Price
        {
            get;
            set;
        }
    }
}
