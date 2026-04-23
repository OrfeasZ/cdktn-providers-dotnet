using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerAlgorithm
{
    [JsiiInterface(nativeType: typeof(ISagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinition), fullyQualifiedName: "aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinition")]
    public interface ISagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinition
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_algorithm#training_input_mode SagemakerAlgorithm#training_input_mode}.</summary>
        [JsiiProperty(name: "trainingInputMode", typeJson: "{\"primitive\":\"string\"}")]
        string TrainingInputMode
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_algorithm#hyper_parameters SagemakerAlgorithm#hyper_parameters}.</summary>
        [JsiiProperty(name: "hyperParameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? HyperParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>input_data_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_algorithm#input_data_config SagemakerAlgorithm#input_data_config}
        /// </remarks>
        [JsiiProperty(name: "inputDataConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionInputDataConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? InputDataConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>output_data_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_algorithm#output_data_config SagemakerAlgorithm#output_data_config}
        /// </remarks>
        [JsiiProperty(name: "outputDataConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionOutputDataConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? OutputDataConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>resource_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_algorithm#resource_config SagemakerAlgorithm#resource_config}
        /// </remarks>
        [JsiiProperty(name: "resourceConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionResourceConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ResourceConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>stopping_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_algorithm#stopping_condition SagemakerAlgorithm#stopping_condition}
        /// </remarks>
        [JsiiProperty(name: "stoppingCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionStoppingCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? StoppingCondition
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinition), fullyQualifiedName: "aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinition")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerAlgorithm.ISagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_algorithm#training_input_mode SagemakerAlgorithm#training_input_mode}.</summary>
            [JsiiProperty(name: "trainingInputMode", typeJson: "{\"primitive\":\"string\"}")]
            public string TrainingInputMode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_algorithm#hyper_parameters SagemakerAlgorithm#hyper_parameters}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hyperParameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? HyperParameters
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>input_data_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_algorithm#input_data_config SagemakerAlgorithm#input_data_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "inputDataConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionInputDataConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? InputDataConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>output_data_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_algorithm#output_data_config SagemakerAlgorithm#output_data_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "outputDataConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionOutputDataConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? OutputDataConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>resource_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_algorithm#resource_config SagemakerAlgorithm#resource_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionResourceConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ResourceConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>stopping_condition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_algorithm#stopping_condition SagemakerAlgorithm#stopping_condition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stoppingCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionStoppingCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? StoppingCondition
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
