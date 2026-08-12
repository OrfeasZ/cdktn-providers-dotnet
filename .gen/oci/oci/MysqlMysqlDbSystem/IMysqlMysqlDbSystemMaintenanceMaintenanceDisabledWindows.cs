using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlMysqlDbSystem
{
    [JsiiInterface(nativeType: typeof(IMysqlMysqlDbSystemMaintenanceMaintenanceDisabledWindows), fullyQualifiedName: "oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemMaintenanceMaintenanceDisabledWindows")]
    public interface IMysqlMysqlDbSystemMaintenanceMaintenanceDisabledWindows
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/mysql_mysql_db_system#time_end MysqlMysqlDbSystem#time_end}.</summary>
        [JsiiProperty(name: "timeEnd", typeJson: "{\"primitive\":\"string\"}")]
        string TimeEnd
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/mysql_mysql_db_system#time_start MysqlMysqlDbSystem#time_start}.</summary>
        [JsiiProperty(name: "timeStart", typeJson: "{\"primitive\":\"string\"}")]
        string TimeStart
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMysqlMysqlDbSystemMaintenanceMaintenanceDisabledWindows), fullyQualifiedName: "oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemMaintenanceMaintenanceDisabledWindows")]
        internal sealed class _Proxy : DeputyBase, oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemMaintenanceMaintenanceDisabledWindows
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/mysql_mysql_db_system#time_end MysqlMysqlDbSystem#time_end}.</summary>
            [JsiiProperty(name: "timeEnd", typeJson: "{\"primitive\":\"string\"}")]
            public string TimeEnd
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/mysql_mysql_db_system#time_start MysqlMysqlDbSystem#time_start}.</summary>
            [JsiiProperty(name: "timeStart", typeJson: "{\"primitive\":\"string\"}")]
            public string TimeStart
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
