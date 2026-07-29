using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsDaemonTaskDefinition
{
    [JsiiInterface(nativeType: typeof(IEcsDaemonTaskDefinitionContainerDefinitionLogConfigurationSecretOption), fullyQualifiedName: "aws.ecsDaemonTaskDefinition.EcsDaemonTaskDefinitionContainerDefinitionLogConfigurationSecretOption")]
    public interface IEcsDaemonTaskDefinitionContainerDefinitionLogConfigurationSecretOption
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/ecs_daemon_task_definition#name EcsDaemonTaskDefinition#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/ecs_daemon_task_definition#value_from EcsDaemonTaskDefinition#value_from}.</summary>
        [JsiiProperty(name: "valueFrom", typeJson: "{\"primitive\":\"string\"}")]
        string ValueFrom
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsDaemonTaskDefinitionContainerDefinitionLogConfigurationSecretOption), fullyQualifiedName: "aws.ecsDaemonTaskDefinition.EcsDaemonTaskDefinitionContainerDefinitionLogConfigurationSecretOption")]
        internal sealed class _Proxy : DeputyBase, aws.EcsDaemonTaskDefinition.IEcsDaemonTaskDefinitionContainerDefinitionLogConfigurationSecretOption
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/ecs_daemon_task_definition#name EcsDaemonTaskDefinition#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/ecs_daemon_task_definition#value_from EcsDaemonTaskDefinition#value_from}.</summary>
            [JsiiProperty(name: "valueFrom", typeJson: "{\"primitive\":\"string\"}")]
            public string ValueFrom
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
