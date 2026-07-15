using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerengineNodePool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.containerengineNodePool.ContainerengineNodePoolSecondaryVnicsCreateVnicDetails")]
    public class ContainerengineNodePoolSecondaryVnicsCreateVnicDetails : oci.ContainerengineNodePool.IContainerengineNodePoolSecondaryVnicsCreateVnicDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/containerengine_node_pool#subnet_id ContainerengineNodePool#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public string SubnetId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/containerengine_node_pool#application_resources ContainerengineNodePool#application_resources}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "applicationResources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ApplicationResources
        {
            get;
            set;
        }

        private object? _assignIpv6Ip;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/containerengine_node_pool#assign_ipv6ip ContainerengineNodePool#assign_ipv6ip}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "assignIpv6Ip", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? AssignIpv6Ip
        {
            get => _assignIpv6Ip;
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
                _assignIpv6Ip = value;
            }
        }

        private object? _assignPublicIp;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/containerengine_node_pool#assign_public_ip ContainerengineNodePool#assign_public_ip}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "assignPublicIp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? AssignPublicIp
        {
            get => _assignPublicIp;
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
                _assignPublicIp = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/containerengine_node_pool#defined_tags ContainerengineNodePool#defined_tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/containerengine_node_pool#display_name ContainerengineNodePool#display_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DisplayName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/containerengine_node_pool#freeform_tags ContainerengineNodePool#freeform_tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/containerengine_node_pool#ip_count ContainerengineNodePool#ip_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? IpCount
        {
            get;
            set;
        }

        private object? _ipv6AddressIpv6SubnetCidrPairDetails;

        /// <summary>ipv6address_ipv6subnet_cidr_pair_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/containerengine_node_pool#ipv6address_ipv6subnet_cidr_pair_details ContainerengineNodePool#ipv6address_ipv6subnet_cidr_pair_details}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.ContainerengineNodePool.IContainerengineNodePoolSecondaryVnicsCreateVnicDetailsIpv6AddressIpv6SubnetCidrPairDetails" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ipv6AddressIpv6SubnetCidrPairDetails", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.containerengineNodePool.ContainerengineNodePoolSecondaryVnicsCreateVnicDetailsIpv6AddressIpv6SubnetCidrPairDetails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case oci.ContainerengineNodePool.IContainerengineNodePoolSecondaryVnicsCreateVnicDetailsIpv6AddressIpv6SubnetCidrPairDetails[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.ContainerengineNodePool.IContainerengineNodePoolSecondaryVnicsCreateVnicDetailsIpv6AddressIpv6SubnetCidrPairDetails).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ipv6AddressIpv6SubnetCidrPairDetails = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/containerengine_node_pool#nsg_ids ContainerengineNodePool#nsg_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nsgIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? NsgIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/containerengine_node_pool#security_attributes ContainerengineNodePool#security_attributes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "securityAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? SecurityAttributes
        {
            get;
            set;
        }

        private object? _skipSourceDestCheck;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/containerengine_node_pool#skip_source_dest_check ContainerengineNodePool#skip_source_dest_check}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "skipSourceDestCheck", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? SkipSourceDestCheck
        {
            get => _skipSourceDestCheck;
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
                _skipSourceDestCheck = value;
            }
        }
    }
}
