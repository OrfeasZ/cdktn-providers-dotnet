using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseToolsDatabaseToolsIdentity
{
    [JsiiByValue(fqn: "oci.databaseToolsDatabaseToolsIdentity.DatabaseToolsDatabaseToolsIdentityTimeouts")]
    public class DatabaseToolsDatabaseToolsIdentityTimeouts : oci.DatabaseToolsDatabaseToolsIdentity.IDatabaseToolsDatabaseToolsIdentityTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/database_tools_database_tools_identity#create DatabaseToolsDatabaseToolsIdentity#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/database_tools_database_tools_identity#delete DatabaseToolsDatabaseToolsIdentity#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/database_tools_database_tools_identity#update DatabaseToolsDatabaseToolsIdentity#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
