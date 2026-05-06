using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.KmsVault
{
    [JsiiInterface(nativeType: typeof(IKmsVaultExternalKeyManagerMetadataOauthMetadata), fullyQualifiedName: "oci.kmsVault.KmsVaultExternalKeyManagerMetadataOauthMetadata")]
    public interface IKmsVaultExternalKeyManagerMetadataOauthMetadata
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_vault#client_app_id KmsVault#client_app_id}.</summary>
        [JsiiProperty(name: "clientAppId", typeJson: "{\"primitive\":\"string\"}")]
        string ClientAppId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_vault#client_app_secret KmsVault#client_app_secret}.</summary>
        [JsiiProperty(name: "clientAppSecret", typeJson: "{\"primitive\":\"string\"}")]
        string ClientAppSecret
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_vault#idcs_account_name_url KmsVault#idcs_account_name_url}.</summary>
        [JsiiProperty(name: "idcsAccountNameUrl", typeJson: "{\"primitive\":\"string\"}")]
        string IdcsAccountNameUrl
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKmsVaultExternalKeyManagerMetadataOauthMetadata), fullyQualifiedName: "oci.kmsVault.KmsVaultExternalKeyManagerMetadataOauthMetadata")]
        internal sealed class _Proxy : DeputyBase, oci.KmsVault.IKmsVaultExternalKeyManagerMetadataOauthMetadata
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_vault#client_app_id KmsVault#client_app_id}.</summary>
            [JsiiProperty(name: "clientAppId", typeJson: "{\"primitive\":\"string\"}")]
            public string ClientAppId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_vault#client_app_secret KmsVault#client_app_secret}.</summary>
            [JsiiProperty(name: "clientAppSecret", typeJson: "{\"primitive\":\"string\"}")]
            public string ClientAppSecret
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_vault#idcs_account_name_url KmsVault#idcs_account_name_url}.</summary>
            [JsiiProperty(name: "idcsAccountNameUrl", typeJson: "{\"primitive\":\"string\"}")]
            public string IdcsAccountNameUrl
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
