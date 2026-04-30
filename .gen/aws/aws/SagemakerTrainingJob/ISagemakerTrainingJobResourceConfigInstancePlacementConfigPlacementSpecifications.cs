using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerTrainingJob
{
    [JsiiInterface(nativeType: typeof(ISagemakerTrainingJobResourceConfigInstancePlacementConfigPlacementSpecifications), fullyQualifiedName: "aws.sagemakerTrainingJob.SagemakerTrainingJobResourceConfigInstancePlacementConfigPlacementSpecifications")]
    public interface ISagemakerTrainingJobResourceConfigInstancePlacementConfigPlacementSpecifications
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_training_job#instance_count SagemakerTrainingJob#instance_count}.</summary>
        [JsiiProperty(name: "instanceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? InstanceCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_training_job#ultra_server_id SagemakerTrainingJob#ultra_server_id}.</summary>
        [JsiiProperty(name: "ultraServerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UltraServerId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerTrainingJobResourceConfigInstancePlacementConfigPlacementSpecifications), fullyQualifiedName: "aws.sagemakerTrainingJob.SagemakerTrainingJobResourceConfigInstancePlacementConfigPlacementSpecifications")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerTrainingJob.ISagemakerTrainingJobResourceConfigInstancePlacementConfigPlacementSpecifications
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_training_job#instance_count SagemakerTrainingJob#instance_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "instanceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? InstanceCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_training_job#ultra_server_id SagemakerTrainingJob#ultra_server_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ultraServerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UltraServerId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
