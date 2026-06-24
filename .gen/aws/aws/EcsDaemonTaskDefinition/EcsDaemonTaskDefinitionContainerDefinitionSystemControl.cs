using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsDaemonTaskDefinition
{
    [JsiiByValue(fqn: "aws.ecsDaemonTaskDefinition.EcsDaemonTaskDefinitionContainerDefinitionSystemControl")]
    public class EcsDaemonTaskDefinitionContainerDefinitionSystemControl : aws.EcsDaemonTaskDefinition.IEcsDaemonTaskDefinitionContainerDefinitionSystemControl
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.52.0/docs/resources/ecs_daemon_task_definition#namespace EcsDaemonTaskDefinition#namespace}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Namespace
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.52.0/docs/resources/ecs_daemon_task_definition#value EcsDaemonTaskDefinition#value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Value
        {
            get;
            set;
        }
    }
}
