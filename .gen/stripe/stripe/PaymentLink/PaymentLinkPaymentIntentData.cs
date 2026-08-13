using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentLink
{
    [JsiiByValue(fqn: "stripe.paymentLink.PaymentLinkPaymentIntentData")]
    public class PaymentLinkPaymentIntentData : stripe.PaymentLink.IPaymentLinkPaymentIntentData
    {
        /// <summary>Indicates when the funds will be captured from the customer's account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#capture_method PaymentLink#capture_method}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "captureMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CaptureMethod
        {
            get;
            set;
        }

        /// <summary>An arbitrary string attached to the object. Often useful for displaying to users.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#description PaymentLink#description}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Set of [key-value pairs](https://docs.stripe.com/api/metadata) that will set metadata on [Payment Intents](https://docs.stripe.com/api/payment_intents) generated from this payment link.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#metadata PaymentLink#metadata}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Metadata
        {
            get;
            set;
        }

        /// <summary>Indicates that you intend to make future payments with the payment method collected during checkout.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#setup_future_usage PaymentLink#setup_future_usage}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "setupFutureUsage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SetupFutureUsage
        {
            get;
            set;
        }

        /// <summary>For a non-card payment, information about the charge that appears on the customer's statement when this payment succeeds in creating a charge.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#statement_descriptor PaymentLink#statement_descriptor}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "statementDescriptor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StatementDescriptor
        {
            get;
            set;
        }

        /// <summary>For a card payment, information about the charge that appears on the customer's statement when this payment succeeds in creating a charge.</summary>
        /// <remarks>
        /// Concatenated with the account's statement descriptor prefix to form the complete statement descriptor.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#statement_descriptor_suffix PaymentLink#statement_descriptor_suffix}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "statementDescriptorSuffix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StatementDescriptorSuffix
        {
            get;
            set;
        }

        /// <summary>A string that identifies the resulting payment as part of a group.</summary>
        /// <remarks>
        /// See the PaymentIntents <a href="https://docs.stripe.com/connect/separate-charges-and-transfers">use case for connected accounts</a> for details.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#transfer_group PaymentLink#transfer_group}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "transferGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TransferGroup
        {
            get;
            set;
        }
    }
}
