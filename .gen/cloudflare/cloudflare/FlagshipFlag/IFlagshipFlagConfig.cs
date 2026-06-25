using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.FlagshipFlag
{
    [JsiiInterface(nativeType: typeof(IFlagshipFlagConfig), fullyQualifiedName: "cloudflare.flagshipFlag.FlagshipFlagConfig")]
    public interface IFlagshipFlagConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Cloudflare account ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/flagship_flag#account_id FlagshipFlag#account_id}
        /// </remarks>
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        string AccountId
        {
            get;
        }

        /// <summary>App identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/flagship_flag#app_id FlagshipFlag#app_id}
        /// </remarks>
        [JsiiProperty(name: "appId", typeJson: "{\"primitive\":\"string\"}")]
        string AppId
        {
            get;
        }

        /// <summary>Variation served when no rule matches or the flag is disabled. Must be a key in `variations`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/flagship_flag#default_variation FlagshipFlag#default_variation}
        /// </remarks>
        [JsiiProperty(name: "defaultVariation", typeJson: "{\"primitive\":\"string\"}")]
        string DefaultVariation
        {
            get;
        }

        /// <summary>When false, the flag bypasses all rules and always serves `default_variation`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/flagship_flag#enabled FlagshipFlag#enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        /// <summary>Unique identifier for the flag within an app. Used in all evaluation and SDK calls.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/flagship_flag#key FlagshipFlag#key}
        /// </remarks>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Targeting rules evaluated in ascending `priority`;</summary>
        /// <remarks>
        /// the first matching rule wins. An empty array means the flag always serves <c>default_variation</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/flagship_flag#rules FlagshipFlag#rules}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="cloudflare.FlagshipFlag.IFlagshipFlagRules" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "rules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.flagshipFlag.FlagshipFlagRules\"},\"kind\":\"array\"}}]}}")]
        object Rules
        {
            get;
        }

        /// <summary>Map of variation name to value.</summary>
        /// <remarks>
        /// All values must be the same type (boolean, string, number, or JSON object/array). Each serialized value must be 10KB or smaller.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/flagship_flag#variations FlagshipFlag#variations}
        /// </remarks>
        [JsiiProperty(name: "variations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        System.Collections.Generic.IDictionary<string, string> Variations
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/flagship_flag#description FlagshipFlag#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Flag key (slug).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/flagship_flag#flag_key FlagshipFlag#flag_key}
        /// </remarks>
        [JsiiProperty(name: "flagKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FlagKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Value type of the flag's variations.</summary>
        /// <remarks>
        /// Inferred from the variation values on write, so it may be omitted in requests.
        /// Available values: "boolean", "string", "number", "json".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/flagship_flag#type FlagshipFlag#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFlagshipFlagConfig), fullyQualifiedName: "cloudflare.flagshipFlag.FlagshipFlagConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.FlagshipFlag.IFlagshipFlagConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Cloudflare account ID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/flagship_flag#account_id FlagshipFlag#account_id}
            /// </remarks>
            [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
            public string AccountId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>App identifier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/flagship_flag#app_id FlagshipFlag#app_id}
            /// </remarks>
            [JsiiProperty(name: "appId", typeJson: "{\"primitive\":\"string\"}")]
            public string AppId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Variation served when no rule matches or the flag is disabled. Must be a key in `variations`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/flagship_flag#default_variation FlagshipFlag#default_variation}
            /// </remarks>
            [JsiiProperty(name: "defaultVariation", typeJson: "{\"primitive\":\"string\"}")]
            public string DefaultVariation
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>When false, the flag bypasses all rules and always serves `default_variation`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/flagship_flag#enabled FlagshipFlag#enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Unique identifier for the flag within an app. Used in all evaluation and SDK calls.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/flagship_flag#key FlagshipFlag#key}
            /// </remarks>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Targeting rules evaluated in ascending `priority`;</summary>
            /// <remarks>
            /// the first matching rule wins. An empty array means the flag always serves <c>default_variation</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/flagship_flag#rules FlagshipFlag#rules}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="cloudflare.FlagshipFlag.IFlagshipFlagRules" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "rules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.flagshipFlag.FlagshipFlagRules\"},\"kind\":\"array\"}}]}}")]
            public object Rules
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Map of variation name to value.</summary>
            /// <remarks>
            /// All values must be the same type (boolean, string, number, or JSON object/array). Each serialized value must be 10KB or smaller.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/flagship_flag#variations FlagshipFlag#variations}
            /// </remarks>
            [JsiiProperty(name: "variations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
            public System.Collections.Generic.IDictionary<string, string> Variations
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/flagship_flag#description FlagshipFlag#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Flag key (slug).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/flagship_flag#flag_key FlagshipFlag#flag_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "flagKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FlagKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Value type of the flag's variations.</summary>
            /// <remarks>
            /// Inferred from the variation values on write, so it may be omitted in requests.
            /// Available values: "boolean", "string", "number", "json".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/flagship_flag#type FlagshipFlag#type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
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
            /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
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
