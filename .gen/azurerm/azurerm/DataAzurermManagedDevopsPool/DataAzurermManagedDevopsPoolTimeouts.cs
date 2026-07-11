using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermManagedDevopsPool
{
    [JsiiByValue(fqn: "azurerm.dataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolTimeouts")]
    public class DataAzurermManagedDevopsPoolTimeouts : azurerm.DataAzurermManagedDevopsPool.IDataAzurermManagedDevopsPoolTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/data-sources/managed_devops_pool#read DataAzurermManagedDevopsPool#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
