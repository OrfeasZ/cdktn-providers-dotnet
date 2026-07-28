using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NginxDeployment
{
    [JsiiInterface(nativeType: typeof(INginxDeploymentWebApplicationFirewall), fullyQualifiedName: "azurerm.nginxDeployment.NginxDeploymentWebApplicationFirewall")]
    public interface INginxDeploymentWebApplicationFirewall
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/nginx_deployment#activation_state_enabled NginxDeployment#activation_state_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "activationStateEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object ActivationStateEnabled
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(INginxDeploymentWebApplicationFirewall), fullyQualifiedName: "azurerm.nginxDeployment.NginxDeploymentWebApplicationFirewall")]
        internal sealed class _Proxy : DeputyBase, azurerm.NginxDeployment.INginxDeploymentWebApplicationFirewall
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/nginx_deployment#activation_state_enabled NginxDeployment#activation_state_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "activationStateEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object ActivationStateEnabled
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
