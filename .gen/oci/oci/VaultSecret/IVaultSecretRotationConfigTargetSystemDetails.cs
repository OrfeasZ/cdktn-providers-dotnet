using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.VaultSecret
{
    [JsiiInterface(nativeType: typeof(IVaultSecretRotationConfigTargetSystemDetails), fullyQualifiedName: "oci.vaultSecret.VaultSecretRotationConfigTargetSystemDetails")]
    public interface IVaultSecretRotationConfigTargetSystemDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vault_secret#target_system_type VaultSecret#target_system_type}.</summary>
        [JsiiProperty(name: "targetSystemType", typeJson: "{\"primitive\":\"string\"}")]
        string TargetSystemType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vault_secret#adb_id VaultSecret#adb_id}.</summary>
        [JsiiProperty(name: "adbId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AdbId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vault_secret#function_id VaultSecret#function_id}.</summary>
        [JsiiProperty(name: "functionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FunctionId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVaultSecretRotationConfigTargetSystemDetails), fullyQualifiedName: "oci.vaultSecret.VaultSecretRotationConfigTargetSystemDetails")]
        internal sealed class _Proxy : DeputyBase, oci.VaultSecret.IVaultSecretRotationConfigTargetSystemDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vault_secret#target_system_type VaultSecret#target_system_type}.</summary>
            [JsiiProperty(name: "targetSystemType", typeJson: "{\"primitive\":\"string\"}")]
            public string TargetSystemType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vault_secret#adb_id VaultSecret#adb_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "adbId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AdbId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vault_secret#function_id VaultSecret#function_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "functionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FunctionId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
