using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Zone
{
    [JsiiInterface(nativeType: typeof(IZonePlan), fullyQualifiedName: "cloudflare.zone.ZonePlan")]
    public interface IZonePlan
    {

        [JsiiTypeProxy(nativeType: typeof(IZonePlan), fullyQualifiedName: "cloudflare.zone.ZonePlan")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Zone.IZonePlan
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }
        }
    }
}
