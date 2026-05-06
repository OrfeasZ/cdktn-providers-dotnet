using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlMysqlBackup
{
    [JsiiInterface(nativeType: typeof(IMysqlMysqlBackupEncryptData), fullyQualifiedName: "oci.mysqlMysqlBackup.MysqlMysqlBackupEncryptData")]
    public interface IMysqlMysqlBackupEncryptData
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_backup#key_generation_type MysqlMysqlBackup#key_generation_type}.</summary>
        [JsiiProperty(name: "keyGenerationType", typeJson: "{\"primitive\":\"string\"}")]
        string KeyGenerationType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_backup#key_id MysqlMysqlBackup#key_id}.</summary>
        [JsiiProperty(name: "keyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KeyId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMysqlMysqlBackupEncryptData), fullyQualifiedName: "oci.mysqlMysqlBackup.MysqlMysqlBackupEncryptData")]
        internal sealed class _Proxy : DeputyBase, oci.MysqlMysqlBackup.IMysqlMysqlBackupEncryptData
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_backup#key_generation_type MysqlMysqlBackup#key_generation_type}.</summary>
            [JsiiProperty(name: "keyGenerationType", typeJson: "{\"primitive\":\"string\"}")]
            public string KeyGenerationType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_backup#key_id MysqlMysqlBackup#key_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "keyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KeyId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
