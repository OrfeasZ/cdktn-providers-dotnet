using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsDeployArtifact
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.devopsDeployArtifact.DevopsDeployArtifactDeployArtifactSourceHelmVerificationKeySource")]
    public class DevopsDeployArtifactDeployArtifactSourceHelmVerificationKeySource : oci.DevopsDeployArtifact.IDevopsDeployArtifactDeployArtifactSourceHelmVerificationKeySource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_artifact#verification_key_source_type DevopsDeployArtifact#verification_key_source_type}.</summary>
        [JsiiProperty(name: "verificationKeySourceType", typeJson: "{\"primitive\":\"string\"}")]
        public string VerificationKeySourceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_artifact#current_public_key DevopsDeployArtifact#current_public_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "currentPublicKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CurrentPublicKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_artifact#previous_public_key DevopsDeployArtifact#previous_public_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "previousPublicKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PreviousPublicKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_artifact#vault_secret_id DevopsDeployArtifact#vault_secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vaultSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VaultSecretId
        {
            get;
            set;
        }
    }
}
