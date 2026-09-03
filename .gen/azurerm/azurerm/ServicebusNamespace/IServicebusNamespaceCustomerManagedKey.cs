using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ServicebusNamespace
{
    [JsiiInterface(nativeType: typeof(IServicebusNamespaceCustomerManagedKey), fullyQualifiedName: "azurerm.servicebusNamespace.ServicebusNamespaceCustomerManagedKey")]
    public interface IServicebusNamespaceCustomerManagedKey
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/servicebus_namespace#identity_id ServicebusNamespace#identity_id}.</summary>
        [JsiiProperty(name: "identityId", typeJson: "{\"primitive\":\"string\"}")]
        string IdentityId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/servicebus_namespace#key_vault_key_id ServicebusNamespace#key_vault_key_id}.</summary>
        [JsiiProperty(name: "keyVaultKeyId", typeJson: "{\"primitive\":\"string\"}")]
        string KeyVaultKeyId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/servicebus_namespace#infrastructure_encryption_enabled ServicebusNamespace#infrastructure_encryption_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "infrastructureEncryptionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? InfrastructureEncryptionEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IServicebusNamespaceCustomerManagedKey), fullyQualifiedName: "azurerm.servicebusNamespace.ServicebusNamespaceCustomerManagedKey")]
        internal sealed class _Proxy : DeputyBase, azurerm.ServicebusNamespace.IServicebusNamespaceCustomerManagedKey
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/servicebus_namespace#identity_id ServicebusNamespace#identity_id}.</summary>
            [JsiiProperty(name: "identityId", typeJson: "{\"primitive\":\"string\"}")]
            public string IdentityId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/servicebus_namespace#key_vault_key_id ServicebusNamespace#key_vault_key_id}.</summary>
            [JsiiProperty(name: "keyVaultKeyId", typeJson: "{\"primitive\":\"string\"}")]
            public string KeyVaultKeyId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/servicebus_namespace#infrastructure_encryption_enabled ServicebusNamespace#infrastructure_encryption_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "infrastructureEncryptionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? InfrastructureEncryptionEnabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
