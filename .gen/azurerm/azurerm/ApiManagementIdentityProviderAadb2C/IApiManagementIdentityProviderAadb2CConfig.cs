using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementIdentityProviderAadb2C
{
    [JsiiInterface(nativeType: typeof(IApiManagementIdentityProviderAadb2CConfig), fullyQualifiedName: "azurerm.apiManagementIdentityProviderAadb2C.ApiManagementIdentityProviderAadb2CConfig")]
    public interface IApiManagementIdentityProviderAadb2CConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The allowed AAD tenant, usually your B2C tenant domain.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_identity_provider_aadb2c#allowed_tenant ApiManagementIdentityProviderAadb2C#allowed_tenant}
        /// </remarks>
        [JsiiProperty(name: "allowedTenant", typeJson: "{\"primitive\":\"string\"}")]
        string AllowedTenant
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_identity_provider_aadb2c#api_management_name ApiManagementIdentityProviderAadb2C#api_management_name}.</summary>
        [JsiiProperty(name: "apiManagementName", typeJson: "{\"primitive\":\"string\"}")]
        string ApiManagementName
        {
            get;
        }

        /// <summary>OpenID Connect discovery endpoint hostname, usually your b2clogin.com domain.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_identity_provider_aadb2c#authority ApiManagementIdentityProviderAadb2C#authority}
        /// </remarks>
        [JsiiProperty(name: "authority", typeJson: "{\"primitive\":\"string\"}")]
        string Authority
        {
            get;
        }

        /// <summary>Client ID of the Application in your B2C tenant.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_identity_provider_aadb2c#client_id ApiManagementIdentityProviderAadb2C#client_id}
        /// </remarks>
        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
        string ClientId
        {
            get;
        }

        /// <summary>Client secret of the Application in your B2C tenant.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_identity_provider_aadb2c#client_secret ApiManagementIdentityProviderAadb2C#client_secret}
        /// </remarks>
        [JsiiProperty(name: "clientSecret", typeJson: "{\"primitive\":\"string\"}")]
        string ClientSecret
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_identity_provider_aadb2c#resource_group_name ApiManagementIdentityProviderAadb2C#resource_group_name}.</summary>
        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceGroupName
        {
            get;
        }

        /// <summary>Signin Policy Name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_identity_provider_aadb2c#signin_policy ApiManagementIdentityProviderAadb2C#signin_policy}
        /// </remarks>
        [JsiiProperty(name: "signinPolicy", typeJson: "{\"primitive\":\"string\"}")]
        string SigninPolicy
        {
            get;
        }

        /// <summary>The tenant to use instead of Common when logging into Active Directory, usually your B2C tenant domain.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_identity_provider_aadb2c#signin_tenant ApiManagementIdentityProviderAadb2C#signin_tenant}
        /// </remarks>
        [JsiiProperty(name: "signinTenant", typeJson: "{\"primitive\":\"string\"}")]
        string SigninTenant
        {
            get;
        }

        /// <summary>Signup Policy Name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_identity_provider_aadb2c#signup_policy ApiManagementIdentityProviderAadb2C#signup_policy}
        /// </remarks>
        [JsiiProperty(name: "signupPolicy", typeJson: "{\"primitive\":\"string\"}")]
        string SignupPolicy
        {
            get;
        }

        /// <summary>The client library to be used in the Azure AD B2C Identity Provider.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_identity_provider_aadb2c#client_library ApiManagementIdentityProviderAadb2C#client_library}
        /// </remarks>
        [JsiiProperty(name: "clientLibrary", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientLibrary
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_identity_provider_aadb2c#id ApiManagementIdentityProviderAadb2C#id}.</summary>
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

        /// <summary>Password reset Policy Name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_identity_provider_aadb2c#password_reset_policy ApiManagementIdentityProviderAadb2C#password_reset_policy}
        /// </remarks>
        [JsiiProperty(name: "passwordResetPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PasswordResetPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Profile editing Policy Name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_identity_provider_aadb2c#profile_editing_policy ApiManagementIdentityProviderAadb2C#profile_editing_policy}
        /// </remarks>
        [JsiiProperty(name: "profileEditingPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProfileEditingPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_identity_provider_aadb2c#timeouts ApiManagementIdentityProviderAadb2C#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.apiManagementIdentityProviderAadb2C.ApiManagementIdentityProviderAadb2CTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ApiManagementIdentityProviderAadb2C.IApiManagementIdentityProviderAadb2CTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApiManagementIdentityProviderAadb2CConfig), fullyQualifiedName: "azurerm.apiManagementIdentityProviderAadb2C.ApiManagementIdentityProviderAadb2CConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.ApiManagementIdentityProviderAadb2C.IApiManagementIdentityProviderAadb2CConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The allowed AAD tenant, usually your B2C tenant domain.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_identity_provider_aadb2c#allowed_tenant ApiManagementIdentityProviderAadb2C#allowed_tenant}
            /// </remarks>
            [JsiiProperty(name: "allowedTenant", typeJson: "{\"primitive\":\"string\"}")]
            public string AllowedTenant
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_identity_provider_aadb2c#api_management_name ApiManagementIdentityProviderAadb2C#api_management_name}.</summary>
            [JsiiProperty(name: "apiManagementName", typeJson: "{\"primitive\":\"string\"}")]
            public string ApiManagementName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>OpenID Connect discovery endpoint hostname, usually your b2clogin.com domain.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_identity_provider_aadb2c#authority ApiManagementIdentityProviderAadb2C#authority}
            /// </remarks>
            [JsiiProperty(name: "authority", typeJson: "{\"primitive\":\"string\"}")]
            public string Authority
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Client ID of the Application in your B2C tenant.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_identity_provider_aadb2c#client_id ApiManagementIdentityProviderAadb2C#client_id}
            /// </remarks>
            [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
            public string ClientId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Client secret of the Application in your B2C tenant.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_identity_provider_aadb2c#client_secret ApiManagementIdentityProviderAadb2C#client_secret}
            /// </remarks>
            [JsiiProperty(name: "clientSecret", typeJson: "{\"primitive\":\"string\"}")]
            public string ClientSecret
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_identity_provider_aadb2c#resource_group_name ApiManagementIdentityProviderAadb2C#resource_group_name}.</summary>
            [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceGroupName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Signin Policy Name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_identity_provider_aadb2c#signin_policy ApiManagementIdentityProviderAadb2C#signin_policy}
            /// </remarks>
            [JsiiProperty(name: "signinPolicy", typeJson: "{\"primitive\":\"string\"}")]
            public string SigninPolicy
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The tenant to use instead of Common when logging into Active Directory, usually your B2C tenant domain.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_identity_provider_aadb2c#signin_tenant ApiManagementIdentityProviderAadb2C#signin_tenant}
            /// </remarks>
            [JsiiProperty(name: "signinTenant", typeJson: "{\"primitive\":\"string\"}")]
            public string SigninTenant
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Signup Policy Name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_identity_provider_aadb2c#signup_policy ApiManagementIdentityProviderAadb2C#signup_policy}
            /// </remarks>
            [JsiiProperty(name: "signupPolicy", typeJson: "{\"primitive\":\"string\"}")]
            public string SignupPolicy
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The client library to be used in the Azure AD B2C Identity Provider.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_identity_provider_aadb2c#client_library ApiManagementIdentityProviderAadb2C#client_library}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientLibrary", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientLibrary
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_identity_provider_aadb2c#id ApiManagementIdentityProviderAadb2C#id}.</summary>
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

            /// <summary>Password reset Policy Name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_identity_provider_aadb2c#password_reset_policy ApiManagementIdentityProviderAadb2C#password_reset_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "passwordResetPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PasswordResetPolicy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Profile editing Policy Name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_identity_provider_aadb2c#profile_editing_policy ApiManagementIdentityProviderAadb2C#profile_editing_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "profileEditingPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProfileEditingPolicy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_identity_provider_aadb2c#timeouts ApiManagementIdentityProviderAadb2C#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.apiManagementIdentityProviderAadb2C.ApiManagementIdentityProviderAadb2CTimeouts\"}", isOptional: true)]
            public azurerm.ApiManagementIdentityProviderAadb2C.IApiManagementIdentityProviderAadb2CTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.ApiManagementIdentityProviderAadb2C.IApiManagementIdentityProviderAadb2CTimeouts?>();
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
