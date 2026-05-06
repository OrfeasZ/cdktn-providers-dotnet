using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudBridgeAsset
{
    [JsiiByValue(fqn: "oci.cloudBridgeAsset.CloudBridgeAssetComputeScsiController")]
    public class CloudBridgeAssetComputeScsiController : oci.CloudBridgeAsset.ICloudBridgeAssetComputeScsiController
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#label CloudBridgeAsset#label}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "label", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Label
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#shared_bus CloudBridgeAsset#shared_bus}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sharedBus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SharedBus
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#unit_number CloudBridgeAsset#unit_number}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "unitNumber", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? UnitNumber
        {
            get;
            set;
        }
    }
}
