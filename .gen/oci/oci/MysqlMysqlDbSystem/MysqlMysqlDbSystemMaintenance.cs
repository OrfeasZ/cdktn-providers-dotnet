using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlMysqlDbSystem
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemMaintenance")]
    public class MysqlMysqlDbSystemMaintenance : oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemMaintenance
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_db_system#window_start_time MysqlMysqlDbSystem#window_start_time}.</summary>
        [JsiiProperty(name: "windowStartTime", typeJson: "{\"primitive\":\"string\"}")]
        public string WindowStartTime
        {
            get;
            set;
        }
    }
}
