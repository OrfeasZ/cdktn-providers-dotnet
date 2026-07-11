using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermManagedDisks
{
    [JsiiByValue(fqn: "azurerm.dataAzurermManagedDisks.DataAzurermManagedDisksTimeouts")]
    public class DataAzurermManagedDisksTimeouts : azurerm.DataAzurermManagedDisks.IDataAzurermManagedDisksTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/data-sources/managed_disks#read DataAzurermManagedDisks#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
