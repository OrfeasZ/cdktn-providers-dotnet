using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlMysqlDbSystem
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemSourceChannelSslCaCertificate")]
    public class MysqlMysqlDbSystemSourceChannelSslCaCertificate : oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemSourceChannelSslCaCertificate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/mysql_mysql_db_system#certificate_type MysqlMysqlDbSystem#certificate_type}.</summary>
        [JsiiProperty(name: "certificateType", typeJson: "{\"primitive\":\"string\"}")]
        public string CertificateType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/mysql_mysql_db_system#contents MysqlMysqlDbSystem#contents}.</summary>
        [JsiiProperty(name: "contents", typeJson: "{\"primitive\":\"string\"}")]
        public string Contents
        {
            get;
            set;
        }
    }
}
