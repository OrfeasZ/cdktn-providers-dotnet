using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Zone
{
    [JsiiInterface(nativeType: typeof(IZoneOwner), fullyQualifiedName: "cloudflare.zone.ZoneOwner")]
    public interface IZoneOwner
    {

        [JsiiTypeProxy(nativeType: typeof(IZoneOwner), fullyQualifiedName: "cloudflare.zone.ZoneOwner")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Zone.IZoneOwner
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }
        }
    }
}
