using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OpsiDatabaseInsight
{
    [JsiiInterface(nativeType: typeof(IOpsiDatabaseInsightConnectionCredentialDetails), fullyQualifiedName: "oci.opsiDatabaseInsight.OpsiDatabaseInsightConnectionCredentialDetails")]
    public interface IOpsiDatabaseInsightConnectionCredentialDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#credential_type OpsiDatabaseInsight#credential_type}.</summary>
        [JsiiProperty(name: "credentialType", typeJson: "{\"primitive\":\"string\"}")]
        string CredentialType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#credential_source_name OpsiDatabaseInsight#credential_source_name}.</summary>
        [JsiiProperty(name: "credentialSourceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CredentialSourceName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#named_credential_id OpsiDatabaseInsight#named_credential_id}.</summary>
        [JsiiProperty(name: "namedCredentialId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NamedCredentialId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#password_secret_id OpsiDatabaseInsight#password_secret_id}.</summary>
        [JsiiProperty(name: "passwordSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PasswordSecretId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#role OpsiDatabaseInsight#role}.</summary>
        [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Role
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#user_name OpsiDatabaseInsight#user_name}.</summary>
        [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOpsiDatabaseInsightConnectionCredentialDetails), fullyQualifiedName: "oci.opsiDatabaseInsight.OpsiDatabaseInsightConnectionCredentialDetails")]
        internal sealed class _Proxy : DeputyBase, oci.OpsiDatabaseInsight.IOpsiDatabaseInsightConnectionCredentialDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#credential_type OpsiDatabaseInsight#credential_type}.</summary>
            [JsiiProperty(name: "credentialType", typeJson: "{\"primitive\":\"string\"}")]
            public string CredentialType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#credential_source_name OpsiDatabaseInsight#credential_source_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "credentialSourceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CredentialSourceName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#named_credential_id OpsiDatabaseInsight#named_credential_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "namedCredentialId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NamedCredentialId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#password_secret_id OpsiDatabaseInsight#password_secret_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "passwordSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PasswordSecretId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#role OpsiDatabaseInsight#role}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Role
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#user_name OpsiDatabaseInsight#user_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
