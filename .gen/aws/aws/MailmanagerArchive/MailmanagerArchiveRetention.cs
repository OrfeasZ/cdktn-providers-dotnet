using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MailmanagerArchive
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.mailmanagerArchive.MailmanagerArchiveRetention")]
    public class MailmanagerArchiveRetention : aws.MailmanagerArchive.IMailmanagerArchiveRetention
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_archive#retention_period MailmanagerArchive#retention_period}.</summary>
        [JsiiProperty(name: "retentionPeriod", typeJson: "{\"primitive\":\"string\"}")]
        public string RetentionPeriod
        {
            get;
            set;
        }
    }
}
