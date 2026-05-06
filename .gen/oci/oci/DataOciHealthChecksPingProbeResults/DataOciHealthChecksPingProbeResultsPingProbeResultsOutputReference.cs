using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciHealthChecksPingProbeResults
{
    [JsiiClass(nativeType: typeof(oci.DataOciHealthChecksPingProbeResults.DataOciHealthChecksPingProbeResultsPingProbeResultsOutputReference), fullyQualifiedName: "oci.dataOciHealthChecksPingProbeResults.DataOciHealthChecksPingProbeResultsPingProbeResultsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciHealthChecksPingProbeResultsPingProbeResultsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciHealthChecksPingProbeResultsPingProbeResultsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciHealthChecksPingProbeResultsPingProbeResultsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciHealthChecksPingProbeResultsPingProbeResultsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "connection", typeJson: "{\"fqn\":\"oci.dataOciHealthChecksPingProbeResults.DataOciHealthChecksPingProbeResultsPingProbeResultsConnectionList\"}")]
        public virtual oci.DataOciHealthChecksPingProbeResults.DataOciHealthChecksPingProbeResultsPingProbeResultsConnectionList Connection
        {
            get => GetInstanceProperty<oci.DataOciHealthChecksPingProbeResults.DataOciHealthChecksPingProbeResultsPingProbeResultsConnectionList>()!;
        }

        [JsiiProperty(name: "dns", typeJson: "{\"fqn\":\"oci.dataOciHealthChecksPingProbeResults.DataOciHealthChecksPingProbeResultsPingProbeResultsDnsList\"}")]
        public virtual oci.DataOciHealthChecksPingProbeResults.DataOciHealthChecksPingProbeResultsPingProbeResultsDnsList Dns
        {
            get => GetInstanceProperty<oci.DataOciHealthChecksPingProbeResults.DataOciHealthChecksPingProbeResultsPingProbeResultsDnsList>()!;
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

        [JsiiProperty(name: "icmpCode", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double IcmpCode
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

        [JsiiProperty(name: "latencyInMs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LatencyInMs
        {
            get => GetInstanceProperty<double>()!;
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

        [JsiiProperty(name: "startTime", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StartTime
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciHealthChecksPingProbeResults.DataOciHealthChecksPingProbeResultsPingProbeResults\"}", isOptional: true)]
        public virtual oci.DataOciHealthChecksPingProbeResults.IDataOciHealthChecksPingProbeResultsPingProbeResults? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciHealthChecksPingProbeResults.IDataOciHealthChecksPingProbeResultsPingProbeResults?>();
            set => SetInstanceProperty(value);
        }
    }
}
