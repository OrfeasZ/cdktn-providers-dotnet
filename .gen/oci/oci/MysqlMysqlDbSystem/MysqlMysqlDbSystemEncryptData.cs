using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlMysqlDbSystem
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemEncryptData")]
    public class MysqlMysqlDbSystemEncryptData : oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemEncryptData
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_db_system#key_generation_type MysqlMysqlDbSystem#key_generation_type}.</summary>
        [JsiiProperty(name: "keyGenerationType", typeJson: "{\"primitive\":\"string\"}")]
        public string KeyGenerationType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_db_system#key_id MysqlMysqlDbSystem#key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KeyId
        {
            get;
            set;
        }
    }
}
