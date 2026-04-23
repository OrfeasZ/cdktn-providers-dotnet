using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerAlgorithm
{
    [JsiiInterface(nativeType: typeof(ISagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionStoppingCondition), fullyQualifiedName: "aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionStoppingCondition")]
    public interface ISagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionStoppingCondition
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_algorithm#max_pending_time_in_seconds SagemakerAlgorithm#max_pending_time_in_seconds}.</summary>
        [JsiiProperty(name: "maxPendingTimeInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxPendingTimeInSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_algorithm#max_runtime_in_seconds SagemakerAlgorithm#max_runtime_in_seconds}.</summary>
        [JsiiProperty(name: "maxRuntimeInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxRuntimeInSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_algorithm#max_wait_time_in_seconds SagemakerAlgorithm#max_wait_time_in_seconds}.</summary>
        [JsiiProperty(name: "maxWaitTimeInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxWaitTimeInSeconds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionStoppingCondition), fullyQualifiedName: "aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionStoppingCondition")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerAlgorithm.ISagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionStoppingCondition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_algorithm#max_pending_time_in_seconds SagemakerAlgorithm#max_pending_time_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxPendingTimeInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxPendingTimeInSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_algorithm#max_runtime_in_seconds SagemakerAlgorithm#max_runtime_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxRuntimeInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxRuntimeInSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_algorithm#max_wait_time_in_seconds SagemakerAlgorithm#max_wait_time_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxWaitTimeInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxWaitTimeInSeconds
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
