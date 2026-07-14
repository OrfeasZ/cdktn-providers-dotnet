using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CognitiveAccountConnectionAccountManagedIdentity
{
    [JsiiByValue(fqn: "azurerm.cognitiveAccountConnectionAccountManagedIdentity.CognitiveAccountConnectionAccountManagedIdentityTimeouts")]
    public class CognitiveAccountConnectionAccountManagedIdentityTimeouts : azurerm.CognitiveAccountConnectionAccountManagedIdentity.ICognitiveAccountConnectionAccountManagedIdentityTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/cognitive_account_connection_account_managed_identity#create CognitiveAccountConnectionAccountManagedIdentity#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/cognitive_account_connection_account_managed_identity#delete CognitiveAccountConnectionAccountManagedIdentity#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/cognitive_account_connection_account_managed_identity#read CognitiveAccountConnectionAccountManagedIdentity#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/cognitive_account_connection_account_managed_identity#update CognitiveAccountConnectionAccountManagedIdentity#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
