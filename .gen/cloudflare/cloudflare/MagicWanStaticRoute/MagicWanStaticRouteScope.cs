using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.MagicWanStaticRoute
{
    [JsiiByValue(fqn: "cloudflare.magicWanStaticRoute.MagicWanStaticRouteScope")]
    public class MagicWanStaticRouteScope : cloudflare.MagicWanStaticRoute.IMagicWanStaticRouteScope
    {
        /// <summary>List of colo names for the ECMP scope.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_wan_static_route#colo_names MagicWanStaticRoute#colo_names}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "coloNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ColoNames
        {
            get;
            set;
        }

        /// <summary>List of colo regions for the ECMP scope.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_wan_static_route#colo_regions MagicWanStaticRoute#colo_regions}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "coloRegions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ColoRegions
        {
            get;
            set;
        }
    }
}
