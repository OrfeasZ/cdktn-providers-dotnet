using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.FunctionAppFlexConsumption
{
    [JsiiInterface(nativeType: typeof(IFunctionAppFlexConsumptionAuthSettings), fullyQualifiedName: "azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettings")]
    public interface IFunctionAppFlexConsumptionAuthSettings
    {
        /// <summary>Should the Authentication / Authorization feature be enabled?</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/function_app_flex_consumption#enabled FunctionAppFlexConsumption#enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        /// <summary>active_directory block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/function_app_flex_consumption#active_directory FunctionAppFlexConsumption#active_directory}
        /// </remarks>
        [JsiiProperty(name: "activeDirectory", typeJson: "{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettingsActiveDirectory\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAuthSettingsActiveDirectory? ActiveDirectory
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies a map of Login Parameters to send to the OpenID Connect authorization endpoint when a user logs in.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/function_app_flex_consumption#additional_login_parameters FunctionAppFlexConsumption#additional_login_parameters}
        /// </remarks>
        [JsiiProperty(name: "additionalLoginParameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? AdditionalLoginParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies a list of External URLs that can be redirected to as part of logging in or logging out of the Windows Web App.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/function_app_flex_consumption#allowed_external_redirect_urls FunctionAppFlexConsumption#allowed_external_redirect_urls}
        /// </remarks>
        [JsiiProperty(name: "allowedExternalRedirectUrls", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowedExternalRedirectUrls
        {
            get
            {
                return null;
            }
        }

        /// <summary>The default authentication provider to use when multiple providers are configured.</summary>
        /// <remarks>
        /// Possible values include: <c>AzureActiveDirectory</c>, <c>Facebook</c>, <c>Google</c>, <c>MicrosoftAccount</c>, <c>Twitter</c>, <c>Github</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/function_app_flex_consumption#default_provider FunctionAppFlexConsumption#default_provider}
        /// </remarks>
        [JsiiProperty(name: "defaultProvider", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefaultProvider
        {
            get
            {
                return null;
            }
        }

        /// <summary>facebook block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/function_app_flex_consumption#facebook FunctionAppFlexConsumption#facebook}
        /// </remarks>
        [JsiiProperty(name: "facebook", typeJson: "{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettingsFacebook\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAuthSettingsFacebook? Facebook
        {
            get
            {
                return null;
            }
        }

        /// <summary>github block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/function_app_flex_consumption#github FunctionAppFlexConsumption#github}
        /// </remarks>
        [JsiiProperty(name: "github", typeJson: "{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettingsGithub\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAuthSettingsGithub? Github
        {
            get
            {
                return null;
            }
        }

        /// <summary>google block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/function_app_flex_consumption#google FunctionAppFlexConsumption#google}
        /// </remarks>
        [JsiiProperty(name: "google", typeJson: "{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettingsGoogle\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAuthSettingsGoogle? Google
        {
            get
            {
                return null;
            }
        }

        /// <summary>The OpenID Connect Issuer URI that represents the entity which issues access tokens.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/function_app_flex_consumption#issuer FunctionAppFlexConsumption#issuer}
        /// </remarks>
        [JsiiProperty(name: "issuer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Issuer
        {
            get
            {
                return null;
            }
        }

        /// <summary>microsoft block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/function_app_flex_consumption#microsoft FunctionAppFlexConsumption#microsoft}
        /// </remarks>
        [JsiiProperty(name: "microsoft", typeJson: "{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettingsMicrosoft\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAuthSettingsMicrosoft? Microsoft
        {
            get
            {
                return null;
            }
        }

        /// <summary>The RuntimeVersion of the Authentication / Authorization feature in use.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/function_app_flex_consumption#runtime_version FunctionAppFlexConsumption#runtime_version}
        /// </remarks>
        [JsiiProperty(name: "runtimeVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RuntimeVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>The number of hours after session token expiration that a session token can be used to call the token refresh API.</summary>
        /// <remarks>
        /// Defaults to <c>72</c> hours.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/function_app_flex_consumption#token_refresh_extension_hours FunctionAppFlexConsumption#token_refresh_extension_hours}
        /// </remarks>
        [JsiiProperty(name: "tokenRefreshExtensionHours", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TokenRefreshExtensionHours
        {
            get
            {
                return null;
            }
        }

        /// <summary>Should the Windows Web App durably store platform-specific security tokens that are obtained during login flows? Defaults to `false`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/function_app_flex_consumption#token_store_enabled FunctionAppFlexConsumption#token_store_enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "tokenStoreEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TokenStoreEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>twitter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/function_app_flex_consumption#twitter FunctionAppFlexConsumption#twitter}
        /// </remarks>
        [JsiiProperty(name: "twitter", typeJson: "{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettingsTwitter\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAuthSettingsTwitter? Twitter
        {
            get
            {
                return null;
            }
        }

        /// <summary>The action to take when an unauthenticated client attempts to access the app. Possible values include: `RedirectToLoginPage`, `AllowAnonymous`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/function_app_flex_consumption#unauthenticated_client_action FunctionAppFlexConsumption#unauthenticated_client_action}
        /// </remarks>
        [JsiiProperty(name: "unauthenticatedClientAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UnauthenticatedClientAction
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFunctionAppFlexConsumptionAuthSettings), fullyQualifiedName: "azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettings")]
        internal sealed class _Proxy : DeputyBase, azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAuthSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Should the Authentication / Authorization feature be enabled?</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/function_app_flex_consumption#enabled FunctionAppFlexConsumption#enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>active_directory block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/function_app_flex_consumption#active_directory FunctionAppFlexConsumption#active_directory}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "activeDirectory", typeJson: "{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettingsActiveDirectory\"}", isOptional: true)]
            public azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAuthSettingsActiveDirectory? ActiveDirectory
            {
                get => GetInstanceProperty<azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAuthSettingsActiveDirectory?>();
            }

            /// <summary>Specifies a map of Login Parameters to send to the OpenID Connect authorization endpoint when a user logs in.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/function_app_flex_consumption#additional_login_parameters FunctionAppFlexConsumption#additional_login_parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "additionalLoginParameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? AdditionalLoginParameters
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Specifies a list of External URLs that can be redirected to as part of logging in or logging out of the Windows Web App.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/function_app_flex_consumption#allowed_external_redirect_urls FunctionAppFlexConsumption#allowed_external_redirect_urls}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowedExternalRedirectUrls", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowedExternalRedirectUrls
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>The default authentication provider to use when multiple providers are configured.</summary>
            /// <remarks>
            /// Possible values include: <c>AzureActiveDirectory</c>, <c>Facebook</c>, <c>Google</c>, <c>MicrosoftAccount</c>, <c>Twitter</c>, <c>Github</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/function_app_flex_consumption#default_provider FunctionAppFlexConsumption#default_provider}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "defaultProvider", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultProvider
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>facebook block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/function_app_flex_consumption#facebook FunctionAppFlexConsumption#facebook}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "facebook", typeJson: "{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettingsFacebook\"}", isOptional: true)]
            public azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAuthSettingsFacebook? Facebook
            {
                get => GetInstanceProperty<azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAuthSettingsFacebook?>();
            }

            /// <summary>github block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/function_app_flex_consumption#github FunctionAppFlexConsumption#github}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "github", typeJson: "{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettingsGithub\"}", isOptional: true)]
            public azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAuthSettingsGithub? Github
            {
                get => GetInstanceProperty<azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAuthSettingsGithub?>();
            }

            /// <summary>google block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/function_app_flex_consumption#google FunctionAppFlexConsumption#google}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "google", typeJson: "{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettingsGoogle\"}", isOptional: true)]
            public azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAuthSettingsGoogle? Google
            {
                get => GetInstanceProperty<azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAuthSettingsGoogle?>();
            }

            /// <summary>The OpenID Connect Issuer URI that represents the entity which issues access tokens.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/function_app_flex_consumption#issuer FunctionAppFlexConsumption#issuer}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "issuer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Issuer
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>microsoft block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/function_app_flex_consumption#microsoft FunctionAppFlexConsumption#microsoft}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "microsoft", typeJson: "{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettingsMicrosoft\"}", isOptional: true)]
            public azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAuthSettingsMicrosoft? Microsoft
            {
                get => GetInstanceProperty<azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAuthSettingsMicrosoft?>();
            }

            /// <summary>The RuntimeVersion of the Authentication / Authorization feature in use.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/function_app_flex_consumption#runtime_version FunctionAppFlexConsumption#runtime_version}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "runtimeVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RuntimeVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The number of hours after session token expiration that a session token can be used to call the token refresh API.</summary>
            /// <remarks>
            /// Defaults to <c>72</c> hours.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/function_app_flex_consumption#token_refresh_extension_hours FunctionAppFlexConsumption#token_refresh_extension_hours}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tokenRefreshExtensionHours", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TokenRefreshExtensionHours
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Should the Windows Web App durably store platform-specific security tokens that are obtained during login flows? Defaults to `false`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/function_app_flex_consumption#token_store_enabled FunctionAppFlexConsumption#token_store_enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tokenStoreEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? TokenStoreEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>twitter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/function_app_flex_consumption#twitter FunctionAppFlexConsumption#twitter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "twitter", typeJson: "{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettingsTwitter\"}", isOptional: true)]
            public azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAuthSettingsTwitter? Twitter
            {
                get => GetInstanceProperty<azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAuthSettingsTwitter?>();
            }

            /// <summary>The action to take when an unauthenticated client attempts to access the app. Possible values include: `RedirectToLoginPage`, `AllowAnonymous`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/function_app_flex_consumption#unauthenticated_client_action FunctionAppFlexConsumption#unauthenticated_client_action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "unauthenticatedClientAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UnauthenticatedClientAction
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
