using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Worker
{
    [JsiiByValue(fqn: "cloudflare.worker.WorkerPreviewsBaseConfigObservability")]
    public class WorkerPreviewsBaseConfigObservability : cloudflare.Worker.IWorkerPreviewsBaseConfigObservability
    {
        private object? _enabled;

        /// <summary>Whether observability is enabled for the Worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/worker#enabled Worker#enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Enabled
        {
            get => _enabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _enabled = value;
            }
        }

        /// <summary>The sampling rate for observability. From 0 to 1 (1 = 100%, 0.1 = 10%).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/worker#head_sampling_rate Worker#head_sampling_rate}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "headSamplingRate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? HeadSamplingRate
        {
            get;
            set;
        }

        /// <summary>Real-time Issues settings for the Worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/worker#issues Worker#issues}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "issues", typeJson: "{\"fqn\":\"cloudflare.worker.WorkerPreviewsBaseConfigObservabilityIssues\"}", isOptional: true)]
        public cloudflare.Worker.IWorkerPreviewsBaseConfigObservabilityIssues? Issues
        {
            get;
            set;
        }

        /// <summary>Log settings for the Worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/worker#logs Worker#logs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "logs", typeJson: "{\"fqn\":\"cloudflare.worker.WorkerPreviewsBaseConfigObservabilityLogs\"}", isOptional: true)]
        public cloudflare.Worker.IWorkerPreviewsBaseConfigObservabilityLogs? Logs
        {
            get;
            set;
        }

        private object? _redactQueryString;

        /// <summary>Whether query strings are removed from request URLs in logs and traces.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/worker#redact_query_string Worker#redact_query_string}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "redactQueryString", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? RedactQueryString
        {
            get => _redactQueryString;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _redactQueryString = value;
            }
        }

        /// <summary>Trace settings for the Worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/worker#traces Worker#traces}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "traces", typeJson: "{\"fqn\":\"cloudflare.worker.WorkerPreviewsBaseConfigObservabilityTraces\"}", isOptional: true)]
        public cloudflare.Worker.IWorkerPreviewsBaseConfigObservabilityTraces? Traces
        {
            get;
            set;
        }
    }
}
