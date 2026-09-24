using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.SelfSubscription
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.selfSubscription.SelfSubscriptionSubscriptionDetailsPricingPlanDimensionsRates")]
    public class SelfSubscriptionSubscriptionDetailsPricingPlanDimensionsRates : oci.SelfSubscription.ISelfSubscriptionSubscriptionDetailsPricingPlanDimensionsRates
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/self_subscription#currency SelfSubscription#currency}.</summary>
        [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}")]
        public string Currency
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/self_subscription#rate SelfSubscription#rate}.</summary>
        [JsiiProperty(name: "rate", typeJson: "{\"primitive\":\"number\"}")]
        public double Rate
        {
            get;
            set;
        }
    }
}
