using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LoadBalancerBackendsetA
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backendset oci_load_balancer_backendset}.</summary>
    [JsiiClass(nativeType: typeof(oci.LoadBalancerBackendsetA.LoadBalancerBackendsetA), fullyQualifiedName: "oci.loadBalancerBackendsetA.LoadBalancerBackendsetA", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.loadBalancerBackendsetA.LoadBalancerBackendsetAConfig\"}}]")]
    public class LoadBalancerBackendsetA : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backendset oci_load_balancer_backendset} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public LoadBalancerBackendsetA(Constructs.Construct scope, string id, oci.LoadBalancerBackendsetA.ILoadBalancerBackendsetAConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.LoadBalancerBackendsetA.ILoadBalancerBackendsetAConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LoadBalancerBackendsetA(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LoadBalancerBackendsetA(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a LoadBalancerBackendsetA resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the LoadBalancerBackendsetA to import.</param>
        /// <param name="importFromId">The id of the existing LoadBalancerBackendsetA that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the LoadBalancerBackendsetA to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the LoadBalancerBackendsetA to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backendset#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing LoadBalancerBackendsetA that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the LoadBalancerBackendsetA to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.LoadBalancerBackendsetA.LoadBalancerBackendsetA), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putHealthChecker", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.loadBalancerBackendsetA.LoadBalancerBackendsetAHealthChecker\"}}]")]
        public virtual void PutHealthChecker(oci.LoadBalancerBackendsetA.ILoadBalancerBackendsetAHealthChecker @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.LoadBalancerBackendsetA.ILoadBalancerBackendsetAHealthChecker)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLbCookieSessionPersistenceConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.loadBalancerBackendsetA.LoadBalancerBackendsetALbCookieSessionPersistenceConfiguration\"}}]")]
        public virtual void PutLbCookieSessionPersistenceConfiguration(oci.LoadBalancerBackendsetA.ILoadBalancerBackendsetALbCookieSessionPersistenceConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.LoadBalancerBackendsetA.ILoadBalancerBackendsetALbCookieSessionPersistenceConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSessionPersistenceConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.loadBalancerBackendsetA.LoadBalancerBackendsetASessionPersistenceConfiguration\"}}]")]
        public virtual void PutSessionPersistenceConfiguration(oci.LoadBalancerBackendsetA.ILoadBalancerBackendsetASessionPersistenceConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.LoadBalancerBackendsetA.ILoadBalancerBackendsetASessionPersistenceConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSslConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.loadBalancerBackendsetA.LoadBalancerBackendsetASslConfiguration\"}}]")]
        public virtual void PutSslConfiguration(oci.LoadBalancerBackendsetA.ILoadBalancerBackendsetASslConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.LoadBalancerBackendsetA.ILoadBalancerBackendsetASslConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.loadBalancerBackendsetA.LoadBalancerBackendsetATimeouts\"}}]")]
        public virtual void PutTimeouts(oci.LoadBalancerBackendsetA.ILoadBalancerBackendsetATimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.LoadBalancerBackendsetA.ILoadBalancerBackendsetATimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(oci.LoadBalancerBackendsetA.LoadBalancerBackendsetA))!;

        [JsiiProperty(name: "backend", typeJson: "{\"fqn\":\"oci.loadBalancerBackendsetA.LoadBalancerBackendsetABackendList\"}")]
        public virtual oci.LoadBalancerBackendsetA.LoadBalancerBackendsetABackendList Backend
        {
            get => GetInstanceProperty<oci.LoadBalancerBackendsetA.LoadBalancerBackendsetABackendList>()!;
        }

        [JsiiProperty(name: "healthChecker", typeJson: "{\"fqn\":\"oci.loadBalancerBackendsetA.LoadBalancerBackendsetAHealthCheckerOutputReference\"}")]
        public virtual oci.LoadBalancerBackendsetA.LoadBalancerBackendsetAHealthCheckerOutputReference HealthChecker
        {
            get => GetInstanceProperty<oci.LoadBalancerBackendsetA.LoadBalancerBackendsetAHealthCheckerOutputReference>()!;
        }

        [JsiiProperty(name: "lbCookieSessionPersistenceConfiguration", typeJson: "{\"fqn\":\"oci.loadBalancerBackendsetA.LoadBalancerBackendsetALbCookieSessionPersistenceConfigurationOutputReference\"}")]
        public virtual oci.LoadBalancerBackendsetA.LoadBalancerBackendsetALbCookieSessionPersistenceConfigurationOutputReference LbCookieSessionPersistenceConfiguration
        {
            get => GetInstanceProperty<oci.LoadBalancerBackendsetA.LoadBalancerBackendsetALbCookieSessionPersistenceConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "sessionPersistenceConfiguration", typeJson: "{\"fqn\":\"oci.loadBalancerBackendsetA.LoadBalancerBackendsetASessionPersistenceConfigurationOutputReference\"}")]
        public virtual oci.LoadBalancerBackendsetA.LoadBalancerBackendsetASessionPersistenceConfigurationOutputReference SessionPersistenceConfiguration
        {
            get => GetInstanceProperty<oci.LoadBalancerBackendsetA.LoadBalancerBackendsetASessionPersistenceConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "sslConfiguration", typeJson: "{\"fqn\":\"oci.loadBalancerBackendsetA.LoadBalancerBackendsetASslConfigurationOutputReference\"}")]
        public virtual oci.LoadBalancerBackendsetA.LoadBalancerBackendsetASslConfigurationOutputReference SslConfiguration
        {
            get => GetInstanceProperty<oci.LoadBalancerBackendsetA.LoadBalancerBackendsetASslConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.loadBalancerBackendsetA.LoadBalancerBackendsetATimeoutsOutputReference\"}")]
        public virtual oci.LoadBalancerBackendsetA.LoadBalancerBackendsetATimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.LoadBalancerBackendsetA.LoadBalancerBackendsetATimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "backendMaxConnectionsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? BackendMaxConnectionsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthCheckerInput", typeJson: "{\"fqn\":\"oci.loadBalancerBackendsetA.LoadBalancerBackendsetAHealthChecker\"}", isOptional: true)]
        public virtual oci.LoadBalancerBackendsetA.ILoadBalancerBackendsetAHealthChecker? HealthCheckerInput
        {
            get => GetInstanceProperty<oci.LoadBalancerBackendsetA.ILoadBalancerBackendsetAHealthChecker?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lbCookieSessionPersistenceConfigurationInput", typeJson: "{\"fqn\":\"oci.loadBalancerBackendsetA.LoadBalancerBackendsetALbCookieSessionPersistenceConfiguration\"}", isOptional: true)]
        public virtual oci.LoadBalancerBackendsetA.ILoadBalancerBackendsetALbCookieSessionPersistenceConfiguration? LbCookieSessionPersistenceConfigurationInput
        {
            get => GetInstanceProperty<oci.LoadBalancerBackendsetA.ILoadBalancerBackendsetALbCookieSessionPersistenceConfiguration?>();
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
        [JsiiProperty(name: "sessionPersistenceConfigurationInput", typeJson: "{\"fqn\":\"oci.loadBalancerBackendsetA.LoadBalancerBackendsetASessionPersistenceConfiguration\"}", isOptional: true)]
        public virtual oci.LoadBalancerBackendsetA.ILoadBalancerBackendsetASessionPersistenceConfiguration? SessionPersistenceConfigurationInput
        {
            get => GetInstanceProperty<oci.LoadBalancerBackendsetA.ILoadBalancerBackendsetASessionPersistenceConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sslConfigurationInput", typeJson: "{\"fqn\":\"oci.loadBalancerBackendsetA.LoadBalancerBackendsetASslConfiguration\"}", isOptional: true)]
        public virtual oci.LoadBalancerBackendsetA.ILoadBalancerBackendsetASslConfiguration? SslConfigurationInput
        {
            get => GetInstanceProperty<oci.LoadBalancerBackendsetA.ILoadBalancerBackendsetASslConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.loadBalancerBackendsetA.LoadBalancerBackendsetATimeouts\"}]}}", isOptional: true)]
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
