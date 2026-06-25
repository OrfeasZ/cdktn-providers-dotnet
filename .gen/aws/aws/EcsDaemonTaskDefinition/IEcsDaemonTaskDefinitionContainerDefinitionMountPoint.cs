using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsDaemonTaskDefinition
{
    [JsiiInterface(nativeType: typeof(IEcsDaemonTaskDefinitionContainerDefinitionMountPoint), fullyQualifiedName: "aws.ecsDaemonTaskDefinition.EcsDaemonTaskDefinitionContainerDefinitionMountPoint")]
    public interface IEcsDaemonTaskDefinitionContainerDefinitionMountPoint
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.52.0/docs/resources/ecs_daemon_task_definition#container_path EcsDaemonTaskDefinition#container_path}.</summary>
        [JsiiProperty(name: "containerPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ContainerPath
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.52.0/docs/resources/ecs_daemon_task_definition#read_only EcsDaemonTaskDefinition#read_only}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "readOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ReadOnly
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.52.0/docs/resources/ecs_daemon_task_definition#source_volume EcsDaemonTaskDefinition#source_volume}.</summary>
        [JsiiProperty(name: "sourceVolume", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SourceVolume
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsDaemonTaskDefinitionContainerDefinitionMountPoint), fullyQualifiedName: "aws.ecsDaemonTaskDefinition.EcsDaemonTaskDefinitionContainerDefinitionMountPoint")]
        internal sealed class _Proxy : DeputyBase, aws.EcsDaemonTaskDefinition.IEcsDaemonTaskDefinitionContainerDefinitionMountPoint
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.52.0/docs/resources/ecs_daemon_task_definition#container_path EcsDaemonTaskDefinition#container_path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "containerPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ContainerPath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.52.0/docs/resources/ecs_daemon_task_definition#read_only EcsDaemonTaskDefinition#read_only}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "readOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ReadOnly
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.52.0/docs/resources/ecs_daemon_task_definition#source_volume EcsDaemonTaskDefinition#source_volume}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourceVolume", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SourceVolume
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
