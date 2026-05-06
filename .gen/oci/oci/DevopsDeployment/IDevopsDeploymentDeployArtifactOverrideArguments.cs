using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsDeployment
{
    [JsiiInterface(nativeType: typeof(IDevopsDeploymentDeployArtifactOverrideArguments), fullyQualifiedName: "oci.devopsDeployment.DevopsDeploymentDeployArtifactOverrideArguments")]
    public interface IDevopsDeploymentDeployArtifactOverrideArguments
    {
        /// <summary>items block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deployment#items DevopsDeployment#items}
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.devopsDeployment.DevopsDeploymentDeployArtifactOverrideArgumentsItems\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Items
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDevopsDeploymentDeployArtifactOverrideArguments), fullyQualifiedName: "oci.devopsDeployment.DevopsDeploymentDeployArtifactOverrideArguments")]
        internal sealed class _Proxy : DeputyBase, oci.DevopsDeployment.IDevopsDeploymentDeployArtifactOverrideArguments
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>items block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deployment#items DevopsDeployment#items}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "items", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.devopsDeployment.DevopsDeploymentDeployArtifactOverrideArgumentsItems\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Items
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
