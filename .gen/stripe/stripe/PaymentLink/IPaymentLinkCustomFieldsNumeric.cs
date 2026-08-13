using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentLink
{
    [JsiiInterface(nativeType: typeof(IPaymentLinkCustomFieldsNumeric), fullyQualifiedName: "stripe.paymentLink.PaymentLinkCustomFieldsNumeric")]
    public interface IPaymentLinkCustomFieldsNumeric
    {
        /// <summary>The value that pre-fills the field on the payment page.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#default_value PaymentLink#default_value}
        /// </remarks>
        [JsiiProperty(name: "defaultValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefaultValue
        {
            get
            {
                return null;
            }
        }

        /// <summary>The maximum character length constraint for the customer's input.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#maximum_length PaymentLink#maximum_length}
        /// </remarks>
        [JsiiProperty(name: "maximumLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaximumLength
        {
            get
            {
                return null;
            }
        }

        /// <summary>The minimum character length requirement for the customer's input.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#minimum_length PaymentLink#minimum_length}
        /// </remarks>
        [JsiiProperty(name: "minimumLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinimumLength
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentLinkCustomFieldsNumeric), fullyQualifiedName: "stripe.paymentLink.PaymentLinkCustomFieldsNumeric")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentLink.IPaymentLinkCustomFieldsNumeric
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The value that pre-fills the field on the payment page.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#default_value PaymentLink#default_value}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "defaultValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultValue
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The maximum character length constraint for the customer's input.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#maximum_length PaymentLink#maximum_length}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maximumLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaximumLength
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The minimum character length requirement for the customer's input.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#minimum_length PaymentLink#minimum_length}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "minimumLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinimumLength
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
