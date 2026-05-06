using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceModel
{
    [JsiiInterface(nativeType: typeof(IDatascienceModelBackupSetting), fullyQualifiedName: "oci.datascienceModel.DatascienceModelBackupSetting")]
    public interface IDatascienceModelBackupSetting
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model#backup_region DatascienceModel#backup_region}.</summary>
        [JsiiProperty(name: "backupRegion", typeJson: "{\"primitive\":\"string\"}")]
        string BackupRegion
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model#is_backup_enabled DatascienceModel#is_backup_enabled}.</summary>
        [JsiiProperty(name: "isBackupEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object IsBackupEnabled
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model#customer_notification_type DatascienceModel#customer_notification_type}.</summary>
        [JsiiProperty(name: "customerNotificationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CustomerNotificationType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatascienceModelBackupSetting), fullyQualifiedName: "oci.datascienceModel.DatascienceModelBackupSetting")]
        internal sealed class _Proxy : DeputyBase, oci.DatascienceModel.IDatascienceModelBackupSetting
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model#backup_region DatascienceModel#backup_region}.</summary>
            [JsiiProperty(name: "backupRegion", typeJson: "{\"primitive\":\"string\"}")]
            public string BackupRegion
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model#is_backup_enabled DatascienceModel#is_backup_enabled}.</summary>
            [JsiiProperty(name: "isBackupEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object IsBackupEnabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model#customer_notification_type DatascienceModel#customer_notification_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "customerNotificationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CustomerNotificationType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
