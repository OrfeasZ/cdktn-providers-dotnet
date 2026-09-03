using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MailmanagerArchive
{
    [JsiiInterface(nativeType: typeof(IMailmanagerArchiveRetention), fullyQualifiedName: "aws.mailmanagerArchive.MailmanagerArchiveRetention")]
    public interface IMailmanagerArchiveRetention
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_archive#retention_period MailmanagerArchive#retention_period}.</summary>
        [JsiiProperty(name: "retentionPeriod", typeJson: "{\"primitive\":\"string\"}")]
        string RetentionPeriod
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMailmanagerArchiveRetention), fullyQualifiedName: "aws.mailmanagerArchive.MailmanagerArchiveRetention")]
        internal sealed class _Proxy : DeputyBase, aws.MailmanagerArchive.IMailmanagerArchiveRetention
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_archive#retention_period MailmanagerArchive#retention_period}.</summary>
            [JsiiProperty(name: "retentionPeriod", typeJson: "{\"primitive\":\"string\"}")]
            public string RetentionPeriod
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
