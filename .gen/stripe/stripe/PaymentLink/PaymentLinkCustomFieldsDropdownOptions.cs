using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentLink
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.paymentLink.PaymentLinkCustomFieldsDropdownOptions")]
    public class PaymentLinkCustomFieldsDropdownOptions : stripe.PaymentLink.IPaymentLinkCustomFieldsDropdownOptions
    {
        /// <summary>The label for the option, displayed to the customer. Up to 100 characters.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#label PaymentLink#label}
        /// </remarks>
        [JsiiProperty(name: "label", typeJson: "{\"primitive\":\"string\"}")]
        public string Label
        {
            get;
            set;
        }

        /// <summary>The value for this option, not displayed to the customer, used by your integration to reconcile the option selected by the customer.</summary>
        /// <remarks>
        /// Must be unique to this option, alphanumeric, and up to 100 characters.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#value PaymentLink#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
