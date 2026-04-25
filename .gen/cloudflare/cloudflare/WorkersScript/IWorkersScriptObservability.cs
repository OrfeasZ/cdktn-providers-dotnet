using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkersScript
{
    [JsiiInterface(nativeType: typeof(IWorkersScriptObservability), fullyQualifiedName: "cloudflare.workersScript.WorkersScriptObservability")]
    public interface IWorkersScriptObservability
    {
        /// <summary>Whether observability is enabled for the Worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/workers_script#enabled WorkersScript#enabled}
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        /// <summary>The sampling rate for incoming requests. From 0 to 1 (1 = 100%, 0.1 = 10%). Default is 1.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/workers_script#head_sampling_rate WorkersScript#head_sampling_rate}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/workers_script#logs WorkersScript#logs}
        /// </remarks>
        [JsiiProperty(name: "logs", typeJson: "{\"fqn\":\"cloudflare.workersScript.WorkersScriptObservabilityLogs\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.WorkersScript.IWorkersScriptObservabilityLogs? Logs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Trace settings for the Worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/workers_script#traces WorkersScript#traces}
        /// </remarks>
        [JsiiProperty(name: "traces", typeJson: "{\"fqn\":\"cloudflare.workersScript.WorkersScriptObservabilityTraces\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.WorkersScript.IWorkersScriptObservabilityTraces? Traces
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkersScriptObservability), fullyQualifiedName: "cloudflare.workersScript.WorkersScriptObservability")]
        internal sealed class _Proxy : DeputyBase, cloudflare.WorkersScript.IWorkersScriptObservability
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Whether observability is enabled for the Worker.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/workers_script#enabled WorkersScript#enabled}
            /// </remarks>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>The sampling rate for incoming requests. From 0 to 1 (1 = 100%, 0.1 = 10%). Default is 1.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/workers_script#head_sampling_rate WorkersScript#head_sampling_rate}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "headSamplingRate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? HeadSamplingRate
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Log settings for the Worker.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/workers_script#logs WorkersScript#logs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logs", typeJson: "{\"fqn\":\"cloudflare.workersScript.WorkersScriptObservabilityLogs\"}", isOptional: true)]
            public cloudflare.WorkersScript.IWorkersScriptObservabilityLogs? Logs
            {
                get => GetInstanceProperty<cloudflare.WorkersScript.IWorkersScriptObservabilityLogs?>();
            }

            /// <summary>Trace settings for the Worker.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/workers_script#traces WorkersScript#traces}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "traces", typeJson: "{\"fqn\":\"cloudflare.workersScript.WorkersScriptObservabilityTraces\"}", isOptional: true)]
            public cloudflare.WorkersScript.IWorkersScriptObservabilityTraces? Traces
            {
                get => GetInstanceProperty<cloudflare.WorkersScript.IWorkersScriptObservabilityTraces?>();
            }
        }
    }
}
