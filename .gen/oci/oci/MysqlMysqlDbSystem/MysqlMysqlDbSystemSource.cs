using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlMysqlDbSystem
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemSource")]
    public class MysqlMysqlDbSystemSource : oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/mysql_mysql_db_system#source_type MysqlMysqlDbSystem#source_type}.</summary>
        [JsiiProperty(name: "sourceType", typeJson: "{\"primitive\":\"string\"}")]
        public string SourceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/mysql_mysql_db_system#backup_id MysqlMysqlDbSystem#backup_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "backupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BackupId
        {
            get;
            set;
        }

        /// <summary>channel block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/mysql_mysql_db_system#channel MysqlMysqlDbSystem#channel}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "channel", typeJson: "{\"fqn\":\"oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemSourceChannel\"}", isOptional: true)]
        public oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemSourceChannel? Channel
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/mysql_mysql_db_system#db_system_id MysqlMysqlDbSystem#db_system_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dbSystemId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DbSystemId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/mysql_mysql_db_system#recovery_point MysqlMysqlDbSystem#recovery_point}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "recoveryPoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RecoveryPoint
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/mysql_mysql_db_system#region MysqlMysqlDbSystem#region}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Region
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/mysql_mysql_db_system#source_url MysqlMysqlDbSystem#source_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourceUrl
        {
            get;
            set;
        }
    }
}
