using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiInterface(nativeType: typeof(IPaymentIntentPaymentMethodDataAuBecsDebit), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentPaymentMethodDataAuBecsDebit")]
    public interface IPaymentIntentPaymentMethodDataAuBecsDebit
    {
        /// <summary>The account number for the bank account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#account_number PaymentIntent#account_number}
        /// </remarks>
        [JsiiProperty(name: "accountNumber", typeJson: "{\"primitive\":\"string\"}")]
        string AccountNumber
        {
            get;
        }

        /// <summary>Bank-State-Branch number of the bank account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#bsb_number PaymentIntent#bsb_number}
        /// </remarks>
        [JsiiProperty(name: "bsbNumber", typeJson: "{\"primitive\":\"string\"}")]
        string BsbNumber
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentIntentPaymentMethodDataAuBecsDebit), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentPaymentMethodDataAuBecsDebit")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentIntent.IPaymentIntentPaymentMethodDataAuBecsDebit
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The account number for the bank account.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#account_number PaymentIntent#account_number}
            /// </remarks>
            [JsiiProperty(name: "accountNumber", typeJson: "{\"primitive\":\"string\"}")]
            public string AccountNumber
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Bank-State-Branch number of the bank account.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#bsb_number PaymentIntent#bsb_number}
            /// </remarks>
            [JsiiProperty(name: "bsbNumber", typeJson: "{\"primitive\":\"string\"}")]
            public string BsbNumber
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
