using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.TenantmanagercontrolplaneChildTenancy
{
    [JsiiInterface(nativeType: typeof(ITenantmanagercontrolplaneChildTenancyConfig), fullyQualifiedName: "oci.tenantmanagercontrolplaneChildTenancy.TenantmanagercontrolplaneChildTenancyConfig")]
    public interface ITenantmanagercontrolplaneChildTenancyConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/tenantmanagercontrolplane_child_tenancy#admin_email TenantmanagercontrolplaneChildTenancy#admin_email}.</summary>
        [JsiiProperty(name: "adminEmail", typeJson: "{\"primitive\":\"string\"}")]
        string AdminEmail
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/tenantmanagercontrolplane_child_tenancy#compartment_id TenantmanagercontrolplaneChildTenancy#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        string CompartmentId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/tenantmanagercontrolplane_child_tenancy#home_region TenantmanagercontrolplaneChildTenancy#home_region}.</summary>
        [JsiiProperty(name: "homeRegion", typeJson: "{\"primitive\":\"string\"}")]
        string HomeRegion
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/tenantmanagercontrolplane_child_tenancy#tenancy_name TenantmanagercontrolplaneChildTenancy#tenancy_name}.</summary>
        [JsiiProperty(name: "tenancyName", typeJson: "{\"primitive\":\"string\"}")]
        string TenancyName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/tenantmanagercontrolplane_child_tenancy#features TenantmanagercontrolplaneChildTenancy#features}.</summary>
        [JsiiProperty(name: "features", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Features
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/tenantmanagercontrolplane_child_tenancy#governance_status TenantmanagercontrolplaneChildTenancy#governance_status}.</summary>
        [JsiiProperty(name: "governanceStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GovernanceStatus
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/tenantmanagercontrolplane_child_tenancy#id TenantmanagercontrolplaneChildTenancy#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/tenantmanagercontrolplane_child_tenancy#policy_name TenantmanagercontrolplaneChildTenancy#policy_name}.</summary>
        [JsiiProperty(name: "policyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PolicyName
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/tenantmanagercontrolplane_child_tenancy#timeouts TenantmanagercontrolplaneChildTenancy#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.tenantmanagercontrolplaneChildTenancy.TenantmanagercontrolplaneChildTenancyTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.TenantmanagercontrolplaneChildTenancy.ITenantmanagercontrolplaneChildTenancyTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ITenantmanagercontrolplaneChildTenancyConfig), fullyQualifiedName: "oci.tenantmanagercontrolplaneChildTenancy.TenantmanagercontrolplaneChildTenancyConfig")]
        internal sealed class _Proxy : DeputyBase, oci.TenantmanagercontrolplaneChildTenancy.ITenantmanagercontrolplaneChildTenancyConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/tenantmanagercontrolplane_child_tenancy#admin_email TenantmanagercontrolplaneChildTenancy#admin_email}.</summary>
            [JsiiProperty(name: "adminEmail", typeJson: "{\"primitive\":\"string\"}")]
            public string AdminEmail
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/tenantmanagercontrolplane_child_tenancy#compartment_id TenantmanagercontrolplaneChildTenancy#compartment_id}.</summary>
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
            public string CompartmentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/tenantmanagercontrolplane_child_tenancy#home_region TenantmanagercontrolplaneChildTenancy#home_region}.</summary>
            [JsiiProperty(name: "homeRegion", typeJson: "{\"primitive\":\"string\"}")]
            public string HomeRegion
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/tenantmanagercontrolplane_child_tenancy#tenancy_name TenantmanagercontrolplaneChildTenancy#tenancy_name}.</summary>
            [JsiiProperty(name: "tenancyName", typeJson: "{\"primitive\":\"string\"}")]
            public string TenancyName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/tenantmanagercontrolplane_child_tenancy#features TenantmanagercontrolplaneChildTenancy#features}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "features", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Features
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/tenantmanagercontrolplane_child_tenancy#governance_status TenantmanagercontrolplaneChildTenancy#governance_status}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "governanceStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GovernanceStatus
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/tenantmanagercontrolplane_child_tenancy#id TenantmanagercontrolplaneChildTenancy#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/tenantmanagercontrolplane_child_tenancy#policy_name TenantmanagercontrolplaneChildTenancy#policy_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "policyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PolicyName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/tenantmanagercontrolplane_child_tenancy#timeouts TenantmanagercontrolplaneChildTenancy#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.tenantmanagercontrolplaneChildTenancy.TenantmanagercontrolplaneChildTenancyTimeouts\"}", isOptional: true)]
            public oci.TenantmanagercontrolplaneChildTenancy.ITenantmanagercontrolplaneChildTenancyTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.TenantmanagercontrolplaneChildTenancy.ITenantmanagercontrolplaneChildTenancyTimeouts?>();
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
