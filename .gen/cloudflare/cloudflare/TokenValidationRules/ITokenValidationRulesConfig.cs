using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.TokenValidationRules
{
    [JsiiInterface(nativeType: typeof(ITokenValidationRulesConfig), fullyQualifiedName: "cloudflare.tokenValidationRules.TokenValidationRulesConfig")]
    public interface ITokenValidationRulesConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Action to take on requests that match operations included in `selector` and fail `expression`. Available values: "log", "block".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/token_validation_rules#action TokenValidationRules#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        string Action
        {
            get;
        }

        /// <summary>A human-readable description that gives more details than `title`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/token_validation_rules#description TokenValidationRules#description}
        /// </remarks>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        string Description
        {
            get;
        }

        /// <summary>Toggle rule on or off.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/token_validation_rules#enabled TokenValidationRules#enabled}
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        /// <summary>Rule expression. Requests that fail to match this expression will be subject to `action`.</summary>
        /// <remarks>
        /// For details on expressions, see the <a href="https://developers.cloudflare.com/api-shield/security/jwt-validation/">Cloudflare Docs</a>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/token_validation_rules#expression TokenValidationRules#expression}
        /// </remarks>
        [JsiiProperty(name: "expression", typeJson: "{\"primitive\":\"string\"}")]
        string Expression
        {
            get;
        }

        /// <summary>Select operations covered by this rule.</summary>
        /// <remarks>
        /// For details on selectors, see the <a href="https://developers.cloudflare.com/api-shield/security/jwt-validation/">Cloudflare Docs</a>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/token_validation_rules#selector TokenValidationRules#selector}
        /// </remarks>
        [JsiiProperty(name: "selector", typeJson: "{\"fqn\":\"cloudflare.tokenValidationRules.TokenValidationRulesSelector\"}")]
        cloudflare.TokenValidationRules.ITokenValidationRulesSelector Selector
        {
            get;
        }

        /// <summary>A human-readable name for the rule.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/token_validation_rules#title TokenValidationRules#title}
        /// </remarks>
        [JsiiProperty(name: "title", typeJson: "{\"primitive\":\"string\"}")]
        string Title
        {
            get;
        }

        /// <summary>Identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/token_validation_rules#zone_id TokenValidationRules#zone_id}
        /// </remarks>
        [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}")]
        string ZoneId
        {
            get;
        }

        /// <summary>Update rule order among zone rules.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/token_validation_rules#position TokenValidationRules#position}
        /// </remarks>
        [JsiiProperty(name: "position", typeJson: "{\"fqn\":\"cloudflare.tokenValidationRules.TokenValidationRulesPosition\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.TokenValidationRules.ITokenValidationRulesPosition? Position
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ITokenValidationRulesConfig), fullyQualifiedName: "cloudflare.tokenValidationRules.TokenValidationRulesConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.TokenValidationRules.ITokenValidationRulesConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Action to take on requests that match operations included in `selector` and fail `expression`. Available values: "log", "block".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/token_validation_rules#action TokenValidationRules#action}
            /// </remarks>
            [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
            public string Action
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>A human-readable description that gives more details than `title`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/token_validation_rules#description TokenValidationRules#description}
            /// </remarks>
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
            public string Description
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Toggle rule on or off.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/token_validation_rules#enabled TokenValidationRules#enabled}
            /// </remarks>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Rule expression. Requests that fail to match this expression will be subject to `action`.</summary>
            /// <remarks>
            /// For details on expressions, see the <a href="https://developers.cloudflare.com/api-shield/security/jwt-validation/">Cloudflare Docs</a>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/token_validation_rules#expression TokenValidationRules#expression}
            /// </remarks>
            [JsiiProperty(name: "expression", typeJson: "{\"primitive\":\"string\"}")]
            public string Expression
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Select operations covered by this rule.</summary>
            /// <remarks>
            /// For details on selectors, see the <a href="https://developers.cloudflare.com/api-shield/security/jwt-validation/">Cloudflare Docs</a>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/token_validation_rules#selector TokenValidationRules#selector}
            /// </remarks>
            [JsiiProperty(name: "selector", typeJson: "{\"fqn\":\"cloudflare.tokenValidationRules.TokenValidationRulesSelector\"}")]
            public cloudflare.TokenValidationRules.ITokenValidationRulesSelector Selector
            {
                get => GetInstanceProperty<cloudflare.TokenValidationRules.ITokenValidationRulesSelector>()!;
            }

            /// <summary>A human-readable name for the rule.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/token_validation_rules#title TokenValidationRules#title}
            /// </remarks>
            [JsiiProperty(name: "title", typeJson: "{\"primitive\":\"string\"}")]
            public string Title
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Identifier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/token_validation_rules#zone_id TokenValidationRules#zone_id}
            /// </remarks>
            [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}")]
            public string ZoneId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Update rule order among zone rules.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/token_validation_rules#position TokenValidationRules#position}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "position", typeJson: "{\"fqn\":\"cloudflare.tokenValidationRules.TokenValidationRulesPosition\"}", isOptional: true)]
            public cloudflare.TokenValidationRules.ITokenValidationRulesPosition? Position
            {
                get => GetInstanceProperty<cloudflare.TokenValidationRules.ITokenValidationRulesPosition?>();
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
