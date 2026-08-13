using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiInterface(nativeType: typeof(IPaymentIntentPaymentMethodOptionsUsBankAccountMandateOptions), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentPaymentMethodOptionsUsBankAccountMandateOptions")]
    public interface IPaymentIntentPaymentMethodOptionsUsBankAccountMandateOptions
    {
        /// <summary>Mandate collection method.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#collection_method PaymentIntent#collection_method}
        /// </remarks>
        [JsiiProperty(name: "collectionMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CollectionMethod
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentIntentPaymentMethodOptionsUsBankAccountMandateOptions), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentPaymentMethodOptionsUsBankAccountMandateOptions")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsUsBankAccountMandateOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Mandate collection method.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#collection_method PaymentIntent#collection_method}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "collectionMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CollectionMethod
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
