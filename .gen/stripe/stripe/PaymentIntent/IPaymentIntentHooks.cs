using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiInterface(nativeType: typeof(IPaymentIntentHooks), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentHooks")]
    public interface IPaymentIntentHooks
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#inputs PaymentIntent#inputs}.</summary>
        [JsiiProperty(name: "inputs", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentHooksInputs\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentIntent.IPaymentIntentHooksInputs? Inputs
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentIntentHooks), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentHooks")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentIntent.IPaymentIntentHooks
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#inputs PaymentIntent#inputs}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "inputs", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentHooksInputs\"}", isOptional: true)]
            public stripe.PaymentIntent.IPaymentIntentHooksInputs? Inputs
            {
                get => GetInstanceProperty<stripe.PaymentIntent.IPaymentIntentHooksInputs?>();
            }
        }
    }
}
