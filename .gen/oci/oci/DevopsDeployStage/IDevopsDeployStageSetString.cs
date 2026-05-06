using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsDeployStage
{
    [JsiiInterface(nativeType: typeof(IDevopsDeployStageSetString), fullyQualifiedName: "oci.devopsDeployStage.DevopsDeployStageSetString")]
    public interface IDevopsDeployStageSetString
    {
        /// <summary>items block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#items DevopsDeployStage#items}
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageSetStringItems\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Items
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDevopsDeployStageSetString), fullyQualifiedName: "oci.devopsDeployStage.DevopsDeployStageSetString")]
        internal sealed class _Proxy : DeputyBase, oci.DevopsDeployStage.IDevopsDeployStageSetString
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>items block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#items DevopsDeployStage#items}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "items", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageSetStringItems\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Items
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
