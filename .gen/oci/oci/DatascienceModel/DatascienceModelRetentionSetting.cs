using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceModel
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.datascienceModel.DatascienceModelRetentionSetting")]
    public class DatascienceModelRetentionSetting : oci.DatascienceModel.IDatascienceModelRetentionSetting
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model#archive_after_days DatascienceModel#archive_after_days}.</summary>
        [JsiiProperty(name: "archiveAfterDays", typeJson: "{\"primitive\":\"number\"}")]
        public double ArchiveAfterDays
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model#customer_notification_type DatascienceModel#customer_notification_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customerNotificationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CustomerNotificationType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model#delete_after_days DatascienceModel#delete_after_days}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deleteAfterDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DeleteAfterDays
        {
            get;
            set;
        }
    }
}
