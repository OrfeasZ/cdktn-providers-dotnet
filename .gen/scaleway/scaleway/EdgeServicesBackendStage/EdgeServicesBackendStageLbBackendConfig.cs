using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.EdgeServicesBackendStage
{
    [JsiiByValue(fqn: "scaleway.edgeServicesBackendStage.EdgeServicesBackendStageLbBackendConfig")]
    public class EdgeServicesBackendStageLbBackendConfig : scaleway.EdgeServicesBackendStage.IEdgeServicesBackendStageLbBackendConfig
    {
        /// <summary>lb_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/edge_services_backend_stage#lb_config EdgeServicesBackendStage#lb_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lbConfig", typeJson: "{\"fqn\":\"scaleway.edgeServicesBackendStage.EdgeServicesBackendStageLbBackendConfigLbConfig\"}", isOptional: true)]
        public scaleway.EdgeServicesBackendStage.IEdgeServicesBackendStageLbBackendConfigLbConfig? LbConfig
        {
            get;
            set;
        }
    }
}
