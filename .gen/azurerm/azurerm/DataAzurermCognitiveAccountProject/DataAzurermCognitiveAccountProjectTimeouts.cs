using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermCognitiveAccountProject
{
    [JsiiByValue(fqn: "azurerm.dataAzurermCognitiveAccountProject.DataAzurermCognitiveAccountProjectTimeouts")]
    public class DataAzurermCognitiveAccountProjectTimeouts : azurerm.DataAzurermCognitiveAccountProject.IDataAzurermCognitiveAccountProjectTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/data-sources/cognitive_account_project#read DataAzurermCognitiveAccountProject#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
