using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsDeployArtifact
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.devopsDeployArtifact.DevopsDeployArtifactDeployArtifactSource")]
    public class DevopsDeployArtifactDeployArtifactSource : oci.DevopsDeployArtifact.IDevopsDeployArtifactDeployArtifactSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_artifact#deploy_artifact_source_type DevopsDeployArtifact#deploy_artifact_source_type}.</summary>
        [JsiiProperty(name: "deployArtifactSourceType", typeJson: "{\"primitive\":\"string\"}")]
        public string DeployArtifactSourceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_artifact#base64encoded_content DevopsDeployArtifact#base64encoded_content}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "base64EncodedContent", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Base64EncodedContent
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_artifact#chart_url DevopsDeployArtifact#chart_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "chartUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ChartUrl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_artifact#deploy_artifact_path DevopsDeployArtifact#deploy_artifact_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deployArtifactPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DeployArtifactPath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_artifact#deploy_artifact_version DevopsDeployArtifact#deploy_artifact_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deployArtifactVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DeployArtifactVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_artifact#helm_artifact_source_type DevopsDeployArtifact#helm_artifact_source_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "helmArtifactSourceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HelmArtifactSourceType
        {
            get;
            set;
        }

        /// <summary>helm_verification_key_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_artifact#helm_verification_key_source DevopsDeployArtifact#helm_verification_key_source}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "helmVerificationKeySource", typeJson: "{\"fqn\":\"oci.devopsDeployArtifact.DevopsDeployArtifactDeployArtifactSourceHelmVerificationKeySource\"}", isOptional: true)]
        public oci.DevopsDeployArtifact.IDevopsDeployArtifactDeployArtifactSourceHelmVerificationKeySource? HelmVerificationKeySource
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_artifact#image_digest DevopsDeployArtifact#image_digest}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "imageDigest", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ImageDigest
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_artifact#image_uri DevopsDeployArtifact#image_uri}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "imageUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ImageUri
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_artifact#repository_id DevopsDeployArtifact#repository_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "repositoryId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RepositoryId
        {
            get;
            set;
        }
    }
}
