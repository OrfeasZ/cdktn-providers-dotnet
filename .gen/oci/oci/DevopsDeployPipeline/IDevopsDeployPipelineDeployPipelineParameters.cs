using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsDeployPipeline
{
    [JsiiInterface(nativeType: typeof(IDevopsDeployPipelineDeployPipelineParameters), fullyQualifiedName: "oci.devopsDeployPipeline.DevopsDeployPipelineDeployPipelineParameters")]
    public interface IDevopsDeployPipelineDeployPipelineParameters
    {
        /// <summary>items block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_pipeline#items DevopsDeployPipeline#items}
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.devopsDeployPipeline.DevopsDeployPipelineDeployPipelineParametersItems\"},\"kind\":\"array\"}}]}}")]
        object Items
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDevopsDeployPipelineDeployPipelineParameters), fullyQualifiedName: "oci.devopsDeployPipeline.DevopsDeployPipelineDeployPipelineParameters")]
        internal sealed class _Proxy : DeputyBase, oci.DevopsDeployPipeline.IDevopsDeployPipelineDeployPipelineParameters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>items block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_pipeline#items DevopsDeployPipeline#items}
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.devopsDeployPipeline.DevopsDeployPipelineDeployPipelineParametersItems\"},\"kind\":\"array\"}}]}}")]
            public object Items
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
