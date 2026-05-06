using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsBuildPipeline
{
    [JsiiInterface(nativeType: typeof(IDevopsBuildPipelineBuildPipelineParameters), fullyQualifiedName: "oci.devopsBuildPipeline.DevopsBuildPipelineBuildPipelineParameters")]
    public interface IDevopsBuildPipelineBuildPipelineParameters
    {
        /// <summary>items block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline#items DevopsBuildPipeline#items}
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.devopsBuildPipeline.DevopsBuildPipelineBuildPipelineParametersItems\"},\"kind\":\"array\"}}]}}")]
        object Items
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDevopsBuildPipelineBuildPipelineParameters), fullyQualifiedName: "oci.devopsBuildPipeline.DevopsBuildPipelineBuildPipelineParameters")]
        internal sealed class _Proxy : DeputyBase, oci.DevopsBuildPipeline.IDevopsBuildPipelineBuildPipelineParameters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>items block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline#items DevopsBuildPipeline#items}
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.devopsBuildPipeline.DevopsBuildPipelineBuildPipelineParametersItems\"},\"kind\":\"array\"}}]}}")]
            public object Items
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
