using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LoadBalancerBackendSet
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backend_set oci_load_balancer_backend_set}.</summary>
    [JsiiClass(nativeType: typeof(oci.LoadBalancerBackendSet.LoadBalancerBackendSet), fullyQualifiedName: "oci.loadBalancerBackendSet.LoadBalancerBackendSet", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.loadBalancerBackendSet.LoadBalancerBackendSetConfig\"}}]")]
    public class LoadBalancerBackendSet : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backend_set oci_load_balancer_backend_set} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public LoadBalancerBackendSet(Constructs.Construct scope, string id, oci.LoadBalancerBackendSet.ILoadBalancerBackendSetConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.LoadBalancerBackendSet.ILoadBalancerBackendSetConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LoadBalancerBackendSet(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LoadBalancerBackendSet(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a LoadBalancerBackendSet resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the LoadBalancerBackendSet to import.</param>
        /// <param name="importFromId">The id of the existing LoadBalancerBackendSet that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the LoadBalancerBackendSet to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the LoadBalancerBackendSet to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backend_set#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing LoadBalancerBackendSet that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the LoadBalancerBackendSet to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.LoadBalancerBackendSet.LoadBalancerBackendSet), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putHealthChecker", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.loadBalancerBackendSet.LoadBalancerBackendSetHealthChecker\"}}]")]
        public virtual void PutHealthChecker(oci.LoadBalancerBackendSet.ILoadBalancerBackendSetHealthChecker @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.LoadBalancerBackendSet.ILoadBalancerBackendSetHealthChecker)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLbCookieSessionPersistenceConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.loadBalancerBackendSet.LoadBalancerBackendSetLbCookieSessionPersistenceConfiguration\"}}]")]
        public virtual void PutLbCookieSessionPersistenceConfiguration(oci.LoadBalancerBackendSet.ILoadBalancerBackendSetLbCookieSessionPersistenceConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.LoadBalancerBackendSet.ILoadBalancerBackendSetLbCookieSessionPersistenceConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSessionPersistenceConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.loadBalancerBackendSet.LoadBalancerBackendSetSessionPersistenceConfiguration\"}}]")]
        public virtual void PutSessionPersistenceConfiguration(oci.LoadBalancerBackendSet.ILoadBalancerBackendSetSessionPersistenceConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.LoadBalancerBackendSet.ILoadBalancerBackendSetSessionPersistenceConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSslConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.loadBalancerBackendSet.LoadBalancerBackendSetSslConfiguration\"}}]")]
        public virtual void PutSslConfiguration(oci.LoadBalancerBackendSet.ILoadBalancerBackendSetSslConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.LoadBalancerBackendSet.ILoadBalancerBackendSetSslConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.loadBalancerBackendSet.LoadBalancerBackendSetTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.LoadBalancerBackendSet.ILoadBalancerBackendSetTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.LoadBalancerBackendSet.ILoadBalancerBackendSetTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBackendMaxConnections")]
        public virtual void ResetBackendMaxConnections()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLbCookieSessionPersistenceConfiguration")]
        public virtual void ResetLbCookieSessionPersistenceConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSessionPersistenceConfiguration")]
        public virtual void ResetSessionPersistenceConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSslConfiguration")]
        public virtual void ResetSslConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
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
        = GetStaticProperty<string>(typeof(oci.LoadBalancerBackendSet.LoadBalancerBackendSet))!;

        [JsiiProperty(name: "backend", typeJson: "{\"fqn\":\"oci.loadBalancerBackendSet.LoadBalancerBackendSetBackendList\"}")]
        public virtual oci.LoadBalancerBackendSet.LoadBalancerBackendSetBackendList Backend
        {
            get => GetInstanceProperty<oci.LoadBalancerBackendSet.LoadBalancerBackendSetBackendList>()!;
        }

        [JsiiProperty(name: "healthChecker", typeJson: "{\"fqn\":\"oci.loadBalancerBackendSet.LoadBalancerBackendSetHealthCheckerOutputReference\"}")]
        public virtual oci.LoadBalancerBackendSet.LoadBalancerBackendSetHealthCheckerOutputReference HealthChecker
        {
            get => GetInstanceProperty<oci.LoadBalancerBackendSet.LoadBalancerBackendSetHealthCheckerOutputReference>()!;
        }

        [JsiiProperty(name: "lbCookieSessionPersistenceConfiguration", typeJson: "{\"fqn\":\"oci.loadBalancerBackendSet.LoadBalancerBackendSetLbCookieSessionPersistenceConfigurationOutputReference\"}")]
        public virtual oci.LoadBalancerBackendSet.LoadBalancerBackendSetLbCookieSessionPersistenceConfigurationOutputReference LbCookieSessionPersistenceConfiguration
        {
            get => GetInstanceProperty<oci.LoadBalancerBackendSet.LoadBalancerBackendSetLbCookieSessionPersistenceConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "sessionPersistenceConfiguration", typeJson: "{\"fqn\":\"oci.loadBalancerBackendSet.LoadBalancerBackendSetSessionPersistenceConfigurationOutputReference\"}")]
        public virtual oci.LoadBalancerBackendSet.LoadBalancerBackendSetSessionPersistenceConfigurationOutputReference SessionPersistenceConfiguration
        {
            get => GetInstanceProperty<oci.LoadBalancerBackendSet.LoadBalancerBackendSetSessionPersistenceConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "sslConfiguration", typeJson: "{\"fqn\":\"oci.loadBalancerBackendSet.LoadBalancerBackendSetSslConfigurationOutputReference\"}")]
        public virtual oci.LoadBalancerBackendSet.LoadBalancerBackendSetSslConfigurationOutputReference SslConfiguration
        {
            get => GetInstanceProperty<oci.LoadBalancerBackendSet.LoadBalancerBackendSetSslConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.loadBalancerBackendSet.LoadBalancerBackendSetTimeoutsOutputReference\"}")]
        public virtual oci.LoadBalancerBackendSet.LoadBalancerBackendSetTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.LoadBalancerBackendSet.LoadBalancerBackendSetTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "backendMaxConnectionsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? BackendMaxConnectionsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthCheckerInput", typeJson: "{\"fqn\":\"oci.loadBalancerBackendSet.LoadBalancerBackendSetHealthChecker\"}", isOptional: true)]
        public virtual oci.LoadBalancerBackendSet.ILoadBalancerBackendSetHealthChecker? HealthCheckerInput
        {
            get => GetInstanceProperty<oci.LoadBalancerBackendSet.ILoadBalancerBackendSetHealthChecker?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lbCookieSessionPersistenceConfigurationInput", typeJson: "{\"fqn\":\"oci.loadBalancerBackendSet.LoadBalancerBackendSetLbCookieSessionPersistenceConfiguration\"}", isOptional: true)]
        public virtual oci.LoadBalancerBackendSet.ILoadBalancerBackendSetLbCookieSessionPersistenceConfiguration? LbCookieSessionPersistenceConfigurationInput
        {
            get => GetInstanceProperty<oci.LoadBalancerBackendSet.ILoadBalancerBackendSetLbCookieSessionPersistenceConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loadBalancerIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LoadBalancerIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "policyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PolicyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sessionPersistenceConfigurationInput", typeJson: "{\"fqn\":\"oci.loadBalancerBackendSet.LoadBalancerBackendSetSessionPersistenceConfiguration\"}", isOptional: true)]
        public virtual oci.LoadBalancerBackendSet.ILoadBalancerBackendSetSessionPersistenceConfiguration? SessionPersistenceConfigurationInput
        {
            get => GetInstanceProperty<oci.LoadBalancerBackendSet.ILoadBalancerBackendSetSessionPersistenceConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sslConfigurationInput", typeJson: "{\"fqn\":\"oci.loadBalancerBackendSet.LoadBalancerBackendSetSslConfiguration\"}", isOptional: true)]
        public virtual oci.LoadBalancerBackendSet.ILoadBalancerBackendSetSslConfiguration? SslConfigurationInput
        {
            get => GetInstanceProperty<oci.LoadBalancerBackendSet.ILoadBalancerBackendSetSslConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.loadBalancerBackendSet.LoadBalancerBackendSetTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "backendMaxConnections", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BackendMaxConnections
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "loadBalancerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LoadBalancerId
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

        [JsiiProperty(name: "policy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Policy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
