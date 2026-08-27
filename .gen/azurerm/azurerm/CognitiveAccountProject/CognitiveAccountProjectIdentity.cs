using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CognitiveAccountProject
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.cognitiveAccountProject.CognitiveAccountProjectIdentity")]
    public class CognitiveAccountProjectIdentity : azurerm.CognitiveAccountProject.ICognitiveAccountProjectIdentity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cognitive_account_project#type CognitiveAccountProject#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cognitive_account_project#identity_ids CognitiveAccountProject#identity_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "identityIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? IdentityIds
        {
            get;
            set;
        }
    }
}
