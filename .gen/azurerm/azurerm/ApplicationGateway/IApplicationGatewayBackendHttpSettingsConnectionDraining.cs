using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApplicationGateway
{
    [JsiiInterface(nativeType: typeof(IApplicationGatewayBackendHttpSettingsConnectionDraining), fullyQualifiedName: "azurerm.applicationGateway.ApplicationGatewayBackendHttpSettingsConnectionDraining")]
    public interface IApplicationGatewayBackendHttpSettingsConnectionDraining
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/application_gateway#drain_timeout_sec ApplicationGateway#drain_timeout_sec}.</summary>
        [JsiiProperty(name: "drainTimeoutSec", typeJson: "{\"primitive\":\"number\"}")]
        double DrainTimeoutSec
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/application_gateway#enabled ApplicationGateway#enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IApplicationGatewayBackendHttpSettingsConnectionDraining), fullyQualifiedName: "azurerm.applicationGateway.ApplicationGatewayBackendHttpSettingsConnectionDraining")]
        internal sealed class _Proxy : DeputyBase, azurerm.ApplicationGateway.IApplicationGatewayBackendHttpSettingsConnectionDraining
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/application_gateway#drain_timeout_sec ApplicationGateway#drain_timeout_sec}.</summary>
            [JsiiProperty(name: "drainTimeoutSec", typeJson: "{\"primitive\":\"number\"}")]
            public double DrainTimeoutSec
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/application_gateway#enabled ApplicationGateway#enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
