using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2BillingServiceAction
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.v2BillingServiceAction.V2BillingServiceActionCreditGrantApplicabilityConfig")]
    public class V2BillingServiceActionCreditGrantApplicabilityConfig : stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrantApplicabilityConfig
    {
        /// <summary>scope block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_service_action#scope V2BillingServiceAction#scope}
        /// </remarks>
        [JsiiProperty(name: "scope", typeJson: "{\"fqn\":\"stripe.v2BillingServiceAction.V2BillingServiceActionCreditGrantApplicabilityConfigScope\"}")]
        public stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrantApplicabilityConfigScope Scope
        {
            get;
            set;
        }
    }
}
