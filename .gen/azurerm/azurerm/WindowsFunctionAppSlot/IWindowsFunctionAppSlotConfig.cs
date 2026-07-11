using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsFunctionAppSlot
{
    [JsiiInterface(nativeType: typeof(IWindowsFunctionAppSlotConfig), fullyQualifiedName: "azurerm.windowsFunctionAppSlot.WindowsFunctionAppSlotConfig")]
    public interface IWindowsFunctionAppSlotConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The ID of the Windows Function App this Slot is a member of.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#function_app_id WindowsFunctionAppSlot#function_app_id}
        /// </remarks>
        [JsiiProperty(name: "functionAppId", typeJson: "{\"primitive\":\"string\"}")]
        string FunctionAppId
        {
            get;
        }

        /// <summary>Specifies the name of the Windows Function App Slot.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#name WindowsFunctionAppSlot#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>site_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#site_config WindowsFunctionAppSlot#site_config}
        /// </remarks>
        [JsiiProperty(name: "siteConfig", typeJson: "{\"fqn\":\"azurerm.windowsFunctionAppSlot.WindowsFunctionAppSlotSiteConfig\"}")]
        azurerm.WindowsFunctionAppSlot.IWindowsFunctionAppSlotSiteConfig SiteConfig
        {
            get;
        }

        /// <summary>A map of key-value pairs for [App Settings](https://docs.microsoft.com/en-us/azure/azure-functions/functions-app-settings) and custom values.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#app_settings WindowsFunctionAppSlot#app_settings}
        /// </remarks>
        [JsiiProperty(name: "appSettings", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? AppSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>auth_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#auth_settings WindowsFunctionAppSlot#auth_settings}
        /// </remarks>
        [JsiiProperty(name: "authSettings", typeJson: "{\"fqn\":\"azurerm.windowsFunctionAppSlot.WindowsFunctionAppSlotAuthSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.WindowsFunctionAppSlot.IWindowsFunctionAppSlotAuthSettings? AuthSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>auth_settings_v2 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#auth_settings_v2 WindowsFunctionAppSlot#auth_settings_v2}
        /// </remarks>
        [JsiiProperty(name: "authSettingsV2", typeJson: "{\"fqn\":\"azurerm.windowsFunctionAppSlot.WindowsFunctionAppSlotAuthSettingsV2\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.WindowsFunctionAppSlot.IWindowsFunctionAppSlotAuthSettingsV2? AuthSettingsV2
        {
            get
            {
                return null;
            }
        }

        /// <summary>backup block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#backup WindowsFunctionAppSlot#backup}
        /// </remarks>
        [JsiiProperty(name: "backup", typeJson: "{\"fqn\":\"azurerm.windowsFunctionAppSlot.WindowsFunctionAppSlotBackup\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.WindowsFunctionAppSlot.IWindowsFunctionAppSlotBackup? Backup
        {
            get
            {
                return null;
            }
        }

        /// <summary>Should built in logging be enabled. Configures `AzureWebJobsDashboard` app setting based on the configured storage setting.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#builtin_logging_enabled WindowsFunctionAppSlot#builtin_logging_enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "builtinLoggingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? BuiltinLoggingEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Should the Function App Slot use Client Certificates.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#client_certificate_enabled WindowsFunctionAppSlot#client_certificate_enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "clientCertificateEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ClientCertificateEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Paths to exclude when using client certificates, separated by ;</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#client_certificate_exclusion_paths WindowsFunctionAppSlot#client_certificate_exclusion_paths}
        /// </remarks>
        [JsiiProperty(name: "clientCertificateExclusionPaths", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientCertificateExclusionPaths
        {
            get
            {
                return null;
            }
        }

        /// <summary>The mode of the Function App Slot's client certificates requirement for incoming requests.</summary>
        /// <remarks>
        /// Possible values are <c>Required</c>, <c>Optional</c>, and <c>OptionalInteractiveUser</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#client_certificate_mode WindowsFunctionAppSlot#client_certificate_mode}
        /// </remarks>
        [JsiiProperty(name: "clientCertificateMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientCertificateMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>connection_string block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#connection_string WindowsFunctionAppSlot#connection_string}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.WindowsFunctionAppSlot.IWindowsFunctionAppSlotConnectionString" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "connectionString", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.windowsFunctionAppSlot.WindowsFunctionAppSlotConnectionString\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ConnectionString
        {
            get
            {
                return null;
            }
        }

        /// <summary>Force disable the content share settings.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#content_share_force_disabled WindowsFunctionAppSlot#content_share_force_disabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "contentShareForceDisabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ContentShareForceDisabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>The amount of memory in gigabyte-seconds that your application is allowed to consume per day.</summary>
        /// <remarks>
        /// Setting this value only affects function apps in Consumption Plans.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#daily_memory_time_quota WindowsFunctionAppSlot#daily_memory_time_quota}
        /// </remarks>
        [JsiiProperty(name: "dailyMemoryTimeQuota", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DailyMemoryTimeQuota
        {
            get
            {
                return null;
            }
        }

        /// <summary>Is the Windows Function App Slot enabled.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#enabled WindowsFunctionAppSlot#enabled}
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#ftp_publish_basic_authentication_enabled WindowsFunctionAppSlot#ftp_publish_basic_authentication_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "ftpPublishBasicAuthenticationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FtpPublishBasicAuthenticationEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>The runtime version associated with the Function App Slot.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#functions_extension_version WindowsFunctionAppSlot#functions_extension_version}
        /// </remarks>
        [JsiiProperty(name: "functionsExtensionVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FunctionsExtensionVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Can the Function App Slot only be accessed via HTTPS?</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#https_only WindowsFunctionAppSlot#https_only}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "httpsOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? HttpsOnly
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#id WindowsFunctionAppSlot#id}.</summary>
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

        /// <summary>identity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#identity WindowsFunctionAppSlot#identity}
        /// </remarks>
        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.windowsFunctionAppSlot.WindowsFunctionAppSlotIdentity\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.WindowsFunctionAppSlot.IWindowsFunctionAppSlotIdentity? Identity
        {
            get
            {
                return null;
            }
        }

        /// <summary>The User Assigned Identity to use for Key Vault access.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#key_vault_reference_identity_id WindowsFunctionAppSlot#key_vault_reference_identity_id}
        /// </remarks>
        [JsiiProperty(name: "keyVaultReferenceIdentityId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KeyVaultReferenceIdentityId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#public_network_access_enabled WindowsFunctionAppSlot#public_network_access_enabled}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#service_plan_id WindowsFunctionAppSlot#service_plan_id}.</summary>
        [JsiiProperty(name: "servicePlanId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServicePlanId
        {
            get
            {
                return null;
            }
        }

        /// <summary>storage_account block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#storage_account WindowsFunctionAppSlot#storage_account}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.WindowsFunctionAppSlot.IWindowsFunctionAppSlotStorageAccount" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "storageAccount", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.windowsFunctionAppSlot.WindowsFunctionAppSlotStorageAccount\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? StorageAccount
        {
            get
            {
                return null;
            }
        }

        /// <summary>The access key which will be used to access the storage account for the Function App Slot.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#storage_account_access_key WindowsFunctionAppSlot#storage_account_access_key}
        /// </remarks>
        [JsiiProperty(name: "storageAccountAccessKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StorageAccountAccessKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>The backend storage account name which will be used by this Function App Slot.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#storage_account_name WindowsFunctionAppSlot#storage_account_name}
        /// </remarks>
        [JsiiProperty(name: "storageAccountName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StorageAccountName
        {
            get
            {
                return null;
            }
        }

        /// <summary>The Key Vault Secret ID, including version, that contains the Connection String to connect to the storage account for this Function App.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#storage_key_vault_secret_id WindowsFunctionAppSlot#storage_key_vault_secret_id}
        /// </remarks>
        [JsiiProperty(name: "storageKeyVaultSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StorageKeyVaultSecretId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Should the Function App Slot use its Managed Identity to access storage?</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#storage_uses_managed_identity WindowsFunctionAppSlot#storage_uses_managed_identity}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "storageUsesManagedIdentity", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? StorageUsesManagedIdentity
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#tags WindowsFunctionAppSlot#tags}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#timeouts WindowsFunctionAppSlot#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.windowsFunctionAppSlot.WindowsFunctionAppSlotTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.WindowsFunctionAppSlot.IWindowsFunctionAppSlotTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#virtual_network_backup_restore_enabled WindowsFunctionAppSlot#virtual_network_backup_restore_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "virtualNetworkBackupRestoreEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? VirtualNetworkBackupRestoreEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#virtual_network_subnet_id WindowsFunctionAppSlot#virtual_network_subnet_id}.</summary>
        [JsiiProperty(name: "virtualNetworkSubnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VirtualNetworkSubnetId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Is container image pull over virtual network enabled? Defaults to `false`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#vnet_image_pull_enabled WindowsFunctionAppSlot#vnet_image_pull_enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "vnetImagePullEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? VnetImagePullEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#webdeploy_publish_basic_authentication_enabled WindowsFunctionAppSlot#webdeploy_publish_basic_authentication_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "webdeployPublishBasicAuthenticationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? WebdeployPublishBasicAuthenticationEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWindowsFunctionAppSlotConfig), fullyQualifiedName: "azurerm.windowsFunctionAppSlot.WindowsFunctionAppSlotConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.WindowsFunctionAppSlot.IWindowsFunctionAppSlotConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The ID of the Windows Function App this Slot is a member of.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#function_app_id WindowsFunctionAppSlot#function_app_id}
            /// </remarks>
            [JsiiProperty(name: "functionAppId", typeJson: "{\"primitive\":\"string\"}")]
            public string FunctionAppId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Specifies the name of the Windows Function App Slot.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#name WindowsFunctionAppSlot#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>site_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#site_config WindowsFunctionAppSlot#site_config}
            /// </remarks>
            [JsiiProperty(name: "siteConfig", typeJson: "{\"fqn\":\"azurerm.windowsFunctionAppSlot.WindowsFunctionAppSlotSiteConfig\"}")]
            public azurerm.WindowsFunctionAppSlot.IWindowsFunctionAppSlotSiteConfig SiteConfig
            {
                get => GetInstanceProperty<azurerm.WindowsFunctionAppSlot.IWindowsFunctionAppSlotSiteConfig>()!;
            }

            /// <summary>A map of key-value pairs for [App Settings](https://docs.microsoft.com/en-us/azure/azure-functions/functions-app-settings) and custom values.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#app_settings WindowsFunctionAppSlot#app_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "appSettings", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? AppSettings
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>auth_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#auth_settings WindowsFunctionAppSlot#auth_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "authSettings", typeJson: "{\"fqn\":\"azurerm.windowsFunctionAppSlot.WindowsFunctionAppSlotAuthSettings\"}", isOptional: true)]
            public azurerm.WindowsFunctionAppSlot.IWindowsFunctionAppSlotAuthSettings? AuthSettings
            {
                get => GetInstanceProperty<azurerm.WindowsFunctionAppSlot.IWindowsFunctionAppSlotAuthSettings?>();
            }

            /// <summary>auth_settings_v2 block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#auth_settings_v2 WindowsFunctionAppSlot#auth_settings_v2}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "authSettingsV2", typeJson: "{\"fqn\":\"azurerm.windowsFunctionAppSlot.WindowsFunctionAppSlotAuthSettingsV2\"}", isOptional: true)]
            public azurerm.WindowsFunctionAppSlot.IWindowsFunctionAppSlotAuthSettingsV2? AuthSettingsV2
            {
                get => GetInstanceProperty<azurerm.WindowsFunctionAppSlot.IWindowsFunctionAppSlotAuthSettingsV2?>();
            }

            /// <summary>backup block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#backup WindowsFunctionAppSlot#backup}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "backup", typeJson: "{\"fqn\":\"azurerm.windowsFunctionAppSlot.WindowsFunctionAppSlotBackup\"}", isOptional: true)]
            public azurerm.WindowsFunctionAppSlot.IWindowsFunctionAppSlotBackup? Backup
            {
                get => GetInstanceProperty<azurerm.WindowsFunctionAppSlot.IWindowsFunctionAppSlotBackup?>();
            }

            /// <summary>Should built in logging be enabled. Configures `AzureWebJobsDashboard` app setting based on the configured storage setting.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#builtin_logging_enabled WindowsFunctionAppSlot#builtin_logging_enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "builtinLoggingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? BuiltinLoggingEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Should the Function App Slot use Client Certificates.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#client_certificate_enabled WindowsFunctionAppSlot#client_certificate_enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientCertificateEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ClientCertificateEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Paths to exclude when using client certificates, separated by ;</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#client_certificate_exclusion_paths WindowsFunctionAppSlot#client_certificate_exclusion_paths}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientCertificateExclusionPaths", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientCertificateExclusionPaths
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The mode of the Function App Slot's client certificates requirement for incoming requests.</summary>
            /// <remarks>
            /// Possible values are <c>Required</c>, <c>Optional</c>, and <c>OptionalInteractiveUser</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#client_certificate_mode WindowsFunctionAppSlot#client_certificate_mode}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientCertificateMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientCertificateMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>connection_string block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#connection_string WindowsFunctionAppSlot#connection_string}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.WindowsFunctionAppSlot.IWindowsFunctionAppSlotConnectionString" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connectionString", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.windowsFunctionAppSlot.WindowsFunctionAppSlotConnectionString\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ConnectionString
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Force disable the content share settings.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#content_share_force_disabled WindowsFunctionAppSlot#content_share_force_disabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "contentShareForceDisabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ContentShareForceDisabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The amount of memory in gigabyte-seconds that your application is allowed to consume per day.</summary>
            /// <remarks>
            /// Setting this value only affects function apps in Consumption Plans.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#daily_memory_time_quota WindowsFunctionAppSlot#daily_memory_time_quota}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dailyMemoryTimeQuota", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DailyMemoryTimeQuota
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Is the Windows Function App Slot enabled.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#enabled WindowsFunctionAppSlot#enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#ftp_publish_basic_authentication_enabled WindowsFunctionAppSlot#ftp_publish_basic_authentication_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ftpPublishBasicAuthenticationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? FtpPublishBasicAuthenticationEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The runtime version associated with the Function App Slot.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#functions_extension_version WindowsFunctionAppSlot#functions_extension_version}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "functionsExtensionVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FunctionsExtensionVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Can the Function App Slot only be accessed via HTTPS?</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#https_only WindowsFunctionAppSlot#https_only}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpsOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? HttpsOnly
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#id WindowsFunctionAppSlot#id}.</summary>
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

            /// <summary>identity block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#identity WindowsFunctionAppSlot#identity}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.windowsFunctionAppSlot.WindowsFunctionAppSlotIdentity\"}", isOptional: true)]
            public azurerm.WindowsFunctionAppSlot.IWindowsFunctionAppSlotIdentity? Identity
            {
                get => GetInstanceProperty<azurerm.WindowsFunctionAppSlot.IWindowsFunctionAppSlotIdentity?>();
            }

            /// <summary>The User Assigned Identity to use for Key Vault access.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#key_vault_reference_identity_id WindowsFunctionAppSlot#key_vault_reference_identity_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "keyVaultReferenceIdentityId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KeyVaultReferenceIdentityId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#public_network_access_enabled WindowsFunctionAppSlot#public_network_access_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "publicNetworkAccessEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? PublicNetworkAccessEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#service_plan_id WindowsFunctionAppSlot#service_plan_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "servicePlanId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServicePlanId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>storage_account block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#storage_account WindowsFunctionAppSlot#storage_account}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.WindowsFunctionAppSlot.IWindowsFunctionAppSlotStorageAccount" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "storageAccount", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.windowsFunctionAppSlot.WindowsFunctionAppSlotStorageAccount\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? StorageAccount
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The access key which will be used to access the storage account for the Function App Slot.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#storage_account_access_key WindowsFunctionAppSlot#storage_account_access_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "storageAccountAccessKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StorageAccountAccessKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The backend storage account name which will be used by this Function App Slot.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#storage_account_name WindowsFunctionAppSlot#storage_account_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "storageAccountName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StorageAccountName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The Key Vault Secret ID, including version, that contains the Connection String to connect to the storage account for this Function App.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#storage_key_vault_secret_id WindowsFunctionAppSlot#storage_key_vault_secret_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "storageKeyVaultSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StorageKeyVaultSecretId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Should the Function App Slot use its Managed Identity to access storage?</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#storage_uses_managed_identity WindowsFunctionAppSlot#storage_uses_managed_identity}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "storageUsesManagedIdentity", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? StorageUsesManagedIdentity
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#tags WindowsFunctionAppSlot#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#timeouts WindowsFunctionAppSlot#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.windowsFunctionAppSlot.WindowsFunctionAppSlotTimeouts\"}", isOptional: true)]
            public azurerm.WindowsFunctionAppSlot.IWindowsFunctionAppSlotTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.WindowsFunctionAppSlot.IWindowsFunctionAppSlotTimeouts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#virtual_network_backup_restore_enabled WindowsFunctionAppSlot#virtual_network_backup_restore_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "virtualNetworkBackupRestoreEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? VirtualNetworkBackupRestoreEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#virtual_network_subnet_id WindowsFunctionAppSlot#virtual_network_subnet_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "virtualNetworkSubnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VirtualNetworkSubnetId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Is container image pull over virtual network enabled? Defaults to `false`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#vnet_image_pull_enabled WindowsFunctionAppSlot#vnet_image_pull_enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vnetImagePullEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? VnetImagePullEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_function_app_slot#webdeploy_publish_basic_authentication_enabled WindowsFunctionAppSlot#webdeploy_publish_basic_authentication_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "webdeployPublishBasicAuthenticationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? WebdeployPublishBasicAuthenticationEnabled
            {
                get => GetInstanceProperty<object?>();
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
