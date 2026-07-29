using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlMysqlConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.mysqlMysqlConfiguration.MysqlMysqlConfigurationOptions")]
    public class MysqlMysqlConfigurationOptions : oci.MysqlMysqlConfiguration.IMysqlMysqlConfigurationOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/mysql_mysql_configuration#name MysqlMysqlConfiguration#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/mysql_mysql_configuration#value MysqlMysqlConfiguration#value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Value
        {
            get;
            set;
        }
    }
}
