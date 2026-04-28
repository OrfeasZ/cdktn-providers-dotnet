using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.JobDefinition
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.jobDefinition.JobDefinitionSecretReference")]
    public class JobDefinitionSecretReference : scaleway.JobDefinition.IJobDefinitionSecretReference
    {
        /// <summary>The secret unique identifier, it could be formatted as region/UUID or UUID.</summary>
        /// <remarks>
        /// In case the region is passed, it must be the same as the job definition.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/job_definition#secret_id JobDefinition#secret_id}
        /// </remarks>
        [JsiiProperty(name: "secretId", typeJson: "{\"primitive\":\"string\"}")]
        public string SecretId
        {
            get;
            set;
        }

        /// <summary>An environment variable containing the secret value.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/job_definition#environment JobDefinition#environment}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "environment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Environment
        {
            get;
            set;
        }

        /// <summary>The absolute file path where the secret will be mounted.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/job_definition#file JobDefinition#file}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "file", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? File
        {
            get;
            set;
        }

        /// <summary>The secret version.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/job_definition#secret_version JobDefinition#secret_version}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secretVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecretVersion
        {
            get;
            set;
        }
    }
}
