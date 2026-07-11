using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.FluidRelayServer
{
    [JsiiInterface(nativeType: typeof(IFluidRelayServerCustomerManagedKey), fullyQualifiedName: "azurerm.fluidRelayServer.FluidRelayServerCustomerManagedKey")]
    public interface IFluidRelayServerCustomerManagedKey
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/fluid_relay_server#key_vault_key_id FluidRelayServer#key_vault_key_id}.</summary>
        [JsiiProperty(name: "keyVaultKeyId", typeJson: "{\"primitive\":\"string\"}")]
        string KeyVaultKeyId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/fluid_relay_server#user_assigned_identity_id FluidRelayServer#user_assigned_identity_id}.</summary>
        [JsiiProperty(name: "userAssignedIdentityId", typeJson: "{\"primitive\":\"string\"}")]
        string UserAssignedIdentityId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IFluidRelayServerCustomerManagedKey), fullyQualifiedName: "azurerm.fluidRelayServer.FluidRelayServerCustomerManagedKey")]
        internal sealed class _Proxy : DeputyBase, azurerm.FluidRelayServer.IFluidRelayServerCustomerManagedKey
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/fluid_relay_server#key_vault_key_id FluidRelayServer#key_vault_key_id}.</summary>
            [JsiiProperty(name: "keyVaultKeyId", typeJson: "{\"primitive\":\"string\"}")]
            public string KeyVaultKeyId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/fluid_relay_server#user_assigned_identity_id FluidRelayServer#user_assigned_identity_id}.</summary>
            [JsiiProperty(name: "userAssignedIdentityId", typeJson: "{\"primitive\":\"string\"}")]
            public string UserAssignedIdentityId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
