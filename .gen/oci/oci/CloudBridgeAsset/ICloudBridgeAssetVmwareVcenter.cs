using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudBridgeAsset
{
    [JsiiInterface(nativeType: typeof(ICloudBridgeAssetVmwareVcenter), fullyQualifiedName: "oci.cloudBridgeAsset.CloudBridgeAssetVmwareVcenter")]
    public interface ICloudBridgeAssetVmwareVcenter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#data_center CloudBridgeAsset#data_center}.</summary>
        [JsiiProperty(name: "dataCenter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DataCenter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#vcenter_key CloudBridgeAsset#vcenter_key}.</summary>
        [JsiiProperty(name: "vcenterKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VcenterKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#vcenter_version CloudBridgeAsset#vcenter_version}.</summary>
        [JsiiProperty(name: "vcenterVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VcenterVersion
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudBridgeAssetVmwareVcenter), fullyQualifiedName: "oci.cloudBridgeAsset.CloudBridgeAssetVmwareVcenter")]
        internal sealed class _Proxy : DeputyBase, oci.CloudBridgeAsset.ICloudBridgeAssetVmwareVcenter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#data_center CloudBridgeAsset#data_center}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dataCenter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DataCenter
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#vcenter_key CloudBridgeAsset#vcenter_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vcenterKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VcenterKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#vcenter_version CloudBridgeAsset#vcenter_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vcenterVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VcenterVersion
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
