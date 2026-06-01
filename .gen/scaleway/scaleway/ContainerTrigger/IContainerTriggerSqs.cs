using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.ContainerTrigger
{
    [JsiiInterface(nativeType: typeof(IContainerTriggerSqs), fullyQualifiedName: "scaleway.containerTrigger.ContainerTriggerSqs")]
    public interface IContainerTriggerSqs
    {
        /// <summary>The access key for accessing the SQS queue.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/container_trigger#access_key ContainerTrigger#access_key}
        /// </remarks>
        [JsiiProperty(name: "accessKey", typeJson: "{\"primitive\":\"string\"}")]
        string AccessKey
        {
            get;
        }

        /// <summary>Endpoint URL to use to access SQS (e.g., "https://sqs.mnq.fr-par.scaleway.com").</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/container_trigger#endpoint ContainerTrigger#endpoint}
        /// </remarks>
        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}")]
        string Endpoint
        {
            get;
        }

        /// <summary>The URL of the SQS queue to monitor for messages.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/container_trigger#queue_url ContainerTrigger#queue_url}
        /// </remarks>
        [JsiiProperty(name: "queueUrl", typeJson: "{\"primitive\":\"string\"}")]
        string QueueUrl
        {
            get;
        }

        /// <summary>The secret key for accessing the SQS queue.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/container_trigger#secret_key ContainerTrigger#secret_key}
        /// </remarks>
        [JsiiProperty(name: "secretKey", typeJson: "{\"primitive\":\"string\"}")]
        string SecretKey
        {
            get;
        }

        /// <summary>Project ID of the project where the mnq sqs exists, defaults to provider project_id.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/container_trigger#project_id ContainerTrigger#project_id}
        /// </remarks>
        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProjectId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Name of the queue.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/container_trigger#queue ContainerTrigger#queue}
        /// </remarks>
        [JsiiProperty(name: "queue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Queue
        {
            get
            {
                return null;
            }
        }

        /// <summary>The region where the SQS queue is hosted, defaults to function's region.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/container_trigger#region ContainerTrigger#region}
        /// </remarks>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Region
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerTriggerSqs), fullyQualifiedName: "scaleway.containerTrigger.ContainerTriggerSqs")]
        internal sealed class _Proxy : DeputyBase, scaleway.ContainerTrigger.IContainerTriggerSqs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The access key for accessing the SQS queue.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/container_trigger#access_key ContainerTrigger#access_key}
            /// </remarks>
            [JsiiProperty(name: "accessKey", typeJson: "{\"primitive\":\"string\"}")]
            public string AccessKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Endpoint URL to use to access SQS (e.g., "https://sqs.mnq.fr-par.scaleway.com").</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/container_trigger#endpoint ContainerTrigger#endpoint}
            /// </remarks>
            [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}")]
            public string Endpoint
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The URL of the SQS queue to monitor for messages.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/container_trigger#queue_url ContainerTrigger#queue_url}
            /// </remarks>
            [JsiiProperty(name: "queueUrl", typeJson: "{\"primitive\":\"string\"}")]
            public string QueueUrl
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The secret key for accessing the SQS queue.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/container_trigger#secret_key ContainerTrigger#secret_key}
            /// </remarks>
            [JsiiProperty(name: "secretKey", typeJson: "{\"primitive\":\"string\"}")]
            public string SecretKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Project ID of the project where the mnq sqs exists, defaults to provider project_id.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/container_trigger#project_id ContainerTrigger#project_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProjectId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Name of the queue.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/container_trigger#queue ContainerTrigger#queue}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "queue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Queue
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The region where the SQS queue is hosted, defaults to function's region.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/container_trigger#region ContainerTrigger#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
