using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.ContainerTrigger
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.containerTrigger.ContainerTriggerSqs")]
    public class ContainerTriggerSqs : scaleway.ContainerTrigger.IContainerTriggerSqs
    {
        /// <summary>The access key for accessing the SQS queue.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.75.0/docs/resources/container_trigger#access_key ContainerTrigger#access_key}
        /// </remarks>
        [JsiiProperty(name: "accessKey", typeJson: "{\"primitive\":\"string\"}")]
        public string AccessKey
        {
            get;
            set;
        }

        /// <summary>Endpoint URL to use to access SQS (e.g., "https://sqs.mnq.fr-par.scaleway.com").</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.75.0/docs/resources/container_trigger#endpoint ContainerTrigger#endpoint}
        /// </remarks>
        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}")]
        public string Endpoint
        {
            get;
            set;
        }

        /// <summary>The URL of the SQS queue to monitor for messages.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.75.0/docs/resources/container_trigger#queue_url ContainerTrigger#queue_url}
        /// </remarks>
        [JsiiProperty(name: "queueUrl", typeJson: "{\"primitive\":\"string\"}")]
        public string QueueUrl
        {
            get;
            set;
        }

        /// <summary>The secret key for accessing the SQS queue.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.75.0/docs/resources/container_trigger#secret_key ContainerTrigger#secret_key}
        /// </remarks>
        [JsiiProperty(name: "secretKey", typeJson: "{\"primitive\":\"string\"}")]
        public string SecretKey
        {
            get;
            set;
        }

        /// <summary>Project ID of the project where the mnq sqs exists, defaults to provider project_id.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.75.0/docs/resources/container_trigger#project_id ContainerTrigger#project_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ProjectId
        {
            get;
            set;
        }

        /// <summary>Name of the queue.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.75.0/docs/resources/container_trigger#queue ContainerTrigger#queue}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "queue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Queue
        {
            get;
            set;
        }

        /// <summary>The region where the SQS queue is hosted, defaults to function's region.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.75.0/docs/resources/container_trigger#region ContainerTrigger#region}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Region
        {
            get;
            set;
        }
    }
}
