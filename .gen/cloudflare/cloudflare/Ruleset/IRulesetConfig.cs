using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Ruleset
{
    [JsiiInterface(nativeType: typeof(IRulesetConfig), fullyQualifiedName: "cloudflare.ruleset.RulesetConfig")]
    public interface IRulesetConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The kind of the ruleset. Available values: "managed", "custom", "root", "zone".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#kind Ruleset#kind}
        /// </remarks>
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        string Kind
        {
            get;
        }

        /// <summary>The human-readable name of the ruleset.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#name Ruleset#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>The phase of the ruleset.</summary>
        /// <remarks>
        /// Available values: "ddos_l4", "ddos_l7", "http_config_settings", "http_custom_errors", "http_log_custom_fields", "http_ratelimit", "http_request_cache_settings", "http_request_dynamic_redirect", "http_request_firewall_custom", "http_request_firewall_managed", "http_request_late_transform", "http_request_origin", "http_request_redirect", "http_request_sanitize", "http_request_sbfm", "http_request_transform", "http_response_cache_settings", "http_response_compression", "http_response_firewall_managed", "http_response_headers_transform", "magic_transit", "magic_transit_ids_managed", "magic_transit_managed", "magic_transit_ratelimit".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#phase Ruleset#phase}
        /// </remarks>
        [JsiiProperty(name: "phase", typeJson: "{\"primitive\":\"string\"}")]
        string Phase
        {
            get;
        }

        /// <summary>The unique ID of the account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#account_id Ruleset#account_id}
        /// </remarks>
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccountId
        {
            get
            {
                return null;
            }
        }

        /// <summary>An informative description of the ruleset.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#description Ruleset#description}
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

        /// <summary>The list of rules in the ruleset.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#rules Ruleset#rules}
        /// </remarks>
        [JsiiProperty(name: "rules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.ruleset.RulesetRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Rules
        {
            get
            {
                return null;
            }
        }

        /// <summary>The unique ID of the zone.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#zone_id Ruleset#zone_id}
        /// </remarks>
        [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ZoneId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRulesetConfig), fullyQualifiedName: "cloudflare.ruleset.RulesetConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Ruleset.IRulesetConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The kind of the ruleset. Available values: "managed", "custom", "root", "zone".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#kind Ruleset#kind}
            /// </remarks>
            [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
            public string Kind
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The human-readable name of the ruleset.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#name Ruleset#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The phase of the ruleset.</summary>
            /// <remarks>
            /// Available values: "ddos_l4", "ddos_l7", "http_config_settings", "http_custom_errors", "http_log_custom_fields", "http_ratelimit", "http_request_cache_settings", "http_request_dynamic_redirect", "http_request_firewall_custom", "http_request_firewall_managed", "http_request_late_transform", "http_request_origin", "http_request_redirect", "http_request_sanitize", "http_request_sbfm", "http_request_transform", "http_response_cache_settings", "http_response_compression", "http_response_firewall_managed", "http_response_headers_transform", "magic_transit", "magic_transit_ids_managed", "magic_transit_managed", "magic_transit_ratelimit".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#phase Ruleset#phase}
            /// </remarks>
            [JsiiProperty(name: "phase", typeJson: "{\"primitive\":\"string\"}")]
            public string Phase
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The unique ID of the account.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#account_id Ruleset#account_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccountId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>An informative description of the ruleset.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#description Ruleset#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The list of rules in the ruleset.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#rules Ruleset#rules}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.ruleset.RulesetRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Rules
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The unique ID of the zone.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#zone_id Ruleset#zone_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ZoneId
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
