using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentMethod
{
    [JsiiInterface(nativeType: typeof(IPaymentMethodBizum), fullyQualifiedName: "stripe.paymentMethod.PaymentMethodBizum")]
    public interface IPaymentMethodBizum
    {

        [JsiiTypeProxy(nativeType: typeof(IPaymentMethodBizum), fullyQualifiedName: "stripe.paymentMethod.PaymentMethodBizum")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentMethod.IPaymentMethodBizum
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }
        }
    }
}
