using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BatchJobDefinition
{
    [JsiiInterface(nativeType: typeof(IBatchJobDefinitionEksPropertiesPodProperties), fullyQualifiedName: "aws.batchJobDefinition.BatchJobDefinitionEksPropertiesPodProperties")]
    public interface IBatchJobDefinitionEksPropertiesPodProperties
    {
        /// <summary>containers block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/batch_job_definition#containers BatchJobDefinition#containers}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodPropertiesContainers" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "containers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.batchJobDefinition.BatchJobDefinitionEksPropertiesPodPropertiesContainers\"},\"kind\":\"array\"}}]}}")]
        object Containers
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/batch_job_definition#dns_policy BatchJobDefinition#dns_policy}.</summary>
        [JsiiProperty(name: "dnsPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DnsPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/batch_job_definition#host_network BatchJobDefinition#host_network}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "hostNetwork", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? HostNetwork
        {
            get
            {
                return null;
            }
        }

        /// <summary>image_pull_secret block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/batch_job_definition#image_pull_secret BatchJobDefinition#image_pull_secret}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodPropertiesImagePullSecret" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "imagePullSecret", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.batchJobDefinition.BatchJobDefinitionEksPropertiesPodPropertiesImagePullSecret\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ImagePullSecret
        {
            get
            {
                return null;
            }
        }

        /// <summary>init_containers block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/batch_job_definition#init_containers BatchJobDefinition#init_containers}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodPropertiesInitContainers" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "initContainers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.batchJobDefinition.BatchJobDefinitionEksPropertiesPodPropertiesInitContainers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? InitContainers
        {
            get
            {
                return null;
            }
        }

        /// <summary>metadata block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/batch_job_definition#metadata BatchJobDefinition#metadata}
        /// </remarks>
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"aws.batchJobDefinition.BatchJobDefinitionEksPropertiesPodPropertiesMetadata\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodPropertiesMetadata? Metadata
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/batch_job_definition#service_account_name BatchJobDefinition#service_account_name}.</summary>
        [JsiiProperty(name: "serviceAccountName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServiceAccountName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/batch_job_definition#share_process_namespace BatchJobDefinition#share_process_namespace}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "shareProcessNamespace", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ShareProcessNamespace
        {
            get
            {
                return null;
            }
        }

        /// <summary>volumes block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/batch_job_definition#volumes BatchJobDefinition#volumes}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodPropertiesVolumes" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "volumes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.batchJobDefinition.BatchJobDefinitionEksPropertiesPodPropertiesVolumes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Volumes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBatchJobDefinitionEksPropertiesPodProperties), fullyQualifiedName: "aws.batchJobDefinition.BatchJobDefinitionEksPropertiesPodProperties")]
        internal sealed class _Proxy : DeputyBase, aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodProperties
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>containers block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/batch_job_definition#containers BatchJobDefinition#containers}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodPropertiesContainers" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "containers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.batchJobDefinition.BatchJobDefinitionEksPropertiesPodPropertiesContainers\"},\"kind\":\"array\"}}]}}")]
            public object Containers
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/batch_job_definition#dns_policy BatchJobDefinition#dns_policy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dnsPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DnsPolicy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/batch_job_definition#host_network BatchJobDefinition#host_network}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hostNetwork", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? HostNetwork
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>image_pull_secret block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/batch_job_definition#image_pull_secret BatchJobDefinition#image_pull_secret}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodPropertiesImagePullSecret" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "imagePullSecret", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.batchJobDefinition.BatchJobDefinitionEksPropertiesPodPropertiesImagePullSecret\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ImagePullSecret
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>init_containers block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/batch_job_definition#init_containers BatchJobDefinition#init_containers}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodPropertiesInitContainers" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "initContainers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.batchJobDefinition.BatchJobDefinitionEksPropertiesPodPropertiesInitContainers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? InitContainers
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>metadata block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/batch_job_definition#metadata BatchJobDefinition#metadata}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"aws.batchJobDefinition.BatchJobDefinitionEksPropertiesPodPropertiesMetadata\"}", isOptional: true)]
            public aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodPropertiesMetadata? Metadata
            {
                get => GetInstanceProperty<aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodPropertiesMetadata?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/batch_job_definition#service_account_name BatchJobDefinition#service_account_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serviceAccountName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServiceAccountName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/batch_job_definition#share_process_namespace BatchJobDefinition#share_process_namespace}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "shareProcessNamespace", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ShareProcessNamespace
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>volumes block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/batch_job_definition#volumes BatchJobDefinition#volumes}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodPropertiesVolumes" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "volumes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.batchJobDefinition.BatchJobDefinitionEksPropertiesPodPropertiesVolumes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Volumes
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
