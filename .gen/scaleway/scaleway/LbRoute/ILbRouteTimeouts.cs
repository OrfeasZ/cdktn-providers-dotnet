using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.LbRoute
{
    [JsiiInterface(nativeType: typeof(ILbRouteTimeouts), fullyQualifiedName: "scaleway.lbRoute.LbRouteTimeouts")]
    public interface ILbRouteTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_route#default LbRoute#default}.</summary>
        [JsiiProperty(name: "default", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Default
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILbRouteTimeouts), fullyQualifiedName: "scaleway.lbRoute.LbRouteTimeouts")]
        internal sealed class _Proxy : DeputyBase, scaleway.LbRoute.ILbRouteTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_route#default LbRoute#default}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "default", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Default
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
