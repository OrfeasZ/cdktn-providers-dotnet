using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.PsqlBackup
{
    [JsiiInterface(nativeType: typeof(IPsqlBackupSourceBackupDetails), fullyQualifiedName: "oci.psqlBackup.PsqlBackupSourceBackupDetails")]
    public interface IPsqlBackupSourceBackupDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/psql_backup#source_backup_id PsqlBackup#source_backup_id}.</summary>
        [JsiiProperty(name: "sourceBackupId", typeJson: "{\"primitive\":\"string\"}")]
        string SourceBackupId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/psql_backup#source_region PsqlBackup#source_region}.</summary>
        [JsiiProperty(name: "sourceRegion", typeJson: "{\"primitive\":\"string\"}")]
        string SourceRegion
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPsqlBackupSourceBackupDetails), fullyQualifiedName: "oci.psqlBackup.PsqlBackupSourceBackupDetails")]
        internal sealed class _Proxy : DeputyBase, oci.PsqlBackup.IPsqlBackupSourceBackupDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/psql_backup#source_backup_id PsqlBackup#source_backup_id}.</summary>
            [JsiiProperty(name: "sourceBackupId", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceBackupId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/psql_backup#source_region PsqlBackup#source_region}.</summary>
            [JsiiProperty(name: "sourceRegion", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceRegion
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
