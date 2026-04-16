using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEcrLifecyclePolicyDocument
{
    [JsiiInterface(nativeType: typeof(IDataAwsEcrLifecyclePolicyDocumentRuleAction), fullyQualifiedName: "aws.dataAwsEcrLifecyclePolicyDocument.DataAwsEcrLifecyclePolicyDocumentRuleAction")]
    public interface IDataAwsEcrLifecyclePolicyDocumentRuleAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/data-sources/ecr_lifecycle_policy_document#type DataAwsEcrLifecyclePolicyDocument#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/data-sources/ecr_lifecycle_policy_document#target_storage_class DataAwsEcrLifecyclePolicyDocument#target_storage_class}.</summary>
        [JsiiProperty(name: "targetStorageClass", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TargetStorageClass
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsEcrLifecyclePolicyDocumentRuleAction), fullyQualifiedName: "aws.dataAwsEcrLifecyclePolicyDocument.DataAwsEcrLifecyclePolicyDocumentRuleAction")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsEcrLifecyclePolicyDocument.IDataAwsEcrLifecyclePolicyDocumentRuleAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/data-sources/ecr_lifecycle_policy_document#type DataAwsEcrLifecyclePolicyDocument#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/data-sources/ecr_lifecycle_policy_document#target_storage_class DataAwsEcrLifecyclePolicyDocument#target_storage_class}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetStorageClass", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TargetStorageClass
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
