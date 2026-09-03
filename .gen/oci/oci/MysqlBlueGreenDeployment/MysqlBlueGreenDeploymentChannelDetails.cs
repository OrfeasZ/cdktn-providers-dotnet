using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlBlueGreenDeployment
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.mysqlBlueGreenDeployment.MysqlBlueGreenDeploymentChannelDetails")]
    public class MysqlBlueGreenDeploymentChannelDetails : oci.MysqlBlueGreenDeployment.IMysqlBlueGreenDeploymentChannelDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/mysql_blue_green_deployment#source_password MysqlBlueGreenDeployment#source_password}.</summary>
        [JsiiProperty(name: "sourcePassword", typeJson: "{\"primitive\":\"string\"}")]
        public string SourcePassword
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/mysql_blue_green_deployment#source_username MysqlBlueGreenDeployment#source_username}.</summary>
        [JsiiProperty(name: "sourceUsername", typeJson: "{\"primitive\":\"string\"}")]
        public string SourceUsername
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/mysql_blue_green_deployment#ssl_mode MysqlBlueGreenDeployment#ssl_mode}.</summary>
        [JsiiProperty(name: "sslMode", typeJson: "{\"primitive\":\"string\"}")]
        public string SslMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/mysql_blue_green_deployment#applier_username MysqlBlueGreenDeployment#applier_username}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "applierUsername", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ApplierUsername
        {
            get;
            set;
        }

        /// <summary>ssl_ca_certificate block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/mysql_blue_green_deployment#ssl_ca_certificate MysqlBlueGreenDeployment#ssl_ca_certificate}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sslCaCertificate", typeJson: "{\"fqn\":\"oci.mysqlBlueGreenDeployment.MysqlBlueGreenDeploymentChannelDetailsSslCaCertificate\"}", isOptional: true)]
        public oci.MysqlBlueGreenDeployment.IMysqlBlueGreenDeploymentChannelDetailsSslCaCertificate? SslCaCertificate
        {
            get;
            set;
        }
    }
}
