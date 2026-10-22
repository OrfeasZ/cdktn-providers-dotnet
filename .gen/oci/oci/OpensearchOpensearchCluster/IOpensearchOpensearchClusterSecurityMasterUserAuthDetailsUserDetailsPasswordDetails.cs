using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OpensearchOpensearchCluster
{
    [JsiiInterface(nativeType: typeof(IOpensearchOpensearchClusterSecurityMasterUserAuthDetailsUserDetailsPasswordDetails), fullyQualifiedName: "oci.opensearchOpensearchCluster.OpensearchOpensearchClusterSecurityMasterUserAuthDetailsUserDetailsPasswordDetails")]
    public interface IOpensearchOpensearchClusterSecurityMasterUserAuthDetailsUserDetailsPasswordDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/opensearch_opensearch_cluster#source_type OpensearchOpensearchCluster#source_type}.</summary>
        [JsiiProperty(name: "sourceType", typeJson: "{\"primitive\":\"string\"}")]
        string SourceType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/opensearch_opensearch_cluster#plain_password OpensearchOpensearchCluster#plain_password}.</summary>
        [JsiiProperty(name: "plainPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PlainPassword
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/opensearch_opensearch_cluster#vault_secret_id OpensearchOpensearchCluster#vault_secret_id}.</summary>
        [JsiiProperty(name: "vaultSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VaultSecretId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOpensearchOpensearchClusterSecurityMasterUserAuthDetailsUserDetailsPasswordDetails), fullyQualifiedName: "oci.opensearchOpensearchCluster.OpensearchOpensearchClusterSecurityMasterUserAuthDetailsUserDetailsPasswordDetails")]
        internal sealed class _Proxy : DeputyBase, oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterSecurityMasterUserAuthDetailsUserDetailsPasswordDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/opensearch_opensearch_cluster#source_type OpensearchOpensearchCluster#source_type}.</summary>
            [JsiiProperty(name: "sourceType", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/opensearch_opensearch_cluster#plain_password OpensearchOpensearchCluster#plain_password}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "plainPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PlainPassword
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/opensearch_opensearch_cluster#vault_secret_id OpensearchOpensearchCluster#vault_secret_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vaultSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VaultSecretId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
