using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Source
{
    [JsiiInterface(nativeType: typeof(ISourceSepaDebit), fullyQualifiedName: "stripe.source.SourceSepaDebit")]
    public interface ISourceSepaDebit
    {

        [JsiiTypeProxy(nativeType: typeof(ISourceSepaDebit), fullyQualifiedName: "stripe.source.SourceSepaDebit")]
        internal sealed class _Proxy : DeputyBase, stripe.Source.ISourceSepaDebit
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }
        }
    }
}
