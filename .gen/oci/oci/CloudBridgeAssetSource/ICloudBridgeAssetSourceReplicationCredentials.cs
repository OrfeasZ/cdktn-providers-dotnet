using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudBridgeAssetSource
{
    [JsiiInterface(nativeType: typeof(ICloudBridgeAssetSourceReplicationCredentials), fullyQualifiedName: "oci.cloudBridgeAssetSource.CloudBridgeAssetSourceReplicationCredentials")]
    public interface ICloudBridgeAssetSourceReplicationCredentials
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset_source#secret_id CloudBridgeAssetSource#secret_id}.</summary>
        [JsiiProperty(name: "secretId", typeJson: "{\"primitive\":\"string\"}")]
        string SecretId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset_source#type CloudBridgeAssetSource#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudBridgeAssetSourceReplicationCredentials), fullyQualifiedName: "oci.cloudBridgeAssetSource.CloudBridgeAssetSourceReplicationCredentials")]
        internal sealed class _Proxy : DeputyBase, oci.CloudBridgeAssetSource.ICloudBridgeAssetSourceReplicationCredentials
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset_source#secret_id CloudBridgeAssetSource#secret_id}.</summary>
            [JsiiProperty(name: "secretId", typeJson: "{\"primitive\":\"string\"}")]
            public string SecretId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset_source#type CloudBridgeAssetSource#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
