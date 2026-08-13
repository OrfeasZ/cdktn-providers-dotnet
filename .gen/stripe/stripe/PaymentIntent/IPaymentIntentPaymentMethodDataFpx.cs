using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiInterface(nativeType: typeof(IPaymentIntentPaymentMethodDataFpx), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentPaymentMethodDataFpx")]
    public interface IPaymentIntentPaymentMethodDataFpx
    {
        /// <summary>The customer's bank.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#bank PaymentIntent#bank}
        /// </remarks>
        [JsiiProperty(name: "bank", typeJson: "{\"primitive\":\"string\"}")]
        string Bank
        {
            get;
        }

        /// <summary>Account holder type for FPX transaction.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#account_holder_type PaymentIntent#account_holder_type}
        /// </remarks>
        [JsiiProperty(name: "accountHolderType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccountHolderType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentIntentPaymentMethodDataFpx), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentPaymentMethodDataFpx")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentIntent.IPaymentIntentPaymentMethodDataFpx
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The customer's bank.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#bank PaymentIntent#bank}
            /// </remarks>
            [JsiiProperty(name: "bank", typeJson: "{\"primitive\":\"string\"}")]
            public string Bank
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Account holder type for FPX transaction.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#account_holder_type PaymentIntent#account_holder_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accountHolderType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccountHolderType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
