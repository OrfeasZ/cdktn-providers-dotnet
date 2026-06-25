using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudBridgeAsset
{
    [JsiiByValue(fqn: "oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2NetworkInterfaces")]
    public class CloudBridgeAssetAwsEc2NetworkInterfaces : oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2NetworkInterfaces
    {
        /// <summary>association block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/cloud_bridge_asset#association CloudBridgeAsset#association}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "association", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2NetworkInterfacesAssociation\"}", isOptional: true)]
        public oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2NetworkInterfacesAssociation? Association
        {
            get;
            set;
        }

        /// <summary>attachment block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/cloud_bridge_asset#attachment CloudBridgeAsset#attachment}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "attachment", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2NetworkInterfacesAttachment\"}", isOptional: true)]
        public oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2NetworkInterfacesAttachment? Attachment
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/cloud_bridge_asset#description CloudBridgeAsset#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/cloud_bridge_asset#interface_type CloudBridgeAsset#interface_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "interfaceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InterfaceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/cloud_bridge_asset#ipv4prefixes CloudBridgeAsset#ipv4prefixes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipv4Prefixes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Ipv4Prefixes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/cloud_bridge_asset#ipv6addresses CloudBridgeAsset#ipv6addresses}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipv6Addresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Ipv6Addresses
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/cloud_bridge_asset#ipv6prefixes CloudBridgeAsset#ipv6prefixes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipv6Prefixes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Ipv6Prefixes
        {
            get;
            set;
        }

        private object? _isSourceDestCheck;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/cloud_bridge_asset#is_source_dest_check CloudBridgeAsset#is_source_dest_check}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isSourceDestCheck", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsSourceDestCheck
        {
            get => _isSourceDestCheck;
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
                _isSourceDestCheck = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/cloud_bridge_asset#mac_address CloudBridgeAsset#mac_address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "macAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MacAddress
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/cloud_bridge_asset#network_interface_key CloudBridgeAsset#network_interface_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "networkInterfaceKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NetworkInterfaceKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/cloud_bridge_asset#owner_key CloudBridgeAsset#owner_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ownerKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OwnerKey
        {
            get;
            set;
        }

        private object? _privateIpAddresses;

        /// <summary>private_ip_addresses block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/cloud_bridge_asset#private_ip_addresses CloudBridgeAsset#private_ip_addresses}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2NetworkInterfacesPrivateIpAddresses" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "privateIpAddresses", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2NetworkInterfacesPrivateIpAddresses\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? PrivateIpAddresses
        {
            get => _privateIpAddresses;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2NetworkInterfacesPrivateIpAddresses[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2NetworkInterfacesPrivateIpAddresses).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _privateIpAddresses = value;
            }
        }

        private object? _securityGroups;

        /// <summary>security_groups block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/cloud_bridge_asset#security_groups CloudBridgeAsset#security_groups}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2NetworkInterfacesSecurityGroups" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "securityGroups", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2NetworkInterfacesSecurityGroups\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SecurityGroups
        {
            get => _securityGroups;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2NetworkInterfacesSecurityGroups[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2NetworkInterfacesSecurityGroups).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _securityGroups = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/cloud_bridge_asset#status CloudBridgeAsset#status}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Status
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/cloud_bridge_asset#subnet_key CloudBridgeAsset#subnet_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subnetKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SubnetKey
        {
            get;
            set;
        }
    }
}
