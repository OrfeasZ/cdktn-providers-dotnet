using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DatabaseCluster
{
    [JsiiInterface(nativeType: typeof(IDatabaseClusterBackupRestore), fullyQualifiedName: "digitalocean.databaseCluster.DatabaseClusterBackupRestore")]
    public interface IDatabaseClusterBackupRestore
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_cluster#database_name DatabaseCluster#database_name}.</summary>
        [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}")]
        string DatabaseName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_cluster#backup_created_at DatabaseCluster#backup_created_at}.</summary>
        [JsiiProperty(name: "backupCreatedAt", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BackupCreatedAt
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseClusterBackupRestore), fullyQualifiedName: "digitalocean.databaseCluster.DatabaseClusterBackupRestore")]
        internal sealed class _Proxy : DeputyBase, digitalocean.DatabaseCluster.IDatabaseClusterBackupRestore
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_cluster#database_name DatabaseCluster#database_name}.</summary>
            [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}")]
            public string DatabaseName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_cluster#backup_created_at DatabaseCluster#backup_created_at}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "backupCreatedAt", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BackupCreatedAt
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
