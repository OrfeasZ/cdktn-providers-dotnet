using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AiFoundry
{
    [JsiiByValue(fqn: "azurerm.aiFoundry.AiFoundryManagedNetwork")]
    public class AiFoundryManagedNetwork : azurerm.AiFoundry.IAiFoundryManagedNetwork
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/ai_foundry#isolation_mode AiFoundry#isolation_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isolationMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IsolationMode
        {
            get;
            set;
        }
    }
}
