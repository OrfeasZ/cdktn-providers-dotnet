using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.BillingPortalConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionUpdateProducts")]
    public class BillingPortalConfigurationFeaturesSubscriptionUpdateProducts : stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesSubscriptionUpdateProducts
    {
        /// <summary>The list of price IDs which, when subscribed to, a subscription can be updated.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_portal_configuration#prices BillingPortalConfiguration#prices}
        /// </remarks>
        [JsiiProperty(name: "prices", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Prices
        {
            get;
            set;
        }

        /// <summary>The product ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_portal_configuration#product BillingPortalConfiguration#product}
        /// </remarks>
        [JsiiProperty(name: "product", typeJson: "{\"primitive\":\"string\"}")]
        public string Product
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_portal_configuration#adjustable_quantity BillingPortalConfiguration#adjustable_quantity}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "adjustableQuantity", typeJson: "{\"fqn\":\"stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionUpdateProductsAdjustableQuantity\"}", isOptional: true)]
        public stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesSubscriptionUpdateProductsAdjustableQuantity? AdjustableQuantity
        {
            get;
            set;
        }
    }
}
