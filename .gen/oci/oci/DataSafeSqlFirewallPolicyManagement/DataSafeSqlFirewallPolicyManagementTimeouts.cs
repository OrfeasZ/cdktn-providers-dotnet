using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeSqlFirewallPolicyManagement
{
    [JsiiByValue(fqn: "oci.dataSafeSqlFirewallPolicyManagement.DataSafeSqlFirewallPolicyManagementTimeouts")]
    public class DataSafeSqlFirewallPolicyManagementTimeouts : oci.DataSafeSqlFirewallPolicyManagement.IDataSafeSqlFirewallPolicyManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sql_firewall_policy_management#create DataSafeSqlFirewallPolicyManagement#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sql_firewall_policy_management#delete DataSafeSqlFirewallPolicyManagement#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sql_firewall_policy_management#update DataSafeSqlFirewallPolicyManagement#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
