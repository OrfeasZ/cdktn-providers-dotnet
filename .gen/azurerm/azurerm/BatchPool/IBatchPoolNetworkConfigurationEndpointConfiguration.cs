using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.BatchPool
{
    [JsiiInterface(nativeType: typeof(IBatchPoolNetworkConfigurationEndpointConfiguration), fullyQualifiedName: "azurerm.batchPool.BatchPoolNetworkConfigurationEndpointConfiguration")]
    public interface IBatchPoolNetworkConfigurationEndpointConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/batch_pool#backend_port BatchPool#backend_port}.</summary>
        [JsiiProperty(name: "backendPort", typeJson: "{\"primitive\":\"number\"}")]
        double BackendPort
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/batch_pool#frontend_port_range BatchPool#frontend_port_range}.</summary>
        [JsiiProperty(name: "frontendPortRange", typeJson: "{\"primitive\":\"string\"}")]
        string FrontendPortRange
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/batch_pool#name BatchPool#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/batch_pool#protocol BatchPool#protocol}.</summary>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        string Protocol
        {
            get;
        }

        /// <summary>network_security_group_rules block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/batch_pool#network_security_group_rules BatchPool#network_security_group_rules}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.BatchPool.IBatchPoolNetworkConfigurationEndpointConfigurationNetworkSecurityGroupRules" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "networkSecurityGroupRules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.batchPool.BatchPoolNetworkConfigurationEndpointConfigurationNetworkSecurityGroupRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NetworkSecurityGroupRules
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBatchPoolNetworkConfigurationEndpointConfiguration), fullyQualifiedName: "azurerm.batchPool.BatchPoolNetworkConfigurationEndpointConfiguration")]
        internal sealed class _Proxy : DeputyBase, azurerm.BatchPool.IBatchPoolNetworkConfigurationEndpointConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/batch_pool#backend_port BatchPool#backend_port}.</summary>
            [JsiiProperty(name: "backendPort", typeJson: "{\"primitive\":\"number\"}")]
            public double BackendPort
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/batch_pool#frontend_port_range BatchPool#frontend_port_range}.</summary>
            [JsiiProperty(name: "frontendPortRange", typeJson: "{\"primitive\":\"string\"}")]
            public string FrontendPortRange
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/batch_pool#name BatchPool#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/batch_pool#protocol BatchPool#protocol}.</summary>
            [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
            public string Protocol
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>network_security_group_rules block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/batch_pool#network_security_group_rules BatchPool#network_security_group_rules}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.BatchPool.IBatchPoolNetworkConfigurationEndpointConfigurationNetworkSecurityGroupRules" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "networkSecurityGroupRules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.batchPool.BatchPoolNetworkConfigurationEndpointConfigurationNetworkSecurityGroupRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? NetworkSecurityGroupRules
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
