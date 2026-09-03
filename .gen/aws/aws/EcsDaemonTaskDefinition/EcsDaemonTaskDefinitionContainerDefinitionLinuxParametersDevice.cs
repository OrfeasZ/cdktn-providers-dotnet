using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsDaemonTaskDefinition
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ecsDaemonTaskDefinition.EcsDaemonTaskDefinitionContainerDefinitionLinuxParametersDevice")]
    public class EcsDaemonTaskDefinitionContainerDefinitionLinuxParametersDevice : aws.EcsDaemonTaskDefinition.IEcsDaemonTaskDefinitionContainerDefinitionLinuxParametersDevice
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/ecs_daemon_task_definition#host_path EcsDaemonTaskDefinition#host_path}.</summary>
        [JsiiProperty(name: "hostPath", typeJson: "{\"primitive\":\"string\"}")]
        public string HostPath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/ecs_daemon_task_definition#container_path EcsDaemonTaskDefinition#container_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "containerPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ContainerPath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/ecs_daemon_task_definition#permissions EcsDaemonTaskDefinition#permissions}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "permissions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Permissions
        {
            get;
            set;
        }
    }
}
