using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlMysqlDbSystem
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemBackupPolicyCopyPolicies")]
    public class MysqlMysqlDbSystemBackupPolicyCopyPolicies : oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemBackupPolicyCopyPolicies
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_db_system#copy_to_region MysqlMysqlDbSystem#copy_to_region}.</summary>
        [JsiiProperty(name: "copyToRegion", typeJson: "{\"primitive\":\"string\"}")]
        public string CopyToRegion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_db_system#backup_copy_retention_in_days MysqlMysqlDbSystem#backup_copy_retention_in_days}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "backupCopyRetentionInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BackupCopyRetentionInDays
        {
            get;
            set;
        }
    }
}
