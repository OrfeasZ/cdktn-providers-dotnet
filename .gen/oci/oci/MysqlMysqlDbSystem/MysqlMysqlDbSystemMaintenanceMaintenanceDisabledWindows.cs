using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlMysqlDbSystem
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemMaintenanceMaintenanceDisabledWindows")]
    public class MysqlMysqlDbSystemMaintenanceMaintenanceDisabledWindows : oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemMaintenanceMaintenanceDisabledWindows
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/mysql_mysql_db_system#time_end MysqlMysqlDbSystem#time_end}.</summary>
        [JsiiProperty(name: "timeEnd", typeJson: "{\"primitive\":\"string\"}")]
        public string TimeEnd
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/mysql_mysql_db_system#time_start MysqlMysqlDbSystem#time_start}.</summary>
        [JsiiProperty(name: "timeStart", typeJson: "{\"primitive\":\"string\"}")]
        public string TimeStart
        {
            get;
            set;
        }
    }
}
