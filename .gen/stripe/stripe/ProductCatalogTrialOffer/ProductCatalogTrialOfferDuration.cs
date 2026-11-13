using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.ProductCatalogTrialOffer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.productCatalogTrialOffer.ProductCatalogTrialOfferDuration")]
    public class ProductCatalogTrialOfferDuration : stripe.ProductCatalogTrialOffer.IProductCatalogTrialOfferDuration
    {
        /// <summary>The type of trial offer duration.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/product_catalog_trial_offer#type ProductCatalogTrialOffer#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/product_catalog_trial_offer#relative ProductCatalogTrialOffer#relative}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "relative", typeJson: "{\"fqn\":\"stripe.productCatalogTrialOffer.ProductCatalogTrialOfferDurationRelative\"}", isOptional: true)]
        public stripe.ProductCatalogTrialOffer.IProductCatalogTrialOfferDurationRelative? Relative
        {
            get;
            set;
        }
    }
}
