using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.BotManagement
{
    [JsiiInterface(nativeType: typeof(IBotManagementConfig), fullyQualifiedName: "cloudflare.botManagement.BotManagementConfig")]
    public interface IBotManagementConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/bot_management#zone_id BotManagement#zone_id}
        /// </remarks>
        [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}")]
        string ZoneId
        {
            get;
        }

        /// <summary>Enable rule to block AI Scrapers and Crawlers.</summary>
        /// <remarks>
        /// Please note the value <c>only_on_ad_pages</c> is currently not available for Enterprise customers.
        /// Available values: "block", "disabled", "only_on_ad_pages".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/bot_management#ai_bots_protection BotManagement#ai_bots_protection}
        /// </remarks>
        [JsiiProperty(name: "aiBotsProtection", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AiBotsProtection
        {
            get
            {
                return null;
            }
        }

        /// <summary>Automatically update to the newest bot detection models created by Cloudflare as they are released. [Learn more.](https://developers.cloudflare.com/bots/reference/machine-learning-models#model-versions-and-release-notes).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/bot_management#auto_update_model BotManagement#auto_update_model}
        /// </remarks>
        [JsiiProperty(name: "autoUpdateModel", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AutoUpdateModel
        {
            get
            {
                return null;
            }
        }

        /// <summary>Indicates that the bot management cookie can be placed on end user devices accessing the site. Defaults to true.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/bot_management#bm_cookie_enabled BotManagement#bm_cookie_enabled}
        /// </remarks>
        [JsiiProperty(name: "bmCookieEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? BmCookieEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies the Robots Access Control License variant to use. Available values: "off", "policy_only".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/bot_management#cf_robots_variant BotManagement#cf_robots_variant}
        /// </remarks>
        [JsiiProperty(name: "cfRobotsVariant", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CfRobotsVariant
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enable rule to block content bots.</summary>
        /// <remarks>
        /// When enabled, blocks automated traffic with low bot scores, excluding safe verified bot categories. Exceptions should be managed via skip rules.
        /// Available values: "block", "disabled".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/bot_management#content_bots_protection BotManagement#content_bots_protection}
        /// </remarks>
        [JsiiProperty(name: "contentBotsProtection", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ContentBotsProtection
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enable rule to punish AI Scrapers and Crawlers via a link maze. Available values: "enabled", "disabled".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/bot_management#crawler_protection BotManagement#crawler_protection}
        /// </remarks>
        [JsiiProperty(name: "crawlerProtection", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CrawlerProtection
        {
            get
            {
                return null;
            }
        }

        /// <summary>Use lightweight, invisible JavaScript detections to improve Bot Management. [Learn more about JavaScript Detections](https://developers.cloudflare.com/bots/reference/javascript-detections/).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/bot_management#enable_js BotManagement#enable_js}
        /// </remarks>
        [JsiiProperty(name: "enableJs", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnableJs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether to enable Bot Fight Mode.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/bot_management#fight_mode BotManagement#fight_mode}
        /// </remarks>
        [JsiiProperty(name: "fightMode", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FightMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enable cloudflare managed robots.txt. If an existing robots.txt is detected, then managed robots.txt will be prepended to the existing robots.txt.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/bot_management#is_robots_txt_managed BotManagement#is_robots_txt_managed}
        /// </remarks>
        [JsiiProperty(name: "isRobotsTxtManaged", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsRobotsTxtManaged
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether to optimize Super Bot Fight Mode protections for Wordpress.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/bot_management#optimize_wordpress BotManagement#optimize_wordpress}
        /// </remarks>
        [JsiiProperty(name: "optimizeWordpress", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? OptimizeWordpress
        {
            get
            {
                return null;
            }
        }

        /// <summary>Super Bot Fight Mode (SBFM) action to take on definitely automated requests. Available values: "allow", "block", "managed_challenge".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/bot_management#sbfm_definitely_automated BotManagement#sbfm_definitely_automated}
        /// </remarks>
        [JsiiProperty(name: "sbfmDefinitelyAutomated", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SbfmDefinitelyAutomated
        {
            get
            {
                return null;
            }
        }

        /// <summary>Super Bot Fight Mode (SBFM) action to take on likely automated requests. Available values: "allow", "block", "managed_challenge".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/bot_management#sbfm_likely_automated BotManagement#sbfm_likely_automated}
        /// </remarks>
        [JsiiProperty(name: "sbfmLikelyAutomated", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SbfmLikelyAutomated
        {
            get
            {
                return null;
            }
        }

        /// <summary>Super Bot Fight Mode (SBFM) to enable static resource protection.</summary>
        /// <remarks>
        /// Enable if static resources on your application need bot protection.
        /// Note: Static resource protection can also result in legitimate traffic being blocked.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/bot_management#sbfm_static_resource_protection BotManagement#sbfm_static_resource_protection}
        /// </remarks>
        [JsiiProperty(name: "sbfmStaticResourceProtection", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SbfmStaticResourceProtection
        {
            get
            {
                return null;
            }
        }

        /// <summary>Super Bot Fight Mode (SBFM) action to take on verified bots requests. Available values: "allow", "block".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/bot_management#sbfm_verified_bots BotManagement#sbfm_verified_bots}
        /// </remarks>
        [JsiiProperty(name: "sbfmVerifiedBots", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SbfmVerifiedBots
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether to disable tracking the highest bot score for a session in the Bot Management cookie.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/bot_management#suppress_session_score BotManagement#suppress_session_score}
        /// </remarks>
        [JsiiProperty(name: "suppressSessionScore", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SuppressSessionScore
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBotManagementConfig), fullyQualifiedName: "cloudflare.botManagement.BotManagementConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.BotManagement.IBotManagementConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Identifier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/bot_management#zone_id BotManagement#zone_id}
            /// </remarks>
            [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}")]
            public string ZoneId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Enable rule to block AI Scrapers and Crawlers.</summary>
            /// <remarks>
            /// Please note the value <c>only_on_ad_pages</c> is currently not available for Enterprise customers.
            /// Available values: "block", "disabled", "only_on_ad_pages".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/bot_management#ai_bots_protection BotManagement#ai_bots_protection}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "aiBotsProtection", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AiBotsProtection
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Automatically update to the newest bot detection models created by Cloudflare as they are released. [Learn more.](https://developers.cloudflare.com/bots/reference/machine-learning-models#model-versions-and-release-notes).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/bot_management#auto_update_model BotManagement#auto_update_model}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "autoUpdateModel", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AutoUpdateModel
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Indicates that the bot management cookie can be placed on end user devices accessing the site. Defaults to true.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/bot_management#bm_cookie_enabled BotManagement#bm_cookie_enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bmCookieEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? BmCookieEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Specifies the Robots Access Control License variant to use. Available values: "off", "policy_only".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/bot_management#cf_robots_variant BotManagement#cf_robots_variant}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cfRobotsVariant", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CfRobotsVariant
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Enable rule to block content bots.</summary>
            /// <remarks>
            /// When enabled, blocks automated traffic with low bot scores, excluding safe verified bot categories. Exceptions should be managed via skip rules.
            /// Available values: "block", "disabled".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/bot_management#content_bots_protection BotManagement#content_bots_protection}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "contentBotsProtection", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ContentBotsProtection
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Enable rule to punish AI Scrapers and Crawlers via a link maze. Available values: "enabled", "disabled".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/bot_management#crawler_protection BotManagement#crawler_protection}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "crawlerProtection", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CrawlerProtection
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Use lightweight, invisible JavaScript detections to improve Bot Management. [Learn more about JavaScript Detections](https://developers.cloudflare.com/bots/reference/javascript-detections/).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/bot_management#enable_js BotManagement#enable_js}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enableJs", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? EnableJs
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether to enable Bot Fight Mode.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/bot_management#fight_mode BotManagement#fight_mode}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fightMode", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? FightMode
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Enable cloudflare managed robots.txt. If an existing robots.txt is detected, then managed robots.txt will be prepended to the existing robots.txt.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/bot_management#is_robots_txt_managed BotManagement#is_robots_txt_managed}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isRobotsTxtManaged", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsRobotsTxtManaged
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether to optimize Super Bot Fight Mode protections for Wordpress.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/bot_management#optimize_wordpress BotManagement#optimize_wordpress}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "optimizeWordpress", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? OptimizeWordpress
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Super Bot Fight Mode (SBFM) action to take on definitely automated requests. Available values: "allow", "block", "managed_challenge".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/bot_management#sbfm_definitely_automated BotManagement#sbfm_definitely_automated}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sbfmDefinitelyAutomated", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SbfmDefinitelyAutomated
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Super Bot Fight Mode (SBFM) action to take on likely automated requests. Available values: "allow", "block", "managed_challenge".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/bot_management#sbfm_likely_automated BotManagement#sbfm_likely_automated}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sbfmLikelyAutomated", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SbfmLikelyAutomated
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Super Bot Fight Mode (SBFM) to enable static resource protection.</summary>
            /// <remarks>
            /// Enable if static resources on your application need bot protection.
            /// Note: Static resource protection can also result in legitimate traffic being blocked.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/bot_management#sbfm_static_resource_protection BotManagement#sbfm_static_resource_protection}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sbfmStaticResourceProtection", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? SbfmStaticResourceProtection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Super Bot Fight Mode (SBFM) action to take on verified bots requests. Available values: "allow", "block".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/bot_management#sbfm_verified_bots BotManagement#sbfm_verified_bots}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sbfmVerifiedBots", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SbfmVerifiedBots
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Whether to disable tracking the highest bot score for a session in the Bot Management cookie.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/bot_management#suppress_session_score BotManagement#suppress_session_score}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "suppressSessionScore", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? SuppressSessionScore
            {
                get => GetInstanceProperty<object?>();
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
