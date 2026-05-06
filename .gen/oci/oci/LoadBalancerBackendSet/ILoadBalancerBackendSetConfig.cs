using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LoadBalancerBackendSet
{
    [JsiiInterface(nativeType: typeof(ILoadBalancerBackendSetConfig), fullyQualifiedName: "oci.loadBalancerBackendSet.LoadBalancerBackendSetConfig")]
    public interface ILoadBalancerBackendSetConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>health_checker block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backend_set#health_checker LoadBalancerBackendSet#health_checker}
        /// </remarks>
        [JsiiProperty(name: "healthChecker", typeJson: "{\"fqn\":\"oci.loadBalancerBackendSet.LoadBalancerBackendSetHealthChecker\"}")]
        oci.LoadBalancerBackendSet.ILoadBalancerBackendSetHealthChecker HealthChecker
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backend_set#load_balancer_id LoadBalancerBackendSet#load_balancer_id}.</summary>
        [JsiiProperty(name: "loadBalancerId", typeJson: "{\"primitive\":\"string\"}")]
        string LoadBalancerId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backend_set#name LoadBalancerBackendSet#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backend_set#policy LoadBalancerBackendSet#policy}.</summary>
        [JsiiProperty(name: "policy", typeJson: "{\"primitive\":\"string\"}")]
        string Policy
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backend_set#backend_max_connections LoadBalancerBackendSet#backend_max_connections}.</summary>
        [JsiiProperty(name: "backendMaxConnections", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BackendMaxConnections
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backend_set#id LoadBalancerBackendSet#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>lb_cookie_session_persistence_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backend_set#lb_cookie_session_persistence_configuration LoadBalancerBackendSet#lb_cookie_session_persistence_configuration}
        /// </remarks>
        [JsiiProperty(name: "lbCookieSessionPersistenceConfiguration", typeJson: "{\"fqn\":\"oci.loadBalancerBackendSet.LoadBalancerBackendSetLbCookieSessionPersistenceConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.LoadBalancerBackendSet.ILoadBalancerBackendSetLbCookieSessionPersistenceConfiguration? LbCookieSessionPersistenceConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>session_persistence_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backend_set#session_persistence_configuration LoadBalancerBackendSet#session_persistence_configuration}
        /// </remarks>
        [JsiiProperty(name: "sessionPersistenceConfiguration", typeJson: "{\"fqn\":\"oci.loadBalancerBackendSet.LoadBalancerBackendSetSessionPersistenceConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.LoadBalancerBackendSet.ILoadBalancerBackendSetSessionPersistenceConfiguration? SessionPersistenceConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>ssl_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backend_set#ssl_configuration LoadBalancerBackendSet#ssl_configuration}
        /// </remarks>
        [JsiiProperty(name: "sslConfiguration", typeJson: "{\"fqn\":\"oci.loadBalancerBackendSet.LoadBalancerBackendSetSslConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.LoadBalancerBackendSet.ILoadBalancerBackendSetSslConfiguration? SslConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backend_set#timeouts LoadBalancerBackendSet#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.loadBalancerBackendSet.LoadBalancerBackendSetTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.LoadBalancerBackendSet.ILoadBalancerBackendSetTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILoadBalancerBackendSetConfig), fullyQualifiedName: "oci.loadBalancerBackendSet.LoadBalancerBackendSetConfig")]
        internal sealed class _Proxy : DeputyBase, oci.LoadBalancerBackendSet.ILoadBalancerBackendSetConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>health_checker block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backend_set#health_checker LoadBalancerBackendSet#health_checker}
            /// </remarks>
            [JsiiProperty(name: "healthChecker", typeJson: "{\"fqn\":\"oci.loadBalancerBackendSet.LoadBalancerBackendSetHealthChecker\"}")]
            public oci.LoadBalancerBackendSet.ILoadBalancerBackendSetHealthChecker HealthChecker
            {
                get => GetInstanceProperty<oci.LoadBalancerBackendSet.ILoadBalancerBackendSetHealthChecker>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backend_set#load_balancer_id LoadBalancerBackendSet#load_balancer_id}.</summary>
            [JsiiProperty(name: "loadBalancerId", typeJson: "{\"primitive\":\"string\"}")]
            public string LoadBalancerId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backend_set#name LoadBalancerBackendSet#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backend_set#policy LoadBalancerBackendSet#policy}.</summary>
            [JsiiProperty(name: "policy", typeJson: "{\"primitive\":\"string\"}")]
            public string Policy
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backend_set#backend_max_connections LoadBalancerBackendSet#backend_max_connections}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "backendMaxConnections", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BackendMaxConnections
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backend_set#id LoadBalancerBackendSet#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>lb_cookie_session_persistence_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backend_set#lb_cookie_session_persistence_configuration LoadBalancerBackendSet#lb_cookie_session_persistence_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lbCookieSessionPersistenceConfiguration", typeJson: "{\"fqn\":\"oci.loadBalancerBackendSet.LoadBalancerBackendSetLbCookieSessionPersistenceConfiguration\"}", isOptional: true)]
            public oci.LoadBalancerBackendSet.ILoadBalancerBackendSetLbCookieSessionPersistenceConfiguration? LbCookieSessionPersistenceConfiguration
            {
                get => GetInstanceProperty<oci.LoadBalancerBackendSet.ILoadBalancerBackendSetLbCookieSessionPersistenceConfiguration?>();
            }

            /// <summary>session_persistence_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backend_set#session_persistence_configuration LoadBalancerBackendSet#session_persistence_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sessionPersistenceConfiguration", typeJson: "{\"fqn\":\"oci.loadBalancerBackendSet.LoadBalancerBackendSetSessionPersistenceConfiguration\"}", isOptional: true)]
            public oci.LoadBalancerBackendSet.ILoadBalancerBackendSetSessionPersistenceConfiguration? SessionPersistenceConfiguration
            {
                get => GetInstanceProperty<oci.LoadBalancerBackendSet.ILoadBalancerBackendSetSessionPersistenceConfiguration?>();
            }

            /// <summary>ssl_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backend_set#ssl_configuration LoadBalancerBackendSet#ssl_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sslConfiguration", typeJson: "{\"fqn\":\"oci.loadBalancerBackendSet.LoadBalancerBackendSetSslConfiguration\"}", isOptional: true)]
            public oci.LoadBalancerBackendSet.ILoadBalancerBackendSetSslConfiguration? SslConfiguration
            {
                get => GetInstanceProperty<oci.LoadBalancerBackendSet.ILoadBalancerBackendSetSslConfiguration?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backend_set#timeouts LoadBalancerBackendSet#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.loadBalancerBackendSet.LoadBalancerBackendSetTimeouts\"}", isOptional: true)]
            public oci.LoadBalancerBackendSet.ILoadBalancerBackendSetTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.LoadBalancerBackendSet.ILoadBalancerBackendSetTimeouts?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
