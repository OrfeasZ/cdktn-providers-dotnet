using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.MagicWanStaticRoute
{
    [JsiiInterface(nativeType: typeof(IMagicWanStaticRouteScope), fullyQualifiedName: "cloudflare.magicWanStaticRoute.MagicWanStaticRouteScope")]
    public interface IMagicWanStaticRouteScope
    {
        /// <summary>List of colo names for the ECMP scope.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_wan_static_route#colo_names MagicWanStaticRoute#colo_names}
        /// </remarks>
        [JsiiProperty(name: "coloNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ColoNames
        {
            get
            {
                return null;
            }
        }

        /// <summary>List of colo regions for the ECMP scope.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_wan_static_route#colo_regions MagicWanStaticRoute#colo_regions}
        /// </remarks>
        [JsiiProperty(name: "coloRegions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ColoRegions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMagicWanStaticRouteScope), fullyQualifiedName: "cloudflare.magicWanStaticRoute.MagicWanStaticRouteScope")]
        internal sealed class _Proxy : DeputyBase, cloudflare.MagicWanStaticRoute.IMagicWanStaticRouteScope
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>List of colo names for the ECMP scope.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_wan_static_route#colo_names MagicWanStaticRoute#colo_names}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "coloNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ColoNames
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>List of colo regions for the ECMP scope.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_wan_static_route#colo_regions MagicWanStaticRoute#colo_regions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "coloRegions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ColoRegions
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
