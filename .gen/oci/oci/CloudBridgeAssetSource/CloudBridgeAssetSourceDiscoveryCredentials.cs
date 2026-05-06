using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudBridgeAssetSource
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.cloudBridgeAssetSource.CloudBridgeAssetSourceDiscoveryCredentials")]
    public class CloudBridgeAssetSourceDiscoveryCredentials : oci.CloudBridgeAssetSource.ICloudBridgeAssetSourceDiscoveryCredentials
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset_source#secret_id CloudBridgeAssetSource#secret_id}.</summary>
        [JsiiProperty(name: "secretId", typeJson: "{\"primitive\":\"string\"}")]
        public string SecretId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset_source#type CloudBridgeAssetSource#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}
