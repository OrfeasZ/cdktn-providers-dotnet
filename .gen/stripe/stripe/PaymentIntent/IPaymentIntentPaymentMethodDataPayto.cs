using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiInterface(nativeType: typeof(IPaymentIntentPaymentMethodDataPayto), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentPaymentMethodDataPayto")]
    public interface IPaymentIntentPaymentMethodDataPayto
    {
        /// <summary>The account number for the bank account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#account_number PaymentIntent#account_number}
        /// </remarks>
        [JsiiProperty(name: "accountNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccountNumber
        {
            get
            {
                return null;
            }
        }

        /// <summary>Bank-State-Branch number of the bank account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#bsb_number PaymentIntent#bsb_number}
        /// </remarks>
        [JsiiProperty(name: "bsbNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BsbNumber
        {
            get
            {
                return null;
            }
        }

        /// <summary>The PayID alias for the bank account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#pay_id PaymentIntent#pay_id}
        /// </remarks>
        [JsiiProperty(name: "payId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PayId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentIntentPaymentMethodDataPayto), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentPaymentMethodDataPayto")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentIntent.IPaymentIntentPaymentMethodDataPayto
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The account number for the bank account.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#account_number PaymentIntent#account_number}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accountNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccountNumber
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Bank-State-Branch number of the bank account.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#bsb_number PaymentIntent#bsb_number}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bsbNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BsbNumber
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The PayID alias for the bank account.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#pay_id PaymentIntent#pay_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "payId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PayId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
