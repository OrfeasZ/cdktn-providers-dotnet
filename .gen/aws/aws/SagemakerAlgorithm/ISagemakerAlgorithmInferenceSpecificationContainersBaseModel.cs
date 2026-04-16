using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerAlgorithm
{
    [JsiiInterface(nativeType: typeof(ISagemakerAlgorithmInferenceSpecificationContainersBaseModel), fullyQualifiedName: "aws.sagemakerAlgorithm.SagemakerAlgorithmInferenceSpecificationContainersBaseModel")]
    public interface ISagemakerAlgorithmInferenceSpecificationContainersBaseModel
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#hub_content_name SagemakerAlgorithm#hub_content_name}.</summary>
        [JsiiProperty(name: "hubContentName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HubContentName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#hub_content_version SagemakerAlgorithm#hub_content_version}.</summary>
        [JsiiProperty(name: "hubContentVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HubContentVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#recipe_name SagemakerAlgorithm#recipe_name}.</summary>
        [JsiiProperty(name: "recipeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RecipeName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerAlgorithmInferenceSpecificationContainersBaseModel), fullyQualifiedName: "aws.sagemakerAlgorithm.SagemakerAlgorithmInferenceSpecificationContainersBaseModel")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerAlgorithm.ISagemakerAlgorithmInferenceSpecificationContainersBaseModel
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#hub_content_name SagemakerAlgorithm#hub_content_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hubContentName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HubContentName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#hub_content_version SagemakerAlgorithm#hub_content_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hubContentVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HubContentVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#recipe_name SagemakerAlgorithm#recipe_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "recipeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RecipeName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
