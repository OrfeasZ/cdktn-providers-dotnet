using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciApmTracesTrace
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/apm_traces_trace oci_apm_traces_trace}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciApmTracesTrace.DataOciApmTracesTrace), fullyQualifiedName: "oci.dataOciApmTracesTrace.DataOciApmTracesTrace", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciApmTracesTrace.DataOciApmTracesTraceConfig\"}}]")]
    public class DataOciApmTracesTrace : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/apm_traces_trace oci_apm_traces_trace} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciApmTracesTrace(Constructs.Construct scope, string id, oci.DataOciApmTracesTrace.IDataOciApmTracesTraceConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciApmTracesTrace.IDataOciApmTracesTraceConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciApmTracesTrace(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciApmTracesTrace(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciApmTracesTrace resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciApmTracesTrace to import.</param>
        /// <param name="importFromId">The id of the existing DataOciApmTracesTrace that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciApmTracesTrace to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciApmTracesTrace to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/apm_traces_trace#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciApmTracesTrace that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciApmTracesTrace to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciApmTracesTrace.DataOciApmTracesTrace), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeTraceStartedGreaterThanOrEqualTo")]
        public virtual void ResetTimeTraceStartedGreaterThanOrEqualTo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeTraceStartedLessThan")]
        public virtual void ResetTimeTraceStartedLessThan()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTraceNamespace")]
        public virtual void ResetTraceNamespace()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(oci.DataOciApmTracesTrace.DataOciApmTracesTrace))!;

        [JsiiProperty(name: "errorSpanCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ErrorSpanCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "isFault", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsFault
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Key
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rootSpanDurationInMs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RootSpanDurationInMs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "rootSpanOperationName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RootSpanOperationName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rootSpanServiceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RootSpanServiceName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceSummaries", typeJson: "{\"fqn\":\"oci.dataOciApmTracesTrace.DataOciApmTracesTraceServiceSummariesList\"}")]
        public virtual oci.DataOciApmTracesTrace.DataOciApmTracesTraceServiceSummariesList ServiceSummaries
        {
            get => GetInstanceProperty<oci.DataOciApmTracesTrace.DataOciApmTracesTraceServiceSummariesList>()!;
        }

        [JsiiProperty(name: "sourceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "spanCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SpanCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "spans", typeJson: "{\"fqn\":\"oci.dataOciApmTracesTrace.DataOciApmTracesTraceSpansList\"}")]
        public virtual oci.DataOciApmTracesTrace.DataOciApmTracesTraceSpansList Spans
        {
            get => GetInstanceProperty<oci.DataOciApmTracesTrace.DataOciApmTracesTraceSpansList>()!;
        }

        [JsiiProperty(name: "spanSummary", typeJson: "{\"fqn\":\"oci.dataOciApmTracesTrace.DataOciApmTracesTraceSpanSummaryList\"}")]
        public virtual oci.DataOciApmTracesTrace.DataOciApmTracesTraceSpanSummaryList SpanSummary
        {
            get => GetInstanceProperty<oci.DataOciApmTracesTrace.DataOciApmTracesTraceSpanSummaryList>()!;
        }

        [JsiiProperty(name: "timeEarliestSpanStarted", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeEarliestSpanStarted
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeLatestSpanEnded", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeLatestSpanEnded
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeRootSpanEnded", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeRootSpanEnded
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeRootSpanStarted", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeRootSpanStarted
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "traceDurationInMs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TraceDurationInMs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "traceErrorCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TraceErrorCode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "traceErrorType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TraceErrorType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "traceStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TraceStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "apmDomainIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ApmDomainIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeTraceStartedGreaterThanOrEqualToInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimeTraceStartedGreaterThanOrEqualToInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeTraceStartedLessThanInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimeTraceStartedLessThanInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "traceKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TraceKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "traceNamespaceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TraceNamespaceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "apmDomainId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApmDomainId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeTraceStartedGreaterThanOrEqualTo", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeTraceStartedGreaterThanOrEqualTo
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeTraceStartedLessThan", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeTraceStartedLessThan
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "traceKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TraceKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "traceNamespace", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TraceNamespace
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
