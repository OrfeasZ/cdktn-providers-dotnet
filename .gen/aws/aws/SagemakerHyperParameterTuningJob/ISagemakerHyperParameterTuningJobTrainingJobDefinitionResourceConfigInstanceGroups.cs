using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerHyperParameterTuningJob
{
    [JsiiInterface(nativeType: typeof(ISagemakerHyperParameterTuningJobTrainingJobDefinitionResourceConfigInstanceGroups), fullyQualifiedName: "aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionResourceConfigInstanceGroups")]
    public interface ISagemakerHyperParameterTuningJobTrainingJobDefinitionResourceConfigInstanceGroups
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#instance_count SagemakerHyperParameterTuningJob#instance_count}.</summary>
        [JsiiProperty(name: "instanceCount", typeJson: "{\"primitive\":\"number\"}")]
        double InstanceCount
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#instance_group_name SagemakerHyperParameterTuningJob#instance_group_name}.</summary>
        [JsiiProperty(name: "instanceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        string InstanceGroupName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#instance_type SagemakerHyperParameterTuningJob#instance_type}.</summary>
        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
        string InstanceType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerHyperParameterTuningJobTrainingJobDefinitionResourceConfigInstanceGroups), fullyQualifiedName: "aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionResourceConfigInstanceGroups")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobTrainingJobDefinitionResourceConfigInstanceGroups
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#instance_count SagemakerHyperParameterTuningJob#instance_count}.</summary>
            [JsiiProperty(name: "instanceCount", typeJson: "{\"primitive\":\"number\"}")]
            public double InstanceCount
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#instance_group_name SagemakerHyperParameterTuningJob#instance_group_name}.</summary>
            [JsiiProperty(name: "instanceGroupName", typeJson: "{\"primitive\":\"string\"}")]
            public string InstanceGroupName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#instance_type SagemakerHyperParameterTuningJob#instance_type}.</summary>
            [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
            public string InstanceType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
