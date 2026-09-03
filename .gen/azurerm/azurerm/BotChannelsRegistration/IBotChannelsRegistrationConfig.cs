using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.BotChannelsRegistration
{
    [JsiiInterface(nativeType: typeof(IBotChannelsRegistrationConfig), fullyQualifiedName: "azurerm.botChannelsRegistration.BotChannelsRegistrationConfig")]
    public interface IBotChannelsRegistrationConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/bot_channels_registration#location BotChannelsRegistration#location}.</summary>
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        string Location
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/bot_channels_registration#microsoft_app_id BotChannelsRegistration#microsoft_app_id}.</summary>
        [JsiiProperty(name: "microsoftAppId", typeJson: "{\"primitive\":\"string\"}")]
        string MicrosoftAppId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/bot_channels_registration#microsoft_app_type BotChannelsRegistration#microsoft_app_type}.</summary>
        [JsiiProperty(name: "microsoftAppType", typeJson: "{\"primitive\":\"string\"}")]
        string MicrosoftAppType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/bot_channels_registration#name BotChannelsRegistration#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/bot_channels_registration#resource_group_name BotChannelsRegistration#resource_group_name}.</summary>
        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceGroupName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/bot_channels_registration#sku BotChannelsRegistration#sku}.</summary>
        [JsiiProperty(name: "sku", typeJson: "{\"primitive\":\"string\"}")]
        string Sku
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/bot_channels_registration#cmk_key_vault_url BotChannelsRegistration#cmk_key_vault_url}.</summary>
        [JsiiProperty(name: "cmkKeyVaultUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CmkKeyVaultUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/bot_channels_registration#description BotChannelsRegistration#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/bot_channels_registration#developer_app_insights_api_key BotChannelsRegistration#developer_app_insights_api_key}.</summary>
        [JsiiProperty(name: "developerAppInsightsApiKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DeveloperAppInsightsApiKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/bot_channels_registration#developer_app_insights_application_id BotChannelsRegistration#developer_app_insights_application_id}.</summary>
        [JsiiProperty(name: "developerAppInsightsApplicationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DeveloperAppInsightsApplicationId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/bot_channels_registration#developer_app_insights_key BotChannelsRegistration#developer_app_insights_key}.</summary>
        [JsiiProperty(name: "developerAppInsightsKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DeveloperAppInsightsKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/bot_channels_registration#display_name BotChannelsRegistration#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisplayName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/bot_channels_registration#endpoint BotChannelsRegistration#endpoint}.</summary>
        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Endpoint
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/bot_channels_registration#icon_url BotChannelsRegistration#icon_url}.</summary>
        [JsiiProperty(name: "iconUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IconUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/bot_channels_registration#id BotChannelsRegistration#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/bot_channels_registration#microsoft_app_tenant_id BotChannelsRegistration#microsoft_app_tenant_id}.</summary>
        [JsiiProperty(name: "microsoftAppTenantId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MicrosoftAppTenantId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/bot_channels_registration#microsoft_app_user_assigned_identity_id BotChannelsRegistration#microsoft_app_user_assigned_identity_id}.</summary>
        [JsiiProperty(name: "microsoftAppUserAssignedIdentityId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MicrosoftAppUserAssignedIdentityId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/bot_channels_registration#public_network_access_enabled BotChannelsRegistration#public_network_access_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "publicNetworkAccessEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PublicNetworkAccessEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/bot_channels_registration#streaming_endpoint_enabled BotChannelsRegistration#streaming_endpoint_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "streamingEndpointEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? StreamingEndpointEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/bot_channels_registration#tags BotChannelsRegistration#tags}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/bot_channels_registration#timeouts BotChannelsRegistration#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.botChannelsRegistration.BotChannelsRegistrationTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.BotChannelsRegistration.IBotChannelsRegistrationTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBotChannelsRegistrationConfig), fullyQualifiedName: "azurerm.botChannelsRegistration.BotChannelsRegistrationConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.BotChannelsRegistration.IBotChannelsRegistrationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/bot_channels_registration#location BotChannelsRegistration#location}.</summary>
            [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
            public string Location
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/bot_channels_registration#microsoft_app_id BotChannelsRegistration#microsoft_app_id}.</summary>
            [JsiiProperty(name: "microsoftAppId", typeJson: "{\"primitive\":\"string\"}")]
            public string MicrosoftAppId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/bot_channels_registration#microsoft_app_type BotChannelsRegistration#microsoft_app_type}.</summary>
            [JsiiProperty(name: "microsoftAppType", typeJson: "{\"primitive\":\"string\"}")]
            public string MicrosoftAppType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/bot_channels_registration#name BotChannelsRegistration#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/bot_channels_registration#resource_group_name BotChannelsRegistration#resource_group_name}.</summary>
            [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceGroupName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/bot_channels_registration#sku BotChannelsRegistration#sku}.</summary>
            [JsiiProperty(name: "sku", typeJson: "{\"primitive\":\"string\"}")]
            public string Sku
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/bot_channels_registration#cmk_key_vault_url BotChannelsRegistration#cmk_key_vault_url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cmkKeyVaultUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CmkKeyVaultUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/bot_channels_registration#description BotChannelsRegistration#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/bot_channels_registration#developer_app_insights_api_key BotChannelsRegistration#developer_app_insights_api_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "developerAppInsightsApiKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DeveloperAppInsightsApiKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/bot_channels_registration#developer_app_insights_application_id BotChannelsRegistration#developer_app_insights_application_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "developerAppInsightsApplicationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DeveloperAppInsightsApplicationId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/bot_channels_registration#developer_app_insights_key BotChannelsRegistration#developer_app_insights_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "developerAppInsightsKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DeveloperAppInsightsKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/bot_channels_registration#display_name BotChannelsRegistration#display_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisplayName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/bot_channels_registration#endpoint BotChannelsRegistration#endpoint}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Endpoint
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/bot_channels_registration#icon_url BotChannelsRegistration#icon_url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "iconUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IconUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/bot_channels_registration#id BotChannelsRegistration#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/bot_channels_registration#microsoft_app_tenant_id BotChannelsRegistration#microsoft_app_tenant_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "microsoftAppTenantId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MicrosoftAppTenantId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/bot_channels_registration#microsoft_app_user_assigned_identity_id BotChannelsRegistration#microsoft_app_user_assigned_identity_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "microsoftAppUserAssignedIdentityId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MicrosoftAppUserAssignedIdentityId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/bot_channels_registration#public_network_access_enabled BotChannelsRegistration#public_network_access_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "publicNetworkAccessEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? PublicNetworkAccessEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/bot_channels_registration#streaming_endpoint_enabled BotChannelsRegistration#streaming_endpoint_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "streamingEndpointEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? StreamingEndpointEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/bot_channels_registration#tags BotChannelsRegistration#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/bot_channels_registration#timeouts BotChannelsRegistration#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.botChannelsRegistration.BotChannelsRegistrationTimeouts\"}", isOptional: true)]
            public azurerm.BotChannelsRegistration.IBotChannelsRegistrationTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.BotChannelsRegistration.IBotChannelsRegistrationTimeouts?>();
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
