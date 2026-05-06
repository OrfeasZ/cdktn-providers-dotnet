using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceModel
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.datascienceModel.DatascienceModelBackupSetting")]
    public class DatascienceModelBackupSetting : oci.DatascienceModel.IDatascienceModelBackupSetting
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model#backup_region DatascienceModel#backup_region}.</summary>
        [JsiiProperty(name: "backupRegion", typeJson: "{\"primitive\":\"string\"}")]
        public string BackupRegion
        {
            get;
            set;
        }

        private object _isBackupEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model#is_backup_enabled DatascienceModel#is_backup_enabled}.</summary>
        [JsiiProperty(name: "isBackupEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public object IsBackupEnabled
        {
            get => _isBackupEnabled;
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
                _isBackupEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model#customer_notification_type DatascienceModel#customer_notification_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customerNotificationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CustomerNotificationType
        {
            get;
            set;
        }
    }
}
