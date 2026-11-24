using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementApi
{
    [JsiiInterface(nativeType: typeof(IApiManagementApiConfig), fullyQualifiedName: "azurerm.apiManagementApi.ApiManagementApiConfig")]
    public interface IApiManagementApiConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#api_management_name ApiManagementApi#api_management_name}.</summary>
        [JsiiProperty(name: "apiManagementName", typeJson: "{\"primitive\":\"string\"}")]
        string ApiManagementName
        {
            get;
        }

        /// <summary>The name of the API Management API.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#name ApiManagementApi#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#resource_group_name ApiManagementApi#resource_group_name}.</summary>
        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceGroupName
        {
            get;
        }

        /// <summary>The Revision which used for this API.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#revision ApiManagementApi#revision}
        /// </remarks>
        [JsiiProperty(name: "revision", typeJson: "{\"primitive\":\"string\"}")]
        string Revision
        {
            get;
        }

        /// <summary>Type of API.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#api_type ApiManagementApi#api_type}
        /// </remarks>
        [JsiiProperty(name: "apiType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ApiType
        {
            get
            {
                return null;
            }
        }

        /// <summary>contact block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#contact ApiManagementApi#contact}
        /// </remarks>
        [JsiiProperty(name: "contact", typeJson: "{\"fqn\":\"azurerm.apiManagementApi.ApiManagementApiContact\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ApiManagementApi.IApiManagementApiContact? Contact
        {
            get
            {
                return null;
            }
        }

        /// <summary>A description of the API Management API, which may include HTML formatting tags.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#description ApiManagementApi#description}
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

        /// <summary>The display name of the API.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#display_name ApiManagementApi#display_name}
        /// </remarks>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisplayName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#id ApiManagementApi#id}.</summary>
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

        /// <summary>import block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#import ApiManagementApi#import}
        /// </remarks>
        [JsiiProperty(name: "import", typeJson: "{\"fqn\":\"azurerm.apiManagementApi.ApiManagementApiImport\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ApiManagementApi.IApiManagementApiImport? Import
        {
            get
            {
                return null;
            }
        }

        /// <summary>license block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#license ApiManagementApi#license}
        /// </remarks>
        [JsiiProperty(name: "license", typeJson: "{\"fqn\":\"azurerm.apiManagementApi.ApiManagementApiLicense\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ApiManagementApi.IApiManagementApiLicense? License
        {
            get
            {
                return null;
            }
        }

        /// <summary>oauth2_authorization block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#oauth2_authorization ApiManagementApi#oauth2_authorization}
        /// </remarks>
        [JsiiProperty(name: "oauth2Authorization", typeJson: "{\"fqn\":\"azurerm.apiManagementApi.ApiManagementApiOauth2Authorization\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ApiManagementApi.IApiManagementApiOauth2Authorization? Oauth2Authorization
        {
            get
            {
                return null;
            }
        }

        /// <summary>openid_authentication block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#openid_authentication ApiManagementApi#openid_authentication}
        /// </remarks>
        [JsiiProperty(name: "openidAuthentication", typeJson: "{\"fqn\":\"azurerm.apiManagementApi.ApiManagementApiOpenidAuthentication\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ApiManagementApi.IApiManagementApiOpenidAuthentication? OpenidAuthentication
        {
            get
            {
                return null;
            }
        }

        /// <summary>The Path for this API Management API, which is a relative URL which uniquely identifies this API and all of its resource paths within the API Management Service.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#path ApiManagementApi#path}
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Path
        {
            get
            {
                return null;
            }
        }

        /// <summary>A list of protocols the operations in this API can be invoked.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#protocols ApiManagementApi#protocols}
        /// </remarks>
        [JsiiProperty(name: "protocols", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Protocols
        {
            get
            {
                return null;
            }
        }

        /// <summary>The description of the API Revision of the API Management API.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#revision_description ApiManagementApi#revision_description}
        /// </remarks>
        [JsiiProperty(name: "revisionDescription", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RevisionDescription
        {
            get
            {
                return null;
            }
        }

        /// <summary>Absolute URL of the backend service implementing this API.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#service_url ApiManagementApi#service_url}
        /// </remarks>
        [JsiiProperty(name: "serviceUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServiceUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>The API ID of the source API, which could be in format `azurerm_api_management_api.example.id` or in format `azurerm_api_management_api.example.id;rev=1`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#source_api_id ApiManagementApi#source_api_id}
        /// </remarks>
        [JsiiProperty(name: "sourceApiId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SourceApiId
        {
            get
            {
                return null;
            }
        }

        /// <summary>subscription_key_parameter_names block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#subscription_key_parameter_names ApiManagementApi#subscription_key_parameter_names}
        /// </remarks>
        [JsiiProperty(name: "subscriptionKeyParameterNames", typeJson: "{\"fqn\":\"azurerm.apiManagementApi.ApiManagementApiSubscriptionKeyParameterNames\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ApiManagementApi.IApiManagementApiSubscriptionKeyParameterNames? SubscriptionKeyParameterNames
        {
            get
            {
                return null;
            }
        }

        /// <summary>Should this API require a subscription key?</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#subscription_required ApiManagementApi#subscription_required}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "subscriptionRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SubscriptionRequired
        {
            get
            {
                return null;
            }
        }

        /// <summary>Absolute URL of the Terms of Service for the API.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#terms_of_service_url ApiManagementApi#terms_of_service_url}
        /// </remarks>
        [JsiiProperty(name: "termsOfServiceUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TermsOfServiceUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#timeouts ApiManagementApi#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.apiManagementApi.ApiManagementApiTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ApiManagementApi.IApiManagementApiTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>The Version number of this API, if this API is versioned.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#version ApiManagementApi#version}
        /// </remarks>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Version
        {
            get
            {
                return null;
            }
        }

        /// <summary>The description of the API Version of the API Management API.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#version_description ApiManagementApi#version_description}
        /// </remarks>
        [JsiiProperty(name: "versionDescription", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VersionDescription
        {
            get
            {
                return null;
            }
        }

        /// <summary>The ID of the Version Set which this API is associated with.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#version_set_id ApiManagementApi#version_set_id}
        /// </remarks>
        [JsiiProperty(name: "versionSetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VersionSetId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApiManagementApiConfig), fullyQualifiedName: "azurerm.apiManagementApi.ApiManagementApiConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.ApiManagementApi.IApiManagementApiConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#api_management_name ApiManagementApi#api_management_name}.</summary>
            [JsiiProperty(name: "apiManagementName", typeJson: "{\"primitive\":\"string\"}")]
            public string ApiManagementName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The name of the API Management API.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#name ApiManagementApi#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#resource_group_name ApiManagementApi#resource_group_name}.</summary>
            [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceGroupName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The Revision which used for this API.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#revision ApiManagementApi#revision}
            /// </remarks>
            [JsiiProperty(name: "revision", typeJson: "{\"primitive\":\"string\"}")]
            public string Revision
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Type of API.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#api_type ApiManagementApi#api_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "apiType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ApiType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>contact block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#contact ApiManagementApi#contact}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "contact", typeJson: "{\"fqn\":\"azurerm.apiManagementApi.ApiManagementApiContact\"}", isOptional: true)]
            public azurerm.ApiManagementApi.IApiManagementApiContact? Contact
            {
                get => GetInstanceProperty<azurerm.ApiManagementApi.IApiManagementApiContact?>();
            }

            /// <summary>A description of the API Management API, which may include HTML formatting tags.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#description ApiManagementApi#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The display name of the API.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#display_name ApiManagementApi#display_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisplayName
            {
                get => GetInstanceProperty<string?>();
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
                get => GetInstanceProperty<string?>();
            }

            /// <summary>import block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#import ApiManagementApi#import}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "import", typeJson: "{\"fqn\":\"azurerm.apiManagementApi.ApiManagementApiImport\"}", isOptional: true)]
            public azurerm.ApiManagementApi.IApiManagementApiImport? Import
            {
                get => GetInstanceProperty<azurerm.ApiManagementApi.IApiManagementApiImport?>();
            }

            /// <summary>license block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#license ApiManagementApi#license}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "license", typeJson: "{\"fqn\":\"azurerm.apiManagementApi.ApiManagementApiLicense\"}", isOptional: true)]
            public azurerm.ApiManagementApi.IApiManagementApiLicense? License
            {
                get => GetInstanceProperty<azurerm.ApiManagementApi.IApiManagementApiLicense?>();
            }

            /// <summary>oauth2_authorization block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#oauth2_authorization ApiManagementApi#oauth2_authorization}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "oauth2Authorization", typeJson: "{\"fqn\":\"azurerm.apiManagementApi.ApiManagementApiOauth2Authorization\"}", isOptional: true)]
            public azurerm.ApiManagementApi.IApiManagementApiOauth2Authorization? Oauth2Authorization
            {
                get => GetInstanceProperty<azurerm.ApiManagementApi.IApiManagementApiOauth2Authorization?>();
            }

            /// <summary>openid_authentication block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#openid_authentication ApiManagementApi#openid_authentication}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "openidAuthentication", typeJson: "{\"fqn\":\"azurerm.apiManagementApi.ApiManagementApiOpenidAuthentication\"}", isOptional: true)]
            public azurerm.ApiManagementApi.IApiManagementApiOpenidAuthentication? OpenidAuthentication
            {
                get => GetInstanceProperty<azurerm.ApiManagementApi.IApiManagementApiOpenidAuthentication?>();
            }

            /// <summary>The Path for this API Management API, which is a relative URL which uniquely identifies this API and all of its resource paths within the API Management Service.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#path ApiManagementApi#path}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Path
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A list of protocols the operations in this API can be invoked.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#protocols ApiManagementApi#protocols}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "protocols", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Protocols
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>The description of the API Revision of the API Management API.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#revision_description ApiManagementApi#revision_description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "revisionDescription", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RevisionDescription
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Absolute URL of the backend service implementing this API.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#service_url ApiManagementApi#service_url}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "serviceUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServiceUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The API ID of the source API, which could be in format `azurerm_api_management_api.example.id` or in format `azurerm_api_management_api.example.id;rev=1`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#source_api_id ApiManagementApi#source_api_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sourceApiId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SourceApiId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>subscription_key_parameter_names block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#subscription_key_parameter_names ApiManagementApi#subscription_key_parameter_names}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "subscriptionKeyParameterNames", typeJson: "{\"fqn\":\"azurerm.apiManagementApi.ApiManagementApiSubscriptionKeyParameterNames\"}", isOptional: true)]
            public azurerm.ApiManagementApi.IApiManagementApiSubscriptionKeyParameterNames? SubscriptionKeyParameterNames
            {
                get => GetInstanceProperty<azurerm.ApiManagementApi.IApiManagementApiSubscriptionKeyParameterNames?>();
            }

            /// <summary>Should this API require a subscription key?</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#subscription_required ApiManagementApi#subscription_required}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "subscriptionRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? SubscriptionRequired
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Absolute URL of the Terms of Service for the API.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#terms_of_service_url ApiManagementApi#terms_of_service_url}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "termsOfServiceUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TermsOfServiceUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#timeouts ApiManagementApi#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.apiManagementApi.ApiManagementApiTimeouts\"}", isOptional: true)]
            public azurerm.ApiManagementApi.IApiManagementApiTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.ApiManagementApi.IApiManagementApiTimeouts?>();
            }

            /// <summary>The Version number of this API, if this API is versioned.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#version ApiManagementApi#version}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Version
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The description of the API Version of the API Management API.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#version_description ApiManagementApi#version_description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "versionDescription", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VersionDescription
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The ID of the Version Set which this API is associated with.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#version_set_id ApiManagementApi#version_set_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "versionSetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VersionSetId
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
