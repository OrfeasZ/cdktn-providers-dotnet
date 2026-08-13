using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TaxId
{
    [JsiiInterface(nativeType: typeof(ITaxIdOwner), fullyQualifiedName: "stripe.taxId.TaxIdOwner")]
    public interface ITaxIdOwner
    {

        [JsiiTypeProxy(nativeType: typeof(ITaxIdOwner), fullyQualifiedName: "stripe.taxId.TaxIdOwner")]
        internal sealed class _Proxy : DeputyBase, stripe.TaxId.ITaxIdOwner
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }
        }
    }
}
