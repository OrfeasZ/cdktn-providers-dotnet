using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudBridgeAsset
{
    [JsiiByValue(fqn: "oci.cloudBridgeAsset.CloudBridgeAssetComputeDisks")]
    public class CloudBridgeAssetComputeDisks : oci.CloudBridgeAsset.ICloudBridgeAssetComputeDisks
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#boot_order CloudBridgeAsset#boot_order}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bootOrder", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BootOrder
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#location CloudBridgeAsset#location}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Location
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#name CloudBridgeAsset#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#persistent_mode CloudBridgeAsset#persistent_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "persistentMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PersistentMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#size_in_mbs CloudBridgeAsset#size_in_mbs}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sizeInMbs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SizeInMbs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#uuid CloudBridgeAsset#uuid}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "uuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Uuid
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#uuid_lun CloudBridgeAsset#uuid_lun}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "uuidLun", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UuidLun
        {
            get;
            set;
        }
    }
}
