using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnFrontdoorFirewallPolicy
{
    [JsiiInterface(nativeType: typeof(ICdnFrontdoorFirewallPolicyConfig), fullyQualifiedName: "azurerm.cdnFrontdoorFirewallPolicy.CdnFrontdoorFirewallPolicyConfig")]
    public interface ICdnFrontdoorFirewallPolicyConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_firewall_policy#mode CdnFrontdoorFirewallPolicy#mode}.</summary>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        string Mode
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_firewall_policy#name CdnFrontdoorFirewallPolicy#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_firewall_policy#resource_group_name CdnFrontdoorFirewallPolicy#resource_group_name}.</summary>
        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceGroupName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_firewall_policy#sku_name CdnFrontdoorFirewallPolicy#sku_name}.</summary>
        [JsiiProperty(name: "skuName", typeJson: "{\"primitive\":\"string\"}")]
        string SkuName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_firewall_policy#captcha_cookie_expiration_in_minutes CdnFrontdoorFirewallPolicy#captcha_cookie_expiration_in_minutes}.</summary>
        [JsiiProperty(name: "captchaCookieExpirationInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CaptchaCookieExpirationInMinutes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_firewall_policy#custom_block_response_body CdnFrontdoorFirewallPolicy#custom_block_response_body}.</summary>
        [JsiiProperty(name: "customBlockResponseBody", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CustomBlockResponseBody
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_firewall_policy#custom_block_response_status_code CdnFrontdoorFirewallPolicy#custom_block_response_status_code}.</summary>
        [JsiiProperty(name: "customBlockResponseStatusCode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CustomBlockResponseStatusCode
        {
            get
            {
                return null;
            }
        }

        /// <summary>custom_rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_firewall_policy#custom_rule CdnFrontdoorFirewallPolicy#custom_rule}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorFirewallPolicy.ICdnFrontdoorFirewallPolicyCustomRule" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "customRule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorFirewallPolicy.CdnFrontdoorFirewallPolicyCustomRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CustomRule
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_firewall_policy#enabled CdnFrontdoorFirewallPolicy#enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_firewall_policy#id CdnFrontdoorFirewallPolicy#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_firewall_policy#js_challenge_cookie_expiration_in_minutes CdnFrontdoorFirewallPolicy#js_challenge_cookie_expiration_in_minutes}.</summary>
        [JsiiProperty(name: "jsChallengeCookieExpirationInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? JsChallengeCookieExpirationInMinutes
        {
            get
            {
                return null;
            }
        }

        /// <summary>log_scrubbing block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_firewall_policy#log_scrubbing CdnFrontdoorFirewallPolicy#log_scrubbing}
        /// </remarks>
        [JsiiProperty(name: "logScrubbing", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorFirewallPolicy.CdnFrontdoorFirewallPolicyLogScrubbing\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.CdnFrontdoorFirewallPolicy.ICdnFrontdoorFirewallPolicyLogScrubbing? LogScrubbing
        {
            get
            {
                return null;
            }
        }

        /// <summary>managed_rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_firewall_policy#managed_rule CdnFrontdoorFirewallPolicy#managed_rule}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorFirewallPolicy.ICdnFrontdoorFirewallPolicyManagedRule" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "managedRule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorFirewallPolicy.CdnFrontdoorFirewallPolicyManagedRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ManagedRule
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_firewall_policy#redirect_url CdnFrontdoorFirewallPolicy#redirect_url}.</summary>
        [JsiiProperty(name: "redirectUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RedirectUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_firewall_policy#request_body_check_enabled CdnFrontdoorFirewallPolicy#request_body_check_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "requestBodyCheckEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequestBodyCheckEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_firewall_policy#tags CdnFrontdoorFirewallPolicy#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_firewall_policy#timeouts CdnFrontdoorFirewallPolicy#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorFirewallPolicy.CdnFrontdoorFirewallPolicyTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.CdnFrontdoorFirewallPolicy.ICdnFrontdoorFirewallPolicyTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICdnFrontdoorFirewallPolicyConfig), fullyQualifiedName: "azurerm.cdnFrontdoorFirewallPolicy.CdnFrontdoorFirewallPolicyConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.CdnFrontdoorFirewallPolicy.ICdnFrontdoorFirewallPolicyConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_firewall_policy#mode CdnFrontdoorFirewallPolicy#mode}.</summary>
            [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
            public string Mode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_firewall_policy#name CdnFrontdoorFirewallPolicy#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_firewall_policy#resource_group_name CdnFrontdoorFirewallPolicy#resource_group_name}.</summary>
            [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceGroupName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_firewall_policy#sku_name CdnFrontdoorFirewallPolicy#sku_name}.</summary>
            [JsiiProperty(name: "skuName", typeJson: "{\"primitive\":\"string\"}")]
            public string SkuName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_firewall_policy#captcha_cookie_expiration_in_minutes CdnFrontdoorFirewallPolicy#captcha_cookie_expiration_in_minutes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "captchaCookieExpirationInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CaptchaCookieExpirationInMinutes
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_firewall_policy#custom_block_response_body CdnFrontdoorFirewallPolicy#custom_block_response_body}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "customBlockResponseBody", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CustomBlockResponseBody
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_firewall_policy#custom_block_response_status_code CdnFrontdoorFirewallPolicy#custom_block_response_status_code}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "customBlockResponseStatusCode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CustomBlockResponseStatusCode
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>custom_rule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_firewall_policy#custom_rule CdnFrontdoorFirewallPolicy#custom_rule}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorFirewallPolicy.ICdnFrontdoorFirewallPolicyCustomRule" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customRule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorFirewallPolicy.CdnFrontdoorFirewallPolicyCustomRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CustomRule
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_firewall_policy#enabled CdnFrontdoorFirewallPolicy#enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_firewall_policy#id CdnFrontdoorFirewallPolicy#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_firewall_policy#js_challenge_cookie_expiration_in_minutes CdnFrontdoorFirewallPolicy#js_challenge_cookie_expiration_in_minutes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "jsChallengeCookieExpirationInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? JsChallengeCookieExpirationInMinutes
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>log_scrubbing block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_firewall_policy#log_scrubbing CdnFrontdoorFirewallPolicy#log_scrubbing}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logScrubbing", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorFirewallPolicy.CdnFrontdoorFirewallPolicyLogScrubbing\"}", isOptional: true)]
            public azurerm.CdnFrontdoorFirewallPolicy.ICdnFrontdoorFirewallPolicyLogScrubbing? LogScrubbing
            {
                get => GetInstanceProperty<azurerm.CdnFrontdoorFirewallPolicy.ICdnFrontdoorFirewallPolicyLogScrubbing?>();
            }

            /// <summary>managed_rule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_firewall_policy#managed_rule CdnFrontdoorFirewallPolicy#managed_rule}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorFirewallPolicy.ICdnFrontdoorFirewallPolicyManagedRule" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "managedRule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorFirewallPolicy.CdnFrontdoorFirewallPolicyManagedRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ManagedRule
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_firewall_policy#redirect_url CdnFrontdoorFirewallPolicy#redirect_url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "redirectUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RedirectUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_firewall_policy#request_body_check_enabled CdnFrontdoorFirewallPolicy#request_body_check_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requestBodyCheckEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? RequestBodyCheckEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_firewall_policy#tags CdnFrontdoorFirewallPolicy#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_firewall_policy#timeouts CdnFrontdoorFirewallPolicy#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorFirewallPolicy.CdnFrontdoorFirewallPolicyTimeouts\"}", isOptional: true)]
            public azurerm.CdnFrontdoorFirewallPolicy.ICdnFrontdoorFirewallPolicyTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.CdnFrontdoorFirewallPolicy.ICdnFrontdoorFirewallPolicyTimeouts?>();
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
