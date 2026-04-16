using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Stream
{
    [JsiiInterface(nativeType: typeof(IStreamStatus), fullyQualifiedName: "cloudflare.stream.StreamStatus")]
    public interface IStreamStatus
    {

        [JsiiTypeProxy(nativeType: typeof(IStreamStatus), fullyQualifiedName: "cloudflare.stream.StreamStatus")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Stream.IStreamStatus
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }
        }
    }
}
