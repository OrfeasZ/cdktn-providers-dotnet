using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementApi
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.apiManagementApi.ApiManagementApiConfig")]
    public class ApiManagementApiConfig : azurerm.ApiManagementApi.IApiManagementApiConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#api_management_name ApiManagementApi#api_management_name}.</summary>
        [JsiiProperty(name: "apiManagementName", typeJson: "{\"primitive\":\"string\"}")]
        public string ApiManagementName
        {
            get;
            set;
        }

        /// <summary>The name of the API Management API.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#name ApiManagementApi#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#resource_group_name ApiManagementApi#resource_group_name}.</summary>
        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public string ResourceGroupName
        {
            get;
            set;
        }

        /// <summary>The Revision which used for this API.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#revision ApiManagementApi#revision}
        /// </remarks>
        [JsiiProperty(name: "revision", typeJson: "{\"primitive\":\"string\"}")]
        public string Revision
        {
            get;
            set;
        }

        /// <summary>Type of API.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#api_type ApiManagementApi#api_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "apiType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ApiType
        {
            get;
            set;
        }

        /// <summary>contact block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#contact ApiManagementApi#contact}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "contact", typeJson: "{\"fqn\":\"azurerm.apiManagementApi.ApiManagementApiContact\"}", isOptional: true)]
        public azurerm.ApiManagementApi.IApiManagementApiContact? Contact
        {
            get;
            set;
        }

        /// <summary>A description of the API Management API, which may include HTML formatting tags.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#description ApiManagementApi#description}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>The display name of the API.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#display_name ApiManagementApi#display_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DisplayName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#id ApiManagementApi#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Id
        {
            get;
            set;
        }

        /// <summary>import block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#import ApiManagementApi#import}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "import", typeJson: "{\"fqn\":\"azurerm.apiManagementApi.ApiManagementApiImport\"}", isOptional: true)]
        public azurerm.ApiManagementApi.IApiManagementApiImport? Import
        {
            get;
            set;
        }

        /// <summary>license block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#license ApiManagementApi#license}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "license", typeJson: "{\"fqn\":\"azurerm.apiManagementApi.ApiManagementApiLicense\"}", isOptional: true)]
        public azurerm.ApiManagementApi.IApiManagementApiLicense? License
        {
            get;
            set;
        }

        /// <summary>oauth2_authorization block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#oauth2_authorization ApiManagementApi#oauth2_authorization}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "oauth2Authorization", typeJson: "{\"fqn\":\"azurerm.apiManagementApi.ApiManagementApiOauth2Authorization\"}", isOptional: true)]
        public azurerm.ApiManagementApi.IApiManagementApiOauth2Authorization? Oauth2Authorization
        {
            get;
            set;
        }

        /// <summary>openid_authentication block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#openid_authentication ApiManagementApi#openid_authentication}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "openidAuthentication", typeJson: "{\"fqn\":\"azurerm.apiManagementApi.ApiManagementApiOpenidAuthentication\"}", isOptional: true)]
        public azurerm.ApiManagementApi.IApiManagementApiOpenidAuthentication? OpenidAuthentication
        {
            get;
            set;
        }

        /// <summary>The Path for this API Management API, which is a relative URL which uniquely identifies this API and all of its resource paths within the API Management Service.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#path ApiManagementApi#path}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Path
        {
            get;
            set;
        }

        /// <summary>A list of protocols the operations in this API can be invoked.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#protocols ApiManagementApi#protocols}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "protocols", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Protocols
        {
            get;
            set;
        }

        /// <summary>The description of the API Revision of the API Management API.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#revision_description ApiManagementApi#revision_description}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "revisionDescription", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RevisionDescription
        {
            get;
            set;
        }

        /// <summary>Absolute URL of the backend service implementing this API.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#service_url ApiManagementApi#service_url}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "serviceUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ServiceUrl
        {
            get;
            set;
        }

        /// <summary>The API ID of the source API, which could be in format `azurerm_api_management_api.example.id` or in format `azurerm_api_management_api.example.id;rev=1`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#source_api_id ApiManagementApi#source_api_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sourceApiId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourceApiId
        {
            get;
            set;
        }

        /// <summary>subscription_key_parameter_names block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#subscription_key_parameter_names ApiManagementApi#subscription_key_parameter_names}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "subscriptionKeyParameterNames", typeJson: "{\"fqn\":\"azurerm.apiManagementApi.ApiManagementApiSubscriptionKeyParameterNames\"}", isOptional: true)]
        public azurerm.ApiManagementApi.IApiManagementApiSubscriptionKeyParameterNames? SubscriptionKeyParameterNames
        {
            get;
            set;
        }

        private object? _subscriptionRequired;

        /// <summary>Should this API require a subscription key?</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#subscription_required ApiManagementApi#subscription_required}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "subscriptionRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? SubscriptionRequired
        {
            get => _subscriptionRequired;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _subscriptionRequired = value;
            }
        }

        /// <summary>Absolute URL of the Terms of Service for the API.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#terms_of_service_url ApiManagementApi#terms_of_service_url}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "termsOfServiceUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TermsOfServiceUrl
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#timeouts ApiManagementApi#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.apiManagementApi.ApiManagementApiTimeouts\"}", isOptional: true)]
        public azurerm.ApiManagementApi.IApiManagementApiTimeouts? Timeouts
        {
            get;
            set;
        }

        /// <summary>The Version number of this API, if this API is versioned.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#version ApiManagementApi#version}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Version
        {
            get;
            set;
        }

        /// <summary>The description of the API Version of the API Management API.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#version_description ApiManagementApi#version_description}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "versionDescription", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VersionDescription
        {
            get;
            set;
        }

        /// <summary>The ID of the Version Set which this API is associated with.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#version_set_id ApiManagementApi#version_set_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "versionSetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VersionSetId
        {
            get;
            set;
        }

        private object? _connection;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
        public object? Connection
        {
            get => _connection;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.ISSHProvisionerConnection cast_cd4240:
                            break;
                        case Io.Cdktn.IWinrmProvisionerConnection cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.ISSHProvisionerConnection).FullName}, {typeof(Io.Cdktn.IWinrmProvisionerConnection).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _connection = value;
            }
        }

        private object? _count;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
        public object? Count
        {
            get => _count;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case double cast_cd4240:
                            break;
                        case byte cast_cd4240:
                            break;
                        case decimal cast_cd4240:
                            break;
                        case float cast_cd4240:
                            break;
                        case int cast_cd4240:
                            break;
                        case long cast_cd4240:
                            break;
                        case sbyte cast_cd4240:
                            break;
                        case short cast_cd4240:
                            break;
                        case uint cast_cd4240:
                            break;
                        case ulong cast_cd4240:
                            break;
                        case ushort cast_cd4240:
                            break;
                        case Io.Cdktn.TerraformCount cast_cd4240:
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: double, {typeof(Io.Cdktn.TerraformCount).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _count = value;
            }
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public Io.Cdktn.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
        public Io.Cdktn.ITerraformIterator? ForEach
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
        public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
        public Io.Cdktn.TerraformProvider? Provider
        {
            get;
            set;
        }

        private object[]? _provisioners;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
        public object[]? Provisioners
        {
            get => _provisioners;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    for (var __idx_cd4240 = 0 ; __idx_cd4240 < value.Length ; __idx_cd4240++)
                    {
                        switch (value[__idx_cd4240])
                        {
                            case Io.Cdktn.IFileProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.ILocalExecProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.IRemoteExecProvisioner cast_e9c63e:
                                break;
                            case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_e9c63e:
                                // Not enough information to type-check...
                                break;
                            case null:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received null", nameof(value));
                            default:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received {value[__idx_cd4240].GetType().FullName}", nameof(value));
                        }
                    }
                }
                _provisioners = value;
            }
        }
    }
}
