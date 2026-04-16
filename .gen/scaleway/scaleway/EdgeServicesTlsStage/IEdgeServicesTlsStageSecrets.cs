using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.EdgeServicesTlsStage
{
    [JsiiInterface(nativeType: typeof(IEdgeServicesTlsStageSecrets), fullyQualifiedName: "scaleway.edgeServicesTlsStage.EdgeServicesTlsStageSecrets")]
    public interface IEdgeServicesTlsStageSecrets
    {
        /// <summary>The region you want to attach the resource to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/edge_services_tls_stage#region EdgeServicesTlsStage#region}
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

        /// <summary>The ID of the Secret.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/edge_services_tls_stage#secret_id EdgeServicesTlsStage#secret_id}
        /// </remarks>
        [JsiiProperty(name: "secretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SecretId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEdgeServicesTlsStageSecrets), fullyQualifiedName: "scaleway.edgeServicesTlsStage.EdgeServicesTlsStageSecrets")]
        internal sealed class _Proxy : DeputyBase, scaleway.EdgeServicesTlsStage.IEdgeServicesTlsStageSecrets
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The region you want to attach the resource to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/edge_services_tls_stage#region EdgeServicesTlsStage#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The ID of the Secret.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/edge_services_tls_stage#secret_id EdgeServicesTlsStage#secret_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "secretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SecretId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
