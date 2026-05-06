using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.KmsVault
{
    [JsiiInterface(nativeType: typeof(IKmsVaultExternalKeyManagerMetadata), fullyQualifiedName: "oci.kmsVault.KmsVaultExternalKeyManagerMetadata")]
    public interface IKmsVaultExternalKeyManagerMetadata
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_vault#external_vault_endpoint_url KmsVault#external_vault_endpoint_url}.</summary>
        [JsiiProperty(name: "externalVaultEndpointUrl", typeJson: "{\"primitive\":\"string\"}")]
        string ExternalVaultEndpointUrl
        {
            get;
        }

        /// <summary>oauth_metadata block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_vault#oauth_metadata KmsVault#oauth_metadata}
        /// </remarks>
        [JsiiProperty(name: "oauthMetadata", typeJson: "{\"fqn\":\"oci.kmsVault.KmsVaultExternalKeyManagerMetadataOauthMetadata\"}")]
        oci.KmsVault.IKmsVaultExternalKeyManagerMetadataOauthMetadata OauthMetadata
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_vault#private_endpoint_id KmsVault#private_endpoint_id}.</summary>
        [JsiiProperty(name: "privateEndpointId", typeJson: "{\"primitive\":\"string\"}")]
        string PrivateEndpointId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKmsVaultExternalKeyManagerMetadata), fullyQualifiedName: "oci.kmsVault.KmsVaultExternalKeyManagerMetadata")]
        internal sealed class _Proxy : DeputyBase, oci.KmsVault.IKmsVaultExternalKeyManagerMetadata
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_vault#external_vault_endpoint_url KmsVault#external_vault_endpoint_url}.</summary>
            [JsiiProperty(name: "externalVaultEndpointUrl", typeJson: "{\"primitive\":\"string\"}")]
            public string ExternalVaultEndpointUrl
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>oauth_metadata block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_vault#oauth_metadata KmsVault#oauth_metadata}
            /// </remarks>
            [JsiiProperty(name: "oauthMetadata", typeJson: "{\"fqn\":\"oci.kmsVault.KmsVaultExternalKeyManagerMetadataOauthMetadata\"}")]
            public oci.KmsVault.IKmsVaultExternalKeyManagerMetadataOauthMetadata OauthMetadata
            {
                get => GetInstanceProperty<oci.KmsVault.IKmsVaultExternalKeyManagerMetadataOauthMetadata>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_vault#private_endpoint_id KmsVault#private_endpoint_id}.</summary>
            [JsiiProperty(name: "privateEndpointId", typeJson: "{\"primitive\":\"string\"}")]
            public string PrivateEndpointId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
