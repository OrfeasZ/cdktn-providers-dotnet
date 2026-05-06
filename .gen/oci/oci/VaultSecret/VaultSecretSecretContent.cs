using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.VaultSecret
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.vaultSecret.VaultSecretSecretContent")]
    public class VaultSecretSecretContent : oci.VaultSecret.IVaultSecretSecretContent
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vault_secret#content_type VaultSecret#content_type}.</summary>
        [JsiiProperty(name: "contentType", typeJson: "{\"primitive\":\"string\"}")]
        public string ContentType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vault_secret#content VaultSecret#content}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Content
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vault_secret#name VaultSecret#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vault_secret#stage VaultSecret#stage}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "stage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Stage
        {
            get;
            set;
        }
    }
}
