using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlMysqlDbSystem
{
    [JsiiInterface(nativeType: typeof(IMysqlMysqlDbSystemDataStorage), fullyQualifiedName: "oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemDataStorage")]
    public interface IMysqlMysqlDbSystemDataStorage
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_db_system#is_auto_expand_storage_enabled MysqlMysqlDbSystem#is_auto_expand_storage_enabled}.</summary>
        [JsiiProperty(name: "isAutoExpandStorageEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsAutoExpandStorageEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_db_system#max_storage_size_in_gbs MysqlMysqlDbSystem#max_storage_size_in_gbs}.</summary>
        [JsiiProperty(name: "maxStorageSizeInGbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxStorageSizeInGbs
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMysqlMysqlDbSystemDataStorage), fullyQualifiedName: "oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemDataStorage")]
        internal sealed class _Proxy : DeputyBase, oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemDataStorage
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_db_system#is_auto_expand_storage_enabled MysqlMysqlDbSystem#is_auto_expand_storage_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isAutoExpandStorageEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsAutoExpandStorageEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_db_system#max_storage_size_in_gbs MysqlMysqlDbSystem#max_storage_size_in_gbs}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxStorageSizeInGbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxStorageSizeInGbs
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
