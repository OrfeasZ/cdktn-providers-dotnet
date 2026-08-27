using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AiFoundry
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.aiFoundry.AiFoundryEncryption")]
    public class AiFoundryEncryption : azurerm.AiFoundry.IAiFoundryEncryption
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/ai_foundry#key_id AiFoundry#key_id}.</summary>
        [JsiiProperty(name: "keyId", typeJson: "{\"primitive\":\"string\"}")]
        public string KeyId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/ai_foundry#key_vault_id AiFoundry#key_vault_id}.</summary>
        [JsiiProperty(name: "keyVaultId", typeJson: "{\"primitive\":\"string\"}")]
        public string KeyVaultId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/ai_foundry#user_assigned_identity_id AiFoundry#user_assigned_identity_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "userAssignedIdentityId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UserAssignedIdentityId
        {
            get;
            set;
        }
    }
}
