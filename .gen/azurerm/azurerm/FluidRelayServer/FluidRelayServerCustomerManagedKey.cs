using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.FluidRelayServer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.fluidRelayServer.FluidRelayServerCustomerManagedKey")]
    public class FluidRelayServerCustomerManagedKey : azurerm.FluidRelayServer.IFluidRelayServerCustomerManagedKey
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/fluid_relay_server#key_vault_key_id FluidRelayServer#key_vault_key_id}.</summary>
        [JsiiProperty(name: "keyVaultKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public string KeyVaultKeyId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/fluid_relay_server#user_assigned_identity_id FluidRelayServer#user_assigned_identity_id}.</summary>
        [JsiiProperty(name: "userAssignedIdentityId", typeJson: "{\"primitive\":\"string\"}")]
        public string UserAssignedIdentityId
        {
            get;
            set;
        }
    }
}
