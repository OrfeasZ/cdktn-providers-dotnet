using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.ProductCatalogTrialOffer
{
    [JsiiInterface(nativeType: typeof(IProductCatalogTrialOfferDuration), fullyQualifiedName: "stripe.productCatalogTrialOffer.ProductCatalogTrialOfferDuration")]
    public interface IProductCatalogTrialOfferDuration
    {
        /// <summary>The type of trial offer duration.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/product_catalog_trial_offer#type ProductCatalogTrialOffer#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/product_catalog_trial_offer#relative ProductCatalogTrialOffer#relative}.</summary>
        [JsiiProperty(name: "relative", typeJson: "{\"fqn\":\"stripe.productCatalogTrialOffer.ProductCatalogTrialOfferDurationRelative\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.ProductCatalogTrialOffer.IProductCatalogTrialOfferDurationRelative? Relative
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IProductCatalogTrialOfferDuration), fullyQualifiedName: "stripe.productCatalogTrialOffer.ProductCatalogTrialOfferDuration")]
        internal sealed class _Proxy : DeputyBase, stripe.ProductCatalogTrialOffer.IProductCatalogTrialOfferDuration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The type of trial offer duration.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/product_catalog_trial_offer#type ProductCatalogTrialOffer#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/product_catalog_trial_offer#relative ProductCatalogTrialOffer#relative}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "relative", typeJson: "{\"fqn\":\"stripe.productCatalogTrialOffer.ProductCatalogTrialOfferDurationRelative\"}", isOptional: true)]
            public stripe.ProductCatalogTrialOffer.IProductCatalogTrialOfferDurationRelative? Relative
            {
                get => GetInstanceProperty<stripe.ProductCatalogTrialOffer.IProductCatalogTrialOfferDurationRelative?>();
            }
        }
    }
}
