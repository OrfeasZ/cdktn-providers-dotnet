using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.BillingPortalConfiguration
{
    [JsiiByValue(fqn: "stripe.billingPortalConfiguration.BillingPortalConfigurationBusinessProfile")]
    public class BillingPortalConfigurationBusinessProfile : stripe.BillingPortalConfiguration.IBillingPortalConfigurationBusinessProfile
    {
        /// <summary>The messaging shown to customers in the portal.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_portal_configuration#headline BillingPortalConfiguration#headline}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "headline", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Headline
        {
            get;
            set;
        }

        /// <summary>A link to the business’s publicly available privacy policy.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_portal_configuration#privacy_policy_url BillingPortalConfiguration#privacy_policy_url}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "privacyPolicyUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrivacyPolicyUrl
        {
            get;
            set;
        }

        /// <summary>A link to the business’s publicly available terms of service.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_portal_configuration#terms_of_service_url BillingPortalConfiguration#terms_of_service_url}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "termsOfServiceUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TermsOfServiceUrl
        {
            get;
            set;
        }
    }
}
