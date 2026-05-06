using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsBuildPipelineStage
{
    [JsiiInterface(nativeType: typeof(IDevopsBuildPipelineStageBuildPipelineStagePredecessorCollection), fullyQualifiedName: "oci.devopsBuildPipelineStage.DevopsBuildPipelineStageBuildPipelineStagePredecessorCollection")]
    public interface IDevopsBuildPipelineStageBuildPipelineStagePredecessorCollection
    {
        /// <summary>items block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#items DevopsBuildPipelineStage#items}
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.devopsBuildPipelineStage.DevopsBuildPipelineStageBuildPipelineStagePredecessorCollectionItems\"},\"kind\":\"array\"}}]}}")]
        object Items
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDevopsBuildPipelineStageBuildPipelineStagePredecessorCollection), fullyQualifiedName: "oci.devopsBuildPipelineStage.DevopsBuildPipelineStageBuildPipelineStagePredecessorCollection")]
        internal sealed class _Proxy : DeputyBase, oci.DevopsBuildPipelineStage.IDevopsBuildPipelineStageBuildPipelineStagePredecessorCollection
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>items block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#items DevopsBuildPipelineStage#items}
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.devopsBuildPipelineStage.DevopsBuildPipelineStageBuildPipelineStagePredecessorCollectionItems\"},\"kind\":\"array\"}}]}}")]
            public object Items
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
