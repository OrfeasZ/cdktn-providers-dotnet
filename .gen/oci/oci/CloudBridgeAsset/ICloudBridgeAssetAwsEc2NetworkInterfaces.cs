using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudBridgeAsset
{
    [JsiiInterface(nativeType: typeof(ICloudBridgeAssetAwsEc2NetworkInterfaces), fullyQualifiedName: "oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2NetworkInterfaces")]
    public interface ICloudBridgeAssetAwsEc2NetworkInterfaces
    {
        /// <summary>association block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/cloud_bridge_asset#association CloudBridgeAsset#association}
        /// </remarks>
        [JsiiProperty(name: "association", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2NetworkInterfacesAssociation\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2NetworkInterfacesAssociation? Association
        {
            get
            {
                return null;
            }
        }

        /// <summary>attachment block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/cloud_bridge_asset#attachment CloudBridgeAsset#attachment}
        /// </remarks>
        [JsiiProperty(name: "attachment", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2NetworkInterfacesAttachment\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2NetworkInterfacesAttachment? Attachment
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/cloud_bridge_asset#description CloudBridgeAsset#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/cloud_bridge_asset#interface_type CloudBridgeAsset#interface_type}.</summary>
        [JsiiProperty(name: "interfaceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InterfaceType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/cloud_bridge_asset#ipv4prefixes CloudBridgeAsset#ipv4prefixes}.</summary>
        [JsiiProperty(name: "ipv4Prefixes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Ipv4Prefixes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/cloud_bridge_asset#ipv6addresses CloudBridgeAsset#ipv6addresses}.</summary>
        [JsiiProperty(name: "ipv6Addresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Ipv6Addresses
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/cloud_bridge_asset#ipv6prefixes CloudBridgeAsset#ipv6prefixes}.</summary>
        [JsiiProperty(name: "ipv6Prefixes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Ipv6Prefixes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/cloud_bridge_asset#is_source_dest_check CloudBridgeAsset#is_source_dest_check}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isSourceDestCheck", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsSourceDestCheck
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/cloud_bridge_asset#mac_address CloudBridgeAsset#mac_address}.</summary>
        [JsiiProperty(name: "macAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MacAddress
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/cloud_bridge_asset#network_interface_key CloudBridgeAsset#network_interface_key}.</summary>
        [JsiiProperty(name: "networkInterfaceKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NetworkInterfaceKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/cloud_bridge_asset#owner_key CloudBridgeAsset#owner_key}.</summary>
        [JsiiProperty(name: "ownerKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OwnerKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>private_ip_addresses block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/cloud_bridge_asset#private_ip_addresses CloudBridgeAsset#private_ip_addresses}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2NetworkInterfacesPrivateIpAddresses" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "privateIpAddresses", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2NetworkInterfacesPrivateIpAddresses\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PrivateIpAddresses
        {
            get
            {
                return null;
            }
        }

        /// <summary>security_groups block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/cloud_bridge_asset#security_groups CloudBridgeAsset#security_groups}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2NetworkInterfacesSecurityGroups" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "securityGroups", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2NetworkInterfacesSecurityGroups\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SecurityGroups
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/cloud_bridge_asset#status CloudBridgeAsset#status}.</summary>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Status
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/cloud_bridge_asset#subnet_key CloudBridgeAsset#subnet_key}.</summary>
        [JsiiProperty(name: "subnetKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SubnetKey
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudBridgeAssetAwsEc2NetworkInterfaces), fullyQualifiedName: "oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2NetworkInterfaces")]
        internal sealed class _Proxy : DeputyBase, oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2NetworkInterfaces
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>association block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/cloud_bridge_asset#association CloudBridgeAsset#association}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "association", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2NetworkInterfacesAssociation\"}", isOptional: true)]
            public oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2NetworkInterfacesAssociation? Association
            {
                get => GetInstanceProperty<oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2NetworkInterfacesAssociation?>();
            }

            /// <summary>attachment block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/cloud_bridge_asset#attachment CloudBridgeAsset#attachment}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "attachment", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2NetworkInterfacesAttachment\"}", isOptional: true)]
            public oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2NetworkInterfacesAttachment? Attachment
            {
                get => GetInstanceProperty<oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2NetworkInterfacesAttachment?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/cloud_bridge_asset#description CloudBridgeAsset#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/cloud_bridge_asset#interface_type CloudBridgeAsset#interface_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "interfaceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InterfaceType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/cloud_bridge_asset#ipv4prefixes CloudBridgeAsset#ipv4prefixes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ipv4Prefixes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Ipv4Prefixes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/cloud_bridge_asset#ipv6addresses CloudBridgeAsset#ipv6addresses}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ipv6Addresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Ipv6Addresses
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/cloud_bridge_asset#ipv6prefixes CloudBridgeAsset#ipv6prefixes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ipv6Prefixes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Ipv6Prefixes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/cloud_bridge_asset#is_source_dest_check CloudBridgeAsset#is_source_dest_check}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isSourceDestCheck", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsSourceDestCheck
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/cloud_bridge_asset#mac_address CloudBridgeAsset#mac_address}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "macAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MacAddress
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/cloud_bridge_asset#network_interface_key CloudBridgeAsset#network_interface_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "networkInterfaceKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NetworkInterfaceKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/cloud_bridge_asset#owner_key CloudBridgeAsset#owner_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ownerKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OwnerKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>private_ip_addresses block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/cloud_bridge_asset#private_ip_addresses CloudBridgeAsset#private_ip_addresses}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2NetworkInterfacesPrivateIpAddresses" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "privateIpAddresses", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2NetworkInterfacesPrivateIpAddresses\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PrivateIpAddresses
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>security_groups block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/cloud_bridge_asset#security_groups CloudBridgeAsset#security_groups}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2NetworkInterfacesSecurityGroups" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "securityGroups", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2NetworkInterfacesSecurityGroups\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SecurityGroups
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/cloud_bridge_asset#status CloudBridgeAsset#status}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Status
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/cloud_bridge_asset#subnet_key CloudBridgeAsset#subnet_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "subnetKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SubnetKey
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
