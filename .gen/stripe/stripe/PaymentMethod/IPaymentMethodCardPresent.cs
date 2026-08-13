using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentMethod
{
    [JsiiInterface(nativeType: typeof(IPaymentMethodCardPresent), fullyQualifiedName: "stripe.paymentMethod.PaymentMethodCardPresent")]
    public interface IPaymentMethodCardPresent
    {

        [JsiiTypeProxy(nativeType: typeof(IPaymentMethodCardPresent), fullyQualifiedName: "stripe.paymentMethod.PaymentMethodCardPresent")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentMethod.IPaymentMethodCardPresent
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }
        }
    }
}
