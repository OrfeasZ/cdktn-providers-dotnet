using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlMysqlDbSystem
{
    [JsiiInterface(nativeType: typeof(IMysqlMysqlDbSystemDeletionPolicy), fullyQualifiedName: "oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemDeletionPolicy")]
    public interface IMysqlMysqlDbSystemDeletionPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_db_system#automatic_backup_retention MysqlMysqlDbSystem#automatic_backup_retention}.</summary>
        [JsiiProperty(name: "automaticBackupRetention", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AutomaticBackupRetention
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_db_system#final_backup MysqlMysqlDbSystem#final_backup}.</summary>
        [JsiiProperty(name: "finalBackup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FinalBackup
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_db_system#is_delete_protected MysqlMysqlDbSystem#is_delete_protected}.</summary>
        [JsiiProperty(name: "isDeleteProtected", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsDeleteProtected
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMysqlMysqlDbSystemDeletionPolicy), fullyQualifiedName: "oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemDeletionPolicy")]
        internal sealed class _Proxy : DeputyBase, oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemDeletionPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_db_system#automatic_backup_retention MysqlMysqlDbSystem#automatic_backup_retention}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "automaticBackupRetention", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AutomaticBackupRetention
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_db_system#final_backup MysqlMysqlDbSystem#final_backup}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "finalBackup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FinalBackup
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_db_system#is_delete_protected MysqlMysqlDbSystem#is_delete_protected}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isDeleteProtected", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsDeleteProtected
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
