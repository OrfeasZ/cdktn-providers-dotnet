using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerAppJob
{
    [JsiiByValue(fqn: "azurerm.containerAppJob.ContainerAppJobEventTriggerConfig")]
    public class ContainerAppJobEventTriggerConfig : azurerm.ContainerAppJob.IContainerAppJobEventTriggerConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/container_app_job#parallelism ContainerAppJob#parallelism}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "parallelism", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Parallelism
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/container_app_job#replica_completion_count ContainerAppJob#replica_completion_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "replicaCompletionCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ReplicaCompletionCount
        {
            get;
            set;
        }

        private object? _scale;

        /// <summary>scale block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/container_app_job#scale ContainerAppJob#scale}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ContainerAppJob.IContainerAppJobEventTriggerConfigScale" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scale", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerAppJob.ContainerAppJobEventTriggerConfigScale\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Scale
        {
            get => _scale;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.ContainerAppJob.IContainerAppJobEventTriggerConfigScale[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ContainerAppJob.IContainerAppJobEventTriggerConfigScale).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _scale = value;
            }
        }
    }
}
