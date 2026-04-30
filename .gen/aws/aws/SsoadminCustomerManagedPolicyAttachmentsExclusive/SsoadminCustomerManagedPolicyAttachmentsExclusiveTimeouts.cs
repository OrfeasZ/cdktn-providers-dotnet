using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsoadminCustomerManagedPolicyAttachmentsExclusive
{
    [JsiiByValue(fqn: "aws.ssoadminCustomerManagedPolicyAttachmentsExclusive.SsoadminCustomerManagedPolicyAttachmentsExclusiveTimeouts")]
    public class SsoadminCustomerManagedPolicyAttachmentsExclusiveTimeouts : aws.SsoadminCustomerManagedPolicyAttachmentsExclusive.ISsoadminCustomerManagedPolicyAttachmentsExclusiveTimeouts
    {
        /// <summary>A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as "30s" or "2h45m". Valid time units are "s" (seconds), "m" (minutes), "h" (hours).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ssoadmin_customer_managed_policy_attachments_exclusive#create SsoadminCustomerManagedPolicyAttachmentsExclusive#create}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as "30s" or "2h45m". Valid time units are "s" (seconds), "m" (minutes), "h" (hours).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ssoadmin_customer_managed_policy_attachments_exclusive#update SsoadminCustomerManagedPolicyAttachmentsExclusive#update}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
