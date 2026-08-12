using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsDaemonTaskDefinition
{
    [JsiiByValue(fqn: "aws.ecsDaemonTaskDefinition.EcsDaemonTaskDefinitionVolumeHost")]
    public class EcsDaemonTaskDefinitionVolumeHost : aws.EcsDaemonTaskDefinition.IEcsDaemonTaskDefinitionVolumeHost
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/ecs_daemon_task_definition#source_path EcsDaemonTaskDefinition#source_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourcePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourcePath
        {
            get;
            set;
        }
    }
}
