using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Worker
{
    [JsiiInterface(nativeType: typeof(IWorkerObservability), fullyQualifiedName: "cloudflare.worker.WorkerObservability")]
    public interface IWorkerObservability
    {
        /// <summary>Whether observability is enabled for the Worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker#enabled Worker#enabled}
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>The sampling rate for observability. From 0 to 1 (1 = 100%, 0.1 = 10%).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker#head_sampling_rate Worker#head_sampling_rate}
        /// </remarks>
        [JsiiProperty(name: "headSamplingRate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? HeadSamplingRate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Log settings for the Worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker#logs Worker#logs}
        /// </remarks>
        [JsiiProperty(name: "logs", typeJson: "{\"fqn\":\"cloudflare.worker.WorkerObservabilityLogs\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.Worker.IWorkerObservabilityLogs? Logs
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkerObservability), fullyQualifiedName: "cloudflare.worker.WorkerObservability")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Worker.IWorkerObservability
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Whether observability is enabled for the Worker.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker#enabled Worker#enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The sampling rate for observability. From 0 to 1 (1 = 100%, 0.1 = 10%).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker#head_sampling_rate Worker#head_sampling_rate}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "headSamplingRate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? HeadSamplingRate
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Log settings for the Worker.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker#logs Worker#logs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logs", typeJson: "{\"fqn\":\"cloudflare.worker.WorkerObservabilityLogs\"}", isOptional: true)]
            public cloudflare.Worker.IWorkerObservabilityLogs? Logs
            {
                get => GetInstanceProperty<cloudflare.Worker.IWorkerObservabilityLogs?>();
            }
        }
    }
}
