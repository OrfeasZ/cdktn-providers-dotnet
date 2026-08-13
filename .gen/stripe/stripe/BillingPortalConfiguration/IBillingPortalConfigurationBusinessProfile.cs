using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.BillingPortalConfiguration
{
    [JsiiInterface(nativeType: typeof(IBillingPortalConfigurationBusinessProfile), fullyQualifiedName: "stripe.billingPortalConfiguration.BillingPortalConfigurationBusinessProfile")]
    public interface IBillingPortalConfigurationBusinessProfile
    {
        /// <summary>The messaging shown to customers in the portal.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_portal_configuration#headline BillingPortalConfiguration#headline}
        /// </remarks>
        [JsiiProperty(name: "headline", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Headline
        {
            get
            {
                return null;
            }
        }

        /// <summary>A link to the business’s publicly available privacy policy.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_portal_configuration#privacy_policy_url BillingPortalConfiguration#privacy_policy_url}
        /// </remarks>
        [JsiiProperty(name: "privacyPolicyUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PrivacyPolicyUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>A link to the business’s publicly available terms of service.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_portal_configuration#terms_of_service_url BillingPortalConfiguration#terms_of_service_url}
        /// </remarks>
        [JsiiProperty(name: "termsOfServiceUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TermsOfServiceUrl
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBillingPortalConfigurationBusinessProfile), fullyQualifiedName: "stripe.billingPortalConfiguration.BillingPortalConfigurationBusinessProfile")]
        internal sealed class _Proxy : DeputyBase, stripe.BillingPortalConfiguration.IBillingPortalConfigurationBusinessProfile
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The messaging shown to customers in the portal.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_portal_configuration#headline BillingPortalConfiguration#headline}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "headline", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Headline
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A link to the business’s publicly available privacy policy.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_portal_configuration#privacy_policy_url BillingPortalConfiguration#privacy_policy_url}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "privacyPolicyUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PrivacyPolicyUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A link to the business’s publicly available terms of service.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_portal_configuration#terms_of_service_url BillingPortalConfiguration#terms_of_service_url}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "termsOfServiceUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TermsOfServiceUrl
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
