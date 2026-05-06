using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlMysqlBackup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.mysqlMysqlBackup.MysqlMysqlBackupEncryptData")]
    public class MysqlMysqlBackupEncryptData : oci.MysqlMysqlBackup.IMysqlMysqlBackupEncryptData
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_backup#key_generation_type MysqlMysqlBackup#key_generation_type}.</summary>
        [JsiiProperty(name: "keyGenerationType", typeJson: "{\"primitive\":\"string\"}")]
        public string KeyGenerationType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_backup#key_id MysqlMysqlBackup#key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KeyId
        {
            get;
            set;
        }
    }
}
