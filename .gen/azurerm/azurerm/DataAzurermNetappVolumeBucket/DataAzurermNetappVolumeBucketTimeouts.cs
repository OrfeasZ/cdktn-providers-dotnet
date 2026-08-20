using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermNetappVolumeBucket
{
    [JsiiByValue(fqn: "azurerm.dataAzurermNetappVolumeBucket.DataAzurermNetappVolumeBucketTimeouts")]
    public class DataAzurermNetappVolumeBucketTimeouts : azurerm.DataAzurermNetappVolumeBucket.IDataAzurermNetappVolumeBucketTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/data-sources/netapp_volume_bucket#read DataAzurermNetappVolumeBucket#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
