using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlMysqlDbSystem
{
    [JsiiInterface(nativeType: typeof(IMysqlMysqlDbSystemCustomerContacts), fullyQualifiedName: "oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemCustomerContacts")]
    public interface IMysqlMysqlDbSystemCustomerContacts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_db_system#email MysqlMysqlDbSystem#email}.</summary>
        [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}")]
        string Email
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMysqlMysqlDbSystemCustomerContacts), fullyQualifiedName: "oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemCustomerContacts")]
        internal sealed class _Proxy : DeputyBase, oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemCustomerContacts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_db_system#email MysqlMysqlDbSystem#email}.</summary>
            [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}")]
            public string Email
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
