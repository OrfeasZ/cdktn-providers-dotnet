using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsoadminCustomerManagedPolicyAttachmentsExclusive
{
    [JsiiInterface(nativeType: typeof(ISsoadminCustomerManagedPolicyAttachmentsExclusiveCustomerManagedPolicyReference), fullyQualifiedName: "aws.ssoadminCustomerManagedPolicyAttachmentsExclusive.SsoadminCustomerManagedPolicyAttachmentsExclusiveCustomerManagedPolicyReference")]
    public interface ISsoadminCustomerManagedPolicyAttachmentsExclusiveCustomerManagedPolicyReference
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ssoadmin_customer_managed_policy_attachments_exclusive#name SsoadminCustomerManagedPolicyAttachmentsExclusive#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ssoadmin_customer_managed_policy_attachments_exclusive#path SsoadminCustomerManagedPolicyAttachmentsExclusive#path}.</summary>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Path
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISsoadminCustomerManagedPolicyAttachmentsExclusiveCustomerManagedPolicyReference), fullyQualifiedName: "aws.ssoadminCustomerManagedPolicyAttachmentsExclusive.SsoadminCustomerManagedPolicyAttachmentsExclusiveCustomerManagedPolicyReference")]
        internal sealed class _Proxy : DeputyBase, aws.SsoadminCustomerManagedPolicyAttachmentsExclusive.ISsoadminCustomerManagedPolicyAttachmentsExclusiveCustomerManagedPolicyReference
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ssoadmin_customer_managed_policy_attachments_exclusive#name SsoadminCustomerManagedPolicyAttachmentsExclusive#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ssoadmin_customer_managed_policy_attachments_exclusive#path SsoadminCustomerManagedPolicyAttachmentsExclusive#path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Path
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
