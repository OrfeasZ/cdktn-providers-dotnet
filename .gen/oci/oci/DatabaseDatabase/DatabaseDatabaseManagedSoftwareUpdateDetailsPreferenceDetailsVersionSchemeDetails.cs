using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseDatabase
{
    [JsiiByValue(fqn: "oci.databaseDatabase.DatabaseDatabaseManagedSoftwareUpdateDetailsPreferenceDetailsVersionSchemeDetails")]
    public class DatabaseDatabaseManagedSoftwareUpdateDetailsPreferenceDetailsVersionSchemeDetails : oci.DatabaseDatabase.IDatabaseDatabaseManagedSoftwareUpdateDetailsPreferenceDetailsVersionSchemeDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/database_database#major_version DatabaseDatabase#major_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "majorVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MajorVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/database_database#source DatabaseDatabase#source}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Source
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/database_database#version_preference DatabaseDatabase#version_preference}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "versionPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VersionPreference
        {
            get;
            set;
        }
    }
}
