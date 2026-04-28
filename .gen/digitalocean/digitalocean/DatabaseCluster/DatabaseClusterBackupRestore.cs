using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DatabaseCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "digitalocean.databaseCluster.DatabaseClusterBackupRestore")]
    public class DatabaseClusterBackupRestore : digitalocean.DatabaseCluster.IDatabaseClusterBackupRestore
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_cluster#database_name DatabaseCluster#database_name}.</summary>
        [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}")]
        public string DatabaseName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_cluster#backup_created_at DatabaseCluster#backup_created_at}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "backupCreatedAt", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BackupCreatedAt
        {
            get;
            set;
        }
    }
}
