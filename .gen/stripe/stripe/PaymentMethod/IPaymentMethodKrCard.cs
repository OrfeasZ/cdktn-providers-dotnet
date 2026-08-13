using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentMethod
{
    [JsiiInterface(nativeType: typeof(IPaymentMethodKrCard), fullyQualifiedName: "stripe.paymentMethod.PaymentMethodKrCard")]
    public interface IPaymentMethodKrCard
    {

        [JsiiTypeProxy(nativeType: typeof(IPaymentMethodKrCard), fullyQualifiedName: "stripe.paymentMethod.PaymentMethodKrCard")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentMethod.IPaymentMethodKrCard
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }
        }
    }
}
