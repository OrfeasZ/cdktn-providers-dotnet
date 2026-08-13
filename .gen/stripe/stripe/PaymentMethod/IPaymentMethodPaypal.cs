using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentMethod
{
    [JsiiInterface(nativeType: typeof(IPaymentMethodPaypal), fullyQualifiedName: "stripe.paymentMethod.PaymentMethodPaypal")]
    public interface IPaymentMethodPaypal
    {

        [JsiiTypeProxy(nativeType: typeof(IPaymentMethodPaypal), fullyQualifiedName: "stripe.paymentMethod.PaymentMethodPaypal")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentMethod.IPaymentMethodPaypal
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }
        }
    }
}
