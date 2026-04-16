using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Stream
{
    [JsiiInterface(nativeType: typeof(IStreamWatermark), fullyQualifiedName: "cloudflare.stream.StreamWatermark")]
    public interface IStreamWatermark
    {

        [JsiiTypeProxy(nativeType: typeof(IStreamWatermark), fullyQualifiedName: "cloudflare.stream.StreamWatermark")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Stream.IStreamWatermark
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }
        }
    }
}
