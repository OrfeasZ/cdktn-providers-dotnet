using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerDataQualityJobDefinition
{
    [JsiiInterface(nativeType: typeof(ISagemakerDataQualityJobDefinitionConfig), fullyQualifiedName: "aws.sagemakerDataQualityJobDefinition.SagemakerDataQualityJobDefinitionConfig")]
    public interface ISagemakerDataQualityJobDefinitionConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>data_quality_app_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_data_quality_job_definition#data_quality_app_specification SagemakerDataQualityJobDefinition#data_quality_app_specification}
        /// </remarks>
        [JsiiProperty(name: "dataQualityAppSpecification", typeJson: "{\"fqn\":\"aws.sagemakerDataQualityJobDefinition.SagemakerDataQualityJobDefinitionDataQualityAppSpecification\"}")]
        aws.SagemakerDataQualityJobDefinition.ISagemakerDataQualityJobDefinitionDataQualityAppSpecification DataQualityAppSpecification
        {
            get;
        }

        /// <summary>data_quality_job_input block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_data_quality_job_definition#data_quality_job_input SagemakerDataQualityJobDefinition#data_quality_job_input}
        /// </remarks>
        [JsiiProperty(name: "dataQualityJobInput", typeJson: "{\"fqn\":\"aws.sagemakerDataQualityJobDefinition.SagemakerDataQualityJobDefinitionDataQualityJobInput\"}")]
        aws.SagemakerDataQualityJobDefinition.ISagemakerDataQualityJobDefinitionDataQualityJobInput DataQualityJobInput
        {
            get;
        }

        /// <summary>data_quality_job_output_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_data_quality_job_definition#data_quality_job_output_config SagemakerDataQualityJobDefinition#data_quality_job_output_config}
        /// </remarks>
        [JsiiProperty(name: "dataQualityJobOutputConfig", typeJson: "{\"fqn\":\"aws.sagemakerDataQualityJobDefinition.SagemakerDataQualityJobDefinitionDataQualityJobOutputConfig\"}")]
        aws.SagemakerDataQualityJobDefinition.ISagemakerDataQualityJobDefinitionDataQualityJobOutputConfig DataQualityJobOutputConfig
        {
            get;
        }

        /// <summary>job_resources block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_data_quality_job_definition#job_resources SagemakerDataQualityJobDefinition#job_resources}
        /// </remarks>
        [JsiiProperty(name: "jobResources", typeJson: "{\"fqn\":\"aws.sagemakerDataQualityJobDefinition.SagemakerDataQualityJobDefinitionJobResources\"}")]
        aws.SagemakerDataQualityJobDefinition.ISagemakerDataQualityJobDefinitionJobResources JobResources
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_data_quality_job_definition#role_arn SagemakerDataQualityJobDefinition#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        string RoleArn
        {
            get;
        }

        /// <summary>data_quality_baseline_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_data_quality_job_definition#data_quality_baseline_config SagemakerDataQualityJobDefinition#data_quality_baseline_config}
        /// </remarks>
        [JsiiProperty(name: "dataQualityBaselineConfig", typeJson: "{\"fqn\":\"aws.sagemakerDataQualityJobDefinition.SagemakerDataQualityJobDefinitionDataQualityBaselineConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerDataQualityJobDefinition.ISagemakerDataQualityJobDefinitionDataQualityBaselineConfig? DataQualityBaselineConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_data_quality_job_definition#id SagemakerDataQualityJobDefinition#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_data_quality_job_definition#name SagemakerDataQualityJobDefinition#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>network_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_data_quality_job_definition#network_config SagemakerDataQualityJobDefinition#network_config}
        /// </remarks>
        [JsiiProperty(name: "networkConfig", typeJson: "{\"fqn\":\"aws.sagemakerDataQualityJobDefinition.SagemakerDataQualityJobDefinitionNetworkConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerDataQualityJobDefinition.ISagemakerDataQualityJobDefinitionNetworkConfig? NetworkConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_data_quality_job_definition#region SagemakerDataQualityJobDefinition#region}
        /// </remarks>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Region
        {
            get
            {
                return null;
            }
        }

        /// <summary>stopping_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_data_quality_job_definition#stopping_condition SagemakerDataQualityJobDefinition#stopping_condition}
        /// </remarks>
        [JsiiProperty(name: "stoppingCondition", typeJson: "{\"fqn\":\"aws.sagemakerDataQualityJobDefinition.SagemakerDataQualityJobDefinitionStoppingCondition\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerDataQualityJobDefinition.ISagemakerDataQualityJobDefinitionStoppingCondition? StoppingCondition
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_data_quality_job_definition#tags SagemakerDataQualityJobDefinition#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_data_quality_job_definition#tags_all SagemakerDataQualityJobDefinition#tags_all}.</summary>
        [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? TagsAll
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerDataQualityJobDefinitionConfig), fullyQualifiedName: "aws.sagemakerDataQualityJobDefinition.SagemakerDataQualityJobDefinitionConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerDataQualityJobDefinition.ISagemakerDataQualityJobDefinitionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>data_quality_app_specification block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_data_quality_job_definition#data_quality_app_specification SagemakerDataQualityJobDefinition#data_quality_app_specification}
            /// </remarks>
            [JsiiProperty(name: "dataQualityAppSpecification", typeJson: "{\"fqn\":\"aws.sagemakerDataQualityJobDefinition.SagemakerDataQualityJobDefinitionDataQualityAppSpecification\"}")]
            public aws.SagemakerDataQualityJobDefinition.ISagemakerDataQualityJobDefinitionDataQualityAppSpecification DataQualityAppSpecification
            {
                get => GetInstanceProperty<aws.SagemakerDataQualityJobDefinition.ISagemakerDataQualityJobDefinitionDataQualityAppSpecification>()!;
            }

            /// <summary>data_quality_job_input block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_data_quality_job_definition#data_quality_job_input SagemakerDataQualityJobDefinition#data_quality_job_input}
            /// </remarks>
            [JsiiProperty(name: "dataQualityJobInput", typeJson: "{\"fqn\":\"aws.sagemakerDataQualityJobDefinition.SagemakerDataQualityJobDefinitionDataQualityJobInput\"}")]
            public aws.SagemakerDataQualityJobDefinition.ISagemakerDataQualityJobDefinitionDataQualityJobInput DataQualityJobInput
            {
                get => GetInstanceProperty<aws.SagemakerDataQualityJobDefinition.ISagemakerDataQualityJobDefinitionDataQualityJobInput>()!;
            }

            /// <summary>data_quality_job_output_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_data_quality_job_definition#data_quality_job_output_config SagemakerDataQualityJobDefinition#data_quality_job_output_config}
            /// </remarks>
            [JsiiProperty(name: "dataQualityJobOutputConfig", typeJson: "{\"fqn\":\"aws.sagemakerDataQualityJobDefinition.SagemakerDataQualityJobDefinitionDataQualityJobOutputConfig\"}")]
            public aws.SagemakerDataQualityJobDefinition.ISagemakerDataQualityJobDefinitionDataQualityJobOutputConfig DataQualityJobOutputConfig
            {
                get => GetInstanceProperty<aws.SagemakerDataQualityJobDefinition.ISagemakerDataQualityJobDefinitionDataQualityJobOutputConfig>()!;
            }

            /// <summary>job_resources block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_data_quality_job_definition#job_resources SagemakerDataQualityJobDefinition#job_resources}
            /// </remarks>
            [JsiiProperty(name: "jobResources", typeJson: "{\"fqn\":\"aws.sagemakerDataQualityJobDefinition.SagemakerDataQualityJobDefinitionJobResources\"}")]
            public aws.SagemakerDataQualityJobDefinition.ISagemakerDataQualityJobDefinitionJobResources JobResources
            {
                get => GetInstanceProperty<aws.SagemakerDataQualityJobDefinition.ISagemakerDataQualityJobDefinitionJobResources>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_data_quality_job_definition#role_arn SagemakerDataQualityJobDefinition#role_arn}.</summary>
            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>data_quality_baseline_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_data_quality_job_definition#data_quality_baseline_config SagemakerDataQualityJobDefinition#data_quality_baseline_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dataQualityBaselineConfig", typeJson: "{\"fqn\":\"aws.sagemakerDataQualityJobDefinition.SagemakerDataQualityJobDefinitionDataQualityBaselineConfig\"}", isOptional: true)]
            public aws.SagemakerDataQualityJobDefinition.ISagemakerDataQualityJobDefinitionDataQualityBaselineConfig? DataQualityBaselineConfig
            {
                get => GetInstanceProperty<aws.SagemakerDataQualityJobDefinition.ISagemakerDataQualityJobDefinitionDataQualityBaselineConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_data_quality_job_definition#id SagemakerDataQualityJobDefinition#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_data_quality_job_definition#name SagemakerDataQualityJobDefinition#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>network_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_data_quality_job_definition#network_config SagemakerDataQualityJobDefinition#network_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "networkConfig", typeJson: "{\"fqn\":\"aws.sagemakerDataQualityJobDefinition.SagemakerDataQualityJobDefinitionNetworkConfig\"}", isOptional: true)]
            public aws.SagemakerDataQualityJobDefinition.ISagemakerDataQualityJobDefinitionNetworkConfig? NetworkConfig
            {
                get => GetInstanceProperty<aws.SagemakerDataQualityJobDefinition.ISagemakerDataQualityJobDefinitionNetworkConfig?>();
            }

            /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_data_quality_job_definition#region SagemakerDataQualityJobDefinition#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>stopping_condition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_data_quality_job_definition#stopping_condition SagemakerDataQualityJobDefinition#stopping_condition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stoppingCondition", typeJson: "{\"fqn\":\"aws.sagemakerDataQualityJobDefinition.SagemakerDataQualityJobDefinitionStoppingCondition\"}", isOptional: true)]
            public aws.SagemakerDataQualityJobDefinition.ISagemakerDataQualityJobDefinitionStoppingCondition? StoppingCondition
            {
                get => GetInstanceProperty<aws.SagemakerDataQualityJobDefinition.ISagemakerDataQualityJobDefinitionStoppingCondition?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_data_quality_job_definition#tags SagemakerDataQualityJobDefinition#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_data_quality_job_definition#tags_all SagemakerDataQualityJobDefinition#tags_all}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? TagsAll
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
