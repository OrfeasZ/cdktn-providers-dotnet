using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreClusterNetwork
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.coreClusterNetwork.CoreClusterNetworkPlacementConfiguration")]
    public class CoreClusterNetworkPlacementConfiguration : oci.CoreClusterNetwork.ICoreClusterNetworkPlacementConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_cluster_network#availability_domain CoreClusterNetwork#availability_domain}.</summary>
        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
        public string AvailabilityDomain
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_cluster_network#placement_constraint CoreClusterNetwork#placement_constraint}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "placementConstraint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PlacementConstraint
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_cluster_network#primary_subnet_id CoreClusterNetwork#primary_subnet_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "primarySubnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrimarySubnetId
        {
            get;
            set;
        }

        /// <summary>primary_vnic_subnets block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_cluster_network#primary_vnic_subnets CoreClusterNetwork#primary_vnic_subnets}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "primaryVnicSubnets", typeJson: "{\"fqn\":\"oci.coreClusterNetwork.CoreClusterNetworkPlacementConfigurationPrimaryVnicSubnets\"}", isOptional: true)]
        public oci.CoreClusterNetwork.ICoreClusterNetworkPlacementConfigurationPrimaryVnicSubnets? PrimaryVnicSubnets
        {
            get;
            set;
        }

        private object? _secondaryVnicSubnets;

        /// <summary>secondary_vnic_subnets block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_cluster_network#secondary_vnic_subnets CoreClusterNetwork#secondary_vnic_subnets}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secondaryVnicSubnets", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.coreClusterNetwork.CoreClusterNetworkPlacementConfigurationSecondaryVnicSubnets\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case oci.CoreClusterNetwork.ICoreClusterNetworkPlacementConfigurationSecondaryVnicSubnets[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CoreClusterNetwork.ICoreClusterNetworkPlacementConfigurationSecondaryVnicSubnets).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _secondaryVnicSubnets = value;
            }
        }
    }
}
