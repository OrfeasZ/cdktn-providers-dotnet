using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiInterface(nativeType: typeof(IPaymentIntentManagedPayments), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentManagedPayments")]
    public interface IPaymentIntentManagedPayments
    {

        [JsiiTypeProxy(nativeType: typeof(IPaymentIntentManagedPayments), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentManagedPayments")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentIntent.IPaymentIntentManagedPayments
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }
        }
    }
}
