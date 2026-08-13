using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiInterface(nativeType: typeof(IPaymentIntentPaymentMethodDataAcssDebit), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentPaymentMethodDataAcssDebit")]
    public interface IPaymentIntentPaymentMethodDataAcssDebit
    {
        /// <summary>Customer's bank account number.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#account_number PaymentIntent#account_number}
        /// </remarks>
        [JsiiProperty(name: "accountNumber", typeJson: "{\"primitive\":\"string\"}")]
        string AccountNumber
        {
            get;
        }

        /// <summary>Institution number of the customer's bank.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#institution_number PaymentIntent#institution_number}
        /// </remarks>
        [JsiiProperty(name: "institutionNumber", typeJson: "{\"primitive\":\"string\"}")]
        string InstitutionNumber
        {
            get;
        }

        /// <summary>Transit number of the customer's bank.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#transit_number PaymentIntent#transit_number}
        /// </remarks>
        [JsiiProperty(name: "transitNumber", typeJson: "{\"primitive\":\"string\"}")]
        string TransitNumber
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentIntentPaymentMethodDataAcssDebit), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentPaymentMethodDataAcssDebit")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentIntent.IPaymentIntentPaymentMethodDataAcssDebit
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Customer's bank account number.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#account_number PaymentIntent#account_number}
            /// </remarks>
            [JsiiProperty(name: "accountNumber", typeJson: "{\"primitive\":\"string\"}")]
            public string AccountNumber
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Institution number of the customer's bank.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#institution_number PaymentIntent#institution_number}
            /// </remarks>
            [JsiiProperty(name: "institutionNumber", typeJson: "{\"primitive\":\"string\"}")]
            public string InstitutionNumber
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Transit number of the customer's bank.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#transit_number PaymentIntent#transit_number}
            /// </remarks>
            [JsiiProperty(name: "transitNumber", typeJson: "{\"primitive\":\"string\"}")]
            public string TransitNumber
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
