using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkersScript
{
    [JsiiInterface(nativeType: typeof(IWorkersScriptObservabilityTraces), fullyQualifiedName: "cloudflare.workersScript.WorkersScriptObservabilityTraces")]
    public interface IWorkersScriptObservabilityTraces
    {
        /// <summary>A list of destinations where traces will be exported to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.0/docs/resources/workers_script#destinations WorkersScript#destinations}
        /// </remarks>
        [JsiiProperty(name: "destinations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Destinations
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether traces are enabled for the Worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.0/docs/resources/workers_script#enabled WorkersScript#enabled}
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

        /// <summary>The sampling rate for traces. From 0 to 1 (1 = 100%, 0.1 = 10%). Default is 1.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.0/docs/resources/workers_script#head_sampling_rate WorkersScript#head_sampling_rate}
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

        /// <summary>Whether trace persistence is enabled for the Worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.0/docs/resources/workers_script#persist WorkersScript#persist}
        /// </remarks>
        [JsiiProperty(name: "persist", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Persist
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls how inbound trace context (traceparent/tracestate) headers on incoming requests are handled.</summary>
        /// <remarks>
        /// "authenticated" (default) honors inbound trace context only when accompanied by a valid trace auth token. "accept" unconditionally accepts inbound trace context. Requires the trace propagation feature to be enabled.
        /// Available values: "authenticated", "accept".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.0/docs/resources/workers_script#propagation_policy WorkersScript#propagation_policy}
        /// </remarks>
        [JsiiProperty(name: "propagationPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PropagationPolicy
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkersScriptObservabilityTraces), fullyQualifiedName: "cloudflare.workersScript.WorkersScriptObservabilityTraces")]
        internal sealed class _Proxy : DeputyBase, cloudflare.WorkersScript.IWorkersScriptObservabilityTraces
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>A list of destinations where traces will be exported to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.0/docs/resources/workers_script#destinations WorkersScript#destinations}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "destinations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Destinations
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Whether traces are enabled for the Worker.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.0/docs/resources/workers_script#enabled WorkersScript#enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The sampling rate for traces. From 0 to 1 (1 = 100%, 0.1 = 10%). Default is 1.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.0/docs/resources/workers_script#head_sampling_rate WorkersScript#head_sampling_rate}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "headSamplingRate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? HeadSamplingRate
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Whether trace persistence is enabled for the Worker.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.0/docs/resources/workers_script#persist WorkersScript#persist}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "persist", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Persist
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Controls how inbound trace context (traceparent/tracestate) headers on incoming requests are handled.</summary>
            /// <remarks>
            /// "authenticated" (default) honors inbound trace context only when accompanied by a valid trace auth token. "accept" unconditionally accepts inbound trace context. Requires the trace propagation feature to be enabled.
            /// Available values: "authenticated", "accept".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.0/docs/resources/workers_script#propagation_policy WorkersScript#propagation_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "propagationPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PropagationPolicy
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
