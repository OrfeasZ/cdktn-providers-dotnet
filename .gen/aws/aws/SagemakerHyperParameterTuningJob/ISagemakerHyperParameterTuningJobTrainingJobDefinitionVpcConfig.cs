using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerHyperParameterTuningJob
{
    [JsiiInterface(nativeType: typeof(ISagemakerHyperParameterTuningJobTrainingJobDefinitionVpcConfig), fullyQualifiedName: "aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionVpcConfig")]
    public interface ISagemakerHyperParameterTuningJobTrainingJobDefinitionVpcConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#security_group_ids SagemakerHyperParameterTuningJob#security_group_ids}.</summary>
        [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] SecurityGroupIds
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#subnets SagemakerHyperParameterTuningJob#subnets}.</summary>
        [JsiiProperty(name: "subnets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Subnets
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerHyperParameterTuningJobTrainingJobDefinitionVpcConfig), fullyQualifiedName: "aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionVpcConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobTrainingJobDefinitionVpcConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#security_group_ids SagemakerHyperParameterTuningJob#security_group_ids}.</summary>
            [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] SecurityGroupIds
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#subnets SagemakerHyperParameterTuningJob#subnets}.</summary>
            [JsiiProperty(name: "subnets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Subnets
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
