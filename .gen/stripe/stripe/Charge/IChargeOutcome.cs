using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Charge
{
    [JsiiInterface(nativeType: typeof(IChargeOutcome), fullyQualifiedName: "stripe.charge.ChargeOutcome")]
    public interface IChargeOutcome
    {

        [JsiiTypeProxy(nativeType: typeof(IChargeOutcome), fullyQualifiedName: "stripe.charge.ChargeOutcome")]
        internal sealed class _Proxy : DeputyBase, stripe.Charge.IChargeOutcome
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }
        }
    }
}
