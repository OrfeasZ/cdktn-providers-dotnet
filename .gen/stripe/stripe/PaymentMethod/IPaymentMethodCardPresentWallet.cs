using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentMethod
{
    [JsiiInterface(nativeType: typeof(IPaymentMethodCardPresentWallet), fullyQualifiedName: "stripe.paymentMethod.PaymentMethodCardPresentWallet")]
    public interface IPaymentMethodCardPresentWallet
    {

        [JsiiTypeProxy(nativeType: typeof(IPaymentMethodCardPresentWallet), fullyQualifiedName: "stripe.paymentMethod.PaymentMethodCardPresentWallet")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentMethod.IPaymentMethodCardPresentWallet
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }
        }
    }
}
