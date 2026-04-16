using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.LbFrontend
{
    [JsiiInterface(nativeType: typeof(ILbFrontendConfig), fullyQualifiedName: "scaleway.lbFrontend.LbFrontendConfig")]
    public interface ILbFrontendConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The load-balancer backend ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_frontend#backend_id LbFrontend#backend_id}
        /// </remarks>
        [JsiiProperty(name: "backendId", typeJson: "{\"primitive\":\"string\"}")]
        string BackendId
        {
            get;
        }

        /// <summary>TCP port to listen on the front side.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_frontend#inbound_port LbFrontend#inbound_port}
        /// </remarks>
        [JsiiProperty(name: "inboundPort", typeJson: "{\"primitive\":\"number\"}")]
        double InboundPort
        {
            get;
        }

        /// <summary>The load-balancer ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_frontend#lb_id LbFrontend#lb_id}
        /// </remarks>
        [JsiiProperty(name: "lbId", typeJson: "{\"primitive\":\"string\"}")]
        string LbId
        {
            get;
        }

        /// <summary>acl block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_frontend#acl LbFrontend#acl}
        /// </remarks>
        [JsiiProperty(name: "acl", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.lbFrontend.LbFrontendAcl\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Acl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Collection of Certificate IDs related to the load balancer and domain.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_frontend#certificate_ids LbFrontend#certificate_ids}
        /// </remarks>
        [JsiiProperty(name: "certificateIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? CertificateIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Rate limit for new connections established on this frontend.</summary>
        /// <remarks>
        /// Use 0 value to disable, else value is connections per second
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_frontend#connection_rate_limit LbFrontend#connection_rate_limit}
        /// </remarks>
        [JsiiProperty(name: "connectionRateLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ConnectionRateLimit
        {
            get
            {
                return null;
            }
        }

        /// <summary>Defines whether to enable access logs on the frontend.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_frontend#enable_access_logs LbFrontend#enable_access_logs}
        /// </remarks>
        [JsiiProperty(name: "enableAccessLogs", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnableAccessLogs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Activates HTTP/3 protocol.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_frontend#enable_http3 LbFrontend#enable_http3}
        /// </remarks>
        [JsiiProperty(name: "enableHttp3", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnableHttp3
        {
            get
            {
                return null;
            }
        }

        /// <summary>This boolean determines if ACLs should be managed externally through the 'lb_acl' resource.</summary>
        /// <remarks>
        /// If set to <c>true</c>, <c>acl</c> attribute cannot be set directly in the lb frontend
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_frontend#external_acls LbFrontend#external_acls}
        /// </remarks>
        [JsiiProperty(name: "externalAcls", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ExternalAcls
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_frontend#id LbFrontend#id}.</summary>
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

        /// <summary>The name of the frontend.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_frontend#name LbFrontend#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Set the maximum inactivity time on the client side.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_frontend#timeout_client LbFrontend#timeout_client}
        /// </remarks>
        [JsiiProperty(name: "timeoutClient", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeoutClient
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_frontend#timeouts LbFrontend#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"scaleway.lbFrontend.LbFrontendTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        scaleway.LbFrontend.ILbFrontendTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILbFrontendConfig), fullyQualifiedName: "scaleway.lbFrontend.LbFrontendConfig")]
        internal sealed class _Proxy : DeputyBase, scaleway.LbFrontend.ILbFrontendConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The load-balancer backend ID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_frontend#backend_id LbFrontend#backend_id}
            /// </remarks>
            [JsiiProperty(name: "backendId", typeJson: "{\"primitive\":\"string\"}")]
            public string BackendId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>TCP port to listen on the front side.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_frontend#inbound_port LbFrontend#inbound_port}
            /// </remarks>
            [JsiiProperty(name: "inboundPort", typeJson: "{\"primitive\":\"number\"}")]
            public double InboundPort
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>The load-balancer ID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_frontend#lb_id LbFrontend#lb_id}
            /// </remarks>
            [JsiiProperty(name: "lbId", typeJson: "{\"primitive\":\"string\"}")]
            public string LbId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>acl block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_frontend#acl LbFrontend#acl}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "acl", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.lbFrontend.LbFrontendAcl\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Acl
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Collection of Certificate IDs related to the load balancer and domain.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_frontend#certificate_ids LbFrontend#certificate_ids}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "certificateIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? CertificateIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Rate limit for new connections established on this frontend.</summary>
            /// <remarks>
            /// Use 0 value to disable, else value is connections per second
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_frontend#connection_rate_limit LbFrontend#connection_rate_limit}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connectionRateLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ConnectionRateLimit
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Defines whether to enable access logs on the frontend.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_frontend#enable_access_logs LbFrontend#enable_access_logs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enableAccessLogs", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? EnableAccessLogs
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Activates HTTP/3 protocol.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_frontend#enable_http3 LbFrontend#enable_http3}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enableHttp3", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? EnableHttp3
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>This boolean determines if ACLs should be managed externally through the 'lb_acl' resource.</summary>
            /// <remarks>
            /// If set to <c>true</c>, <c>acl</c> attribute cannot be set directly in the lb frontend
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_frontend#external_acls LbFrontend#external_acls}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "externalAcls", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ExternalAcls
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_frontend#id LbFrontend#id}.</summary>
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

            /// <summary>The name of the frontend.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_frontend#name LbFrontend#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Set the maximum inactivity time on the client side.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_frontend#timeout_client LbFrontend#timeout_client}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeoutClient", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeoutClient
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_frontend#timeouts LbFrontend#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"scaleway.lbFrontend.LbFrontendTimeouts\"}", isOptional: true)]
            public scaleway.LbFrontend.ILbFrontendTimeouts? Timeouts
            {
                get => GetInstanceProperty<scaleway.LbFrontend.ILbFrontendTimeouts?>();
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
