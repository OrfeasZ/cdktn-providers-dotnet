using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsDaemonTaskDefinition
{
    [JsiiInterface(nativeType: typeof(IEcsDaemonTaskDefinitionContainerDefinitionLogConfiguration), fullyQualifiedName: "aws.ecsDaemonTaskDefinition.EcsDaemonTaskDefinitionContainerDefinitionLogConfiguration")]
    public interface IEcsDaemonTaskDefinitionContainerDefinitionLogConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/ecs_daemon_task_definition#log_driver EcsDaemonTaskDefinition#log_driver}.</summary>
        [JsiiProperty(name: "logDriver", typeJson: "{\"primitive\":\"string\"}")]
        string LogDriver
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/ecs_daemon_task_definition#options EcsDaemonTaskDefinition#options}.</summary>
        [JsiiProperty(name: "options", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Options
        {
            get
            {
                return null;
            }
        }

        /// <summary>secret_option block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/ecs_daemon_task_definition#secret_option EcsDaemonTaskDefinition#secret_option}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.EcsDaemonTaskDefinition.IEcsDaemonTaskDefinitionContainerDefinitionLogConfigurationSecretOption" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "secretOption", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsDaemonTaskDefinition.EcsDaemonTaskDefinitionContainerDefinitionLogConfigurationSecretOption\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SecretOption
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsDaemonTaskDefinitionContainerDefinitionLogConfiguration), fullyQualifiedName: "aws.ecsDaemonTaskDefinition.EcsDaemonTaskDefinitionContainerDefinitionLogConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.EcsDaemonTaskDefinition.IEcsDaemonTaskDefinitionContainerDefinitionLogConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/ecs_daemon_task_definition#log_driver EcsDaemonTaskDefinition#log_driver}.</summary>
            [JsiiProperty(name: "logDriver", typeJson: "{\"primitive\":\"string\"}")]
            public string LogDriver
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/ecs_daemon_task_definition#options EcsDaemonTaskDefinition#options}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "options", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Options
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>secret_option block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/ecs_daemon_task_definition#secret_option EcsDaemonTaskDefinition#secret_option}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.EcsDaemonTaskDefinition.IEcsDaemonTaskDefinitionContainerDefinitionLogConfigurationSecretOption" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "secretOption", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsDaemonTaskDefinition.EcsDaemonTaskDefinitionContainerDefinitionLogConfigurationSecretOption\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SecretOption
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
