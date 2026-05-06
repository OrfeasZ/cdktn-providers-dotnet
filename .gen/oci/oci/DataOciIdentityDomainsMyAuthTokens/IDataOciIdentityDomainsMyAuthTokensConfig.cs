using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciIdentityDomainsMyAuthTokens
{
    [JsiiInterface(nativeType: typeof(IDataOciIdentityDomainsMyAuthTokensConfig), fullyQualifiedName: "oci.dataOciIdentityDomainsMyAuthTokens.DataOciIdentityDomainsMyAuthTokensConfig")]
    public interface IDataOciIdentityDomainsMyAuthTokensConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/identity_domains_my_auth_tokens#idcs_endpoint DataOciIdentityDomainsMyAuthTokens#idcs_endpoint}.</summary>
        [JsiiProperty(name: "idcsEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        string IdcsEndpoint
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/identity_domains_my_auth_tokens#authorization DataOciIdentityDomainsMyAuthTokens#authorization}.</summary>
        [JsiiProperty(name: "authorization", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Authorization
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/identity_domains_my_auth_tokens#compartment_id DataOciIdentityDomainsMyAuthTokens#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CompartmentId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/identity_domains_my_auth_tokens#id DataOciIdentityDomainsMyAuthTokens#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/identity_domains_my_auth_tokens#my_auth_token_count DataOciIdentityDomainsMyAuthTokens#my_auth_token_count}.</summary>
        [JsiiProperty(name: "myAuthTokenCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MyAuthTokenCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/identity_domains_my_auth_tokens#my_auth_token_filter DataOciIdentityDomainsMyAuthTokens#my_auth_token_filter}.</summary>
        [JsiiProperty(name: "myAuthTokenFilter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MyAuthTokenFilter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/identity_domains_my_auth_tokens#resource_type_schema_version DataOciIdentityDomainsMyAuthTokens#resource_type_schema_version}.</summary>
        [JsiiProperty(name: "resourceTypeSchemaVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResourceTypeSchemaVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/identity_domains_my_auth_tokens#sort_by DataOciIdentityDomainsMyAuthTokens#sort_by}.</summary>
        [JsiiProperty(name: "sortBy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SortBy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/identity_domains_my_auth_tokens#sort_order DataOciIdentityDomainsMyAuthTokens#sort_order}.</summary>
        [JsiiProperty(name: "sortOrder", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SortOrder
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/identity_domains_my_auth_tokens#start_index DataOciIdentityDomainsMyAuthTokens#start_index}.</summary>
        [JsiiProperty(name: "startIndex", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? StartIndex
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataOciIdentityDomainsMyAuthTokensConfig), fullyQualifiedName: "oci.dataOciIdentityDomainsMyAuthTokens.DataOciIdentityDomainsMyAuthTokensConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DataOciIdentityDomainsMyAuthTokens.IDataOciIdentityDomainsMyAuthTokensConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/identity_domains_my_auth_tokens#idcs_endpoint DataOciIdentityDomainsMyAuthTokens#idcs_endpoint}.</summary>
            [JsiiProperty(name: "idcsEndpoint", typeJson: "{\"primitive\":\"string\"}")]
            public string IdcsEndpoint
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/identity_domains_my_auth_tokens#authorization DataOciIdentityDomainsMyAuthTokens#authorization}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authorization", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Authorization
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/identity_domains_my_auth_tokens#compartment_id DataOciIdentityDomainsMyAuthTokens#compartment_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CompartmentId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/identity_domains_my_auth_tokens#id DataOciIdentityDomainsMyAuthTokens#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/identity_domains_my_auth_tokens#my_auth_token_count DataOciIdentityDomainsMyAuthTokens#my_auth_token_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "myAuthTokenCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MyAuthTokenCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/identity_domains_my_auth_tokens#my_auth_token_filter DataOciIdentityDomainsMyAuthTokens#my_auth_token_filter}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "myAuthTokenFilter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MyAuthTokenFilter
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/identity_domains_my_auth_tokens#resource_type_schema_version DataOciIdentityDomainsMyAuthTokens#resource_type_schema_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "resourceTypeSchemaVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResourceTypeSchemaVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/identity_domains_my_auth_tokens#sort_by DataOciIdentityDomainsMyAuthTokens#sort_by}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sortBy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SortBy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/identity_domains_my_auth_tokens#sort_order DataOciIdentityDomainsMyAuthTokens#sort_order}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sortOrder", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SortOrder
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/identity_domains_my_auth_tokens#start_index DataOciIdentityDomainsMyAuthTokens#start_index}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "startIndex", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? StartIndex
            {
                get => GetInstanceProperty<double?>();
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
