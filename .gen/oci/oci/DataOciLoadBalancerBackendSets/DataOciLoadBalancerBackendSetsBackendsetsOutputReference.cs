using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciLoadBalancerBackendSets
{
    [JsiiClass(nativeType: typeof(oci.DataOciLoadBalancerBackendSets.DataOciLoadBalancerBackendSetsBackendsetsOutputReference), fullyQualifiedName: "oci.dataOciLoadBalancerBackendSets.DataOciLoadBalancerBackendSetsBackendsetsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciLoadBalancerBackendSetsBackendsetsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciLoadBalancerBackendSetsBackendsetsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciLoadBalancerBackendSetsBackendsetsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciLoadBalancerBackendSetsBackendsetsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "backend", typeJson: "{\"fqn\":\"oci.dataOciLoadBalancerBackendSets.DataOciLoadBalancerBackendSetsBackendsetsBackendList\"}")]
        public virtual oci.DataOciLoadBalancerBackendSets.DataOciLoadBalancerBackendSetsBackendsetsBackendList Backend
        {
            get => GetInstanceProperty<oci.DataOciLoadBalancerBackendSets.DataOciLoadBalancerBackendSetsBackendsetsBackendList>()!;
        }

        [JsiiProperty(name: "backendMaxConnections", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BackendMaxConnections
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "healthChecker", typeJson: "{\"fqn\":\"oci.dataOciLoadBalancerBackendSets.DataOciLoadBalancerBackendSetsBackendsetsHealthCheckerList\"}")]
        public virtual oci.DataOciLoadBalancerBackendSets.DataOciLoadBalancerBackendSetsBackendsetsHealthCheckerList HealthChecker
        {
            get => GetInstanceProperty<oci.DataOciLoadBalancerBackendSets.DataOciLoadBalancerBackendSetsBackendsetsHealthCheckerList>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lbCookieSessionPersistenceConfiguration", typeJson: "{\"fqn\":\"oci.dataOciLoadBalancerBackendSets.DataOciLoadBalancerBackendSetsBackendsetsLbCookieSessionPersistenceConfigurationList\"}")]
        public virtual oci.DataOciLoadBalancerBackendSets.DataOciLoadBalancerBackendSetsBackendsetsLbCookieSessionPersistenceConfigurationList LbCookieSessionPersistenceConfiguration
        {
            get => GetInstanceProperty<oci.DataOciLoadBalancerBackendSets.DataOciLoadBalancerBackendSetsBackendsetsLbCookieSessionPersistenceConfigurationList>()!;
        }

        [JsiiProperty(name: "loadBalancerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LoadBalancerId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "policy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Policy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sessionPersistenceConfiguration", typeJson: "{\"fqn\":\"oci.dataOciLoadBalancerBackendSets.DataOciLoadBalancerBackendSetsBackendsetsSessionPersistenceConfigurationList\"}")]
        public virtual oci.DataOciLoadBalancerBackendSets.DataOciLoadBalancerBackendSetsBackendsetsSessionPersistenceConfigurationList SessionPersistenceConfiguration
        {
            get => GetInstanceProperty<oci.DataOciLoadBalancerBackendSets.DataOciLoadBalancerBackendSetsBackendsetsSessionPersistenceConfigurationList>()!;
        }

        [JsiiProperty(name: "sslConfiguration", typeJson: "{\"fqn\":\"oci.dataOciLoadBalancerBackendSets.DataOciLoadBalancerBackendSetsBackendsetsSslConfigurationList\"}")]
        public virtual oci.DataOciLoadBalancerBackendSets.DataOciLoadBalancerBackendSetsBackendsetsSslConfigurationList SslConfiguration
        {
            get => GetInstanceProperty<oci.DataOciLoadBalancerBackendSets.DataOciLoadBalancerBackendSetsBackendsetsSslConfigurationList>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciLoadBalancerBackendSets.DataOciLoadBalancerBackendSetsBackendsets\"}", isOptional: true)]
        public virtual oci.DataOciLoadBalancerBackendSets.IDataOciLoadBalancerBackendSetsBackendsets? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciLoadBalancerBackendSets.IDataOciLoadBalancerBackendSetsBackendsets?>();
            set => SetInstanceProperty(value);
        }
    }
}
