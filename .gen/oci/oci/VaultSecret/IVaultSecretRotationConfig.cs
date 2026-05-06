using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.VaultSecret
{
    [JsiiInterface(nativeType: typeof(IVaultSecretRotationConfig), fullyQualifiedName: "oci.vaultSecret.VaultSecretRotationConfig")]
    public interface IVaultSecretRotationConfig
    {
        /// <summary>target_system_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vault_secret#target_system_details VaultSecret#target_system_details}
        /// </remarks>
        [JsiiProperty(name: "targetSystemDetails", typeJson: "{\"fqn\":\"oci.vaultSecret.VaultSecretRotationConfigTargetSystemDetails\"}")]
        oci.VaultSecret.IVaultSecretRotationConfigTargetSystemDetails TargetSystemDetails
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vault_secret#is_scheduled_rotation_enabled VaultSecret#is_scheduled_rotation_enabled}.</summary>
        [JsiiProperty(name: "isScheduledRotationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsScheduledRotationEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vault_secret#rotation_interval VaultSecret#rotation_interval}.</summary>
        [JsiiProperty(name: "rotationInterval", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RotationInterval
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVaultSecretRotationConfig), fullyQualifiedName: "oci.vaultSecret.VaultSecretRotationConfig")]
        internal sealed class _Proxy : DeputyBase, oci.VaultSecret.IVaultSecretRotationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>target_system_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vault_secret#target_system_details VaultSecret#target_system_details}
            /// </remarks>
            [JsiiProperty(name: "targetSystemDetails", typeJson: "{\"fqn\":\"oci.vaultSecret.VaultSecretRotationConfigTargetSystemDetails\"}")]
            public oci.VaultSecret.IVaultSecretRotationConfigTargetSystemDetails TargetSystemDetails
            {
                get => GetInstanceProperty<oci.VaultSecret.IVaultSecretRotationConfigTargetSystemDetails>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vault_secret#is_scheduled_rotation_enabled VaultSecret#is_scheduled_rotation_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isScheduledRotationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsScheduledRotationEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vault_secret#rotation_interval VaultSecret#rotation_interval}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "rotationInterval", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RotationInterval
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
