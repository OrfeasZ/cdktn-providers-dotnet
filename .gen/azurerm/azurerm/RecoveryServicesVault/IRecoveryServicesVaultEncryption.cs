using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.RecoveryServicesVault
{
    [JsiiInterface(nativeType: typeof(IRecoveryServicesVaultEncryption), fullyQualifiedName: "azurerm.recoveryServicesVault.RecoveryServicesVaultEncryption")]
    public interface IRecoveryServicesVaultEncryption
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/recovery_services_vault#infrastructure_encryption_enabled RecoveryServicesVault#infrastructure_encryption_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "infrastructureEncryptionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object InfrastructureEncryptionEnabled
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/recovery_services_vault#key_id RecoveryServicesVault#key_id}.</summary>
        [JsiiProperty(name: "keyId", typeJson: "{\"primitive\":\"string\"}")]
        string KeyId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/recovery_services_vault#user_assigned_identity_id RecoveryServicesVault#user_assigned_identity_id}.</summary>
        [JsiiProperty(name: "userAssignedIdentityId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserAssignedIdentityId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/recovery_services_vault#use_system_assigned_identity RecoveryServicesVault#use_system_assigned_identity}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "useSystemAssignedIdentity", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UseSystemAssignedIdentity
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRecoveryServicesVaultEncryption), fullyQualifiedName: "azurerm.recoveryServicesVault.RecoveryServicesVaultEncryption")]
        internal sealed class _Proxy : DeputyBase, azurerm.RecoveryServicesVault.IRecoveryServicesVaultEncryption
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/recovery_services_vault#infrastructure_encryption_enabled RecoveryServicesVault#infrastructure_encryption_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "infrastructureEncryptionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object InfrastructureEncryptionEnabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/recovery_services_vault#key_id RecoveryServicesVault#key_id}.</summary>
            [JsiiProperty(name: "keyId", typeJson: "{\"primitive\":\"string\"}")]
            public string KeyId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/recovery_services_vault#user_assigned_identity_id RecoveryServicesVault#user_assigned_identity_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "userAssignedIdentityId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserAssignedIdentityId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/recovery_services_vault#use_system_assigned_identity RecoveryServicesVault#use_system_assigned_identity}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "useSystemAssignedIdentity", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? UseSystemAssignedIdentity
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
