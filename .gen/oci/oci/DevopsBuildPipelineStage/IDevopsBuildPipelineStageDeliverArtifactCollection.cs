using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsBuildPipelineStage
{
    [JsiiInterface(nativeType: typeof(IDevopsBuildPipelineStageDeliverArtifactCollection), fullyQualifiedName: "oci.devopsBuildPipelineStage.DevopsBuildPipelineStageDeliverArtifactCollection")]
    public interface IDevopsBuildPipelineStageDeliverArtifactCollection
    {
        /// <summary>items block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/devops_build_pipeline_stage#items DevopsBuildPipelineStage#items}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DevopsBuildPipelineStage.IDevopsBuildPipelineStageDeliverArtifactCollectionItems" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.devopsBuildPipelineStage.DevopsBuildPipelineStageDeliverArtifactCollectionItems\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Items
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDevopsBuildPipelineStageDeliverArtifactCollection), fullyQualifiedName: "oci.devopsBuildPipelineStage.DevopsBuildPipelineStageDeliverArtifactCollection")]
        internal sealed class _Proxy : DeputyBase, oci.DevopsBuildPipelineStage.IDevopsBuildPipelineStageDeliverArtifactCollection
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>items block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/devops_build_pipeline_stage#items DevopsBuildPipelineStage#items}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DevopsBuildPipelineStage.IDevopsBuildPipelineStageDeliverArtifactCollectionItems" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "items", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.devopsBuildPipelineStage.DevopsBuildPipelineStageDeliverArtifactCollectionItems\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Items
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
