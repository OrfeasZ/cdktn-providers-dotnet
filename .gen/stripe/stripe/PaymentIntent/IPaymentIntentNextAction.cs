using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiInterface(nativeType: typeof(IPaymentIntentNextAction), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentNextAction")]
    public interface IPaymentIntentNextAction
    {

        [JsiiTypeProxy(nativeType: typeof(IPaymentIntentNextAction), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentNextAction")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentIntent.IPaymentIntentNextAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }
        }
    }
}
