using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsDaemon
{
    [JsiiByValue(fqn: "aws.ecsDaemon.EcsDaemonDeploymentConfiguration")]
    public class EcsDaemonDeploymentConfiguration : aws.EcsDaemon.IEcsDaemonDeploymentConfiguration
    {
        private object? _alarms;

        /// <summary>alarms block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/ecs_daemon#alarms EcsDaemon#alarms}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.EcsDaemon.IEcsDaemonDeploymentConfigurationAlarms" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "alarms", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsDaemon.EcsDaemonDeploymentConfigurationAlarms\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Alarms
        {
            get => _alarms;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.EcsDaemon.IEcsDaemonDeploymentConfigurationAlarms[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.EcsDaemon.IEcsDaemonDeploymentConfigurationAlarms).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _alarms = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/ecs_daemon#bake_time_in_minutes EcsDaemon#bake_time_in_minutes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bakeTimeInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BakeTimeInMinutes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/ecs_daemon#drain_percent EcsDaemon#drain_percent}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "drainPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DrainPercent
        {
            get;
            set;
        }
    }
}
