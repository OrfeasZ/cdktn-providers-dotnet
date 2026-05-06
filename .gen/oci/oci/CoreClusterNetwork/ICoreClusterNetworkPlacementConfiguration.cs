using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreClusterNetwork
{
    [JsiiInterface(nativeType: typeof(ICoreClusterNetworkPlacementConfiguration), fullyQualifiedName: "oci.coreClusterNetwork.CoreClusterNetworkPlacementConfiguration")]
    public interface ICoreClusterNetworkPlacementConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_cluster_network#availability_domain CoreClusterNetwork#availability_domain}.</summary>
        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
        string AvailabilityDomain
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_cluster_network#placement_constraint CoreClusterNetwork#placement_constraint}.</summary>
        [JsiiProperty(name: "placementConstraint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PlacementConstraint
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_cluster_network#primary_subnet_id CoreClusterNetwork#primary_subnet_id}.</summary>
        [JsiiProperty(name: "primarySubnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PrimarySubnetId
        {
            get
            {
                return null;
            }
        }

        /// <summary>primary_vnic_subnets block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_cluster_network#primary_vnic_subnets CoreClusterNetwork#primary_vnic_subnets}
        /// </remarks>
        [JsiiProperty(name: "primaryVnicSubnets", typeJson: "{\"fqn\":\"oci.coreClusterNetwork.CoreClusterNetworkPlacementConfigurationPrimaryVnicSubnets\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CoreClusterNetwork.ICoreClusterNetworkPlacementConfigurationPrimaryVnicSubnets? PrimaryVnicSubnets
        {
            get
            {
                return null;
            }
        }

        /// <summary>secondary_vnic_subnets block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_cluster_network#secondary_vnic_subnets CoreClusterNetwork#secondary_vnic_subnets}
        /// </remarks>
        [JsiiProperty(name: "secondaryVnicSubnets", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.coreClusterNetwork.CoreClusterNetworkPlacementConfigurationSecondaryVnicSubnets\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SecondaryVnicSubnets
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreClusterNetworkPlacementConfiguration), fullyQualifiedName: "oci.coreClusterNetwork.CoreClusterNetworkPlacementConfiguration")]
        internal sealed class _Proxy : DeputyBase, oci.CoreClusterNetwork.ICoreClusterNetworkPlacementConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_cluster_network#availability_domain CoreClusterNetwork#availability_domain}.</summary>
            [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
            public string AvailabilityDomain
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_cluster_network#placement_constraint CoreClusterNetwork#placement_constraint}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "placementConstraint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PlacementConstraint
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_cluster_network#primary_subnet_id CoreClusterNetwork#primary_subnet_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "primarySubnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PrimarySubnetId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>primary_vnic_subnets block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_cluster_network#primary_vnic_subnets CoreClusterNetwork#primary_vnic_subnets}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "primaryVnicSubnets", typeJson: "{\"fqn\":\"oci.coreClusterNetwork.CoreClusterNetworkPlacementConfigurationPrimaryVnicSubnets\"}", isOptional: true)]
            public oci.CoreClusterNetwork.ICoreClusterNetworkPlacementConfigurationPrimaryVnicSubnets? PrimaryVnicSubnets
            {
                get => GetInstanceProperty<oci.CoreClusterNetwork.ICoreClusterNetworkPlacementConfigurationPrimaryVnicSubnets?>();
            }

            /// <summary>secondary_vnic_subnets block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_cluster_network#secondary_vnic_subnets CoreClusterNetwork#secondary_vnic_subnets}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "secondaryVnicSubnets", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.coreClusterNetwork.CoreClusterNetworkPlacementConfigurationSecondaryVnicSubnets\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SecondaryVnicSubnets
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
