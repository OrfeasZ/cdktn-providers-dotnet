using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsBuildPipelineStage
{
    [JsiiInterface(nativeType: typeof(IDevopsBuildPipelineStageBuildSourceCollection), fullyQualifiedName: "oci.devopsBuildPipelineStage.DevopsBuildPipelineStageBuildSourceCollection")]
    public interface IDevopsBuildPipelineStageBuildSourceCollection
    {
        /// <summary>items block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#items DevopsBuildPipelineStage#items}
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.devopsBuildPipelineStage.DevopsBuildPipelineStageBuildSourceCollectionItems\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Items
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDevopsBuildPipelineStageBuildSourceCollection), fullyQualifiedName: "oci.devopsBuildPipelineStage.DevopsBuildPipelineStageBuildSourceCollection")]
        internal sealed class _Proxy : DeputyBase, oci.DevopsBuildPipelineStage.IDevopsBuildPipelineStageBuildSourceCollection
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>items block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#items DevopsBuildPipelineStage#items}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "items", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.devopsBuildPipelineStage.DevopsBuildPipelineStageBuildSourceCollectionItems\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Items
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
