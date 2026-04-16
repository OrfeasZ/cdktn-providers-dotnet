using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DataScalewayLbBackends
{
    [JsiiClass(nativeType: typeof(scaleway.DataScalewayLbBackends.DataScalewayLbBackendsBackendsOutputReference), fullyQualifiedName: "scaleway.dataScalewayLbBackends.DataScalewayLbBackendsBackendsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataScalewayLbBackendsBackendsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataScalewayLbBackendsBackendsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataScalewayLbBackendsBackendsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataScalewayLbBackendsBackendsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "failoverHost", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FailoverHost
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "forwardPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ForwardPort
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "forwardPortAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ForwardPortAlgorithm
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "forwardProtocol", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ForwardProtocol
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "healthCheckDelay", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HealthCheckDelay
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "healthCheckHttp", typeJson: "{\"fqn\":\"scaleway.dataScalewayLbBackends.DataScalewayLbBackendsBackendsHealthCheckHttpList\"}")]
        public virtual scaleway.DataScalewayLbBackends.DataScalewayLbBackendsBackendsHealthCheckHttpList HealthCheckHttp
        {
            get => GetInstanceProperty<scaleway.DataScalewayLbBackends.DataScalewayLbBackendsBackendsHealthCheckHttpList>()!;
        }

        [JsiiProperty(name: "healthCheckHttps", typeJson: "{\"fqn\":\"scaleway.dataScalewayLbBackends.DataScalewayLbBackendsBackendsHealthCheckHttpsList\"}")]
        public virtual scaleway.DataScalewayLbBackends.DataScalewayLbBackendsBackendsHealthCheckHttpsList HealthCheckHttps
        {
            get => GetInstanceProperty<scaleway.DataScalewayLbBackends.DataScalewayLbBackendsBackendsHealthCheckHttpsList>()!;
        }

        [JsiiProperty(name: "healthCheckMaxRetries", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HealthCheckMaxRetries
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "healthCheckPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HealthCheckPort
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "healthCheckTcp", typeJson: "{\"fqn\":\"scaleway.dataScalewayLbBackends.DataScalewayLbBackendsBackendsHealthCheckTcpList\"}")]
        public virtual scaleway.DataScalewayLbBackends.DataScalewayLbBackendsBackendsHealthCheckTcpList HealthCheckTcp
        {
            get => GetInstanceProperty<scaleway.DataScalewayLbBackends.DataScalewayLbBackendsBackendsHealthCheckTcpList>()!;
        }

        [JsiiProperty(name: "healthCheckTimeout", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HealthCheckTimeout
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ignoreSslServerVerify", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IgnoreSslServerVerify
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "lbId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LbId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "onMarkedDownAction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OnMarkedDownAction
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "proxyProtocol", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProxyProtocol
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serverIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ServerIps
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "sslBridging", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable SslBridging
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "stickySessions", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StickySessions
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "stickySessionsCookieName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StickySessionsCookieName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeoutConnect", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeoutConnect
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeoutServer", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeoutServer
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeoutTunnel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeoutTunnel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "updateAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdateAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"scaleway.dataScalewayLbBackends.DataScalewayLbBackendsBackends\"}", isOptional: true)]
        public virtual scaleway.DataScalewayLbBackends.IDataScalewayLbBackendsBackends? InternalValue
        {
            get => GetInstanceProperty<scaleway.DataScalewayLbBackends.IDataScalewayLbBackendsBackends?>();
            set => SetInstanceProperty(value);
        }
    }
}
