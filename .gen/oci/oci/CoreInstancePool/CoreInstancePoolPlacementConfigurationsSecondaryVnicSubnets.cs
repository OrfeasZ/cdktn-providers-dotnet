using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstancePool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.coreInstancePool.CoreInstancePoolPlacementConfigurationsSecondaryVnicSubnets")]
    public class CoreInstancePoolPlacementConfigurationsSecondaryVnicSubnets : oci.CoreInstancePool.ICoreInstancePoolPlacementConfigurationsSecondaryVnicSubnets
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_pool#subnet_id CoreInstancePool#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public string SubnetId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_pool#display_name CoreInstancePool#display_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DisplayName
        {
            get;
            set;
        }

        private object? _ipv6AddressIpv6SubnetCidrPairDetails;

        /// <summary>ipv6address_ipv6subnet_cidr_pair_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_pool#ipv6address_ipv6subnet_cidr_pair_details CoreInstancePool#ipv6address_ipv6subnet_cidr_pair_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ipv6AddressIpv6SubnetCidrPairDetails", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolPlacementConfigurationsSecondaryVnicSubnetsIpv6AddressIpv6SubnetCidrPairDetails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Ipv6AddressIpv6SubnetCidrPairDetails
        {
            get => _ipv6AddressIpv6SubnetCidrPairDetails;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.CoreInstancePool.ICoreInstancePoolPlacementConfigurationsSecondaryVnicSubnetsIpv6AddressIpv6SubnetCidrPairDetails[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CoreInstancePool.ICoreInstancePoolPlacementConfigurationsSecondaryVnicSubnetsIpv6AddressIpv6SubnetCidrPairDetails).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ipv6AddressIpv6SubnetCidrPairDetails = value;
            }
        }

        private object? _isAssignIpv6Ip;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_pool#is_assign_ipv6ip CoreInstancePool#is_assign_ipv6ip}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isAssignIpv6Ip", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsAssignIpv6Ip
        {
            get => _isAssignIpv6Ip;
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
                _isAssignIpv6Ip = value;
            }
        }
    }
}
