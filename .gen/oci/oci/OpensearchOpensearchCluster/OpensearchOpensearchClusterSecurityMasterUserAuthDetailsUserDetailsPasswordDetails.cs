using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OpensearchOpensearchCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.opensearchOpensearchCluster.OpensearchOpensearchClusterSecurityMasterUserAuthDetailsUserDetailsPasswordDetails")]
    public class OpensearchOpensearchClusterSecurityMasterUserAuthDetailsUserDetailsPasswordDetails : oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterSecurityMasterUserAuthDetailsUserDetailsPasswordDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/opensearch_opensearch_cluster#source_type OpensearchOpensearchCluster#source_type}.</summary>
        [JsiiProperty(name: "sourceType", typeJson: "{\"primitive\":\"string\"}")]
        public string SourceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/opensearch_opensearch_cluster#plain_password OpensearchOpensearchCluster#plain_password}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "plainPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PlainPassword
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/opensearch_opensearch_cluster#vault_secret_id OpensearchOpensearchCluster#vault_secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vaultSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VaultSecretId
        {
            get;
            set;
        }
    }
}
