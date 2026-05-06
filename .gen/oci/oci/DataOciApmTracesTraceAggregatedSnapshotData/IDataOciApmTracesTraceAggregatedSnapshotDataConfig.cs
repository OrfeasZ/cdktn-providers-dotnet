using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciApmTracesTraceAggregatedSnapshotData
{
    [JsiiInterface(nativeType: typeof(IDataOciApmTracesTraceAggregatedSnapshotDataConfig), fullyQualifiedName: "oci.dataOciApmTracesTraceAggregatedSnapshotData.DataOciApmTracesTraceAggregatedSnapshotDataConfig")]
    public interface IDataOciApmTracesTraceAggregatedSnapshotDataConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/apm_traces_trace_aggregated_snapshot_data#apm_domain_id DataOciApmTracesTraceAggregatedSnapshotData#apm_domain_id}.</summary>
        [JsiiProperty(name: "apmDomainId", typeJson: "{\"primitive\":\"string\"}")]
        string ApmDomainId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/apm_traces_trace_aggregated_snapshot_data#trace_key DataOciApmTracesTraceAggregatedSnapshotData#trace_key}.</summary>
        [JsiiProperty(name: "traceKey", typeJson: "{\"primitive\":\"string\"}")]
        string TraceKey
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/apm_traces_trace_aggregated_snapshot_data#id DataOciApmTracesTraceAggregatedSnapshotData#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/apm_traces_trace_aggregated_snapshot_data#server_name DataOciApmTracesTraceAggregatedSnapshotData#server_name}.</summary>
        [JsiiProperty(name: "serverName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServerName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/apm_traces_trace_aggregated_snapshot_data#service_name DataOciApmTracesTraceAggregatedSnapshotData#service_name}.</summary>
        [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServiceName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/apm_traces_trace_aggregated_snapshot_data#span_key DataOciApmTracesTraceAggregatedSnapshotData#span_key}.</summary>
        [JsiiProperty(name: "spanKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SpanKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/apm_traces_trace_aggregated_snapshot_data#span_name DataOciApmTracesTraceAggregatedSnapshotData#span_name}.</summary>
        [JsiiProperty(name: "spanName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SpanName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataOciApmTracesTraceAggregatedSnapshotDataConfig), fullyQualifiedName: "oci.dataOciApmTracesTraceAggregatedSnapshotData.DataOciApmTracesTraceAggregatedSnapshotDataConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DataOciApmTracesTraceAggregatedSnapshotData.IDataOciApmTracesTraceAggregatedSnapshotDataConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/apm_traces_trace_aggregated_snapshot_data#apm_domain_id DataOciApmTracesTraceAggregatedSnapshotData#apm_domain_id}.</summary>
            [JsiiProperty(name: "apmDomainId", typeJson: "{\"primitive\":\"string\"}")]
            public string ApmDomainId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/apm_traces_trace_aggregated_snapshot_data#trace_key DataOciApmTracesTraceAggregatedSnapshotData#trace_key}.</summary>
            [JsiiProperty(name: "traceKey", typeJson: "{\"primitive\":\"string\"}")]
            public string TraceKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/apm_traces_trace_aggregated_snapshot_data#id DataOciApmTracesTraceAggregatedSnapshotData#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/apm_traces_trace_aggregated_snapshot_data#server_name DataOciApmTracesTraceAggregatedSnapshotData#server_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serverName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServerName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/apm_traces_trace_aggregated_snapshot_data#service_name DataOciApmTracesTraceAggregatedSnapshotData#service_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServiceName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/apm_traces_trace_aggregated_snapshot_data#span_key DataOciApmTracesTraceAggregatedSnapshotData#span_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "spanKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SpanKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/apm_traces_trace_aggregated_snapshot_data#span_name DataOciApmTracesTraceAggregatedSnapshotData#span_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "spanName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SpanName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
