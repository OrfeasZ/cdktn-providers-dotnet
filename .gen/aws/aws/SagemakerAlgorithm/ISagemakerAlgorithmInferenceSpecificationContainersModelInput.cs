using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerAlgorithm
{
    [JsiiInterface(nativeType: typeof(ISagemakerAlgorithmInferenceSpecificationContainersModelInput), fullyQualifiedName: "aws.sagemakerAlgorithm.SagemakerAlgorithmInferenceSpecificationContainersModelInput")]
    public interface ISagemakerAlgorithmInferenceSpecificationContainersModelInput
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#data_input_config SagemakerAlgorithm#data_input_config}.</summary>
        [JsiiProperty(name: "dataInputConfig", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DataInputConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerAlgorithmInferenceSpecificationContainersModelInput), fullyQualifiedName: "aws.sagemakerAlgorithm.SagemakerAlgorithmInferenceSpecificationContainersModelInput")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerAlgorithm.ISagemakerAlgorithmInferenceSpecificationContainersModelInput
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#data_input_config SagemakerAlgorithm#data_input_config}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dataInputConfig", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DataInputConfig
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
