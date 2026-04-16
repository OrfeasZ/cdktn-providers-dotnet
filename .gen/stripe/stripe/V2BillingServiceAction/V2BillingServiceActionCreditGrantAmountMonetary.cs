using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2BillingServiceAction
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.v2BillingServiceAction.V2BillingServiceActionCreditGrantAmountMonetary")]
    public class V2BillingServiceActionCreditGrantAmountMonetary : stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrantAmountMonetary
    {
        /// <summary>Three-letter [ISO currency code](https://www.iso.org/iso-4217-currency-codes.html), in lowercase. Must be a [supported currency](https://stripe.com/docs/currencies).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_service_action#currency V2BillingServiceAction#currency}
        /// </remarks>
        [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}")]
        public string Currency
        {
            get;
            set;
        }

        /// <summary>A non-negative integer representing how much to charge in the [smallest currency unit](https://docs.stripe.com/currencies#minor-units).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_service_action#value V2BillingServiceAction#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"number\"}")]
        public double Value
        {
            get;
            set;
        }
    }
}
