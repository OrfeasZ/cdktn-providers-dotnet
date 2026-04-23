using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerTrainingJob
{
    [JsiiInterface(nativeType: typeof(ISagemakerTrainingJobModelPackageConfig), fullyQualifiedName: "aws.sagemakerTrainingJob.SagemakerTrainingJobModelPackageConfig")]
    public interface ISagemakerTrainingJobModelPackageConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#model_package_group_arn SagemakerTrainingJob#model_package_group_arn}.</summary>
        [JsiiProperty(name: "modelPackageGroupArn", typeJson: "{\"primitive\":\"string\"}")]
        string ModelPackageGroupArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#source_model_package_arn SagemakerTrainingJob#source_model_package_arn}.</summary>
        [JsiiProperty(name: "sourceModelPackageArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SourceModelPackageArn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerTrainingJobModelPackageConfig), fullyQualifiedName: "aws.sagemakerTrainingJob.SagemakerTrainingJobModelPackageConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerTrainingJob.ISagemakerTrainingJobModelPackageConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#model_package_group_arn SagemakerTrainingJob#model_package_group_arn}.</summary>
            [JsiiProperty(name: "modelPackageGroupArn", typeJson: "{\"primitive\":\"string\"}")]
            public string ModelPackageGroupArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#source_model_package_arn SagemakerTrainingJob#source_model_package_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourceModelPackageArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SourceModelPackageArn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
