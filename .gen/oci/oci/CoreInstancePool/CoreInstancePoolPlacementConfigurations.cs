using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstancePool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.coreInstancePool.CoreInstancePoolPlacementConfigurations")]
    public class CoreInstancePoolPlacementConfigurations : oci.CoreInstancePool.ICoreInstancePoolPlacementConfigurations
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_pool#availability_domain CoreInstancePool#availability_domain}.</summary>
        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
        public string AvailabilityDomain
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_pool#fault_domains CoreInstancePool#fault_domains}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "faultDomains", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? FaultDomains
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_pool#primary_subnet_id CoreInstancePool#primary_subnet_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "primarySubnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrimarySubnetId
        {
            get;
            set;
        }

        /// <summary>primary_vnic_subnets block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_pool#primary_vnic_subnets CoreInstancePool#primary_vnic_subnets}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "primaryVnicSubnets", typeJson: "{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolPlacementConfigurationsPrimaryVnicSubnets\"}", isOptional: true)]
        public oci.CoreInstancePool.ICoreInstancePoolPlacementConfigurationsPrimaryVnicSubnets? PrimaryVnicSubnets
        {
            get;
            set;
        }

        private object? _secondaryVnicSubnets;

        /// <summary>secondary_vnic_subnets block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_pool#secondary_vnic_subnets CoreInstancePool#secondary_vnic_subnets}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secondaryVnicSubnets", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolPlacementConfigurationsSecondaryVnicSubnets\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SecondaryVnicSubnets
        {
            get => _secondaryVnicSubnets;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.CoreInstancePool.ICoreInstancePoolPlacementConfigurationsSecondaryVnicSubnets[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CoreInstancePool.ICoreInstancePoolPlacementConfigurationsSecondaryVnicSubnets).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _secondaryVnicSubnets = value;
            }
        }
    }
}
