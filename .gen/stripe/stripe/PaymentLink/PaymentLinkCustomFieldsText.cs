using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentLink
{
    [JsiiByValue(fqn: "stripe.paymentLink.PaymentLinkCustomFieldsText")]
    public class PaymentLinkCustomFieldsText : stripe.PaymentLink.IPaymentLinkCustomFieldsText
    {
        /// <summary>The value that pre-fills the field on the payment page.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#default_value PaymentLink#default_value}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "defaultValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DefaultValue
        {
            get;
            set;
        }

        /// <summary>The maximum character length constraint for the customer's input.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#maximum_length PaymentLink#maximum_length}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maximumLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaximumLength
        {
            get;
            set;
        }

        /// <summary>The minimum character length requirement for the customer's input.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#minimum_length PaymentLink#minimum_length}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "minimumLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinimumLength
        {
            get;
            set;
        }
    }
}
