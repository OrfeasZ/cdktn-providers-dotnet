using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TaxRate
{
    [JsiiInterface(nativeType: typeof(ITaxRateFlatAmount), fullyQualifiedName: "stripe.taxRate.TaxRateFlatAmount")]
    public interface ITaxRateFlatAmount
    {

        [JsiiTypeProxy(nativeType: typeof(ITaxRateFlatAmount), fullyQualifiedName: "stripe.taxRate.TaxRateFlatAmount")]
        internal sealed class _Proxy : DeputyBase, stripe.TaxRate.ITaxRateFlatAmount
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }
        }
    }
}
