using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.FunctionAppFlexConsumption
{
    [JsiiInterface(nativeType: typeof(IFunctionAppFlexConsumptionConfig), fullyQualifiedName: "azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionConfig")]
    public interface IFunctionAppFlexConsumptionConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#location FunctionAppFlexConsumption#location}.</summary>
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        string Location
        {
            get;
        }

        /// <summary>Specifies the name of the Function App.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#name FunctionAppFlexConsumption#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#resource_group_name FunctionAppFlexConsumption#resource_group_name}.</summary>
        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceGroupName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#runtime_name FunctionAppFlexConsumption#runtime_name}.</summary>
        [JsiiProperty(name: "runtimeName", typeJson: "{\"primitive\":\"string\"}")]
        string RuntimeName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#runtime_version FunctionAppFlexConsumption#runtime_version}.</summary>
        [JsiiProperty(name: "runtimeVersion", typeJson: "{\"primitive\":\"string\"}")]
        string RuntimeVersion
        {
            get;
        }

        /// <summary>The ID of the App Service Plan within which to create this Function App.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#service_plan_id FunctionAppFlexConsumption#service_plan_id}
        /// </remarks>
        [JsiiProperty(name: "servicePlanId", typeJson: "{\"primitive\":\"string\"}")]
        string ServicePlanId
        {
            get;
        }

        /// <summary>site_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#site_config FunctionAppFlexConsumption#site_config}
        /// </remarks>
        [JsiiProperty(name: "siteConfig", typeJson: "{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionSiteConfig\"}")]
        azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionSiteConfig SiteConfig
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#storage_authentication_type FunctionAppFlexConsumption#storage_authentication_type}.</summary>
        [JsiiProperty(name: "storageAuthenticationType", typeJson: "{\"primitive\":\"string\"}")]
        string StorageAuthenticationType
        {
            get;
        }

        /// <summary>The endpoint of the storage container where the function app's code is hosted.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#storage_container_endpoint FunctionAppFlexConsumption#storage_container_endpoint}
        /// </remarks>
        [JsiiProperty(name: "storageContainerEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        string StorageContainerEndpoint
        {
            get;
        }

        /// <summary>The type of the storage container where the function app's code is hosted. Only `blobContainer` is supported currently.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#storage_container_type FunctionAppFlexConsumption#storage_container_type}
        /// </remarks>
        [JsiiProperty(name: "storageContainerType", typeJson: "{\"primitive\":\"string\"}")]
        string StorageContainerType
        {
            get;
        }

        /// <summary>always_ready block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#always_ready FunctionAppFlexConsumption#always_ready}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAlwaysReady" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "alwaysReady", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionAlwaysReady\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AlwaysReady
        {
            get
            {
                return null;
            }
        }

        /// <summary>A map of key-value pairs for [App Settings](https://docs.microsoft.com/en-us/azure/azure-functions/functions-app-settings) and custom values.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#app_settings FunctionAppFlexConsumption#app_settings}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#auth_settings FunctionAppFlexConsumption#auth_settings}
        /// </remarks>
        [JsiiProperty(name: "authSettings", typeJson: "{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAuthSettings? AuthSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>auth_settings_v2 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#auth_settings_v2 FunctionAppFlexConsumption#auth_settings_v2}
        /// </remarks>
        [JsiiProperty(name: "authSettingsV2", typeJson: "{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettingsV2\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAuthSettingsV2? AuthSettingsV2
        {
            get
            {
                return null;
            }
        }

        /// <summary>Should the function app use Client Certificates.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#client_certificate_enabled FunctionAppFlexConsumption#client_certificate_enabled}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#client_certificate_exclusion_paths FunctionAppFlexConsumption#client_certificate_exclusion_paths}
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

        /// <summary>The mode of the Function App's client certificates requirement for incoming requests.</summary>
        /// <remarks>
        /// Possible values are <c>Required</c>, <c>Optional</c>, and <c>OptionalInteractiveUser</c>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#client_certificate_mode FunctionAppFlexConsumption#client_certificate_mode}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#connection_string FunctionAppFlexConsumption#connection_string}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionConnectionString" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "connectionString", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionConnectionString\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ConnectionString
        {
            get
            {
                return null;
            }
        }

        /// <summary>Is the Function App enabled.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#enabled FunctionAppFlexConsumption#enabled}
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#http_concurrency FunctionAppFlexConsumption#http_concurrency}.</summary>
        [JsiiProperty(name: "httpConcurrency", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? HttpConcurrency
        {
            get
            {
                return null;
            }
        }

        /// <summary>Can the Function App only be accessed via HTTPS?</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#https_only FunctionAppFlexConsumption#https_only}
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#id FunctionAppFlexConsumption#id}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#identity FunctionAppFlexConsumption#identity}
        /// </remarks>
        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionIdentity\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionIdentity? Identity
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#instance_memory_in_mb FunctionAppFlexConsumption#instance_memory_in_mb}.</summary>
        [JsiiProperty(name: "instanceMemoryInMb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? InstanceMemoryInMb
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#maximum_instance_count FunctionAppFlexConsumption#maximum_instance_count}.</summary>
        [JsiiProperty(name: "maximumInstanceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaximumInstanceCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#public_network_access_enabled FunctionAppFlexConsumption#public_network_access_enabled}.</summary>
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

        /// <summary>sticky_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#sticky_settings FunctionAppFlexConsumption#sticky_settings}
        /// </remarks>
        [JsiiProperty(name: "stickySettings", typeJson: "{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionStickySettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionStickySettings? StickySettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#storage_access_key FunctionAppFlexConsumption#storage_access_key}.</summary>
        [JsiiProperty(name: "storageAccessKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StorageAccessKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#storage_user_assigned_identity_id FunctionAppFlexConsumption#storage_user_assigned_identity_id}.</summary>
        [JsiiProperty(name: "storageUserAssignedIdentityId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StorageUserAssignedIdentityId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#tags FunctionAppFlexConsumption#tags}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#timeouts FunctionAppFlexConsumption#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#virtual_network_subnet_id FunctionAppFlexConsumption#virtual_network_subnet_id}.</summary>
        [JsiiProperty(name: "virtualNetworkSubnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VirtualNetworkSubnetId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#webdeploy_publish_basic_authentication_enabled FunctionAppFlexConsumption#webdeploy_publish_basic_authentication_enabled}.</summary>
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

        /// <summary>The local path and filename of the Zip packaged application to deploy to this Function App.</summary>
        /// <remarks>
        /// <strong>Note:</strong> Using this value requires either <c>WEBSITE_RUN_FROM_PACKAGE=1</c> or <c>SCM_DO_BUILD_DURING_DEPLOYMENT=true</c> to be set on the App in <c>app_settings</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#zip_deploy_file FunctionAppFlexConsumption#zip_deploy_file}
        /// </remarks>
        [JsiiProperty(name: "zipDeployFile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ZipDeployFile
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFunctionAppFlexConsumptionConfig), fullyQualifiedName: "azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#location FunctionAppFlexConsumption#location}.</summary>
            [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
            public string Location
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Specifies the name of the Function App.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#name FunctionAppFlexConsumption#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#resource_group_name FunctionAppFlexConsumption#resource_group_name}.</summary>
            [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceGroupName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#runtime_name FunctionAppFlexConsumption#runtime_name}.</summary>
            [JsiiProperty(name: "runtimeName", typeJson: "{\"primitive\":\"string\"}")]
            public string RuntimeName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#runtime_version FunctionAppFlexConsumption#runtime_version}.</summary>
            [JsiiProperty(name: "runtimeVersion", typeJson: "{\"primitive\":\"string\"}")]
            public string RuntimeVersion
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The ID of the App Service Plan within which to create this Function App.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#service_plan_id FunctionAppFlexConsumption#service_plan_id}
            /// </remarks>
            [JsiiProperty(name: "servicePlanId", typeJson: "{\"primitive\":\"string\"}")]
            public string ServicePlanId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>site_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#site_config FunctionAppFlexConsumption#site_config}
            /// </remarks>
            [JsiiProperty(name: "siteConfig", typeJson: "{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionSiteConfig\"}")]
            public azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionSiteConfig SiteConfig
            {
                get => GetInstanceProperty<azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionSiteConfig>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#storage_authentication_type FunctionAppFlexConsumption#storage_authentication_type}.</summary>
            [JsiiProperty(name: "storageAuthenticationType", typeJson: "{\"primitive\":\"string\"}")]
            public string StorageAuthenticationType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The endpoint of the storage container where the function app's code is hosted.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#storage_container_endpoint FunctionAppFlexConsumption#storage_container_endpoint}
            /// </remarks>
            [JsiiProperty(name: "storageContainerEndpoint", typeJson: "{\"primitive\":\"string\"}")]
            public string StorageContainerEndpoint
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The type of the storage container where the function app's code is hosted. Only `blobContainer` is supported currently.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#storage_container_type FunctionAppFlexConsumption#storage_container_type}
            /// </remarks>
            [JsiiProperty(name: "storageContainerType", typeJson: "{\"primitive\":\"string\"}")]
            public string StorageContainerType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>always_ready block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#always_ready FunctionAppFlexConsumption#always_ready}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAlwaysReady" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "alwaysReady", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionAlwaysReady\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AlwaysReady
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>A map of key-value pairs for [App Settings](https://docs.microsoft.com/en-us/azure/azure-functions/functions-app-settings) and custom values.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#app_settings FunctionAppFlexConsumption#app_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "appSettings", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? AppSettings
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>auth_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#auth_settings FunctionAppFlexConsumption#auth_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "authSettings", typeJson: "{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettings\"}", isOptional: true)]
            public azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAuthSettings? AuthSettings
            {
                get => GetInstanceProperty<azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAuthSettings?>();
            }

            /// <summary>auth_settings_v2 block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#auth_settings_v2 FunctionAppFlexConsumption#auth_settings_v2}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "authSettingsV2", typeJson: "{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettingsV2\"}", isOptional: true)]
            public azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAuthSettingsV2? AuthSettingsV2
            {
                get => GetInstanceProperty<azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAuthSettingsV2?>();
            }

            /// <summary>Should the function app use Client Certificates.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#client_certificate_enabled FunctionAppFlexConsumption#client_certificate_enabled}
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#client_certificate_exclusion_paths FunctionAppFlexConsumption#client_certificate_exclusion_paths}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientCertificateExclusionPaths", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientCertificateExclusionPaths
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The mode of the Function App's client certificates requirement for incoming requests.</summary>
            /// <remarks>
            /// Possible values are <c>Required</c>, <c>Optional</c>, and <c>OptionalInteractiveUser</c>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#client_certificate_mode FunctionAppFlexConsumption#client_certificate_mode}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientCertificateMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientCertificateMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>connection_string block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#connection_string FunctionAppFlexConsumption#connection_string}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionConnectionString" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connectionString", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionConnectionString\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ConnectionString
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Is the Function App enabled.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#enabled FunctionAppFlexConsumption#enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#http_concurrency FunctionAppFlexConsumption#http_concurrency}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "httpConcurrency", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? HttpConcurrency
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Can the Function App only be accessed via HTTPS?</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#https_only FunctionAppFlexConsumption#https_only}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpsOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? HttpsOnly
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#id FunctionAppFlexConsumption#id}.</summary>
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#identity FunctionAppFlexConsumption#identity}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionIdentity\"}", isOptional: true)]
            public azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionIdentity? Identity
            {
                get => GetInstanceProperty<azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionIdentity?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#instance_memory_in_mb FunctionAppFlexConsumption#instance_memory_in_mb}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "instanceMemoryInMb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? InstanceMemoryInMb
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#maximum_instance_count FunctionAppFlexConsumption#maximum_instance_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maximumInstanceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaximumInstanceCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#public_network_access_enabled FunctionAppFlexConsumption#public_network_access_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "publicNetworkAccessEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? PublicNetworkAccessEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>sticky_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#sticky_settings FunctionAppFlexConsumption#sticky_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stickySettings", typeJson: "{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionStickySettings\"}", isOptional: true)]
            public azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionStickySettings? StickySettings
            {
                get => GetInstanceProperty<azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionStickySettings?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#storage_access_key FunctionAppFlexConsumption#storage_access_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "storageAccessKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StorageAccessKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#storage_user_assigned_identity_id FunctionAppFlexConsumption#storage_user_assigned_identity_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "storageUserAssignedIdentityId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StorageUserAssignedIdentityId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#tags FunctionAppFlexConsumption#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#timeouts FunctionAppFlexConsumption#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionTimeouts\"}", isOptional: true)]
            public azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionTimeouts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#virtual_network_subnet_id FunctionAppFlexConsumption#virtual_network_subnet_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "virtualNetworkSubnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VirtualNetworkSubnetId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#webdeploy_publish_basic_authentication_enabled FunctionAppFlexConsumption#webdeploy_publish_basic_authentication_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "webdeployPublishBasicAuthenticationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? WebdeployPublishBasicAuthenticationEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The local path and filename of the Zip packaged application to deploy to this Function App.</summary>
            /// <remarks>
            /// <strong>Note:</strong> Using this value requires either <c>WEBSITE_RUN_FROM_PACKAGE=1</c> or <c>SCM_DO_BUILD_DURING_DEPLOYMENT=true</c> to be set on the App in <c>app_settings</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#zip_deploy_file FunctionAppFlexConsumption#zip_deploy_file}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "zipDeployFile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ZipDeployFile
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
