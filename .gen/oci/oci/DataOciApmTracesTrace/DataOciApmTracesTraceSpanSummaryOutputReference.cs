using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciApmTracesTrace
{
    [JsiiClass(nativeType: typeof(oci.DataOciApmTracesTrace.DataOciApmTracesTraceSpanSummaryOutputReference), fullyQualifiedName: "oci.dataOciApmTracesTrace.DataOciApmTracesTraceSpanSummaryOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciApmTracesTraceSpanSummaryOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciApmTracesTraceSpanSummaryOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciApmTracesTraceSpanSummaryOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciApmTracesTraceSpanSummaryOutputReference(DeputyProps props): base(props)
        {
        }

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

        [JsiiProperty(name: "serviceSummaries", typeJson: "{\"fqn\":\"oci.dataOciApmTracesTrace.DataOciApmTracesTraceSpanSummaryServiceSummariesList\"}")]
        public virtual oci.DataOciApmTracesTrace.DataOciApmTracesTraceSpanSummaryServiceSummariesList ServiceSummaries
        {
            get => GetInstanceProperty<oci.DataOciApmTracesTrace.DataOciApmTracesTraceSpanSummaryServiceSummariesList>()!;
        }

        [JsiiProperty(name: "spanCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SpanCount
        {
            get => GetInstanceProperty<double>()!;
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciApmTracesTrace.DataOciApmTracesTraceSpanSummary\"}", isOptional: true)]
        public virtual oci.DataOciApmTracesTrace.IDataOciApmTracesTraceSpanSummary? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciApmTracesTrace.IDataOciApmTracesTraceSpanSummary?>();
            set => SetInstanceProperty(value);
        }
    }
}
