using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.ServicePrincipal
{
    [JsiiInterface(nativeType: typeof(IServicePrincipalConfig), fullyQualifiedName: "azuread.servicePrincipal.ServicePrincipalConfig")]
    public interface IServicePrincipalConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The client ID of the application for which to create a service principal.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal#client_id ServicePrincipal#client_id}
        /// </remarks>
        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
        string ClientId
        {
            get;
        }

        /// <summary>Whether or not the service principal account is enabled.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal#account_enabled ServicePrincipal#account_enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "accountEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AccountEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>A list of alternative names, used to retrieve service principals by subscription, identify resource group and full resource ids for managed identities.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal#alternative_names ServicePrincipal#alternative_names}
        /// </remarks>
        [JsiiProperty(name: "alternativeNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AlternativeNames
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether this service principal requires an app role assignment to a user or group before Azure AD will issue a user or access token to the application.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal#app_role_assignment_required ServicePrincipal#app_role_assignment_required}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "appRoleAssignmentRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AppRoleAssignmentRequired
        {
            get
            {
                return null;
            }
        }

        /// <summary>Description of the service principal provided for internal end-users.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal#description ServicePrincipal#description}
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

        /// <summary>features block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal#features ServicePrincipal#features}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.ServicePrincipal.IServicePrincipalFeatures" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "features", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.servicePrincipal.ServicePrincipalFeatures\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Features
        {
            get
            {
                return null;
            }
        }

        /// <summary>feature_tags block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal#feature_tags ServicePrincipal#feature_tags}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.ServicePrincipal.IServicePrincipalFeatureTags" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "featureTags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.servicePrincipal.ServicePrincipalFeatureTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FeatureTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal#id ServicePrincipal#id}.</summary>
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

        /// <summary>The URL where the service provider redirects the user to Azure AD to authenticate.</summary>
        /// <remarks>
        /// Azure AD uses the URL to launch the application from Microsoft 365 or the Azure AD My Apps. When blank, Azure AD performs IdP-initiated sign-on for applications configured with SAML-based single sign-on
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal#login_url ServicePrincipal#login_url}
        /// </remarks>
        [JsiiProperty(name: "loginUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LoginUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Free text field to capture information about the service principal, typically used for operational purposes.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal#notes ServicePrincipal#notes}
        /// </remarks>
        [JsiiProperty(name: "notes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Notes
        {
            get
            {
                return null;
            }
        }

        /// <summary>List of email addresses where Azure AD sends a notification when the active certificate is near the expiration date.</summary>
        /// <remarks>
        /// This is only for the certificates used to sign the SAML token issued for Azure AD Gallery applications
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal#notification_email_addresses ServicePrincipal#notification_email_addresses}
        /// </remarks>
        [JsiiProperty(name: "notificationEmailAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? NotificationEmailAddresses
        {
            get
            {
                return null;
            }
        }

        /// <summary>A list of object IDs of principals that will be granted ownership of the service principal.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal#owners ServicePrincipal#owners}
        /// </remarks>
        [JsiiProperty(name: "owners", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Owners
        {
            get
            {
                return null;
            }
        }

        /// <summary>The single sign-on mode configured for this application.</summary>
        /// <remarks>
        /// Azure AD uses the preferred single sign-on mode to launch the application from Microsoft 365 or the Azure AD My Apps
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal#preferred_single_sign_on_mode ServicePrincipal#preferred_single_sign_on_mode}
        /// </remarks>
        [JsiiProperty(name: "preferredSingleSignOnMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PreferredSingleSignOnMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>saml_single_sign_on block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal#saml_single_sign_on ServicePrincipal#saml_single_sign_on}
        /// </remarks>
        [JsiiProperty(name: "samlSingleSignOn", typeJson: "{\"fqn\":\"azuread.servicePrincipal.ServicePrincipalSamlSingleSignOn\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuread.ServicePrincipal.IServicePrincipalSamlSingleSignOn? SamlSingleSignOn
        {
            get
            {
                return null;
            }
        }

        /// <summary>A set of tags to apply to the service principal.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal#tags ServicePrincipal#tags}
        /// </remarks>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal#timeouts ServicePrincipal#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuread.servicePrincipal.ServicePrincipalTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuread.ServicePrincipal.IServicePrincipalTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>When true, the resource will return an existing service principal instead of failing with an error.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal#use_existing ServicePrincipal#use_existing}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "useExisting", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UseExisting
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IServicePrincipalConfig), fullyQualifiedName: "azuread.servicePrincipal.ServicePrincipalConfig")]
        internal sealed class _Proxy : DeputyBase, azuread.ServicePrincipal.IServicePrincipalConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The client ID of the application for which to create a service principal.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal#client_id ServicePrincipal#client_id}
            /// </remarks>
            [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
            public string ClientId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Whether or not the service principal account is enabled.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal#account_enabled ServicePrincipal#account_enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accountEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AccountEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>A list of alternative names, used to retrieve service principals by subscription, identify resource group and full resource ids for managed identities.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal#alternative_names ServicePrincipal#alternative_names}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "alternativeNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AlternativeNames
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Whether this service principal requires an app role assignment to a user or group before Azure AD will issue a user or access token to the application.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal#app_role_assignment_required ServicePrincipal#app_role_assignment_required}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "appRoleAssignmentRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AppRoleAssignmentRequired
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Description of the service principal provided for internal end-users.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal#description ServicePrincipal#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>features block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal#features ServicePrincipal#features}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.ServicePrincipal.IServicePrincipalFeatures" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "features", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.servicePrincipal.ServicePrincipalFeatures\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Features
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>feature_tags block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal#feature_tags ServicePrincipal#feature_tags}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.ServicePrincipal.IServicePrincipalFeatureTags" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "featureTags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.servicePrincipal.ServicePrincipalFeatureTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? FeatureTags
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal#id ServicePrincipal#id}.</summary>
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

            /// <summary>The URL where the service provider redirects the user to Azure AD to authenticate.</summary>
            /// <remarks>
            /// Azure AD uses the URL to launch the application from Microsoft 365 or the Azure AD My Apps. When blank, Azure AD performs IdP-initiated sign-on for applications configured with SAML-based single sign-on
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal#login_url ServicePrincipal#login_url}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "loginUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LoginUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Free text field to capture information about the service principal, typically used for operational purposes.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal#notes ServicePrincipal#notes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "notes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Notes
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>List of email addresses where Azure AD sends a notification when the active certificate is near the expiration date.</summary>
            /// <remarks>
            /// This is only for the certificates used to sign the SAML token issued for Azure AD Gallery applications
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal#notification_email_addresses ServicePrincipal#notification_email_addresses}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "notificationEmailAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? NotificationEmailAddresses
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>A list of object IDs of principals that will be granted ownership of the service principal.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal#owners ServicePrincipal#owners}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "owners", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Owners
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>The single sign-on mode configured for this application.</summary>
            /// <remarks>
            /// Azure AD uses the preferred single sign-on mode to launch the application from Microsoft 365 or the Azure AD My Apps
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal#preferred_single_sign_on_mode ServicePrincipal#preferred_single_sign_on_mode}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "preferredSingleSignOnMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PreferredSingleSignOnMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>saml_single_sign_on block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal#saml_single_sign_on ServicePrincipal#saml_single_sign_on}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "samlSingleSignOn", typeJson: "{\"fqn\":\"azuread.servicePrincipal.ServicePrincipalSamlSingleSignOn\"}", isOptional: true)]
            public azuread.ServicePrincipal.IServicePrincipalSamlSingleSignOn? SamlSingleSignOn
            {
                get => GetInstanceProperty<azuread.ServicePrincipal.IServicePrincipalSamlSingleSignOn?>();
            }

            /// <summary>A set of tags to apply to the service principal.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal#tags ServicePrincipal#tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Tags
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal#timeouts ServicePrincipal#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuread.servicePrincipal.ServicePrincipalTimeouts\"}", isOptional: true)]
            public azuread.ServicePrincipal.IServicePrincipalTimeouts? Timeouts
            {
                get => GetInstanceProperty<azuread.ServicePrincipal.IServicePrincipalTimeouts?>();
            }

            /// <summary>When true, the resource will return an existing service principal instead of failing with an error.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal#use_existing ServicePrincipal#use_existing}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "useExisting", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? UseExisting
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
