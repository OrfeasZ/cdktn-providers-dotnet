using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.TenantmanagercontrolplaneChildTenancy
{
    [JsiiByValue(fqn: "oci.tenantmanagercontrolplaneChildTenancy.TenantmanagercontrolplaneChildTenancyTimeouts")]
    public class TenantmanagercontrolplaneChildTenancyTimeouts : oci.TenantmanagercontrolplaneChildTenancy.ITenantmanagercontrolplaneChildTenancyTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/tenantmanagercontrolplane_child_tenancy#create TenantmanagercontrolplaneChildTenancy#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/tenantmanagercontrolplane_child_tenancy#delete TenantmanagercontrolplaneChildTenancy#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/tenantmanagercontrolplane_child_tenancy#update TenantmanagercontrolplaneChildTenancy#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
