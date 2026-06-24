using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsDaemonTaskDefinition
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ecsDaemonTaskDefinition.EcsDaemonTaskDefinitionContainerDefinitionDependsOn")]
    public class EcsDaemonTaskDefinitionContainerDefinitionDependsOn : aws.EcsDaemonTaskDefinition.IEcsDaemonTaskDefinitionContainerDefinitionDependsOn
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.52.0/docs/resources/ecs_daemon_task_definition#condition EcsDaemonTaskDefinition#condition}.</summary>
        [JsiiProperty(name: "condition", typeJson: "{\"primitive\":\"string\"}")]
        public string Condition
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.52.0/docs/resources/ecs_daemon_task_definition#container_name EcsDaemonTaskDefinition#container_name}.</summary>
        [JsiiProperty(name: "containerName", typeJson: "{\"primitive\":\"string\"}")]
        public string ContainerName
        {
            get;
            set;
        }
    }
}
