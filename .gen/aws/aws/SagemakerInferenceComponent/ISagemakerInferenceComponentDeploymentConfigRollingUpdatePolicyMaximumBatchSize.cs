using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerInferenceComponent
{
    [JsiiInterface(nativeType: typeof(ISagemakerInferenceComponentDeploymentConfigRollingUpdatePolicyMaximumBatchSize), fullyQualifiedName: "aws.sagemakerInferenceComponent.SagemakerInferenceComponentDeploymentConfigRollingUpdatePolicyMaximumBatchSize")]
    public interface ISagemakerInferenceComponentDeploymentConfigRollingUpdatePolicyMaximumBatchSize
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/sagemaker_inference_component#type SagemakerInferenceComponent#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/sagemaker_inference_component#value SagemakerInferenceComponent#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"number\"}")]
        double Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerInferenceComponentDeploymentConfigRollingUpdatePolicyMaximumBatchSize), fullyQualifiedName: "aws.sagemakerInferenceComponent.SagemakerInferenceComponentDeploymentConfigRollingUpdatePolicyMaximumBatchSize")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerInferenceComponent.ISagemakerInferenceComponentDeploymentConfigRollingUpdatePolicyMaximumBatchSize
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/sagemaker_inference_component#type SagemakerInferenceComponent#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/sagemaker_inference_component#value SagemakerInferenceComponent#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"number\"}")]
            public double Value
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
