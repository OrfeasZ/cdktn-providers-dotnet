using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.EdgeServicesBackendStage
{
    [JsiiInterface(nativeType: typeof(IEdgeServicesBackendStageContainerBackendConfig), fullyQualifiedName: "scaleway.edgeServicesBackendStage.EdgeServicesBackendStageContainerBackendConfig")]
    public interface IEdgeServicesBackendStageContainerBackendConfig
    {
        /// <summary>ID of the Serverless Container.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/edge_services_backend_stage#container_id EdgeServicesBackendStage#container_id}
        /// </remarks>
        [JsiiProperty(name: "containerId", typeJson: "{\"primitive\":\"string\"}")]
        string ContainerId
        {
            get;
        }

        /// <summary>The region you want to attach the resource to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/edge_services_backend_stage#region EdgeServicesBackendStage#region}
        /// </remarks>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Region
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEdgeServicesBackendStageContainerBackendConfig), fullyQualifiedName: "scaleway.edgeServicesBackendStage.EdgeServicesBackendStageContainerBackendConfig")]
        internal sealed class _Proxy : DeputyBase, scaleway.EdgeServicesBackendStage.IEdgeServicesBackendStageContainerBackendConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ID of the Serverless Container.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/edge_services_backend_stage#container_id EdgeServicesBackendStage#container_id}
            /// </remarks>
            [JsiiProperty(name: "containerId", typeJson: "{\"primitive\":\"string\"}")]
            public string ContainerId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The region you want to attach the resource to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/edge_services_backend_stage#region EdgeServicesBackendStage#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
