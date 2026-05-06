using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudBridgeAsset
{
    [JsiiByValue(fqn: "oci.cloudBridgeAsset.CloudBridgeAssetVmwareVcenter")]
    public class CloudBridgeAssetVmwareVcenter : oci.CloudBridgeAsset.ICloudBridgeAssetVmwareVcenter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#data_center CloudBridgeAsset#data_center}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dataCenter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DataCenter
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#vcenter_key CloudBridgeAsset#vcenter_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vcenterKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VcenterKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#vcenter_version CloudBridgeAsset#vcenter_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vcenterVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VcenterVersion
        {
            get;
            set;
        }
    }
}
