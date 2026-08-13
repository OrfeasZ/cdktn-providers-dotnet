using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentMethod
{
    [JsiiInterface(nativeType: typeof(IPaymentMethodCardWallet), fullyQualifiedName: "stripe.paymentMethod.PaymentMethodCardWallet")]
    public interface IPaymentMethodCardWallet
    {

        [JsiiTypeProxy(nativeType: typeof(IPaymentMethodCardWallet), fullyQualifiedName: "stripe.paymentMethod.PaymentMethodCardWallet")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentMethod.IPaymentMethodCardWallet
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }
        }
    }
}
