using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlMysqlBackup
{
    [JsiiInterface(nativeType: typeof(IMysqlMysqlBackupValidateBackupDetails), fullyQualifiedName: "oci.mysqlMysqlBackup.MysqlMysqlBackupValidateBackupDetails")]
    public interface IMysqlMysqlBackupValidateBackupDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_backup#is_prepared_backup_required MysqlMysqlBackup#is_prepared_backup_required}.</summary>
        [JsiiProperty(name: "isPreparedBackupRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object IsPreparedBackupRequired
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMysqlMysqlBackupValidateBackupDetails), fullyQualifiedName: "oci.mysqlMysqlBackup.MysqlMysqlBackupValidateBackupDetails")]
        internal sealed class _Proxy : DeputyBase, oci.MysqlMysqlBackup.IMysqlMysqlBackupValidateBackupDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_backup#is_prepared_backup_required MysqlMysqlBackup#is_prepared_backup_required}.</summary>
            [JsiiProperty(name: "isPreparedBackupRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object IsPreparedBackupRequired
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
