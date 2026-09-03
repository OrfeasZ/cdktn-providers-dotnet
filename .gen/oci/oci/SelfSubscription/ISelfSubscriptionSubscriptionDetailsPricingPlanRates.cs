using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.SelfSubscription
{
    [JsiiInterface(nativeType: typeof(ISelfSubscriptionSubscriptionDetailsPricingPlanRates), fullyQualifiedName: "oci.selfSubscription.SelfSubscriptionSubscriptionDetailsPricingPlanRates")]
    public interface ISelfSubscriptionSubscriptionDetailsPricingPlanRates
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/self_subscription#currency SelfSubscription#currency}.</summary>
        [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}")]
        string Currency
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/self_subscription#rate SelfSubscription#rate}.</summary>
        [JsiiProperty(name: "rate", typeJson: "{\"primitive\":\"number\"}")]
        double Rate
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISelfSubscriptionSubscriptionDetailsPricingPlanRates), fullyQualifiedName: "oci.selfSubscription.SelfSubscriptionSubscriptionDetailsPricingPlanRates")]
        internal sealed class _Proxy : DeputyBase, oci.SelfSubscription.ISelfSubscriptionSubscriptionDetailsPricingPlanRates
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/self_subscription#currency SelfSubscription#currency}.</summary>
            [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}")]
            public string Currency
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/self_subscription#rate SelfSubscription#rate}.</summary>
            [JsiiProperty(name: "rate", typeJson: "{\"primitive\":\"number\"}")]
            public double Rate
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
