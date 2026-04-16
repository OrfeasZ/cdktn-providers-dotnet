using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Customer
{
    [JsiiByValue(fqn: "stripe.customer.CustomerCashBalance")]
    public class CustomerCashBalance : stripe.Customer.ICustomerCashBalance
    {
        /// <summary>settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#settings Customer#settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "settings", typeJson: "{\"fqn\":\"stripe.customer.CustomerCashBalanceSettings\"}", isOptional: true)]
        public stripe.Customer.ICustomerCashBalanceSettings? Settings
        {
            get;
            set;
        }
    }
}
