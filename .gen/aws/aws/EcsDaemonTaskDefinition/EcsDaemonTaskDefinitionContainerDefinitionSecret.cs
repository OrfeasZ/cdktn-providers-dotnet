using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsDaemonTaskDefinition
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ecsDaemonTaskDefinition.EcsDaemonTaskDefinitionContainerDefinitionSecret")]
    public class EcsDaemonTaskDefinitionContainerDefinitionSecret : aws.EcsDaemonTaskDefinition.IEcsDaemonTaskDefinitionContainerDefinitionSecret
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/ecs_daemon_task_definition#name EcsDaemonTaskDefinition#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/ecs_daemon_task_definition#value_from EcsDaemonTaskDefinition#value_from}.</summary>
        [JsiiProperty(name: "valueFrom", typeJson: "{\"primitive\":\"string\"}")]
        public string ValueFrom
        {
            get;
            set;
        }
    }
}
