using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlMysqlBackup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.mysqlMysqlBackup.MysqlMysqlBackupValidateBackupDetails")]
    public class MysqlMysqlBackupValidateBackupDetails : oci.MysqlMysqlBackup.IMysqlMysqlBackupValidateBackupDetails
    {
        private object _isPreparedBackupRequired;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_backup#is_prepared_backup_required MysqlMysqlBackup#is_prepared_backup_required}.</summary>
        [JsiiProperty(name: "isPreparedBackupRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public object IsPreparedBackupRequired
        {
            get => _isPreparedBackupRequired;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isPreparedBackupRequired = value;
            }
        }
    }
}
