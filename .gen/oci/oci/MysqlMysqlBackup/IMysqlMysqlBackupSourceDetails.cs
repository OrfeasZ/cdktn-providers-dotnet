using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlMysqlBackup
{
    [JsiiInterface(nativeType: typeof(IMysqlMysqlBackupSourceDetails), fullyQualifiedName: "oci.mysqlMysqlBackup.MysqlMysqlBackupSourceDetails")]
    public interface IMysqlMysqlBackupSourceDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_backup#backup_id MysqlMysqlBackup#backup_id}.</summary>
        [JsiiProperty(name: "backupId", typeJson: "{\"primitive\":\"string\"}")]
        string BackupId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_backup#compartment_id MysqlMysqlBackup#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        string CompartmentId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_backup#region MysqlMysqlBackup#region}.</summary>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        string Region
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMysqlMysqlBackupSourceDetails), fullyQualifiedName: "oci.mysqlMysqlBackup.MysqlMysqlBackupSourceDetails")]
        internal sealed class _Proxy : DeputyBase, oci.MysqlMysqlBackup.IMysqlMysqlBackupSourceDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_backup#backup_id MysqlMysqlBackup#backup_id}.</summary>
            [JsiiProperty(name: "backupId", typeJson: "{\"primitive\":\"string\"}")]
            public string BackupId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_backup#compartment_id MysqlMysqlBackup#compartment_id}.</summary>
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
            public string CompartmentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_backup#region MysqlMysqlBackup#region}.</summary>
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
            public string Region
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
