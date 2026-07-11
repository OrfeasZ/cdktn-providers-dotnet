using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.ApplicationOptionalClaims
{
    [JsiiInterface(nativeType: typeof(IApplicationOptionalClaimsAConfig), fullyQualifiedName: "azuread.applicationOptionalClaims.ApplicationOptionalClaimsAConfig")]
    public interface IApplicationOptionalClaimsAConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The resource ID of the application to which these optional claims belong.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_optional_claims#application_id ApplicationOptionalClaimsA#application_id}
        /// </remarks>
        [JsiiProperty(name: "applicationId", typeJson: "{\"primitive\":\"string\"}")]
        string ApplicationId
        {
            get;
        }

        /// <summary>access_token block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_optional_claims#access_token ApplicationOptionalClaimsA#access_token}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.ApplicationOptionalClaims.IApplicationOptionalClaimsAccessTokenA" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "accessToken", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.applicationOptionalClaims.ApplicationOptionalClaimsAccessTokenA\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AccessToken
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_optional_claims#id ApplicationOptionalClaimsA#id}.</summary>
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

        /// <summary>id_token block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_optional_claims#id_token ApplicationOptionalClaimsA#id_token}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.ApplicationOptionalClaims.IApplicationOptionalClaimsIdTokenA" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "idToken", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.applicationOptionalClaims.ApplicationOptionalClaimsIdTokenA\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IdToken
        {
            get
            {
                return null;
            }
        }

        /// <summary>saml2_token block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_optional_claims#saml2_token ApplicationOptionalClaimsA#saml2_token}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.ApplicationOptionalClaims.IApplicationOptionalClaimsSaml2TokenA" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "saml2Token", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.applicationOptionalClaims.ApplicationOptionalClaimsSaml2TokenA\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Saml2Token
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_optional_claims#timeouts ApplicationOptionalClaimsA#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuread.applicationOptionalClaims.ApplicationOptionalClaimsTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuread.ApplicationOptionalClaims.IApplicationOptionalClaimsTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApplicationOptionalClaimsAConfig), fullyQualifiedName: "azuread.applicationOptionalClaims.ApplicationOptionalClaimsAConfig")]
        internal sealed class _Proxy : DeputyBase, azuread.ApplicationOptionalClaims.IApplicationOptionalClaimsAConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The resource ID of the application to which these optional claims belong.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_optional_claims#application_id ApplicationOptionalClaimsA#application_id}
            /// </remarks>
            [JsiiProperty(name: "applicationId", typeJson: "{\"primitive\":\"string\"}")]
            public string ApplicationId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>access_token block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_optional_claims#access_token ApplicationOptionalClaimsA#access_token}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.ApplicationOptionalClaims.IApplicationOptionalClaimsAccessTokenA" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accessToken", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.applicationOptionalClaims.ApplicationOptionalClaimsAccessTokenA\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AccessToken
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_optional_claims#id ApplicationOptionalClaimsA#id}.</summary>
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

            /// <summary>id_token block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_optional_claims#id_token ApplicationOptionalClaimsA#id_token}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.ApplicationOptionalClaims.IApplicationOptionalClaimsIdTokenA" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "idToken", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.applicationOptionalClaims.ApplicationOptionalClaimsIdTokenA\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? IdToken
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>saml2_token block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_optional_claims#saml2_token ApplicationOptionalClaimsA#saml2_token}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.ApplicationOptionalClaims.IApplicationOptionalClaimsSaml2TokenA" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "saml2Token", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.applicationOptionalClaims.ApplicationOptionalClaimsSaml2TokenA\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Saml2Token
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_optional_claims#timeouts ApplicationOptionalClaimsA#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuread.applicationOptionalClaims.ApplicationOptionalClaimsTimeouts\"}", isOptional: true)]
            public azuread.ApplicationOptionalClaims.IApplicationOptionalClaimsTimeouts? Timeouts
            {
                get => GetInstanceProperty<azuread.ApplicationOptionalClaims.IApplicationOptionalClaimsTimeouts?>();
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
