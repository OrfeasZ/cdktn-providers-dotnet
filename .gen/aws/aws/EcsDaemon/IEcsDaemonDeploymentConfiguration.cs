using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsDaemon
{
    [JsiiInterface(nativeType: typeof(IEcsDaemonDeploymentConfiguration), fullyQualifiedName: "aws.ecsDaemon.EcsDaemonDeploymentConfiguration")]
    public interface IEcsDaemonDeploymentConfiguration
    {
        /// <summary>alarms block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/ecs_daemon#alarms EcsDaemon#alarms}
        /// </remarks>
        [JsiiProperty(name: "alarms", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsDaemon.EcsDaemonDeploymentConfigurationAlarms\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Alarms
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/ecs_daemon#bake_time_in_minutes EcsDaemon#bake_time_in_minutes}.</summary>
        [JsiiProperty(name: "bakeTimeInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BakeTimeInMinutes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/ecs_daemon#drain_percent EcsDaemon#drain_percent}.</summary>
        [JsiiProperty(name: "drainPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DrainPercent
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsDaemonDeploymentConfiguration), fullyQualifiedName: "aws.ecsDaemon.EcsDaemonDeploymentConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.EcsDaemon.IEcsDaemonDeploymentConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>alarms block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/ecs_daemon#alarms EcsDaemon#alarms}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "alarms", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsDaemon.EcsDaemonDeploymentConfigurationAlarms\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Alarms
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/ecs_daemon#bake_time_in_minutes EcsDaemon#bake_time_in_minutes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bakeTimeInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BakeTimeInMinutes
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/ecs_daemon#drain_percent EcsDaemon#drain_percent}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "drainPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DrainPercent
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
