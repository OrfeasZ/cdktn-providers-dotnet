using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlMysqlConfiguration
{
    [JsiiByValue(fqn: "oci.mysqlMysqlConfiguration.MysqlMysqlConfigurationInitVariables")]
    public class MysqlMysqlConfigurationInitVariables : oci.MysqlMysqlConfiguration.IMysqlMysqlConfigurationInitVariables
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#lower_case_table_names MysqlMysqlConfiguration#lower_case_table_names}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lowerCaseTableNames", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LowerCaseTableNames
        {
            get;
            set;
        }
    }
}
