using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.LbRoute
{
    [JsiiInterface(nativeType: typeof(ILbRouteConfig), fullyQualifiedName: "scaleway.lbRoute.LbRouteConfig")]
    public interface ILbRouteConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The backend ID destination of redirection.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/lb_route#backend_id LbRoute#backend_id}
        /// </remarks>
        [JsiiProperty(name: "backendId", typeJson: "{\"primitive\":\"string\"}")]
        string BackendId
        {
            get;
        }

        /// <summary>The frontend ID origin of redirection.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/lb_route#frontend_id LbRoute#frontend_id}
        /// </remarks>
        [JsiiProperty(name: "frontendId", typeJson: "{\"primitive\":\"string\"}")]
        string FrontendId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/lb_route#id LbRoute#id}.</summary>
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

        /// <summary>Specifies the host of the server to which the request is being sent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/lb_route#match_host_header LbRoute#match_host_header}
        /// </remarks>
        [JsiiProperty(name: "matchHostHeader", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MatchHostHeader
        {
            get
            {
                return null;
            }
        }

        /// <summary>Value to match in the URL beginning path from an incoming request.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/lb_route#match_path_begin LbRoute#match_path_begin}
        /// </remarks>
        [JsiiProperty(name: "matchPathBegin", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MatchPathBegin
        {
            get
            {
                return null;
            }
        }

        /// <summary>Server Name Indication TLS extension field from an incoming connection made via an SSL/TLS transport layer.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/lb_route#match_sni LbRoute#match_sni}
        /// </remarks>
        [JsiiProperty(name: "matchSni", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MatchSni
        {
            get
            {
                return null;
            }
        }

        /// <summary>If true, all subdomains will match.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/lb_route#match_subdomains LbRoute#match_subdomains}
        /// </remarks>
        [JsiiProperty(name: "matchSubdomains", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MatchSubdomains
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/lb_route#timeouts LbRoute#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"scaleway.lbRoute.LbRouteTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        scaleway.LbRoute.ILbRouteTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILbRouteConfig), fullyQualifiedName: "scaleway.lbRoute.LbRouteConfig")]
        internal sealed class _Proxy : DeputyBase, scaleway.LbRoute.ILbRouteConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The backend ID destination of redirection.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/lb_route#backend_id LbRoute#backend_id}
            /// </remarks>
            [JsiiProperty(name: "backendId", typeJson: "{\"primitive\":\"string\"}")]
            public string BackendId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The frontend ID origin of redirection.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/lb_route#frontend_id LbRoute#frontend_id}
            /// </remarks>
            [JsiiProperty(name: "frontendId", typeJson: "{\"primitive\":\"string\"}")]
            public string FrontendId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/lb_route#id LbRoute#id}.</summary>
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

            /// <summary>Specifies the host of the server to which the request is being sent.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/lb_route#match_host_header LbRoute#match_host_header}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "matchHostHeader", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MatchHostHeader
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Value to match in the URL beginning path from an incoming request.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/lb_route#match_path_begin LbRoute#match_path_begin}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "matchPathBegin", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MatchPathBegin
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Server Name Indication TLS extension field from an incoming connection made via an SSL/TLS transport layer.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/lb_route#match_sni LbRoute#match_sni}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "matchSni", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MatchSni
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>If true, all subdomains will match.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/lb_route#match_subdomains LbRoute#match_subdomains}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "matchSubdomains", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? MatchSubdomains
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/lb_route#timeouts LbRoute#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"scaleway.lbRoute.LbRouteTimeouts\"}", isOptional: true)]
            public scaleway.LbRoute.ILbRouteTimeouts? Timeouts
            {
                get => GetInstanceProperty<scaleway.LbRoute.ILbRouteTimeouts?>();
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
