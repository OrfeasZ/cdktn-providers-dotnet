using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Charge
{
    [JsiiInterface(nativeType: typeof(IChargePaymentMethodDetails), fullyQualifiedName: "stripe.charge.ChargePaymentMethodDetails")]
    public interface IChargePaymentMethodDetails
    {

        [JsiiTypeProxy(nativeType: typeof(IChargePaymentMethodDetails), fullyQualifiedName: "stripe.charge.ChargePaymentMethodDetails")]
        internal sealed class _Proxy : DeputyBase, stripe.Charge.IChargePaymentMethodDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }
        }
    }
}
