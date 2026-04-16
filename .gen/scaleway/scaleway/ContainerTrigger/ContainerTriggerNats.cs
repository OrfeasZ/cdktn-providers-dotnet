using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.ContainerTrigger
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.containerTrigger.ContainerTriggerNats")]
    public class ContainerTriggerNats : scaleway.ContainerTrigger.IContainerTriggerNats
    {
        /// <summary>Subject to listen to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/container_trigger#subject ContainerTrigger#subject}
        /// </remarks>
        [JsiiProperty(name: "subject", typeJson: "{\"primitive\":\"string\"}")]
        public string Subject
        {
            get;
            set;
        }

        /// <summary>ID of the mnq nats account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/container_trigger#account_id ContainerTrigger#account_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AccountId
        {
            get;
            set;
        }

        /// <summary>Project ID of the project where the mnq sqs exists, defaults to provider project_id.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/container_trigger#project_id ContainerTrigger#project_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ProjectId
        {
            get;
            set;
        }

        /// <summary>Region where the mnq sqs exists, defaults to function's region.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/container_trigger#region ContainerTrigger#region}
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
