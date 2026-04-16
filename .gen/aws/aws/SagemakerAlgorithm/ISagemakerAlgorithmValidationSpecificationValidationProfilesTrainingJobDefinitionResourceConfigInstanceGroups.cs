using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerAlgorithm
{
    [JsiiInterface(nativeType: typeof(ISagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionResourceConfigInstanceGroups), fullyQualifiedName: "aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionResourceConfigInstanceGroups")]
    public interface ISagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionResourceConfigInstanceGroups
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#instance_count SagemakerAlgorithm#instance_count}.</summary>
        [JsiiProperty(name: "instanceCount", typeJson: "{\"primitive\":\"number\"}")]
        double InstanceCount
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#instance_group_name SagemakerAlgorithm#instance_group_name}.</summary>
        [JsiiProperty(name: "instanceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        string InstanceGroupName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#instance_type SagemakerAlgorithm#instance_type}.</summary>
        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
        string InstanceType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionResourceConfigInstanceGroups), fullyQualifiedName: "aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionResourceConfigInstanceGroups")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerAlgorithm.ISagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionResourceConfigInstanceGroups
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#instance_count SagemakerAlgorithm#instance_count}.</summary>
            [JsiiProperty(name: "instanceCount", typeJson: "{\"primitive\":\"number\"}")]
            public double InstanceCount
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#instance_group_name SagemakerAlgorithm#instance_group_name}.</summary>
            [JsiiProperty(name: "instanceGroupName", typeJson: "{\"primitive\":\"string\"}")]
            public string InstanceGroupName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#instance_type SagemakerAlgorithm#instance_type}.</summary>
            [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
            public string InstanceType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
