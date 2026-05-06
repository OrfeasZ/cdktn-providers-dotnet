using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlMysqlDbSystem
{
    [JsiiInterface(nativeType: typeof(IMysqlMysqlDbSystemBackupPolicyCopyPolicies), fullyQualifiedName: "oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemBackupPolicyCopyPolicies")]
    public interface IMysqlMysqlDbSystemBackupPolicyCopyPolicies
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_db_system#copy_to_region MysqlMysqlDbSystem#copy_to_region}.</summary>
        [JsiiProperty(name: "copyToRegion", typeJson: "{\"primitive\":\"string\"}")]
        string CopyToRegion
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_db_system#backup_copy_retention_in_days MysqlMysqlDbSystem#backup_copy_retention_in_days}.</summary>
        [JsiiProperty(name: "backupCopyRetentionInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BackupCopyRetentionInDays
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMysqlMysqlDbSystemBackupPolicyCopyPolicies), fullyQualifiedName: "oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemBackupPolicyCopyPolicies")]
        internal sealed class _Proxy : DeputyBase, oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemBackupPolicyCopyPolicies
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_db_system#copy_to_region MysqlMysqlDbSystem#copy_to_region}.</summary>
            [JsiiProperty(name: "copyToRegion", typeJson: "{\"primitive\":\"string\"}")]
            public string CopyToRegion
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_db_system#backup_copy_retention_in_days MysqlMysqlDbSystem#backup_copy_retention_in_days}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "backupCopyRetentionInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BackupCopyRetentionInDays
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
