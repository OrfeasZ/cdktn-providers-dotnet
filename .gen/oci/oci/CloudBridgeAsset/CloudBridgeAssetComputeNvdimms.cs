using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudBridgeAsset
{
    [JsiiByValue(fqn: "oci.cloudBridgeAsset.CloudBridgeAssetComputeNvdimms")]
    public class CloudBridgeAssetComputeNvdimms : oci.CloudBridgeAsset.ICloudBridgeAssetComputeNvdimms
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#controller_key CloudBridgeAsset#controller_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "controllerKey", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ControllerKey
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
