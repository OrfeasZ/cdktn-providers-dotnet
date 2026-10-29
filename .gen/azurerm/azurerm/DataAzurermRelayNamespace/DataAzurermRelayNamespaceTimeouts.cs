using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermRelayNamespace
{
    [JsiiByValue(fqn: "azurerm.dataAzurermRelayNamespace.DataAzurermRelayNamespaceTimeouts")]
    public class DataAzurermRelayNamespaceTimeouts : azurerm.DataAzurermRelayNamespace.IDataAzurermRelayNamespaceTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.12.0/docs/data-sources/relay_namespace#read DataAzurermRelayNamespace#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
