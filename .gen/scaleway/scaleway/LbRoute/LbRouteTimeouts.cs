using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.LbRoute
{
    [JsiiByValue(fqn: "scaleway.lbRoute.LbRouteTimeouts")]
    public class LbRouteTimeouts : scaleway.LbRoute.ILbRouteTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_route#default LbRoute#default}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "default", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Default
        {
            get;
            set;
        }
    }
}
