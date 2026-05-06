using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsGrant
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsGrantConfig), fullyQualifiedName: "oci.identityDomainsGrant.IdentityDomainsGrantConfig")]
    public interface IIdentityDomainsGrantConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>grantee block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_grant#grantee IdentityDomainsGrant#grantee}
        /// </remarks>
        [JsiiProperty(name: "grantee", typeJson: "{\"fqn\":\"oci.identityDomainsGrant.IdentityDomainsGrantGrantee\"}")]
        oci.IdentityDomainsGrant.IIdentityDomainsGrantGrantee Grantee
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_grant#grant_mechanism IdentityDomainsGrant#grant_mechanism}.</summary>
        [JsiiProperty(name: "grantMechanism", typeJson: "{\"primitive\":\"string\"}")]
        string GrantMechanism
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_grant#idcs_endpoint IdentityDomainsGrant#idcs_endpoint}.</summary>
        [JsiiProperty(name: "idcsEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        string IdcsEndpoint
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_grant#schemas IdentityDomainsGrant#schemas}.</summary>
        [JsiiProperty(name: "schemas", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Schemas
        {
            get;
        }

        /// <summary>app block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_grant#app IdentityDomainsGrant#app}
        /// </remarks>
        [JsiiProperty(name: "app", typeJson: "{\"fqn\":\"oci.identityDomainsGrant.IdentityDomainsGrantApp\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IdentityDomainsGrant.IIdentityDomainsGrantApp? App
        {
            get
            {
                return null;
            }
        }

        /// <summary>app_entitlement_collection block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_grant#app_entitlement_collection IdentityDomainsGrant#app_entitlement_collection}
        /// </remarks>
        [JsiiProperty(name: "appEntitlementCollection", typeJson: "{\"fqn\":\"oci.identityDomainsGrant.IdentityDomainsGrantAppEntitlementCollection\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IdentityDomainsGrant.IIdentityDomainsGrantAppEntitlementCollection? AppEntitlementCollection
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_grant#attributes IdentityDomainsGrant#attributes}.</summary>
        [JsiiProperty(name: "attributes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Attributes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_grant#attribute_sets IdentityDomainsGrant#attribute_sets}.</summary>
        [JsiiProperty(name: "attributeSets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AttributeSets
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_grant#authorization IdentityDomainsGrant#authorization}.</summary>
        [JsiiProperty(name: "authorization", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Authorization
        {
            get
            {
                return null;
            }
        }

        /// <summary>entitlement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_grant#entitlement IdentityDomainsGrant#entitlement}
        /// </remarks>
        [JsiiProperty(name: "entitlement", typeJson: "{\"fqn\":\"oci.identityDomainsGrant.IdentityDomainsGrantEntitlement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IdentityDomainsGrant.IIdentityDomainsGrantEntitlement? Entitlement
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_grant#granted_attribute_values_json IdentityDomainsGrant#granted_attribute_values_json}.</summary>
        [JsiiProperty(name: "grantedAttributeValuesJson", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GrantedAttributeValuesJson
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_grant#ocid IdentityDomainsGrant#ocid}.</summary>
        [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Ocid
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_grant#resource_type_schema_version IdentityDomainsGrant#resource_type_schema_version}.</summary>
        [JsiiProperty(name: "resourceTypeSchemaVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResourceTypeSchemaVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>tags block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_grant#tags IdentityDomainsGrant#tags}
        /// </remarks>
        [JsiiProperty(name: "tags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsGrant.IdentityDomainsGrantTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_grant#timeouts IdentityDomainsGrant#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.identityDomainsGrant.IdentityDomainsGrantTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IdentityDomainsGrant.IIdentityDomainsGrantTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsGrantConfig), fullyQualifiedName: "oci.identityDomainsGrant.IdentityDomainsGrantConfig")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsGrant.IIdentityDomainsGrantConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>grantee block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_grant#grantee IdentityDomainsGrant#grantee}
            /// </remarks>
            [JsiiProperty(name: "grantee", typeJson: "{\"fqn\":\"oci.identityDomainsGrant.IdentityDomainsGrantGrantee\"}")]
            public oci.IdentityDomainsGrant.IIdentityDomainsGrantGrantee Grantee
            {
                get => GetInstanceProperty<oci.IdentityDomainsGrant.IIdentityDomainsGrantGrantee>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_grant#grant_mechanism IdentityDomainsGrant#grant_mechanism}.</summary>
            [JsiiProperty(name: "grantMechanism", typeJson: "{\"primitive\":\"string\"}")]
            public string GrantMechanism
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_grant#idcs_endpoint IdentityDomainsGrant#idcs_endpoint}.</summary>
            [JsiiProperty(name: "idcsEndpoint", typeJson: "{\"primitive\":\"string\"}")]
            public string IdcsEndpoint
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_grant#schemas IdentityDomainsGrant#schemas}.</summary>
            [JsiiProperty(name: "schemas", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Schemas
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>app block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_grant#app IdentityDomainsGrant#app}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "app", typeJson: "{\"fqn\":\"oci.identityDomainsGrant.IdentityDomainsGrantApp\"}", isOptional: true)]
            public oci.IdentityDomainsGrant.IIdentityDomainsGrantApp? App
            {
                get => GetInstanceProperty<oci.IdentityDomainsGrant.IIdentityDomainsGrantApp?>();
            }

            /// <summary>app_entitlement_collection block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_grant#app_entitlement_collection IdentityDomainsGrant#app_entitlement_collection}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "appEntitlementCollection", typeJson: "{\"fqn\":\"oci.identityDomainsGrant.IdentityDomainsGrantAppEntitlementCollection\"}", isOptional: true)]
            public oci.IdentityDomainsGrant.IIdentityDomainsGrantAppEntitlementCollection? AppEntitlementCollection
            {
                get => GetInstanceProperty<oci.IdentityDomainsGrant.IIdentityDomainsGrantAppEntitlementCollection?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_grant#attributes IdentityDomainsGrant#attributes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "attributes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Attributes
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_grant#attribute_sets IdentityDomainsGrant#attribute_sets}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "attributeSets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AttributeSets
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_grant#authorization IdentityDomainsGrant#authorization}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authorization", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Authorization
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>entitlement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_grant#entitlement IdentityDomainsGrant#entitlement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "entitlement", typeJson: "{\"fqn\":\"oci.identityDomainsGrant.IdentityDomainsGrantEntitlement\"}", isOptional: true)]
            public oci.IdentityDomainsGrant.IIdentityDomainsGrantEntitlement? Entitlement
            {
                get => GetInstanceProperty<oci.IdentityDomainsGrant.IIdentityDomainsGrantEntitlement?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_grant#granted_attribute_values_json IdentityDomainsGrant#granted_attribute_values_json}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "grantedAttributeValuesJson", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GrantedAttributeValuesJson
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_grant#ocid IdentityDomainsGrant#ocid}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ocid
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_grant#resource_type_schema_version IdentityDomainsGrant#resource_type_schema_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "resourceTypeSchemaVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResourceTypeSchemaVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>tags block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_grant#tags IdentityDomainsGrant#tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsGrant.IdentityDomainsGrantTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Tags
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_grant#timeouts IdentityDomainsGrant#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.identityDomainsGrant.IdentityDomainsGrantTimeouts\"}", isOptional: true)]
            public oci.IdentityDomainsGrant.IIdentityDomainsGrantTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.IdentityDomainsGrant.IIdentityDomainsGrantTimeouts?>();
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
