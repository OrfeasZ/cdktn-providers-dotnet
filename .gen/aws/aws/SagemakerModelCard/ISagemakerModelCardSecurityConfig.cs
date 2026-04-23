using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerModelCard
{
    [JsiiInterface(nativeType: typeof(ISagemakerModelCardSecurityConfig), fullyQualifiedName: "aws.sagemakerModelCard.SagemakerModelCardSecurityConfig")]
    public interface ISagemakerModelCardSecurityConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_model_card#kms_key_id SagemakerModelCard#kms_key_id}.</summary>
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}")]
        string KmsKeyId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerModelCardSecurityConfig), fullyQualifiedName: "aws.sagemakerModelCard.SagemakerModelCardSecurityConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerModelCard.ISagemakerModelCardSecurityConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_model_card#kms_key_id SagemakerModelCard#kms_key_id}.</summary>
            [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}")]
            public string KmsKeyId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
