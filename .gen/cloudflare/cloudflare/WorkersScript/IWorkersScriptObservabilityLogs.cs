using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkersScript
{
    [JsiiInterface(nativeType: typeof(IWorkersScriptObservabilityLogs), fullyQualifiedName: "cloudflare.workersScript.WorkersScriptObservabilityLogs")]
    public interface IWorkersScriptObservabilityLogs
    {
        /// <summary>Whether logs are enabled for the Worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/workers_script#enabled WorkersScript#enabled}
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        /// <summary>Whether [invocation logs](https://developers.cloudflare.com/workers/observability/logs/workers-logs/#invocation-logs) are enabled for the Worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/workers_script#invocation_logs WorkersScript#invocation_logs}
        /// </remarks>
        [JsiiProperty(name: "invocationLogs", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object InvocationLogs
        {
            get;
        }

        /// <summary>The sampling rate for logs. From 0 to 1 (1 = 100%, 0.1 = 10%). Default is 1.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/workers_script#head_sampling_rate WorkersScript#head_sampling_rate}
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

        [JsiiTypeProxy(nativeType: typeof(IWorkersScriptObservabilityLogs), fullyQualifiedName: "cloudflare.workersScript.WorkersScriptObservabilityLogs")]
        internal sealed class _Proxy : DeputyBase, cloudflare.WorkersScript.IWorkersScriptObservabilityLogs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Whether logs are enabled for the Worker.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/workers_script#enabled WorkersScript#enabled}
            /// </remarks>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Whether [invocation logs](https://developers.cloudflare.com/workers/observability/logs/workers-logs/#invocation-logs) are enabled for the Worker.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/workers_script#invocation_logs WorkersScript#invocation_logs}
            /// </remarks>
            [JsiiProperty(name: "invocationLogs", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object InvocationLogs
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>The sampling rate for logs. From 0 to 1 (1 = 100%, 0.1 = 10%). Default is 1.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/workers_script#head_sampling_rate WorkersScript#head_sampling_rate}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "headSamplingRate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? HeadSamplingRate
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
