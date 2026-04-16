using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.GradientaiAgentRoute
{
    [JsiiInterface(nativeType: typeof(IGradientaiAgentRouteConfig), fullyQualifiedName: "digitalocean.gradientaiAgentRoute.GradientaiAgentRouteConfig")]
    public interface IGradientaiAgentRouteConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The UUID of the child agent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent_route#child_agent_uuid GradientaiAgentRoute#child_agent_uuid}
        /// </remarks>
        [JsiiProperty(name: "childAgentUuid", typeJson: "{\"primitive\":\"string\"}")]
        string ChildAgentUuid
        {
            get;
        }

        /// <summary>The UUID of the parent agent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent_route#parent_agent_uuid GradientaiAgentRoute#parent_agent_uuid}
        /// </remarks>
        [JsiiProperty(name: "parentAgentUuid", typeJson: "{\"primitive\":\"string\"}")]
        string ParentAgentUuid
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent_route#id GradientaiAgentRoute#id}.</summary>
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

        /// <summary>if-case condition for the route.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent_route#if_case GradientaiAgentRoute#if_case}
        /// </remarks>
        [JsiiProperty(name: "ifCase", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IfCase
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent_route#rollback GradientaiAgentRoute#rollback}.</summary>
        [JsiiProperty(name: "rollback", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Rollback
        {
            get
            {
                return null;
            }
        }

        /// <summary>A name for the route.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent_route#route_name GradientaiAgentRoute#route_name}
        /// </remarks>
        [JsiiProperty(name: "routeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RouteName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGradientaiAgentRouteConfig), fullyQualifiedName: "digitalocean.gradientaiAgentRoute.GradientaiAgentRouteConfig")]
        internal sealed class _Proxy : DeputyBase, digitalocean.GradientaiAgentRoute.IGradientaiAgentRouteConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The UUID of the child agent.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent_route#child_agent_uuid GradientaiAgentRoute#child_agent_uuid}
            /// </remarks>
            [JsiiProperty(name: "childAgentUuid", typeJson: "{\"primitive\":\"string\"}")]
            public string ChildAgentUuid
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The UUID of the parent agent.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent_route#parent_agent_uuid GradientaiAgentRoute#parent_agent_uuid}
            /// </remarks>
            [JsiiProperty(name: "parentAgentUuid", typeJson: "{\"primitive\":\"string\"}")]
            public string ParentAgentUuid
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent_route#id GradientaiAgentRoute#id}.</summary>
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

            /// <summary>if-case condition for the route.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent_route#if_case GradientaiAgentRoute#if_case}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ifCase", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IfCase
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent_route#rollback GradientaiAgentRoute#rollback}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "rollback", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Rollback
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>A name for the route.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent_route#route_name GradientaiAgentRoute#route_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "routeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RouteName
            {
                get => GetInstanceProperty<string?>();
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
