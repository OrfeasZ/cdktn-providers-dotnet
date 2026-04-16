using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Stream
{
    [JsiiInterface(nativeType: typeof(IStreamPlayback), fullyQualifiedName: "cloudflare.stream.StreamPlayback")]
    public interface IStreamPlayback
    {

        [JsiiTypeProxy(nativeType: typeof(IStreamPlayback), fullyQualifiedName: "cloudflare.stream.StreamPlayback")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Stream.IStreamPlayback
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }
        }
    }
}
