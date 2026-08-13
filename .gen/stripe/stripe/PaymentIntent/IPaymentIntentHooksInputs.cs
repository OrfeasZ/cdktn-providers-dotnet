using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiInterface(nativeType: typeof(IPaymentIntentHooksInputs), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentHooksInputs")]
    public interface IPaymentIntentHooksInputs
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#tax PaymentIntent#tax}.</summary>
        [JsiiProperty(name: "tax", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentHooksInputsTax\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentIntent.IPaymentIntentHooksInputsTax? Tax
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentIntentHooksInputs), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentHooksInputs")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentIntent.IPaymentIntentHooksInputs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#tax PaymentIntent#tax}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tax", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentHooksInputsTax\"}", isOptional: true)]
            public stripe.PaymentIntent.IPaymentIntentHooksInputsTax? Tax
            {
                get => GetInstanceProperty<stripe.PaymentIntent.IPaymentIntentHooksInputsTax?>();
            }
        }
    }
}
