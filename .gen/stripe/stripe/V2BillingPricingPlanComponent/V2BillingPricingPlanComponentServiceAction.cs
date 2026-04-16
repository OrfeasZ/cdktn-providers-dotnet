using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2BillingPricingPlanComponent
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.v2BillingPricingPlanComponent.V2BillingPricingPlanComponentServiceAction")]
    public class V2BillingPricingPlanComponentServiceAction : stripe.V2BillingPricingPlanComponent.IV2BillingPricingPlanComponentServiceAction
    {
        /// <summary>The ID of the service action.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_pricing_plan_component#id V2BillingPricingPlanComponent#id}
        ///
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public string Id
        {
            get;
            set;
        }
    }
}
