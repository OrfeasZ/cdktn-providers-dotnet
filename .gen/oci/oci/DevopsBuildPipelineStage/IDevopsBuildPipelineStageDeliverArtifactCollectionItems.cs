using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsBuildPipelineStage
{
    [JsiiInterface(nativeType: typeof(IDevopsBuildPipelineStageDeliverArtifactCollectionItems), fullyQualifiedName: "oci.devopsBuildPipelineStage.DevopsBuildPipelineStageDeliverArtifactCollectionItems")]
    public interface IDevopsBuildPipelineStageDeliverArtifactCollectionItems
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#artifact_id DevopsBuildPipelineStage#artifact_id}.</summary>
        [JsiiProperty(name: "artifactId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ArtifactId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#artifact_name DevopsBuildPipelineStage#artifact_name}.</summary>
        [JsiiProperty(name: "artifactName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ArtifactName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDevopsBuildPipelineStageDeliverArtifactCollectionItems), fullyQualifiedName: "oci.devopsBuildPipelineStage.DevopsBuildPipelineStageDeliverArtifactCollectionItems")]
        internal sealed class _Proxy : DeputyBase, oci.DevopsBuildPipelineStage.IDevopsBuildPipelineStageDeliverArtifactCollectionItems
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#artifact_id DevopsBuildPipelineStage#artifact_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "artifactId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ArtifactId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#artifact_name DevopsBuildPipelineStage#artifact_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "artifactName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ArtifactName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
