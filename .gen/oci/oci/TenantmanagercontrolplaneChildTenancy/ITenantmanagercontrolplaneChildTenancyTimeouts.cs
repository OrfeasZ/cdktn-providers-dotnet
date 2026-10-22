using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.TenantmanagercontrolplaneChildTenancy
{
    [JsiiInterface(nativeType: typeof(ITenantmanagercontrolplaneChildTenancyTimeouts), fullyQualifiedName: "oci.tenantmanagercontrolplaneChildTenancy.TenantmanagercontrolplaneChildTenancyTimeouts")]
    public interface ITenantmanagercontrolplaneChildTenancyTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/tenantmanagercontrolplane_child_tenancy#create TenantmanagercontrolplaneChildTenancy#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/tenantmanagercontrolplane_child_tenancy#delete TenantmanagercontrolplaneChildTenancy#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/tenantmanagercontrolplane_child_tenancy#update TenantmanagercontrolplaneChildTenancy#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ITenantmanagercontrolplaneChildTenancyTimeouts), fullyQualifiedName: "oci.tenantmanagercontrolplaneChildTenancy.TenantmanagercontrolplaneChildTenancyTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.TenantmanagercontrolplaneChildTenancy.ITenantmanagercontrolplaneChildTenancyTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/tenantmanagercontrolplane_child_tenancy#create TenantmanagercontrolplaneChildTenancy#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/tenantmanagercontrolplane_child_tenancy#delete TenantmanagercontrolplaneChildTenancy#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/tenantmanagercontrolplane_child_tenancy#update TenantmanagercontrolplaneChildTenancy#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
