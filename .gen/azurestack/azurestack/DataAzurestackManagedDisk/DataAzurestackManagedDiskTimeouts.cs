using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.DataAzurestackManagedDisk
{
    [JsiiByValue(fqn: "azurestack.dataAzurestackManagedDisk.DataAzurestackManagedDiskTimeouts")]
    public class DataAzurestackManagedDiskTimeouts : azurestack.DataAzurestackManagedDisk.IDataAzurestackManagedDiskTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/data-sources/managed_disk#read DataAzurestackManagedDisk#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
