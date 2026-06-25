using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudBridgeAsset
{
    [JsiiByValue(fqn: "oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2NetworkInterfacesAssociation")]
    public class CloudBridgeAssetAwsEc2NetworkInterfacesAssociation : oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2NetworkInterfacesAssociation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/cloud_bridge_asset#carrier_ip CloudBridgeAsset#carrier_ip}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "carrierIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CarrierIp
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/cloud_bridge_asset#customer_owned_ip CloudBridgeAsset#customer_owned_ip}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customerOwnedIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CustomerOwnedIp
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/cloud_bridge_asset#ip_owner_key CloudBridgeAsset#ip_owner_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipOwnerKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IpOwnerKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/cloud_bridge_asset#public_dns_name CloudBridgeAsset#public_dns_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "publicDnsName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PublicDnsName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/cloud_bridge_asset#public_ip CloudBridgeAsset#public_ip}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "publicIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PublicIp
        {
            get;
            set;
        }
    }
}
