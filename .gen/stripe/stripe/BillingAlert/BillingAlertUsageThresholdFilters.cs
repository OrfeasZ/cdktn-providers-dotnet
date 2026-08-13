using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.BillingAlert
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.billingAlert.BillingAlertUsageThresholdFilters")]
    public class BillingAlertUsageThresholdFilters : stripe.BillingAlert.IBillingAlertUsageThresholdFilters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_alert#type BillingAlert#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Limit the scope of the alert to this customer ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_alert#customer BillingAlert#customer}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Customer
        {
            get;
            set;
        }
    }
}
