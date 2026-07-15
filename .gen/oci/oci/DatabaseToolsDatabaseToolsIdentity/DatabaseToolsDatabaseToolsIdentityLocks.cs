using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseToolsDatabaseToolsIdentity
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.databaseToolsDatabaseToolsIdentity.DatabaseToolsDatabaseToolsIdentityLocks")]
    public class DatabaseToolsDatabaseToolsIdentityLocks : oci.DatabaseToolsDatabaseToolsIdentity.IDatabaseToolsDatabaseToolsIdentityLocks
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/database_tools_database_tools_identity#type DatabaseToolsDatabaseToolsIdentity#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/database_tools_database_tools_identity#message DatabaseToolsDatabaseToolsIdentity#message}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "message", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Message
        {
            get;
            set;
        }
    }
}
