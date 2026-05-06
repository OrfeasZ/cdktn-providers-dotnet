using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudBridgeAsset
{
    [JsiiByValue(fqn: "oci.cloudBridgeAsset.CloudBridgeAssetVm")]
    public class CloudBridgeAssetVm : oci.CloudBridgeAsset.ICloudBridgeAssetVm
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#hypervisor_host CloudBridgeAsset#hypervisor_host}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hypervisorHost", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HypervisorHost
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#hypervisor_vendor CloudBridgeAsset#hypervisor_vendor}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hypervisorVendor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HypervisorVendor
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#hypervisor_version CloudBridgeAsset#hypervisor_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hypervisorVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HypervisorVersion
        {
            get;
            set;
        }
    }
}
