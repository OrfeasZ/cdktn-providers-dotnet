using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerModelCard
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerModelCard.SagemakerModelCardSecurityConfig")]
    public class SagemakerModelCardSecurityConfig : aws.SagemakerModelCard.ISagemakerModelCardSecurityConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_model_card#kms_key_id SagemakerModelCard#kms_key_id}.</summary>
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public string KmsKeyId
        {
            get;
            set;
        }
    }
}
