using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.BatchPool
{
    [JsiiByValue(fqn: "azurerm.batchPool.BatchPoolNetworkConfiguration")]
    public class BatchPoolNetworkConfiguration : azurerm.BatchPool.IBatchPoolNetworkConfiguration
    {
        private object? _acceleratedNetworkingEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/batch_pool#accelerated_networking_enabled BatchPool#accelerated_networking_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "acceleratedNetworkingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? AcceleratedNetworkingEnabled
        {
            get => _acceleratedNetworkingEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _acceleratedNetworkingEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/batch_pool#dynamic_vnet_assignment_scope BatchPool#dynamic_vnet_assignment_scope}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dynamicVnetAssignmentScope", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DynamicVnetAssignmentScope
        {
            get;
            set;
        }

        private object? _endpointConfiguration;

        /// <summary>endpoint_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/batch_pool#endpoint_configuration BatchPool#endpoint_configuration}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.BatchPool.IBatchPoolNetworkConfigurationEndpointConfiguration" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "endpointConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.batchPool.BatchPoolNetworkConfigurationEndpointConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? EndpointConfiguration
        {
            get => _endpointConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.BatchPool.IBatchPoolNetworkConfigurationEndpointConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.BatchPool.IBatchPoolNetworkConfigurationEndpointConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _endpointConfiguration = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/batch_pool#public_address_provisioning_type BatchPool#public_address_provisioning_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "publicAddressProvisioningType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PublicAddressProvisioningType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/batch_pool#public_ips BatchPool#public_ips}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "publicIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? PublicIps
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/batch_pool#subnet_id BatchPool#subnet_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SubnetId
        {
            get;
            set;
        }
    }
}
