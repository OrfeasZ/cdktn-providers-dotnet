using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsoadminCustomerManagedPolicyAttachmentsExclusive
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ssoadminCustomerManagedPolicyAttachmentsExclusive.SsoadminCustomerManagedPolicyAttachmentsExclusiveCustomerManagedPolicyReference")]
    public class SsoadminCustomerManagedPolicyAttachmentsExclusiveCustomerManagedPolicyReference : aws.SsoadminCustomerManagedPolicyAttachmentsExclusive.ISsoadminCustomerManagedPolicyAttachmentsExclusiveCustomerManagedPolicyReference
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ssoadmin_customer_managed_policy_attachments_exclusive#name SsoadminCustomerManagedPolicyAttachmentsExclusive#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ssoadmin_customer_managed_policy_attachments_exclusive#path SsoadminCustomerManagedPolicyAttachmentsExclusive#path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Path
        {
            get;
            set;
        }
    }
}
