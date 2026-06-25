using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudBridgeAsset
{
    [JsiiByValue(fqn: "oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2Cost")]
    public class CloudBridgeAssetAwsEc2Cost : oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2Cost
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/cloud_bridge_asset#amount CloudBridgeAsset#amount}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Amount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/cloud_bridge_asset#currency_code CloudBridgeAsset#currency_code}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "currencyCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CurrencyCode
        {
            get;
            set;
        }
    }
}
