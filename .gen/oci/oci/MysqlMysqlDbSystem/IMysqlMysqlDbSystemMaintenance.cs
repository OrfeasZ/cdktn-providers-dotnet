using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlMysqlDbSystem
{
    [JsiiInterface(nativeType: typeof(IMysqlMysqlDbSystemMaintenance), fullyQualifiedName: "oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemMaintenance")]
    public interface IMysqlMysqlDbSystemMaintenance
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_db_system#window_start_time MysqlMysqlDbSystem#window_start_time}.</summary>
        [JsiiProperty(name: "windowStartTime", typeJson: "{\"primitive\":\"string\"}")]
        string WindowStartTime
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMysqlMysqlDbSystemMaintenance), fullyQualifiedName: "oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemMaintenance")]
        internal sealed class _Proxy : DeputyBase, oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemMaintenance
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_db_system#window_start_time MysqlMysqlDbSystem#window_start_time}.</summary>
            [JsiiProperty(name: "windowStartTime", typeJson: "{\"primitive\":\"string\"}")]
            public string WindowStartTime
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
