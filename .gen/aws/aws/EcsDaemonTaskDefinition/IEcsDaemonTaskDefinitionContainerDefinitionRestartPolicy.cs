using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsDaemonTaskDefinition
{
    [JsiiInterface(nativeType: typeof(IEcsDaemonTaskDefinitionContainerDefinitionRestartPolicy), fullyQualifiedName: "aws.ecsDaemonTaskDefinition.EcsDaemonTaskDefinitionContainerDefinitionRestartPolicy")]
    public interface IEcsDaemonTaskDefinitionContainerDefinitionRestartPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.52.0/docs/resources/ecs_daemon_task_definition#enabled EcsDaemonTaskDefinition#enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.52.0/docs/resources/ecs_daemon_task_definition#ignored_exit_codes EcsDaemonTaskDefinition#ignored_exit_codes}.</summary>
        [JsiiProperty(name: "ignoredExitCodes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double[]? IgnoredExitCodes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.52.0/docs/resources/ecs_daemon_task_definition#restart_attempt_period EcsDaemonTaskDefinition#restart_attempt_period}.</summary>
        [JsiiProperty(name: "restartAttemptPeriod", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RestartAttemptPeriod
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsDaemonTaskDefinitionContainerDefinitionRestartPolicy), fullyQualifiedName: "aws.ecsDaemonTaskDefinition.EcsDaemonTaskDefinitionContainerDefinitionRestartPolicy")]
        internal sealed class _Proxy : DeputyBase, aws.EcsDaemonTaskDefinition.IEcsDaemonTaskDefinitionContainerDefinitionRestartPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.52.0/docs/resources/ecs_daemon_task_definition#enabled EcsDaemonTaskDefinition#enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.52.0/docs/resources/ecs_daemon_task_definition#ignored_exit_codes EcsDaemonTaskDefinition#ignored_exit_codes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ignoredExitCodes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
            public double[]? IgnoredExitCodes
            {
                get => GetInstanceProperty<double[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.52.0/docs/resources/ecs_daemon_task_definition#restart_attempt_period EcsDaemonTaskDefinition#restart_attempt_period}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "restartAttemptPeriod", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RestartAttemptPeriod
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
