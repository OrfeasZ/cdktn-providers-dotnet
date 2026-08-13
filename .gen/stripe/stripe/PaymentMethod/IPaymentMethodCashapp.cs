using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentMethod
{
    [JsiiInterface(nativeType: typeof(IPaymentMethodCashapp), fullyQualifiedName: "stripe.paymentMethod.PaymentMethodCashapp")]
    public interface IPaymentMethodCashapp
    {

        [JsiiTypeProxy(nativeType: typeof(IPaymentMethodCashapp), fullyQualifiedName: "stripe.paymentMethod.PaymentMethodCashapp")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentMethod.IPaymentMethodCashapp
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }
        }
    }
}
