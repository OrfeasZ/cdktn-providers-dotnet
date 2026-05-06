using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceModel
{
    [JsiiInterface(nativeType: typeof(IDatascienceModelRetentionSetting), fullyQualifiedName: "oci.datascienceModel.DatascienceModelRetentionSetting")]
    public interface IDatascienceModelRetentionSetting
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model#archive_after_days DatascienceModel#archive_after_days}.</summary>
        [JsiiProperty(name: "archiveAfterDays", typeJson: "{\"primitive\":\"number\"}")]
        double ArchiveAfterDays
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model#delete_after_days DatascienceModel#delete_after_days}.</summary>
        [JsiiProperty(name: "deleteAfterDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DeleteAfterDays
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatascienceModelRetentionSetting), fullyQualifiedName: "oci.datascienceModel.DatascienceModelRetentionSetting")]
        internal sealed class _Proxy : DeputyBase, oci.DatascienceModel.IDatascienceModelRetentionSetting
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model#archive_after_days DatascienceModel#archive_after_days}.</summary>
            [JsiiProperty(name: "archiveAfterDays", typeJson: "{\"primitive\":\"number\"}")]
            public double ArchiveAfterDays
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model#customer_notification_type DatascienceModel#customer_notification_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "customerNotificationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CustomerNotificationType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model#delete_after_days DatascienceModel#delete_after_days}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deleteAfterDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DeleteAfterDays
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
