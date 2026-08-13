using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiInterface(nativeType: typeof(IPaymentIntentProcessingCard), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentProcessingCard")]
    public interface IPaymentIntentProcessingCard
    {

        [JsiiTypeProxy(nativeType: typeof(IPaymentIntentProcessingCard), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentProcessingCard")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentIntent.IPaymentIntentProcessingCard
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }
        }
    }
}
