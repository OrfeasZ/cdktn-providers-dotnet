using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentMethod
{
    [JsiiInterface(nativeType: typeof(IPaymentMethodBlik), fullyQualifiedName: "stripe.paymentMethod.PaymentMethodBlik")]
    public interface IPaymentMethodBlik
    {

        [JsiiTypeProxy(nativeType: typeof(IPaymentMethodBlik), fullyQualifiedName: "stripe.paymentMethod.PaymentMethodBlik")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentMethod.IPaymentMethodBlik
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }
        }
    }
}
