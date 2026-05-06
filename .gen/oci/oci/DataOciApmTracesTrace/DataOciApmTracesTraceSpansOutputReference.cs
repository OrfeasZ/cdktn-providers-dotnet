using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciApmTracesTrace
{
    [JsiiClass(nativeType: typeof(oci.DataOciApmTracesTrace.DataOciApmTracesTraceSpansOutputReference), fullyQualifiedName: "oci.dataOciApmTracesTrace.DataOciApmTracesTraceSpansOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciApmTracesTraceSpansOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciApmTracesTraceSpansOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciApmTracesTraceSpansOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciApmTracesTraceSpansOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "durationInMs", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DurationInMs
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isError", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsError
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Key
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Kind
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "logs", typeJson: "{\"fqn\":\"oci.dataOciApmTracesTrace.DataOciApmTracesTraceSpansLogsList\"}")]
        public virtual oci.DataOciApmTracesTrace.DataOciApmTracesTraceSpansLogsList Logs
        {
            get => GetInstanceProperty<oci.DataOciApmTracesTrace.DataOciApmTracesTraceSpansLogsList>()!;
        }

        [JsiiProperty(name: "operationName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OperationName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "parentSpanKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParentSpanKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"oci.dataOciApmTracesTrace.DataOciApmTracesTraceSpansTagsList\"}")]
        public virtual oci.DataOciApmTracesTrace.DataOciApmTracesTraceSpansTagsList Tags
        {
            get => GetInstanceProperty<oci.DataOciApmTracesTrace.DataOciApmTracesTraceSpansTagsList>()!;
        }

        [JsiiProperty(name: "timeEnded", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeEnded
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeStarted", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeStarted
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "traceKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TraceKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciApmTracesTrace.DataOciApmTracesTraceSpans\"}", isOptional: true)]
        public virtual oci.DataOciApmTracesTrace.IDataOciApmTracesTraceSpans? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciApmTracesTrace.IDataOciApmTracesTraceSpans?>();
            set => SetInstanceProperty(value);
        }
    }
}
