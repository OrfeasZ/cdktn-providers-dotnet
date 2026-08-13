using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentMethod
{
    [JsiiInterface(nativeType: typeof(IPaymentMethodLink), fullyQualifiedName: "stripe.paymentMethod.PaymentMethodLink")]
    public interface IPaymentMethodLink
    {

        [JsiiTypeProxy(nativeType: typeof(IPaymentMethodLink), fullyQualifiedName: "stripe.paymentMethod.PaymentMethodLink")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentMethod.IPaymentMethodLink
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }
        }
    }
}
