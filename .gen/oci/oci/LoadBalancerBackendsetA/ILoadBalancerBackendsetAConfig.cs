using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LoadBalancerBackendsetA
{
    [JsiiInterface(nativeType: typeof(ILoadBalancerBackendsetAConfig), fullyQualifiedName: "oci.loadBalancerBackendsetA.LoadBalancerBackendsetAConfig")]
    public interface ILoadBalancerBackendsetAConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>health_checker block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backendset#health_checker LoadBalancerBackendsetA#health_checker}
        /// </remarks>
        [JsiiProperty(name: "healthChecker", typeJson: "{\"fqn\":\"oci.loadBalancerBackendsetA.LoadBalancerBackendsetAHealthChecker\"}")]
        oci.LoadBalancerBackendsetA.ILoadBalancerBackendsetAHealthChecker HealthChecker
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backendset#load_balancer_id LoadBalancerBackendsetA#load_balancer_id}.</summary>
        [JsiiProperty(name: "loadBalancerId", typeJson: "{\"primitive\":\"string\"}")]
        string LoadBalancerId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backendset#name LoadBalancerBackendsetA#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backendset#policy LoadBalancerBackendsetA#policy}.</summary>
        [JsiiProperty(name: "policy", typeJson: "{\"primitive\":\"string\"}")]
        string Policy
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backendset#backend_max_connections LoadBalancerBackendsetA#backend_max_connections}.</summary>
        [JsiiProperty(name: "backendMaxConnections", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BackendMaxConnections
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backendset#id LoadBalancerBackendsetA#id}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backendset#lb_cookie_session_persistence_configuration LoadBalancerBackendsetA#lb_cookie_session_persistence_configuration}
        /// </remarks>
        [JsiiProperty(name: "lbCookieSessionPersistenceConfiguration", typeJson: "{\"fqn\":\"oci.loadBalancerBackendsetA.LoadBalancerBackendsetALbCookieSessionPersistenceConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.LoadBalancerBackendsetA.ILoadBalancerBackendsetALbCookieSessionPersistenceConfiguration? LbCookieSessionPersistenceConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>session_persistence_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backendset#session_persistence_configuration LoadBalancerBackendsetA#session_persistence_configuration}
        /// </remarks>
        [JsiiProperty(name: "sessionPersistenceConfiguration", typeJson: "{\"fqn\":\"oci.loadBalancerBackendsetA.LoadBalancerBackendsetASessionPersistenceConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.LoadBalancerBackendsetA.ILoadBalancerBackendsetASessionPersistenceConfiguration? SessionPersistenceConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>ssl_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backendset#ssl_configuration LoadBalancerBackendsetA#ssl_configuration}
        /// </remarks>
        [JsiiProperty(name: "sslConfiguration", typeJson: "{\"fqn\":\"oci.loadBalancerBackendsetA.LoadBalancerBackendsetASslConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.LoadBalancerBackendsetA.ILoadBalancerBackendsetASslConfiguration? SslConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backendset#timeouts LoadBalancerBackendsetA#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.loadBalancerBackendsetA.LoadBalancerBackendsetATimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.LoadBalancerBackendsetA.ILoadBalancerBackendsetATimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILoadBalancerBackendsetAConfig), fullyQualifiedName: "oci.loadBalancerBackendsetA.LoadBalancerBackendsetAConfig")]
        internal sealed class _Proxy : DeputyBase, oci.LoadBalancerBackendsetA.ILoadBalancerBackendsetAConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>health_checker block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backendset#health_checker LoadBalancerBackendsetA#health_checker}
            /// </remarks>
            [JsiiProperty(name: "healthChecker", typeJson: "{\"fqn\":\"oci.loadBalancerBackendsetA.LoadBalancerBackendsetAHealthChecker\"}")]
            public oci.LoadBalancerBackendsetA.ILoadBalancerBackendsetAHealthChecker HealthChecker
            {
                get => GetInstanceProperty<oci.LoadBalancerBackendsetA.ILoadBalancerBackendsetAHealthChecker>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backendset#load_balancer_id LoadBalancerBackendsetA#load_balancer_id}.</summary>
            [JsiiProperty(name: "loadBalancerId", typeJson: "{\"primitive\":\"string\"}")]
            public string LoadBalancerId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backendset#name LoadBalancerBackendsetA#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backendset#policy LoadBalancerBackendsetA#policy}.</summary>
            [JsiiProperty(name: "policy", typeJson: "{\"primitive\":\"string\"}")]
            public string Policy
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backendset#backend_max_connections LoadBalancerBackendsetA#backend_max_connections}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "backendMaxConnections", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BackendMaxConnections
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backendset#id LoadBalancerBackendsetA#id}.</summary>
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backendset#lb_cookie_session_persistence_configuration LoadBalancerBackendsetA#lb_cookie_session_persistence_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lbCookieSessionPersistenceConfiguration", typeJson: "{\"fqn\":\"oci.loadBalancerBackendsetA.LoadBalancerBackendsetALbCookieSessionPersistenceConfiguration\"}", isOptional: true)]
            public oci.LoadBalancerBackendsetA.ILoadBalancerBackendsetALbCookieSessionPersistenceConfiguration? LbCookieSessionPersistenceConfiguration
            {
                get => GetInstanceProperty<oci.LoadBalancerBackendsetA.ILoadBalancerBackendsetALbCookieSessionPersistenceConfiguration?>();
            }

            /// <summary>session_persistence_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backendset#session_persistence_configuration LoadBalancerBackendsetA#session_persistence_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sessionPersistenceConfiguration", typeJson: "{\"fqn\":\"oci.loadBalancerBackendsetA.LoadBalancerBackendsetASessionPersistenceConfiguration\"}", isOptional: true)]
            public oci.LoadBalancerBackendsetA.ILoadBalancerBackendsetASessionPersistenceConfiguration? SessionPersistenceConfiguration
            {
                get => GetInstanceProperty<oci.LoadBalancerBackendsetA.ILoadBalancerBackendsetASessionPersistenceConfiguration?>();
            }

            /// <summary>ssl_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backendset#ssl_configuration LoadBalancerBackendsetA#ssl_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sslConfiguration", typeJson: "{\"fqn\":\"oci.loadBalancerBackendsetA.LoadBalancerBackendsetASslConfiguration\"}", isOptional: true)]
            public oci.LoadBalancerBackendsetA.ILoadBalancerBackendsetASslConfiguration? SslConfiguration
            {
                get => GetInstanceProperty<oci.LoadBalancerBackendsetA.ILoadBalancerBackendsetASslConfiguration?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backendset#timeouts LoadBalancerBackendsetA#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.loadBalancerBackendsetA.LoadBalancerBackendsetATimeouts\"}", isOptional: true)]
            public oci.LoadBalancerBackendsetA.ILoadBalancerBackendsetATimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.LoadBalancerBackendsetA.ILoadBalancerBackendsetATimeouts?>();
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
