using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciNetworkLoadBalancerBackendSet
{
    [JsiiClass(nativeType: typeof(oci.DataOciNetworkLoadBalancerBackendSet.DataOciNetworkLoadBalancerBackendSetHealthCheckerOutputReference), fullyQualifiedName: "oci.dataOciNetworkLoadBalancerBackendSet.DataOciNetworkLoadBalancerBackendSetHealthCheckerOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciNetworkLoadBalancerBackendSetHealthCheckerOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciNetworkLoadBalancerBackendSetHealthCheckerOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciNetworkLoadBalancerBackendSetHealthCheckerOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciNetworkLoadBalancerBackendSetHealthCheckerOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "dns", typeJson: "{\"fqn\":\"oci.dataOciNetworkLoadBalancerBackendSet.DataOciNetworkLoadBalancerBackendSetHealthCheckerDnsList\"}")]
        public virtual oci.DataOciNetworkLoadBalancerBackendSet.DataOciNetworkLoadBalancerBackendSetHealthCheckerDnsList Dns
        {
            get => GetInstanceProperty<oci.DataOciNetworkLoadBalancerBackendSet.DataOciNetworkLoadBalancerBackendSetHealthCheckerDnsList>()!;
        }

        [JsiiProperty(name: "intervalInMillis", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double IntervalInMillis
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Port
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Protocol
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "requestData", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RequestData
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "responseBodyRegex", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResponseBodyRegex
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "responseData", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResponseData
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "retries", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Retries
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "returnCode", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ReturnCode
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "timeoutInMillis", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TimeoutInMillis
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "urlPath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UrlPath
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciNetworkLoadBalancerBackendSet.DataOciNetworkLoadBalancerBackendSetHealthChecker\"}", isOptional: true)]
        public virtual oci.DataOciNetworkLoadBalancerBackendSet.IDataOciNetworkLoadBalancerBackendSetHealthChecker? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciNetworkLoadBalancerBackendSet.IDataOciNetworkLoadBalancerBackendSetHealthChecker?>();
            set => SetInstanceProperty(value);
        }
    }
}
