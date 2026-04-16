using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace neon.JwksUrl
{
    [JsiiInterface(nativeType: typeof(IJwksUrlConfig), fullyQualifiedName: "neon.jwksUrl.JwksUrlConfig")]
    public interface IJwksUrlConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The URL that lists the JWKS.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/jwks_url#jwks_url JwksUrl#jwks_url}
        /// </remarks>
        [JsiiProperty(name: "jwksUrl", typeJson: "{\"primitive\":\"string\"}")]
        string JwksUrl
        {
            get;
        }

        /// <summary>Project ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/jwks_url#project_id JwksUrl#project_id}
        /// </remarks>
        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
        string ProjectId
        {
            get;
        }

        /// <summary>The name of the authentication provider.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/jwks_url#provider_name JwksUrl#provider_name}
        /// </remarks>
        [JsiiProperty(name: "providerName", typeJson: "{\"primitive\":\"string\"}")]
        string ProviderName
        {
            get;
        }

        /// <summary>The roles the JWKS should be mapped to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/jwks_url#role_names JwksUrl#role_names}
        /// </remarks>
        [JsiiProperty(name: "roleNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] RoleNames
        {
            get;
        }

        /// <summary>Branch ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/jwks_url#branch_id JwksUrl#branch_id}
        /// </remarks>
        [JsiiProperty(name: "branchId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BranchId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/jwks_url#id JwksUrl#id}.</summary>
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

        /// <summary>The name of the required JWT Audience to be used.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/jwks_url#jwt_audience JwksUrl#jwt_audience}
        /// </remarks>
        [JsiiProperty(name: "jwtAudience", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? JwtAudience
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IJwksUrlConfig), fullyQualifiedName: "neon.jwksUrl.JwksUrlConfig")]
        internal sealed class _Proxy : DeputyBase, neon.JwksUrl.IJwksUrlConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The URL that lists the JWKS.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/jwks_url#jwks_url JwksUrl#jwks_url}
            /// </remarks>
            [JsiiProperty(name: "jwksUrl", typeJson: "{\"primitive\":\"string\"}")]
            public string JwksUrl
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Project ID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/jwks_url#project_id JwksUrl#project_id}
            /// </remarks>
            [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
            public string ProjectId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The name of the authentication provider.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/jwks_url#provider_name JwksUrl#provider_name}
            /// </remarks>
            [JsiiProperty(name: "providerName", typeJson: "{\"primitive\":\"string\"}")]
            public string ProviderName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The roles the JWKS should be mapped to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/jwks_url#role_names JwksUrl#role_names}
            /// </remarks>
            [JsiiProperty(name: "roleNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] RoleNames
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Branch ID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/jwks_url#branch_id JwksUrl#branch_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "branchId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BranchId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/jwks_url#id JwksUrl#id}.</summary>
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

            /// <summary>The name of the required JWT Audience to be used.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/jwks_url#jwt_audience JwksUrl#jwt_audience}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "jwtAudience", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? JwtAudience
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
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
