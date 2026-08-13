using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiInterface(nativeType: typeof(IPaymentIntentProcessing), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentProcessing")]
    public interface IPaymentIntentProcessing
    {

        [JsiiTypeProxy(nativeType: typeof(IPaymentIntentProcessing), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentProcessing")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentIntent.IPaymentIntentProcessing
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }
        }
    }
}
