using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TaxId
{
    [JsiiInterface(nativeType: typeof(ITaxIdVerification), fullyQualifiedName: "stripe.taxId.TaxIdVerification")]
    public interface ITaxIdVerification
    {

        [JsiiTypeProxy(nativeType: typeof(ITaxIdVerification), fullyQualifiedName: "stripe.taxId.TaxIdVerification")]
        internal sealed class _Proxy : DeputyBase, stripe.TaxId.ITaxIdVerification
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }
        }
    }
}
