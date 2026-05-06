using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlMysqlDbSystem
{
    [JsiiByValue(fqn: "oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemDeletionPolicy")]
    public class MysqlMysqlDbSystemDeletionPolicy : oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemDeletionPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_db_system#automatic_backup_retention MysqlMysqlDbSystem#automatic_backup_retention}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "automaticBackupRetention", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AutomaticBackupRetention
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_db_system#final_backup MysqlMysqlDbSystem#final_backup}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "finalBackup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FinalBackup
        {
            get;
            set;
        }

        private object? _isDeleteProtected;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_db_system#is_delete_protected MysqlMysqlDbSystem#is_delete_protected}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isDeleteProtected", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsDeleteProtected
        {
            get => _isDeleteProtected;
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
                _isDeleteProtected = value;
            }
        }
    }
}
