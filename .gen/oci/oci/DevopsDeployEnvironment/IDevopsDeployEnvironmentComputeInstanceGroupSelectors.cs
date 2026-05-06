using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsDeployEnvironment
{
    [JsiiInterface(nativeType: typeof(IDevopsDeployEnvironmentComputeInstanceGroupSelectors), fullyQualifiedName: "oci.devopsDeployEnvironment.DevopsDeployEnvironmentComputeInstanceGroupSelectors")]
    public interface IDevopsDeployEnvironmentComputeInstanceGroupSelectors
    {
        /// <summary>items block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_environment#items DevopsDeployEnvironment#items}
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.devopsDeployEnvironment.DevopsDeployEnvironmentComputeInstanceGroupSelectorsItems\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Items
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDevopsDeployEnvironmentComputeInstanceGroupSelectors), fullyQualifiedName: "oci.devopsDeployEnvironment.DevopsDeployEnvironmentComputeInstanceGroupSelectors")]
        internal sealed class _Proxy : DeputyBase, oci.DevopsDeployEnvironment.IDevopsDeployEnvironmentComputeInstanceGroupSelectors
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>items block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_environment#items DevopsDeployEnvironment#items}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "items", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.devopsDeployEnvironment.DevopsDeployEnvironmentComputeInstanceGroupSelectorsItems\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Items
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
