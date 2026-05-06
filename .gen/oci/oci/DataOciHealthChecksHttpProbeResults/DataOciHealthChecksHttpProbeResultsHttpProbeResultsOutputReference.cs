using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciHealthChecksHttpProbeResults
{
    [JsiiClass(nativeType: typeof(oci.DataOciHealthChecksHttpProbeResults.DataOciHealthChecksHttpProbeResultsHttpProbeResultsOutputReference), fullyQualifiedName: "oci.dataOciHealthChecksHttpProbeResults.DataOciHealthChecksHttpProbeResultsHttpProbeResultsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciHealthChecksHttpProbeResultsHttpProbeResultsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciHealthChecksHttpProbeResultsHttpProbeResultsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciHealthChecksHttpProbeResultsHttpProbeResultsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciHealthChecksHttpProbeResultsHttpProbeResultsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "connectEnd", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ConnectEnd
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "connection", typeJson: "{\"fqn\":\"oci.dataOciHealthChecksHttpProbeResults.DataOciHealthChecksHttpProbeResultsHttpProbeResultsConnectionList\"}")]
        public virtual oci.DataOciHealthChecksHttpProbeResults.DataOciHealthChecksHttpProbeResultsHttpProbeResultsConnectionList Connection
        {
            get => GetInstanceProperty<oci.DataOciHealthChecksHttpProbeResults.DataOciHealthChecksHttpProbeResultsHttpProbeResultsConnectionList>()!;
        }

        [JsiiProperty(name: "connectStart", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ConnectStart
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "dns", typeJson: "{\"fqn\":\"oci.dataOciHealthChecksHttpProbeResults.DataOciHealthChecksHttpProbeResultsHttpProbeResultsDnsList\"}")]
        public virtual oci.DataOciHealthChecksHttpProbeResults.DataOciHealthChecksHttpProbeResultsHttpProbeResultsDnsList Dns
        {
            get => GetInstanceProperty<oci.DataOciHealthChecksHttpProbeResults.DataOciHealthChecksHttpProbeResultsHttpProbeResultsDnsList>()!;
        }

        [JsiiProperty(name: "domainLookupEnd", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DomainLookupEnd
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "domainLookupStart", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DomainLookupStart
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Duration
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "encodedBodySize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EncodedBodySize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "errorCategory", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ErrorCategory
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "errorMessage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ErrorMessage
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "fetchStart", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FetchStart
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "isHealthy", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsHealthy
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isTimedOut", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsTimedOut
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Key
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "probeConfigurationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProbeConfigurationId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Protocol
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "requestStart", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RequestStart
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "responseEnd", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ResponseEnd
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "responseStart", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ResponseStart
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "secureConnectionStart", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SecureConnectionStart
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "startTime", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StartTime
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "statusCode", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StatusCode
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Target
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vantagePointName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VantagePointName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciHealthChecksHttpProbeResults.DataOciHealthChecksHttpProbeResultsHttpProbeResults\"}", isOptional: true)]
        public virtual oci.DataOciHealthChecksHttpProbeResults.IDataOciHealthChecksHttpProbeResultsHttpProbeResults? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciHealthChecksHttpProbeResults.IDataOciHealthChecksHttpProbeResultsHttpProbeResults?>();
            set => SetInstanceProperty(value);
        }
    }
}
