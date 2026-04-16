using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2BillingServiceAction
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.v2BillingServiceAction.V2BillingServiceActionCreditGrant")]
    public class V2BillingServiceActionCreditGrant : stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrant
    {
        /// <summary>amount block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_service_action#amount V2BillingServiceAction#amount}
        /// </remarks>
        [JsiiProperty(name: "amount", typeJson: "{\"fqn\":\"stripe.v2BillingServiceAction.V2BillingServiceActionCreditGrantAmount\"}")]
        public stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrantAmount Amount
        {
            get;
            set;
        }

        /// <summary>applicability_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_service_action#applicability_config V2BillingServiceAction#applicability_config}
        /// </remarks>
        [JsiiProperty(name: "applicabilityConfig", typeJson: "{\"fqn\":\"stripe.v2BillingServiceAction.V2BillingServiceActionCreditGrantApplicabilityConfig\"}")]
        public stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrantApplicabilityConfig ApplicabilityConfig
        {
            get;
            set;
        }

        /// <summary>expiry_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_service_action#expiry_config V2BillingServiceAction#expiry_config}
        /// </remarks>
        [JsiiProperty(name: "expiryConfig", typeJson: "{\"fqn\":\"stripe.v2BillingServiceAction.V2BillingServiceActionCreditGrantExpiryConfig\"}")]
        public stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrantExpiryConfig ExpiryConfig
        {
            get;
            set;
        }

        /// <summary>A descriptive name shown in dashboard.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_service_action#name V2BillingServiceAction#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>The category of the credit grant.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_service_action#category V2BillingServiceAction#category}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "category", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Category
        {
            get;
            set;
        }

        /// <summary>The desired priority for applying this credit grant.</summary>
        /// <remarks>
        /// If not specified, it will be set to the default value of 50. The highest priority is 0 and the lowest is 100.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_service_action#priority V2BillingServiceAction#priority}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Priority
        {
            get;
            set;
        }
    }
}
