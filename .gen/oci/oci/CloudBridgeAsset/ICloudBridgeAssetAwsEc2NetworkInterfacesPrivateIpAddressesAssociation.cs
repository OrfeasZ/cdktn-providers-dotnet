using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudBridgeAsset
{
    [JsiiInterface(nativeType: typeof(ICloudBridgeAssetAwsEc2NetworkInterfacesPrivateIpAddressesAssociation), fullyQualifiedName: "oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2NetworkInterfacesPrivateIpAddressesAssociation")]
    public interface ICloudBridgeAssetAwsEc2NetworkInterfacesPrivateIpAddressesAssociation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/cloud_bridge_asset#carrier_ip CloudBridgeAsset#carrier_ip}.</summary>
        [JsiiProperty(name: "carrierIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CarrierIp
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/cloud_bridge_asset#customer_owned_ip CloudBridgeAsset#customer_owned_ip}.</summary>
        [JsiiProperty(name: "customerOwnedIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CustomerOwnedIp
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/cloud_bridge_asset#ip_owner_key CloudBridgeAsset#ip_owner_key}.</summary>
        [JsiiProperty(name: "ipOwnerKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IpOwnerKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/cloud_bridge_asset#public_dns_name CloudBridgeAsset#public_dns_name}.</summary>
        [JsiiProperty(name: "publicDnsName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PublicDnsName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/cloud_bridge_asset#public_ip CloudBridgeAsset#public_ip}.</summary>
        [JsiiProperty(name: "publicIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PublicIp
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudBridgeAssetAwsEc2NetworkInterfacesPrivateIpAddressesAssociation), fullyQualifiedName: "oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2NetworkInterfacesPrivateIpAddressesAssociation")]
        internal sealed class _Proxy : DeputyBase, oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2NetworkInterfacesPrivateIpAddressesAssociation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/cloud_bridge_asset#carrier_ip CloudBridgeAsset#carrier_ip}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "carrierIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CarrierIp
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/cloud_bridge_asset#customer_owned_ip CloudBridgeAsset#customer_owned_ip}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "customerOwnedIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CustomerOwnedIp
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/cloud_bridge_asset#ip_owner_key CloudBridgeAsset#ip_owner_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ipOwnerKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IpOwnerKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/cloud_bridge_asset#public_dns_name CloudBridgeAsset#public_dns_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "publicDnsName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PublicDnsName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/cloud_bridge_asset#public_ip CloudBridgeAsset#public_ip}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "publicIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PublicIp
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
