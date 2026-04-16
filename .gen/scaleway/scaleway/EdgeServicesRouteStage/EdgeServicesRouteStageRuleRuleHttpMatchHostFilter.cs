using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.EdgeServicesRouteStage
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.edgeServicesRouteStage.EdgeServicesRouteStageRuleRuleHttpMatchHostFilter")]
    public class EdgeServicesRouteStageRuleRuleHttpMatchHostFilter : scaleway.EdgeServicesRouteStage.IEdgeServicesRouteStageRuleRuleHttpMatchHostFilter
    {
        /// <summary>The type of filter to match for the host path.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/edge_services_route_stage#host_filter_type EdgeServicesRouteStage#host_filter_type}
        /// </remarks>
        [JsiiProperty(name: "hostFilterType", typeJson: "{\"primitive\":\"string\"}")]
        public string HostFilterType
        {
            get;
            set;
        }

        /// <summary>The value to be matched for the host path.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/edge_services_route_stage#value EdgeServicesRouteStage#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
