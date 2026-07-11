using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.ApplicationFlexibleFederatedIdentityCredential
{
    [JsiiInterface(nativeType: typeof(IApplicationFlexibleFederatedIdentityCredentialConfig), fullyQualifiedName: "azuread.applicationFlexibleFederatedIdentityCredential.ApplicationFlexibleFederatedIdentityCredentialConfig")]
    public interface IApplicationFlexibleFederatedIdentityCredentialConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The resource ID of the application for which this flexible federated identity credential should be created.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_flexible_federated_identity_credential#application_id ApplicationFlexibleFederatedIdentityCredential#application_id}
        /// </remarks>
        [JsiiProperty(name: "applicationId", typeJson: "{\"primitive\":\"string\"}")]
        string ApplicationId
        {
            get;
        }

        /// <summary>The audience that can appear in the external token.</summary>
        /// <remarks>
        /// This specifies what should be accepted in the <c>aud</c> claim of incoming tokens.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_flexible_federated_identity_credential#audience ApplicationFlexibleFederatedIdentityCredential#audience}
        /// </remarks>
        [JsiiProperty(name: "audience", typeJson: "{\"primitive\":\"string\"}")]
        string Audience
        {
            get;
        }

        /// <summary>The expression to match for claims.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_flexible_federated_identity_credential#claims_matching_expression ApplicationFlexibleFederatedIdentityCredential#claims_matching_expression}
        /// </remarks>
        [JsiiProperty(name: "claimsMatchingExpression", typeJson: "{\"primitive\":\"string\"}")]
        string ClaimsMatchingExpression
        {
            get;
        }

        /// <summary>A unique display name for the flexible federated identity credential.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_flexible_federated_identity_credential#display_name ApplicationFlexibleFederatedIdentityCredential#display_name}
        /// </remarks>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        string DisplayName
        {
            get;
        }

        /// <summary>The URL of the external identity provider, which must match the issuer claim of the external token being exchanged.</summary>
        /// <remarks>
        /// The combination of the values of issuer and subject must be unique on the app.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_flexible_federated_identity_credential#issuer ApplicationFlexibleFederatedIdentityCredential#issuer}
        /// </remarks>
        [JsiiProperty(name: "issuer", typeJson: "{\"primitive\":\"string\"}")]
        string Issuer
        {
            get;
        }

        /// <summary>A description for the flexible federated identity credential.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_flexible_federated_identity_credential#description ApplicationFlexibleFederatedIdentityCredential#description}
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_flexible_federated_identity_credential#id ApplicationFlexibleFederatedIdentityCredential#id}.</summary>
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

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_flexible_federated_identity_credential#timeouts ApplicationFlexibleFederatedIdentityCredential#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuread.applicationFlexibleFederatedIdentityCredential.ApplicationFlexibleFederatedIdentityCredentialTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuread.ApplicationFlexibleFederatedIdentityCredential.IApplicationFlexibleFederatedIdentityCredentialTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApplicationFlexibleFederatedIdentityCredentialConfig), fullyQualifiedName: "azuread.applicationFlexibleFederatedIdentityCredential.ApplicationFlexibleFederatedIdentityCredentialConfig")]
        internal sealed class _Proxy : DeputyBase, azuread.ApplicationFlexibleFederatedIdentityCredential.IApplicationFlexibleFederatedIdentityCredentialConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The resource ID of the application for which this flexible federated identity credential should be created.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_flexible_federated_identity_credential#application_id ApplicationFlexibleFederatedIdentityCredential#application_id}
            /// </remarks>
            [JsiiProperty(name: "applicationId", typeJson: "{\"primitive\":\"string\"}")]
            public string ApplicationId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The audience that can appear in the external token.</summary>
            /// <remarks>
            /// This specifies what should be accepted in the <c>aud</c> claim of incoming tokens.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_flexible_federated_identity_credential#audience ApplicationFlexibleFederatedIdentityCredential#audience}
            /// </remarks>
            [JsiiProperty(name: "audience", typeJson: "{\"primitive\":\"string\"}")]
            public string Audience
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The expression to match for claims.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_flexible_federated_identity_credential#claims_matching_expression ApplicationFlexibleFederatedIdentityCredential#claims_matching_expression}
            /// </remarks>
            [JsiiProperty(name: "claimsMatchingExpression", typeJson: "{\"primitive\":\"string\"}")]
            public string ClaimsMatchingExpression
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>A unique display name for the flexible federated identity credential.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_flexible_federated_identity_credential#display_name ApplicationFlexibleFederatedIdentityCredential#display_name}
            /// </remarks>
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
            public string DisplayName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The URL of the external identity provider, which must match the issuer claim of the external token being exchanged.</summary>
            /// <remarks>
            /// The combination of the values of issuer and subject must be unique on the app.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_flexible_federated_identity_credential#issuer ApplicationFlexibleFederatedIdentityCredential#issuer}
            /// </remarks>
            [JsiiProperty(name: "issuer", typeJson: "{\"primitive\":\"string\"}")]
            public string Issuer
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>A description for the flexible federated identity credential.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_flexible_federated_identity_credential#description ApplicationFlexibleFederatedIdentityCredential#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_flexible_federated_identity_credential#id ApplicationFlexibleFederatedIdentityCredential#id}.</summary>
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

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_flexible_federated_identity_credential#timeouts ApplicationFlexibleFederatedIdentityCredential#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuread.applicationFlexibleFederatedIdentityCredential.ApplicationFlexibleFederatedIdentityCredentialTimeouts\"}", isOptional: true)]
            public azuread.ApplicationFlexibleFederatedIdentityCredential.IApplicationFlexibleFederatedIdentityCredentialTimeouts? Timeouts
            {
                get => GetInstanceProperty<azuread.ApplicationFlexibleFederatedIdentityCredential.IApplicationFlexibleFederatedIdentityCredentialTimeouts?>();
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
