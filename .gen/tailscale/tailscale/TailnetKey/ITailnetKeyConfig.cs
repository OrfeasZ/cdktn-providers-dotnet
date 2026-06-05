using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace tailscale.TailnetKey
{
    [JsiiInterface(nativeType: typeof(ITailnetKeyConfig), fullyQualifiedName: "tailscale.tailnetKey.TailnetKeyConfig")]
    public interface ITailnetKeyConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>A description of the key consisting of alphanumeric characters. Defaults to `""`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/tailnet_key#description TailnetKey#description}
        /// </remarks>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Indicates if the key is ephemeral. Defaults to `false`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/tailnet_key#ephemeral TailnetKey#ephemeral}
        /// </remarks>
        [JsiiProperty(name: "ephemeral", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Ephemeral
        {
            get
            {
                return null;
            }
        }

        /// <summary>The expiry of the key in seconds. Defaults to `7776000` (90 days).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/tailnet_key#expiry TailnetKey#expiry}
        /// </remarks>
        [JsiiProperty(name: "expiry", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Expiry
        {
            get
            {
                return null;
            }
        }

        /// <summary>Determines whether or not the machines authenticated by the key will be authorized for the tailnet by default.</summary>
        /// <remarks>
        /// Defaults to <c>false</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/tailnet_key#preauthorized TailnetKey#preauthorized}
        /// </remarks>
        [JsiiProperty(name: "preauthorized", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Preauthorized
        {
            get
            {
                return null;
            }
        }

        /// <summary>Determines whether the key should be created again if it becomes invalid.</summary>
        /// <remarks>
        /// By default, reusable keys will be recreated, but single-use keys will not. Possible values: 'always', 'never'.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/tailnet_key#recreate_if_invalid TailnetKey#recreate_if_invalid}
        /// </remarks>
        [JsiiProperty(name: "recreateIfInvalid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RecreateIfInvalid
        {
            get
            {
                return null;
            }
        }

        /// <summary>Indicates if the key is reusable or single-use. Defaults to `false`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/tailnet_key#reusable TailnetKey#reusable}
        /// </remarks>
        [JsiiProperty(name: "reusable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Reusable
        {
            get
            {
                return null;
            }
        }

        /// <summary>List of tags to apply to the machines authenticated by the key.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/tailnet_key#tags TailnetKey#tags}
        /// </remarks>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>ID of the user who created this key, empty for keys created by OAuth clients.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/tailnet_key#user_id TailnetKey#user_id}
        /// </remarks>
        [JsiiProperty(name: "userId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ITailnetKeyConfig), fullyQualifiedName: "tailscale.tailnetKey.TailnetKeyConfig")]
        internal sealed class _Proxy : DeputyBase, tailscale.TailnetKey.ITailnetKeyConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>A description of the key consisting of alphanumeric characters. Defaults to `""`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/tailnet_key#description TailnetKey#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Indicates if the key is ephemeral. Defaults to `false`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/tailnet_key#ephemeral TailnetKey#ephemeral}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ephemeral", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Ephemeral
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The expiry of the key in seconds. Defaults to `7776000` (90 days).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/tailnet_key#expiry TailnetKey#expiry}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "expiry", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Expiry
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Determines whether or not the machines authenticated by the key will be authorized for the tailnet by default.</summary>
            /// <remarks>
            /// Defaults to <c>false</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/tailnet_key#preauthorized TailnetKey#preauthorized}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "preauthorized", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Preauthorized
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Determines whether the key should be created again if it becomes invalid.</summary>
            /// <remarks>
            /// By default, reusable keys will be recreated, but single-use keys will not. Possible values: 'always', 'never'.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/tailnet_key#recreate_if_invalid TailnetKey#recreate_if_invalid}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "recreateIfInvalid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RecreateIfInvalid
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Indicates if the key is reusable or single-use. Defaults to `false`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/tailnet_key#reusable TailnetKey#reusable}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "reusable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Reusable
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>List of tags to apply to the machines authenticated by the key.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/tailnet_key#tags TailnetKey#tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Tags
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>ID of the user who created this key, empty for keys created by OAuth clients.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/tailnet_key#user_id TailnetKey#user_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "userId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserId
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
