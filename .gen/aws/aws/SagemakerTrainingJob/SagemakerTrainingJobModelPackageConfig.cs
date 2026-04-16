using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerTrainingJob
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerTrainingJob.SagemakerTrainingJobModelPackageConfig")]
    public class SagemakerTrainingJobModelPackageConfig : aws.SagemakerTrainingJob.ISagemakerTrainingJobModelPackageConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_training_job#model_package_group_arn SagemakerTrainingJob#model_package_group_arn}.</summary>
        [JsiiProperty(name: "modelPackageGroupArn", typeJson: "{\"primitive\":\"string\"}")]
        public string ModelPackageGroupArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_training_job#source_model_package_arn SagemakerTrainingJob#source_model_package_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceModelPackageArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourceModelPackageArn
        {
            get;
            set;
        }
    }
}
