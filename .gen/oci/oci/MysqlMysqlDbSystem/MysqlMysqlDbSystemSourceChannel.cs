using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlMysqlDbSystem
{
    [JsiiByValue(fqn: "oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemSourceChannel")]
    public class MysqlMysqlDbSystemSourceChannel : oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemSourceChannel
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/mysql_mysql_db_system#applier_username MysqlMysqlDbSystem#applier_username}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "applierUsername", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ApplierUsername
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/mysql_mysql_db_system#source_password MysqlMysqlDbSystem#source_password}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourcePassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourcePassword
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/mysql_mysql_db_system#source_username MysqlMysqlDbSystem#source_username}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceUsername", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourceUsername
        {
            get;
            set;
        }

        /// <summary>ssl_ca_certificate block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/mysql_mysql_db_system#ssl_ca_certificate MysqlMysqlDbSystem#ssl_ca_certificate}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sslCaCertificate", typeJson: "{\"fqn\":\"oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemSourceChannelSslCaCertificate\"}", isOptional: true)]
        public oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemSourceChannelSslCaCertificate? SslCaCertificate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/mysql_mysql_db_system#ssl_mode MysqlMysqlDbSystem#ssl_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sslMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SslMode
        {
            get;
            set;
        }
    }
}
