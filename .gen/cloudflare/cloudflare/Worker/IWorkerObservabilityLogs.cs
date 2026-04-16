using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Worker
{
    [JsiiInterface(nativeType: typeof(IWorkerObservabilityLogs), fullyQualifiedName: "cloudflare.worker.WorkerObservabilityLogs")]
    public interface IWorkerObservabilityLogs
    {
        /// <summary>Whether logs are enabled for the Worker.</summary>
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

        /// <summary>The sampling rate for logs. From 0 to 1 (1 = 100%, 0.1 = 10%).</summary>
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

        /// <summary>Whether [invocation logs](https://developers.cloudflare.com/workers/observability/logs/workers-logs/#invocation-logs) are enabled for the Worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker#invocation_logs Worker#invocation_logs}
        /// </remarks>
        [JsiiProperty(name: "invocationLogs", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? InvocationLogs
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkerObservabilityLogs), fullyQualifiedName: "cloudflare.worker.WorkerObservabilityLogs")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Worker.IWorkerObservabilityLogs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Whether logs are enabled for the Worker.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker#enabled Worker#enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The sampling rate for logs. From 0 to 1 (1 = 100%, 0.1 = 10%).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker#head_sampling_rate Worker#head_sampling_rate}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "headSamplingRate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? HeadSamplingRate
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Whether [invocation logs](https://developers.cloudflare.com/workers/observability/logs/workers-logs/#invocation-logs) are enabled for the Worker.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker#invocation_logs Worker#invocation_logs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "invocationLogs", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? InvocationLogs
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
