using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementAuthorizationServer
{
    [JsiiInterface(nativeType: typeof(IApiManagementAuthorizationServerConfig), fullyQualifiedName: "azurerm.apiManagementAuthorizationServer.ApiManagementAuthorizationServerConfig")]
    public interface IApiManagementAuthorizationServerConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_authorization_server#api_management_name ApiManagementAuthorizationServer#api_management_name}.</summary>
        [JsiiProperty(name: "apiManagementName", typeJson: "{\"primitive\":\"string\"}")]
        string ApiManagementName
        {
            get;
        }

        /// <summary>The OAuth Authorization Endpoint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_authorization_server#authorization_endpoint ApiManagementAuthorizationServer#authorization_endpoint}
        /// </remarks>
        [JsiiProperty(name: "authorizationEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        string AuthorizationEndpoint
        {
            get;
        }

        /// <summary>The HTTP Verbs supported by the Authorization Endpoint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_authorization_server#authorization_methods ApiManagementAuthorizationServer#authorization_methods}
        /// </remarks>
        [JsiiProperty(name: "authorizationMethods", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] AuthorizationMethods
        {
            get;
        }

        /// <summary>The Client/App ID registered with this Authorization Server.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_authorization_server#client_id ApiManagementAuthorizationServer#client_id}
        /// </remarks>
        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
        string ClientId
        {
            get;
        }

        /// <summary>The URI of page where Client/App Registration is performed for this Authorization Server.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_authorization_server#client_registration_endpoint ApiManagementAuthorizationServer#client_registration_endpoint}
        /// </remarks>
        [JsiiProperty(name: "clientRegistrationEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        string ClientRegistrationEndpoint
        {
            get;
        }

        /// <summary>The user-friendly name of this Authorization Server.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_authorization_server#display_name ApiManagementAuthorizationServer#display_name}
        /// </remarks>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        string DisplayName
        {
            get;
        }

        /// <summary>Form of Authorization Grants required when requesting an Access Token.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_authorization_server#grant_types ApiManagementAuthorizationServer#grant_types}
        /// </remarks>
        [JsiiProperty(name: "grantTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] GrantTypes
        {
            get;
        }

        /// <summary>The name of this Authorization Server.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_authorization_server#name ApiManagementAuthorizationServer#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_authorization_server#resource_group_name ApiManagementAuthorizationServer#resource_group_name}.</summary>
        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceGroupName
        {
            get;
        }

        /// <summary>The mechanism by which Access Tokens are passed to the API.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_authorization_server#bearer_token_sending_methods ApiManagementAuthorizationServer#bearer_token_sending_methods}
        /// </remarks>
        [JsiiProperty(name: "bearerTokenSendingMethods", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? BearerTokenSendingMethods
        {
            get
            {
                return null;
            }
        }

        /// <summary>The Authentication Methods supported by the Token endpoint of this Authorization Server.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_authorization_server#client_authentication_method ApiManagementAuthorizationServer#client_authentication_method}
        /// </remarks>
        [JsiiProperty(name: "clientAuthenticationMethod", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ClientAuthenticationMethod
        {
            get
            {
                return null;
            }
        }

        /// <summary>The Client/App Secret registered with this Authorization Server.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_authorization_server#client_secret ApiManagementAuthorizationServer#client_secret}
        /// </remarks>
        [JsiiProperty(name: "clientSecret", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientSecret
        {
            get
            {
                return null;
            }
        }

        /// <summary>The Default Scope used when requesting an Access Token, specified as a string containing space-delimited values.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_authorization_server#default_scope ApiManagementAuthorizationServer#default_scope}
        /// </remarks>
        [JsiiProperty(name: "defaultScope", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefaultScope
        {
            get
            {
                return null;
            }
        }

        /// <summary>A description of the Authorization Server, which may contain HTML formatting tags.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_authorization_server#description ApiManagementAuthorizationServer#description}
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_authorization_server#id ApiManagementAuthorizationServer#id}.</summary>
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

        /// <summary>The password associated with the Resource Owner.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_authorization_server#resource_owner_password ApiManagementAuthorizationServer#resource_owner_password}
        /// </remarks>
        [JsiiProperty(name: "resourceOwnerPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResourceOwnerPassword
        {
            get
            {
                return null;
            }
        }

        /// <summary>The username associated with the Resource Owner.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_authorization_server#resource_owner_username ApiManagementAuthorizationServer#resource_owner_username}
        /// </remarks>
        [JsiiProperty(name: "resourceOwnerUsername", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResourceOwnerUsername
        {
            get
            {
                return null;
            }
        }

        /// <summary>Does this Authorization Server support State?</summary>
        /// <remarks>
        /// If this is set to <c>true</c> the client may use the state parameter to raise protocol security.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_authorization_server#support_state ApiManagementAuthorizationServer#support_state}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "supportState", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SupportState
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_authorization_server#timeouts ApiManagementAuthorizationServer#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.apiManagementAuthorizationServer.ApiManagementAuthorizationServerTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ApiManagementAuthorizationServer.IApiManagementAuthorizationServerTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>token_body_parameter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_authorization_server#token_body_parameter ApiManagementAuthorizationServer#token_body_parameter}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApiManagementAuthorizationServer.IApiManagementAuthorizationServerTokenBodyParameter" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "tokenBodyParameter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagementAuthorizationServer.ApiManagementAuthorizationServerTokenBodyParameter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TokenBodyParameter
        {
            get
            {
                return null;
            }
        }

        /// <summary>The OAuth Token Endpoint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_authorization_server#token_endpoint ApiManagementAuthorizationServer#token_endpoint}
        /// </remarks>
        [JsiiProperty(name: "tokenEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TokenEndpoint
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApiManagementAuthorizationServerConfig), fullyQualifiedName: "azurerm.apiManagementAuthorizationServer.ApiManagementAuthorizationServerConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.ApiManagementAuthorizationServer.IApiManagementAuthorizationServerConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_authorization_server#api_management_name ApiManagementAuthorizationServer#api_management_name}.</summary>
            [JsiiProperty(name: "apiManagementName", typeJson: "{\"primitive\":\"string\"}")]
            public string ApiManagementName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The OAuth Authorization Endpoint.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_authorization_server#authorization_endpoint ApiManagementAuthorizationServer#authorization_endpoint}
            /// </remarks>
            [JsiiProperty(name: "authorizationEndpoint", typeJson: "{\"primitive\":\"string\"}")]
            public string AuthorizationEndpoint
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The HTTP Verbs supported by the Authorization Endpoint.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_authorization_server#authorization_methods ApiManagementAuthorizationServer#authorization_methods}
            /// </remarks>
            [JsiiProperty(name: "authorizationMethods", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] AuthorizationMethods
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>The Client/App ID registered with this Authorization Server.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_authorization_server#client_id ApiManagementAuthorizationServer#client_id}
            /// </remarks>
            [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
            public string ClientId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The URI of page where Client/App Registration is performed for this Authorization Server.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_authorization_server#client_registration_endpoint ApiManagementAuthorizationServer#client_registration_endpoint}
            /// </remarks>
            [JsiiProperty(name: "clientRegistrationEndpoint", typeJson: "{\"primitive\":\"string\"}")]
            public string ClientRegistrationEndpoint
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The user-friendly name of this Authorization Server.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_authorization_server#display_name ApiManagementAuthorizationServer#display_name}
            /// </remarks>
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
            public string DisplayName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Form of Authorization Grants required when requesting an Access Token.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_authorization_server#grant_types ApiManagementAuthorizationServer#grant_types}
            /// </remarks>
            [JsiiProperty(name: "grantTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] GrantTypes
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>The name of this Authorization Server.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_authorization_server#name ApiManagementAuthorizationServer#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_authorization_server#resource_group_name ApiManagementAuthorizationServer#resource_group_name}.</summary>
            [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceGroupName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The mechanism by which Access Tokens are passed to the API.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_authorization_server#bearer_token_sending_methods ApiManagementAuthorizationServer#bearer_token_sending_methods}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bearerTokenSendingMethods", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? BearerTokenSendingMethods
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>The Authentication Methods supported by the Token endpoint of this Authorization Server.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_authorization_server#client_authentication_method ApiManagementAuthorizationServer#client_authentication_method}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientAuthenticationMethod", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ClientAuthenticationMethod
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>The Client/App Secret registered with this Authorization Server.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_authorization_server#client_secret ApiManagementAuthorizationServer#client_secret}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientSecret", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientSecret
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The Default Scope used when requesting an Access Token, specified as a string containing space-delimited values.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_authorization_server#default_scope ApiManagementAuthorizationServer#default_scope}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "defaultScope", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultScope
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A description of the Authorization Server, which may contain HTML formatting tags.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_authorization_server#description ApiManagementAuthorizationServer#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_authorization_server#id ApiManagementAuthorizationServer#id}.</summary>
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

            /// <summary>The password associated with the Resource Owner.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_authorization_server#resource_owner_password ApiManagementAuthorizationServer#resource_owner_password}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceOwnerPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResourceOwnerPassword
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The username associated with the Resource Owner.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_authorization_server#resource_owner_username ApiManagementAuthorizationServer#resource_owner_username}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceOwnerUsername", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResourceOwnerUsername
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Does this Authorization Server support State?</summary>
            /// <remarks>
            /// If this is set to <c>true</c> the client may use the state parameter to raise protocol security.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_authorization_server#support_state ApiManagementAuthorizationServer#support_state}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "supportState", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? SupportState
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_authorization_server#timeouts ApiManagementAuthorizationServer#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.apiManagementAuthorizationServer.ApiManagementAuthorizationServerTimeouts\"}", isOptional: true)]
            public azurerm.ApiManagementAuthorizationServer.IApiManagementAuthorizationServerTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.ApiManagementAuthorizationServer.IApiManagementAuthorizationServerTimeouts?>();
            }

            /// <summary>token_body_parameter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_authorization_server#token_body_parameter ApiManagementAuthorizationServer#token_body_parameter}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApiManagementAuthorizationServer.IApiManagementAuthorizationServerTokenBodyParameter" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tokenBodyParameter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagementAuthorizationServer.ApiManagementAuthorizationServerTokenBodyParameter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TokenBodyParameter
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The OAuth Token Endpoint.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_authorization_server#token_endpoint ApiManagementAuthorizationServer#token_endpoint}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tokenEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TokenEndpoint
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
