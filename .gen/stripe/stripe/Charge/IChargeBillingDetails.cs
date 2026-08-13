using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Charge
{
    [JsiiInterface(nativeType: typeof(IChargeBillingDetails), fullyQualifiedName: "stripe.charge.ChargeBillingDetails")]
    public interface IChargeBillingDetails
    {

        [JsiiTypeProxy(nativeType: typeof(IChargeBillingDetails), fullyQualifiedName: "stripe.charge.ChargeBillingDetails")]
        internal sealed class _Proxy : DeputyBase, stripe.Charge.IChargeBillingDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }
        }
    }
}
