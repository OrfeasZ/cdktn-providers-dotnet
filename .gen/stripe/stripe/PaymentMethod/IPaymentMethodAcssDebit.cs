using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentMethod
{
    [JsiiInterface(nativeType: typeof(IPaymentMethodAcssDebit), fullyQualifiedName: "stripe.paymentMethod.PaymentMethodAcssDebit")]
    public interface IPaymentMethodAcssDebit
    {
        /// <summary>Customer's bank account number.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#account_number PaymentMethod#account_number}
        /// </remarks>
        [JsiiProperty(name: "accountNumber", typeJson: "{\"primitive\":\"string\"}")]
        string AccountNumber
        {
            get;
        }

        /// <summary>Institution number of the bank account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#institution_number PaymentMethod#institution_number}
        /// </remarks>
        [JsiiProperty(name: "institutionNumber", typeJson: "{\"primitive\":\"string\"}")]
        string InstitutionNumber
        {
            get;
        }

        /// <summary>Transit number of the bank account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#transit_number PaymentMethod#transit_number}
        /// </remarks>
        [JsiiProperty(name: "transitNumber", typeJson: "{\"primitive\":\"string\"}")]
        string TransitNumber
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentMethodAcssDebit), fullyQualifiedName: "stripe.paymentMethod.PaymentMethodAcssDebit")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentMethod.IPaymentMethodAcssDebit
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Customer's bank account number.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#account_number PaymentMethod#account_number}
            /// </remarks>
            [JsiiProperty(name: "accountNumber", typeJson: "{\"primitive\":\"string\"}")]
            public string AccountNumber
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Institution number of the bank account.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#institution_number PaymentMethod#institution_number}
            /// </remarks>
            [JsiiProperty(name: "institutionNumber", typeJson: "{\"primitive\":\"string\"}")]
            public string InstitutionNumber
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Transit number of the bank account.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#transit_number PaymentMethod#transit_number}
            /// </remarks>
            [JsiiProperty(name: "transitNumber", typeJson: "{\"primitive\":\"string\"}")]
            public string TransitNumber
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
