using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiInterface(nativeType: typeof(IPaymentIntentPaymentMethodOptionsCardThreeDSecureNetworkOptions), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentPaymentMethodOptionsCardThreeDSecureNetworkOptions")]
    public interface IPaymentIntentPaymentMethodOptionsCardThreeDSecureNetworkOptions
    {
        /// <summary>Cartes Bancaires-specific 3DS fields.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#cartes_bancaires PaymentIntent#cartes_bancaires}
        /// </remarks>
        [JsiiProperty(name: "cartesBancaires", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsCardThreeDSecureNetworkOptionsCartesBancaires\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsCardThreeDSecureNetworkOptionsCartesBancaires? CartesBancaires
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentIntentPaymentMethodOptionsCardThreeDSecureNetworkOptions), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentPaymentMethodOptionsCardThreeDSecureNetworkOptions")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsCardThreeDSecureNetworkOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Cartes Bancaires-specific 3DS fields.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#cartes_bancaires PaymentIntent#cartes_bancaires}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cartesBancaires", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsCardThreeDSecureNetworkOptionsCartesBancaires\"}", isOptional: true)]
            public stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsCardThreeDSecureNetworkOptionsCartesBancaires? CartesBancaires
            {
                get => GetInstanceProperty<stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsCardThreeDSecureNetworkOptionsCartesBancaires?>();
            }
        }
    }
}
