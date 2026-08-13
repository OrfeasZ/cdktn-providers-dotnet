using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentMethod
{
    [JsiiInterface(nativeType: typeof(IPaymentMethodAuBecsDebit), fullyQualifiedName: "stripe.paymentMethod.PaymentMethodAuBecsDebit")]
    public interface IPaymentMethodAuBecsDebit
    {
        /// <summary>The account number for the bank account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#account_number PaymentMethod#account_number}
        /// </remarks>
        [JsiiProperty(name: "accountNumber", typeJson: "{\"primitive\":\"string\"}")]
        string AccountNumber
        {
            get;
        }

        /// <summary>Six-digit number identifying bank and branch associated with this bank account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#bsb_number PaymentMethod#bsb_number}
        /// </remarks>
        [JsiiProperty(name: "bsbNumber", typeJson: "{\"primitive\":\"string\"}")]
        string BsbNumber
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentMethodAuBecsDebit), fullyQualifiedName: "stripe.paymentMethod.PaymentMethodAuBecsDebit")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentMethod.IPaymentMethodAuBecsDebit
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The account number for the bank account.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#account_number PaymentMethod#account_number}
            /// </remarks>
            [JsiiProperty(name: "accountNumber", typeJson: "{\"primitive\":\"string\"}")]
            public string AccountNumber
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Six-digit number identifying bank and branch associated with this bank account.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#bsb_number PaymentMethod#bsb_number}
            /// </remarks>
            [JsiiProperty(name: "bsbNumber", typeJson: "{\"primitive\":\"string\"}")]
            public string BsbNumber
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
