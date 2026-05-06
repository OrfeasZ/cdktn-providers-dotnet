using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatasciencePipeline
{
    [JsiiInterface(nativeType: typeof(IDatasciencePipelineStepArtifact), fullyQualifiedName: "oci.datasciencePipeline.DatasciencePipelineStepArtifact")]
    public interface IDatasciencePipelineStepArtifact
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#pipeline_step_artifact DatasciencePipeline#pipeline_step_artifact}.</summary>
        [JsiiProperty(name: "pipelineStepArtifact", typeJson: "{\"primitive\":\"string\"}")]
        string PipelineStepArtifact
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#step_name DatasciencePipeline#step_name}.</summary>
        [JsiiProperty(name: "stepName", typeJson: "{\"primitive\":\"string\"}")]
        string StepName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#artifact_content_disposition DatasciencePipeline#artifact_content_disposition}.</summary>
        [JsiiProperty(name: "artifactContentDisposition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ArtifactContentDisposition
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#artifact_content_length DatasciencePipeline#artifact_content_length}.</summary>
        [JsiiProperty(name: "artifactContentLength", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ArtifactContentLength
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatasciencePipelineStepArtifact), fullyQualifiedName: "oci.datasciencePipeline.DatasciencePipelineStepArtifact")]
        internal sealed class _Proxy : DeputyBase, oci.DatasciencePipeline.IDatasciencePipelineStepArtifact
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#pipeline_step_artifact DatasciencePipeline#pipeline_step_artifact}.</summary>
            [JsiiProperty(name: "pipelineStepArtifact", typeJson: "{\"primitive\":\"string\"}")]
            public string PipelineStepArtifact
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#step_name DatasciencePipeline#step_name}.</summary>
            [JsiiProperty(name: "stepName", typeJson: "{\"primitive\":\"string\"}")]
            public string StepName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#artifact_content_disposition DatasciencePipeline#artifact_content_disposition}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "artifactContentDisposition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ArtifactContentDisposition
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#artifact_content_length DatasciencePipeline#artifact_content_length}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "artifactContentLength", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ArtifactContentLength
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
