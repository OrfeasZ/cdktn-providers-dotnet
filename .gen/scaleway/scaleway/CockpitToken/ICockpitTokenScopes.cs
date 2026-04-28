using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.CockpitToken
{
    [JsiiInterface(nativeType: typeof(ICockpitTokenScopes), fullyQualifiedName: "scaleway.cockpitToken.CockpitTokenScopes")]
    public interface ICockpitTokenScopes
    {
        /// <summary>Query logs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/cockpit_token#query_logs CockpitToken#query_logs}
        /// </remarks>
        [JsiiProperty(name: "queryLogs", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? QueryLogs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Query metrics.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/cockpit_token#query_metrics CockpitToken#query_metrics}
        /// </remarks>
        [JsiiProperty(name: "queryMetrics", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? QueryMetrics
        {
            get
            {
                return null;
            }
        }

        /// <summary>Query traces.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/cockpit_token#query_traces CockpitToken#query_traces}
        /// </remarks>
        [JsiiProperty(name: "queryTraces", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? QueryTraces
        {
            get
            {
                return null;
            }
        }

        /// <summary>Setup alerts.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/cockpit_token#setup_alerts CockpitToken#setup_alerts}
        /// </remarks>
        [JsiiProperty(name: "setupAlerts", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SetupAlerts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Setup logs rules.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/cockpit_token#setup_logs_rules CockpitToken#setup_logs_rules}
        /// </remarks>
        [JsiiProperty(name: "setupLogsRules", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SetupLogsRules
        {
            get
            {
                return null;
            }
        }

        /// <summary>Setup metrics rules.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/cockpit_token#setup_metrics_rules CockpitToken#setup_metrics_rules}
        /// </remarks>
        [JsiiProperty(name: "setupMetricsRules", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SetupMetricsRules
        {
            get
            {
                return null;
            }
        }

        /// <summary>Write logs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/cockpit_token#write_logs CockpitToken#write_logs}
        /// </remarks>
        [JsiiProperty(name: "writeLogs", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? WriteLogs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Write metrics.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/cockpit_token#write_metrics CockpitToken#write_metrics}
        /// </remarks>
        [JsiiProperty(name: "writeMetrics", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? WriteMetrics
        {
            get
            {
                return null;
            }
        }

        /// <summary>Write traces.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/cockpit_token#write_traces CockpitToken#write_traces}
        /// </remarks>
        [JsiiProperty(name: "writeTraces", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? WriteTraces
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICockpitTokenScopes), fullyQualifiedName: "scaleway.cockpitToken.CockpitTokenScopes")]
        internal sealed class _Proxy : DeputyBase, scaleway.CockpitToken.ICockpitTokenScopes
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Query logs.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/cockpit_token#query_logs CockpitToken#query_logs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "queryLogs", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? QueryLogs
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Query metrics.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/cockpit_token#query_metrics CockpitToken#query_metrics}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "queryMetrics", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? QueryMetrics
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Query traces.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/cockpit_token#query_traces CockpitToken#query_traces}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "queryTraces", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? QueryTraces
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Setup alerts.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/cockpit_token#setup_alerts CockpitToken#setup_alerts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "setupAlerts", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? SetupAlerts
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Setup logs rules.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/cockpit_token#setup_logs_rules CockpitToken#setup_logs_rules}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "setupLogsRules", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? SetupLogsRules
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Setup metrics rules.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/cockpit_token#setup_metrics_rules CockpitToken#setup_metrics_rules}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "setupMetricsRules", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? SetupMetricsRules
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Write logs.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/cockpit_token#write_logs CockpitToken#write_logs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "writeLogs", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? WriteLogs
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Write metrics.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/cockpit_token#write_metrics CockpitToken#write_metrics}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "writeMetrics", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? WriteMetrics
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Write traces.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/cockpit_token#write_traces CockpitToken#write_traces}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "writeTraces", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? WriteTraces
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
