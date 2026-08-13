using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentMethodDomain
{
    [JsiiInterface(nativeType: typeof(IPaymentMethodDomainPaypal), fullyQualifiedName: "stripe.paymentMethodDomain.PaymentMethodDomainPaypal")]
    public interface IPaymentMethodDomainPaypal
    {

        [JsiiTypeProxy(nativeType: typeof(IPaymentMethodDomainPaypal), fullyQualifiedName: "stripe.paymentMethodDomain.PaymentMethodDomainPaypal")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentMethodDomain.IPaymentMethodDomainPaypal
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }
        }
    }
}
