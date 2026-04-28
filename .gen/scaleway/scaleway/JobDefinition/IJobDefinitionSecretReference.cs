using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.JobDefinition
{
    [JsiiInterface(nativeType: typeof(IJobDefinitionSecretReference), fullyQualifiedName: "scaleway.jobDefinition.JobDefinitionSecretReference")]
    public interface IJobDefinitionSecretReference
    {
        /// <summary>The secret unique identifier, it could be formatted as region/UUID or UUID.</summary>
        /// <remarks>
        /// In case the region is passed, it must be the same as the job definition.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/job_definition#secret_id JobDefinition#secret_id}
        /// </remarks>
        [JsiiProperty(name: "secretId", typeJson: "{\"primitive\":\"string\"}")]
        string SecretId
        {
            get;
        }

        /// <summary>An environment variable containing the secret value.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/job_definition#environment JobDefinition#environment}
        /// </remarks>
        [JsiiProperty(name: "environment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Environment
        {
            get
            {
                return null;
            }
        }

        /// <summary>The absolute file path where the secret will be mounted.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/job_definition#file JobDefinition#file}
        /// </remarks>
        [JsiiProperty(name: "file", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? File
        {
            get
            {
                return null;
            }
        }

        /// <summary>The secret version.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/job_definition#secret_version JobDefinition#secret_version}
        /// </remarks>
        [JsiiProperty(name: "secretVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SecretVersion
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IJobDefinitionSecretReference), fullyQualifiedName: "scaleway.jobDefinition.JobDefinitionSecretReference")]
        internal sealed class _Proxy : DeputyBase, scaleway.JobDefinition.IJobDefinitionSecretReference
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The secret unique identifier, it could be formatted as region/UUID or UUID.</summary>
            /// <remarks>
            /// In case the region is passed, it must be the same as the job definition.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/job_definition#secret_id JobDefinition#secret_id}
            /// </remarks>
            [JsiiProperty(name: "secretId", typeJson: "{\"primitive\":\"string\"}")]
            public string SecretId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>An environment variable containing the secret value.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/job_definition#environment JobDefinition#environment}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "environment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Environment
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The absolute file path where the secret will be mounted.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/job_definition#file JobDefinition#file}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "file", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? File
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The secret version.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/job_definition#secret_version JobDefinition#secret_version}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "secretVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SecretVersion
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
