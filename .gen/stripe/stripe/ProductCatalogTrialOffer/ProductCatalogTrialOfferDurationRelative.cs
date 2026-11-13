using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.ProductCatalogTrialOffer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.productCatalogTrialOffer.ProductCatalogTrialOfferDurationRelative")]
    public class ProductCatalogTrialOfferDurationRelative : stripe.ProductCatalogTrialOffer.IProductCatalogTrialOfferDurationRelative
    {
        /// <summary>The number of iterations of the price's interval for this trial offer.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/product_catalog_trial_offer#iterations ProductCatalogTrialOffer#iterations}
        /// </remarks>
        [JsiiProperty(name: "iterations", typeJson: "{\"primitive\":\"number\"}")]
        public double Iterations
        {
            get;
            set;
        }
    }
}
