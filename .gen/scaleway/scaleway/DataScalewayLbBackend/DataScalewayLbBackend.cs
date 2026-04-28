using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DataScalewayLbBackend
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/data-sources/lb_backend scaleway_lb_backend}.</summary>
    [JsiiClass(nativeType: typeof(scaleway.DataScalewayLbBackend.DataScalewayLbBackend), fullyQualifiedName: "scaleway.dataScalewayLbBackend.DataScalewayLbBackend", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"scaleway.dataScalewayLbBackend.DataScalewayLbBackendConfig\"}}]")]
    public class DataScalewayLbBackend : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/data-sources/lb_backend scaleway_lb_backend} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataScalewayLbBackend(Constructs.Construct scope, string id, scaleway.DataScalewayLbBackend.IDataScalewayLbBackendConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, scaleway.DataScalewayLbBackend.IDataScalewayLbBackendConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataScalewayLbBackend(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataScalewayLbBackend(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataScalewayLbBackend resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataScalewayLbBackend to import.</param>
        /// <param name="importFromId">The id of the existing DataScalewayLbBackend that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataScalewayLbBackend to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataScalewayLbBackend to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/data-sources/lb_backend#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataScalewayLbBackend that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataScalewayLbBackend to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(scaleway.DataScalewayLbBackend.DataScalewayLbBackend), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetBackendId")]
        public virtual void ResetBackendId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLbId")]
        public virtual void ResetLbId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
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
        = GetStaticProperty<string>(typeof(scaleway.DataScalewayLbBackend.DataScalewayLbBackend))!;

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

        [JsiiProperty(name: "healthCheckHttp", typeJson: "{\"fqn\":\"scaleway.dataScalewayLbBackend.DataScalewayLbBackendHealthCheckHttpList\"}")]
        public virtual scaleway.DataScalewayLbBackend.DataScalewayLbBackendHealthCheckHttpList HealthCheckHttp
        {
            get => GetInstanceProperty<scaleway.DataScalewayLbBackend.DataScalewayLbBackendHealthCheckHttpList>()!;
        }

        [JsiiProperty(name: "healthCheckHttps", typeJson: "{\"fqn\":\"scaleway.dataScalewayLbBackend.DataScalewayLbBackendHealthCheckHttpsList\"}")]
        public virtual scaleway.DataScalewayLbBackend.DataScalewayLbBackendHealthCheckHttpsList HealthCheckHttps
        {
            get => GetInstanceProperty<scaleway.DataScalewayLbBackend.DataScalewayLbBackendHealthCheckHttpsList>()!;
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

        [JsiiProperty(name: "healthCheckSendProxy", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable HealthCheckSendProxy
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "healthCheckTcp", typeJson: "{\"fqn\":\"scaleway.dataScalewayLbBackend.DataScalewayLbBackendHealthCheckTcpList\"}")]
        public virtual scaleway.DataScalewayLbBackend.DataScalewayLbBackendHealthCheckTcpList HealthCheckTcp
        {
            get => GetInstanceProperty<scaleway.DataScalewayLbBackend.DataScalewayLbBackendHealthCheckTcpList>()!;
        }

        [JsiiProperty(name: "healthCheckTimeout", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HealthCheckTimeout
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "healthCheckTransientDelay", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HealthCheckTransientDelay
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ignoreSslServerVerify", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IgnoreSslServerVerify
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "maxConnections", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxConnections
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxRetries", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxRetries
        {
            get => GetInstanceProperty<double>()!;
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

        [JsiiProperty(name: "redispatchAttemptCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RedispatchAttemptCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "sendProxyV2", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable SendProxyV2
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
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

        [JsiiProperty(name: "timeoutQueue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeoutQueue
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

        [JsiiOptional]
        [JsiiProperty(name: "backendIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BackendIdInput
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
        [JsiiProperty(name: "lbIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LbIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "backendId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BackendId
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

        [JsiiProperty(name: "lbId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LbId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
