using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Zone
{
    [JsiiInterface(nativeType: typeof(IZoneTenant), fullyQualifiedName: "cloudflare.zone.ZoneTenant")]
    public interface IZoneTenant
    {

        [JsiiTypeProxy(nativeType: typeof(IZoneTenant), fullyQualifiedName: "cloudflare.zone.ZoneTenant")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Zone.IZoneTenant
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }
        }
    }
}
