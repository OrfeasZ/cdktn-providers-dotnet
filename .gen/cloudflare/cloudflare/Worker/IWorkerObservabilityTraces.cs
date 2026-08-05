using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Worker
{
    [JsiiInterface(nativeType: typeof(IWorkerObservabilityTraces), fullyQualifiedName: "cloudflare.worker.WorkerObservabilityTraces")]
    public interface IWorkerObservabilityTraces
    {
        /// <summary>A list of destinations where traces will be exported to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/worker#destinations Worker#destinations}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/worker#enabled Worker#enabled}
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

        /// <summary>The sampling rate for traces. From 0 to 1 (1 = 100%, 0.1 = 10%).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/worker#head_sampling_rate Worker#head_sampling_rate}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/worker#persist Worker#persist}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/worker#propagation_policy Worker#propagation_policy}
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

        [JsiiTypeProxy(nativeType: typeof(IWorkerObservabilityTraces), fullyQualifiedName: "cloudflare.worker.WorkerObservabilityTraces")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Worker.IWorkerObservabilityTraces
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>A list of destinations where traces will be exported to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/worker#destinations Worker#destinations}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "destinations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Destinations
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Whether traces are enabled for the Worker.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/worker#enabled Worker#enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The sampling rate for traces. From 0 to 1 (1 = 100%, 0.1 = 10%).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/worker#head_sampling_rate Worker#head_sampling_rate}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "headSamplingRate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? HeadSamplingRate
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Whether trace persistence is enabled for the Worker.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/worker#persist Worker#persist}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/worker#propagation_policy Worker#propagation_policy}
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
