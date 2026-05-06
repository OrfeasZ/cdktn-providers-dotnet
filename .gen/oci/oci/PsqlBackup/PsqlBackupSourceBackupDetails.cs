using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.PsqlBackup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.psqlBackup.PsqlBackupSourceBackupDetails")]
    public class PsqlBackupSourceBackupDetails : oci.PsqlBackup.IPsqlBackupSourceBackupDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/psql_backup#source_backup_id PsqlBackup#source_backup_id}.</summary>
        [JsiiProperty(name: "sourceBackupId", typeJson: "{\"primitive\":\"string\"}")]
        public string SourceBackupId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/psql_backup#source_region PsqlBackup#source_region}.</summary>
        [JsiiProperty(name: "sourceRegion", typeJson: "{\"primitive\":\"string\"}")]
        public string SourceRegion
        {
            get;
            set;
        }
    }
}
