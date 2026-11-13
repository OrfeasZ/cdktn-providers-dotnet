using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentMethod
{
    [JsiiInterface(nativeType: typeof(IPaymentMethodPix), fullyQualifiedName: "stripe.paymentMethod.PaymentMethodPix")]
    public interface IPaymentMethodPix
    {

        [JsiiTypeProxy(nativeType: typeof(IPaymentMethodPix), fullyQualifiedName: "stripe.paymentMethod.PaymentMethodPix")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentMethod.IPaymentMethodPix
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }
        }
    }
}
