using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.EdgeServicesBackendStage
{
    [JsiiInterface(nativeType: typeof(IEdgeServicesBackendStageFunctionBackendConfig), fullyQualifiedName: "scaleway.edgeServicesBackendStage.EdgeServicesBackendStageFunctionBackendConfig")]
    public interface IEdgeServicesBackendStageFunctionBackendConfig
    {
        /// <summary>ID of the Serverless Function.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/edge_services_backend_stage#function_id EdgeServicesBackendStage#function_id}
        /// </remarks>
        [JsiiProperty(name: "functionId", typeJson: "{\"primitive\":\"string\"}")]
        string FunctionId
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

        [JsiiTypeProxy(nativeType: typeof(IEdgeServicesBackendStageFunctionBackendConfig), fullyQualifiedName: "scaleway.edgeServicesBackendStage.EdgeServicesBackendStageFunctionBackendConfig")]
        internal sealed class _Proxy : DeputyBase, scaleway.EdgeServicesBackendStage.IEdgeServicesBackendStageFunctionBackendConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ID of the Serverless Function.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/edge_services_backend_stage#function_id EdgeServicesBackendStage#function_id}
            /// </remarks>
            [JsiiProperty(name: "functionId", typeJson: "{\"primitive\":\"string\"}")]
            public string FunctionId
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
