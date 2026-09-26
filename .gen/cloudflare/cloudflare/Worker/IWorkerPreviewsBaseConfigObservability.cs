using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Worker
{
    [JsiiInterface(nativeType: typeof(IWorkerPreviewsBaseConfigObservability), fullyQualifiedName: "cloudflare.worker.WorkerPreviewsBaseConfigObservability")]
    public interface IWorkerPreviewsBaseConfigObservability
    {
        /// <summary>Whether observability is enabled for the Worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/worker#enabled Worker#enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/worker#head_sampling_rate Worker#head_sampling_rate}
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

        /// <summary>Real-time Issues settings for the Worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/worker#issues Worker#issues}
        /// </remarks>
        [JsiiProperty(name: "issues", typeJson: "{\"fqn\":\"cloudflare.worker.WorkerPreviewsBaseConfigObservabilityIssues\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.Worker.IWorkerPreviewsBaseConfigObservabilityIssues? Issues
        {
            get
            {
                return null;
            }
        }

        /// <summary>Log settings for the Worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/worker#logs Worker#logs}
        /// </remarks>
        [JsiiProperty(name: "logs", typeJson: "{\"fqn\":\"cloudflare.worker.WorkerPreviewsBaseConfigObservabilityLogs\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.Worker.IWorkerPreviewsBaseConfigObservabilityLogs? Logs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether query strings are removed from request URLs in logs and traces.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/worker#redact_query_string Worker#redact_query_string}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "redactQueryString", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RedactQueryString
        {
            get
            {
                return null;
            }
        }

        /// <summary>Trace settings for the Worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/worker#traces Worker#traces}
        /// </remarks>
        [JsiiProperty(name: "traces", typeJson: "{\"fqn\":\"cloudflare.worker.WorkerPreviewsBaseConfigObservabilityTraces\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.Worker.IWorkerPreviewsBaseConfigObservabilityTraces? Traces
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkerPreviewsBaseConfigObservability), fullyQualifiedName: "cloudflare.worker.WorkerPreviewsBaseConfigObservability")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Worker.IWorkerPreviewsBaseConfigObservability
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Whether observability is enabled for the Worker.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/worker#enabled Worker#enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The sampling rate for observability. From 0 to 1 (1 = 100%, 0.1 = 10%).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/worker#head_sampling_rate Worker#head_sampling_rate}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "headSamplingRate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? HeadSamplingRate
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Real-time Issues settings for the Worker.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/worker#issues Worker#issues}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "issues", typeJson: "{\"fqn\":\"cloudflare.worker.WorkerPreviewsBaseConfigObservabilityIssues\"}", isOptional: true)]
            public cloudflare.Worker.IWorkerPreviewsBaseConfigObservabilityIssues? Issues
            {
                get => GetInstanceProperty<cloudflare.Worker.IWorkerPreviewsBaseConfigObservabilityIssues?>();
            }

            /// <summary>Log settings for the Worker.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/worker#logs Worker#logs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logs", typeJson: "{\"fqn\":\"cloudflare.worker.WorkerPreviewsBaseConfigObservabilityLogs\"}", isOptional: true)]
            public cloudflare.Worker.IWorkerPreviewsBaseConfigObservabilityLogs? Logs
            {
                get => GetInstanceProperty<cloudflare.Worker.IWorkerPreviewsBaseConfigObservabilityLogs?>();
            }

            /// <summary>Whether query strings are removed from request URLs in logs and traces.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/worker#redact_query_string Worker#redact_query_string}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "redactQueryString", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? RedactQueryString
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Trace settings for the Worker.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/worker#traces Worker#traces}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "traces", typeJson: "{\"fqn\":\"cloudflare.worker.WorkerPreviewsBaseConfigObservabilityTraces\"}", isOptional: true)]
            public cloudflare.Worker.IWorkerPreviewsBaseConfigObservabilityTraces? Traces
            {
                get => GetInstanceProperty<cloudflare.Worker.IWorkerPreviewsBaseConfigObservabilityTraces?>();
            }
        }
    }
}
