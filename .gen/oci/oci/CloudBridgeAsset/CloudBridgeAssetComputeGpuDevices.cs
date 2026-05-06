using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudBridgeAsset
{
    [JsiiByValue(fqn: "oci.cloudBridgeAsset.CloudBridgeAssetComputeGpuDevices")]
    public class CloudBridgeAssetComputeGpuDevices : oci.CloudBridgeAsset.ICloudBridgeAssetComputeGpuDevices
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#cores_count CloudBridgeAsset#cores_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "coresCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? CoresCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#description CloudBridgeAsset#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#manufacturer CloudBridgeAsset#manufacturer}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "manufacturer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Manufacturer
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#memory_in_mbs CloudBridgeAsset#memory_in_mbs}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "memoryInMbs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MemoryInMbs
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
    }
}
