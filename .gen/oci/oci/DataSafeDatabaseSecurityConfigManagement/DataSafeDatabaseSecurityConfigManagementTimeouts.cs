using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeDatabaseSecurityConfigManagement
{
    [JsiiByValue(fqn: "oci.dataSafeDatabaseSecurityConfigManagement.DataSafeDatabaseSecurityConfigManagementTimeouts")]
    public class DataSafeDatabaseSecurityConfigManagementTimeouts : oci.DataSafeDatabaseSecurityConfigManagement.IDataSafeDatabaseSecurityConfigManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_database_security_config_management#create DataSafeDatabaseSecurityConfigManagement#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_database_security_config_management#delete DataSafeDatabaseSecurityConfigManagement#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_database_security_config_management#update DataSafeDatabaseSecurityConfigManagement#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
