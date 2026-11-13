using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CognitiveAccountProjectConnectionEntraId
{
    [JsiiByValue(fqn: "azurerm.cognitiveAccountProjectConnectionEntraId.CognitiveAccountProjectConnectionEntraIdTimeouts")]
    public class CognitiveAccountProjectConnectionEntraIdTimeouts : azurerm.CognitiveAccountProjectConnectionEntraId.ICognitiveAccountProjectConnectionEntraIdTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.14.0/docs/resources/cognitive_account_project_connection_entra_id#create CognitiveAccountProjectConnectionEntraId#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.14.0/docs/resources/cognitive_account_project_connection_entra_id#delete CognitiveAccountProjectConnectionEntraId#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.14.0/docs/resources/cognitive_account_project_connection_entra_id#read CognitiveAccountProjectConnectionEntraId#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.14.0/docs/resources/cognitive_account_project_connection_entra_id#update CognitiveAccountProjectConnectionEntraId#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
