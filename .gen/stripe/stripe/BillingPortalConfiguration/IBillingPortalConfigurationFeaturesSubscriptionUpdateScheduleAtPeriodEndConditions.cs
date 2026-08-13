using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.BillingPortalConfiguration
{
    [JsiiInterface(nativeType: typeof(IBillingPortalConfigurationFeaturesSubscriptionUpdateScheduleAtPeriodEndConditions), fullyQualifiedName: "stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionUpdateScheduleAtPeriodEndConditions")]
    public interface IBillingPortalConfigurationFeaturesSubscriptionUpdateScheduleAtPeriodEndConditions
    {
        /// <summary>The type of condition.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_portal_configuration#type BillingPortalConfiguration#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBillingPortalConfigurationFeaturesSubscriptionUpdateScheduleAtPeriodEndConditions), fullyQualifiedName: "stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionUpdateScheduleAtPeriodEndConditions")]
        internal sealed class _Proxy : DeputyBase, stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesSubscriptionUpdateScheduleAtPeriodEndConditions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The type of condition.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_portal_configuration#type BillingPortalConfiguration#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
