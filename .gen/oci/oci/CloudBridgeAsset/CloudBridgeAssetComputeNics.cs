using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudBridgeAsset
{
    [JsiiByValue(fqn: "oci.cloudBridgeAsset.CloudBridgeAssetComputeNics")]
    public class CloudBridgeAssetComputeNics : oci.CloudBridgeAsset.ICloudBridgeAssetComputeNics
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#ip_addresses CloudBridgeAsset#ip_addresses}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? IpAddresses
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#label CloudBridgeAsset#label}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "label", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Label
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#mac_address CloudBridgeAsset#mac_address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "macAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MacAddress
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#mac_address_type CloudBridgeAsset#mac_address_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "macAddressType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MacAddressType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#network_name CloudBridgeAsset#network_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "networkName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NetworkName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#switch_name CloudBridgeAsset#switch_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "switchName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SwitchName
        {
            get;
            set;
        }
    }
}
