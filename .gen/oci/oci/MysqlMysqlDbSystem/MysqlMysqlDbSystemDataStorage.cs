using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlMysqlDbSystem
{
    [JsiiByValue(fqn: "oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemDataStorage")]
    public class MysqlMysqlDbSystemDataStorage : oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemDataStorage
    {
        private object? _isAutoExpandStorageEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_db_system#is_auto_expand_storage_enabled MysqlMysqlDbSystem#is_auto_expand_storage_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isAutoExpandStorageEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsAutoExpandStorageEnabled
        {
            get => _isAutoExpandStorageEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isAutoExpandStorageEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_db_system#max_storage_size_in_gbs MysqlMysqlDbSystem#max_storage_size_in_gbs}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxStorageSizeInGbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxStorageSizeInGbs
        {
            get;
            set;
        }
    }
}
