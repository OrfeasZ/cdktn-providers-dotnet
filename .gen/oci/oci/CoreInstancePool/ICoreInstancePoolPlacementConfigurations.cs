using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstancePool
{
    [JsiiInterface(nativeType: typeof(ICoreInstancePoolPlacementConfigurations), fullyQualifiedName: "oci.coreInstancePool.CoreInstancePoolPlacementConfigurations")]
    public interface ICoreInstancePoolPlacementConfigurations
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_pool#availability_domain CoreInstancePool#availability_domain}.</summary>
        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
        string AvailabilityDomain
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_pool#fault_domains CoreInstancePool#fault_domains}.</summary>
        [JsiiProperty(name: "faultDomains", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? FaultDomains
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_pool#primary_subnet_id CoreInstancePool#primary_subnet_id}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_pool#primary_vnic_subnets CoreInstancePool#primary_vnic_subnets}
        /// </remarks>
        [JsiiProperty(name: "primaryVnicSubnets", typeJson: "{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolPlacementConfigurationsPrimaryVnicSubnets\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CoreInstancePool.ICoreInstancePoolPlacementConfigurationsPrimaryVnicSubnets? PrimaryVnicSubnets
        {
            get
            {
                return null;
            }
        }

        /// <summary>secondary_vnic_subnets block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_pool#secondary_vnic_subnets CoreInstancePool#secondary_vnic_subnets}
        /// </remarks>
        [JsiiProperty(name: "secondaryVnicSubnets", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolPlacementConfigurationsSecondaryVnicSubnets\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SecondaryVnicSubnets
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreInstancePoolPlacementConfigurations), fullyQualifiedName: "oci.coreInstancePool.CoreInstancePoolPlacementConfigurations")]
        internal sealed class _Proxy : DeputyBase, oci.CoreInstancePool.ICoreInstancePoolPlacementConfigurations
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_pool#availability_domain CoreInstancePool#availability_domain}.</summary>
            [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
            public string AvailabilityDomain
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_pool#fault_domains CoreInstancePool#fault_domains}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "faultDomains", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? FaultDomains
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_pool#primary_subnet_id CoreInstancePool#primary_subnet_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "primarySubnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PrimarySubnetId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>primary_vnic_subnets block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_pool#primary_vnic_subnets CoreInstancePool#primary_vnic_subnets}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "primaryVnicSubnets", typeJson: "{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolPlacementConfigurationsPrimaryVnicSubnets\"}", isOptional: true)]
            public oci.CoreInstancePool.ICoreInstancePoolPlacementConfigurationsPrimaryVnicSubnets? PrimaryVnicSubnets
            {
                get => GetInstanceProperty<oci.CoreInstancePool.ICoreInstancePoolPlacementConfigurationsPrimaryVnicSubnets?>();
            }

            /// <summary>secondary_vnic_subnets block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_pool#secondary_vnic_subnets CoreInstancePool#secondary_vnic_subnets}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "secondaryVnicSubnets", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolPlacementConfigurationsSecondaryVnicSubnets\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SecondaryVnicSubnets
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
