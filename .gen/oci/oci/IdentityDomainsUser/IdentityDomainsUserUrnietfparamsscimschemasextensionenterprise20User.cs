using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsUser
{
    [JsiiByValue(fqn: "oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasextensionenterprise20User")]
    public class IdentityDomainsUserUrnietfparamsscimschemasextensionenterprise20User : oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasextensionenterprise20User
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#cost_center IdentityDomainsUser#cost_center}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "costCenter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CostCenter
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#department IdentityDomainsUser#department}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "department", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Department
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#division IdentityDomainsUser#division}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "division", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Division
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#employee_number IdentityDomainsUser#employee_number}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "employeeNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EmployeeNumber
        {
            get;
            set;
        }

        /// <summary>manager block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#manager IdentityDomainsUser#manager}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "manager", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasextensionenterprise20UserManager\"}", isOptional: true)]
        public oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasextensionenterprise20UserManager? Manager
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#organization IdentityDomainsUser#organization}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "organization", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Organization
        {
            get;
            set;
        }
    }
}
