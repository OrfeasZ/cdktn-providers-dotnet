using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.BillingCreditGrant
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.billingCreditGrant.BillingCreditGrantApplicabilityConfig")]
    public class BillingCreditGrantApplicabilityConfig : stripe.BillingCreditGrant.IBillingCreditGrantApplicabilityConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_credit_grant#scope BillingCreditGrant#scope}.</summary>
        [JsiiProperty(name: "scope", typeJson: "{\"fqn\":\"stripe.billingCreditGrant.BillingCreditGrantApplicabilityConfigScope\"}")]
        public stripe.BillingCreditGrant.IBillingCreditGrantApplicabilityConfigScope Scope
        {
            get;
            set;
        }
    }
}
