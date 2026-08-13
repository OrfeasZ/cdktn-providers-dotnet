using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermNetappVolumeBucketWithServer
{
    [JsiiByValue(fqn: "azurerm.dataAzurermNetappVolumeBucketWithServer.DataAzurermNetappVolumeBucketWithServerTimeouts")]
    public class DataAzurermNetappVolumeBucketWithServerTimeouts : azurerm.DataAzurermNetappVolumeBucketWithServer.IDataAzurermNetappVolumeBucketWithServerTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/data-sources/netapp_volume_bucket_with_server#read DataAzurermNetappVolumeBucketWithServer#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
