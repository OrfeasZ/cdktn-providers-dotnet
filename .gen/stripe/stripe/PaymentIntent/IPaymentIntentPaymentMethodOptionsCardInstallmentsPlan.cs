using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiInterface(nativeType: typeof(IPaymentIntentPaymentMethodOptionsCardInstallmentsPlan), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentPaymentMethodOptionsCardInstallmentsPlan")]
    public interface IPaymentIntentPaymentMethodOptionsCardInstallmentsPlan
    {
        /// <summary>Type of installment plan, one of `fixed_count`, `bonus`, or `revolving`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#type PaymentIntent#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>For `fixed_count` installment plans, this is the number of installment payments your customer will make to their credit card.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#count PaymentIntent#count}
        /// </remarks>
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Count
        {
            get
            {
                return null;
            }
        }

        /// <summary>For `fixed_count` installment plans, this is the interval between installment payments your customer will make to their credit card.</summary>
        /// <remarks>
        /// One of <c>month</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#interval PaymentIntent#interval}
        /// </remarks>
        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Interval
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentIntentPaymentMethodOptionsCardInstallmentsPlan), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentPaymentMethodOptionsCardInstallmentsPlan")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsCardInstallmentsPlan
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Type of installment plan, one of `fixed_count`, `bonus`, or `revolving`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#type PaymentIntent#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>For `fixed_count` installment plans, this is the number of installment payments your customer will make to their credit card.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#count PaymentIntent#count}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>For `fixed_count` installment plans, this is the interval between installment payments your customer will make to their credit card.</summary>
            /// <remarks>
            /// One of <c>month</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#interval PaymentIntent#interval}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Interval
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
