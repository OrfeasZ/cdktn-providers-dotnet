using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.EdgeServicesTlsStage
{
    [JsiiByValue(fqn: "scaleway.edgeServicesTlsStage.EdgeServicesTlsStageSecrets")]
    public class EdgeServicesTlsStageSecrets : scaleway.EdgeServicesTlsStage.IEdgeServicesTlsStageSecrets
    {
        /// <summary>The region you want to attach the resource to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/edge_services_tls_stage#region EdgeServicesTlsStage#region}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Region
        {
            get;
            set;
        }

        /// <summary>The ID of the Secret.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/edge_services_tls_stage#secret_id EdgeServicesTlsStage#secret_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecretId
        {
            get;
            set;
        }
    }
}
