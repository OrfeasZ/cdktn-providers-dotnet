using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudBridgeAsset
{
    [JsiiInterface(nativeType: typeof(ICloudBridgeAssetAwsEc2Cost), fullyQualifiedName: "oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2Cost")]
    public interface ICloudBridgeAssetAwsEc2Cost
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/cloud_bridge_asset#amount CloudBridgeAsset#amount}.</summary>
        [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Amount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/cloud_bridge_asset#currency_code CloudBridgeAsset#currency_code}.</summary>
        [JsiiProperty(name: "currencyCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CurrencyCode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudBridgeAssetAwsEc2Cost), fullyQualifiedName: "oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2Cost")]
        internal sealed class _Proxy : DeputyBase, oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2Cost
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/cloud_bridge_asset#amount CloudBridgeAsset#amount}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Amount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/cloud_bridge_asset#currency_code CloudBridgeAsset#currency_code}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "currencyCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CurrencyCode
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
