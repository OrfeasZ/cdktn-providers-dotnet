using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsDaemonTaskDefinition
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ecsDaemonTaskDefinition.EcsDaemonTaskDefinitionVolume")]
    public class EcsDaemonTaskDefinitionVolume : aws.EcsDaemonTaskDefinition.IEcsDaemonTaskDefinitionVolume
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.56.0/docs/resources/ecs_daemon_task_definition#name EcsDaemonTaskDefinition#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        private object? _host;

        /// <summary>host block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.56.0/docs/resources/ecs_daemon_task_definition#host EcsDaemonTaskDefinition#host}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.EcsDaemonTaskDefinition.IEcsDaemonTaskDefinitionVolumeHost" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "host", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsDaemonTaskDefinition.EcsDaemonTaskDefinitionVolumeHost\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Host
        {
            get => _host;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.EcsDaemonTaskDefinition.IEcsDaemonTaskDefinitionVolumeHost[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.EcsDaemonTaskDefinition.IEcsDaemonTaskDefinitionVolumeHost).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _host = value;
            }
        }
    }
}
