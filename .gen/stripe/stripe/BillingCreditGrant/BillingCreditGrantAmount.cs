using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.BillingCreditGrant
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.billingCreditGrant.BillingCreditGrantAmount")]
    public class BillingCreditGrantAmount : stripe.BillingCreditGrant.IBillingCreditGrantAmount
    {
        /// <summary>The type of this amount. We currently only support `monetary` billing credits.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_credit_grant#type BillingCreditGrant#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>The monetary amount.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_credit_grant#monetary BillingCreditGrant#monetary}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "monetary", typeJson: "{\"fqn\":\"stripe.billingCreditGrant.BillingCreditGrantAmountMonetary\"}", isOptional: true)]
        public stripe.BillingCreditGrant.IBillingCreditGrantAmountMonetary? Monetary
        {
            get;
            set;
        }
    }
}
