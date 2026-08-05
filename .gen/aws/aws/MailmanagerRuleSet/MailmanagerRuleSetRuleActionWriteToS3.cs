using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MailmanagerRuleSet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.mailmanagerRuleSet.MailmanagerRuleSetRuleActionWriteToS3")]
    public class MailmanagerRuleSetRuleActionWriteToS3 : aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleActionWriteToS3
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/mailmanager_rule_set#role_arn MailmanagerRuleSet#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public string RoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/mailmanager_rule_set#s3_bucket MailmanagerRuleSet#s3_bucket}.</summary>
        [JsiiProperty(name: "s3Bucket", typeJson: "{\"primitive\":\"string\"}")]
        public string S3Bucket
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/mailmanager_rule_set#action_failure_policy MailmanagerRuleSet#action_failure_policy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "actionFailurePolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ActionFailurePolicy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/mailmanager_rule_set#s3_prefix MailmanagerRuleSet#s3_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "s3Prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? S3Prefix
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/mailmanager_rule_set#s3_sse_kms_key_id MailmanagerRuleSet#s3_sse_kms_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "s3SseKmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? S3SseKmsKeyId
        {
            get;
            set;
        }
    }
}
