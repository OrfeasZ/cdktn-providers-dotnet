using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Customer
{
    [JsiiByValue(fqn: "stripe.customer.CustomerCashBalanceSettings")]
    public class CustomerCashBalanceSettings : stripe.Customer.ICustomerCashBalanceSettings
    {
        /// <summary>The configuration for how funds that land in the customer cash balance are reconciled.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/customer#reconciliation_mode Customer#reconciliation_mode}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "reconciliationMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ReconciliationMode
        {
            get;
            set;
        }
    }
}
