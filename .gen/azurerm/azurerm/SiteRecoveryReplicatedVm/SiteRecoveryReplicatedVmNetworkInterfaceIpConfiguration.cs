using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SiteRecoveryReplicatedVm
{
    [JsiiByValue(fqn: "azurerm.siteRecoveryReplicatedVm.SiteRecoveryReplicatedVmNetworkInterfaceIpConfiguration")]
    public class SiteRecoveryReplicatedVmNetworkInterfaceIpConfiguration : azurerm.SiteRecoveryReplicatedVm.ISiteRecoveryReplicatedVmNetworkInterfaceIpConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/site_recovery_replicated_vm#failover_test_public_ip_address_id SiteRecoveryReplicatedVm#failover_test_public_ip_address_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "failoverTestPublicIpAddressId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FailoverTestPublicIpAddressId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/site_recovery_replicated_vm#failover_test_static_ip SiteRecoveryReplicatedVm#failover_test_static_ip}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "failoverTestStaticIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FailoverTestStaticIp
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/site_recovery_replicated_vm#failover_test_subnet_name SiteRecoveryReplicatedVm#failover_test_subnet_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "failoverTestSubnetName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FailoverTestSubnetName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/site_recovery_replicated_vm#name SiteRecoveryReplicatedVm#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        private object? _primary;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/site_recovery_replicated_vm#primary SiteRecoveryReplicatedVm#primary}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "primary", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Primary
        {
            get => _primary;
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
                _primary = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/site_recovery_replicated_vm#recovery_load_balancer_backend_address_pool_ids SiteRecoveryReplicatedVm#recovery_load_balancer_backend_address_pool_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "recoveryLoadBalancerBackendAddressPoolIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? RecoveryLoadBalancerBackendAddressPoolIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/site_recovery_replicated_vm#recovery_public_ip_address_id SiteRecoveryReplicatedVm#recovery_public_ip_address_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "recoveryPublicIpAddressId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RecoveryPublicIpAddressId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/site_recovery_replicated_vm#target_static_ip SiteRecoveryReplicatedVm#target_static_ip}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetStaticIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetStaticIp
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/site_recovery_replicated_vm#target_subnet_name SiteRecoveryReplicatedVm#target_subnet_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetSubnetName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetSubnetName
        {
            get;
            set;
        }
    }
}
