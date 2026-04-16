using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.EdgeServicesBackendStage
{
    [JsiiInterface(nativeType: typeof(IEdgeServicesBackendStageLbBackendConfig), fullyQualifiedName: "scaleway.edgeServicesBackendStage.EdgeServicesBackendStageLbBackendConfig")]
    public interface IEdgeServicesBackendStageLbBackendConfig
    {
        /// <summary>lb_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/edge_services_backend_stage#lb_config EdgeServicesBackendStage#lb_config}
        /// </remarks>
        [JsiiProperty(name: "lbConfig", typeJson: "{\"fqn\":\"scaleway.edgeServicesBackendStage.EdgeServicesBackendStageLbBackendConfigLbConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        scaleway.EdgeServicesBackendStage.IEdgeServicesBackendStageLbBackendConfigLbConfig? LbConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEdgeServicesBackendStageLbBackendConfig), fullyQualifiedName: "scaleway.edgeServicesBackendStage.EdgeServicesBackendStageLbBackendConfig")]
        internal sealed class _Proxy : DeputyBase, scaleway.EdgeServicesBackendStage.IEdgeServicesBackendStageLbBackendConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>lb_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/edge_services_backend_stage#lb_config EdgeServicesBackendStage#lb_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lbConfig", typeJson: "{\"fqn\":\"scaleway.edgeServicesBackendStage.EdgeServicesBackendStageLbBackendConfigLbConfig\"}", isOptional: true)]
            public scaleway.EdgeServicesBackendStage.IEdgeServicesBackendStageLbBackendConfigLbConfig? LbConfig
            {
                get => GetInstanceProperty<scaleway.EdgeServicesBackendStage.IEdgeServicesBackendStageLbBackendConfigLbConfig?>();
            }
        }
    }
}
