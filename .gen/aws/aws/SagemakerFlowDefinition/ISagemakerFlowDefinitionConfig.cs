using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerFlowDefinition
{
    [JsiiInterface(nativeType: typeof(ISagemakerFlowDefinitionConfig), fullyQualifiedName: "aws.sagemakerFlowDefinition.SagemakerFlowDefinitionConfig")]
    public interface ISagemakerFlowDefinitionConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_flow_definition#flow_definition_name SagemakerFlowDefinition#flow_definition_name}.</summary>
        [JsiiProperty(name: "flowDefinitionName", typeJson: "{\"primitive\":\"string\"}")]
        string FlowDefinitionName
        {
            get;
        }

        /// <summary>human_loop_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_flow_definition#human_loop_config SagemakerFlowDefinition#human_loop_config}
        /// </remarks>
        [JsiiProperty(name: "humanLoopConfig", typeJson: "{\"fqn\":\"aws.sagemakerFlowDefinition.SagemakerFlowDefinitionHumanLoopConfig\"}")]
        aws.SagemakerFlowDefinition.ISagemakerFlowDefinitionHumanLoopConfig HumanLoopConfig
        {
            get;
        }

        /// <summary>output_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_flow_definition#output_config SagemakerFlowDefinition#output_config}
        /// </remarks>
        [JsiiProperty(name: "outputConfig", typeJson: "{\"fqn\":\"aws.sagemakerFlowDefinition.SagemakerFlowDefinitionOutputConfig\"}")]
        aws.SagemakerFlowDefinition.ISagemakerFlowDefinitionOutputConfig OutputConfig
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_flow_definition#role_arn SagemakerFlowDefinition#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        string RoleArn
        {
            get;
        }

        /// <summary>human_loop_activation_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_flow_definition#human_loop_activation_config SagemakerFlowDefinition#human_loop_activation_config}
        /// </remarks>
        [JsiiProperty(name: "humanLoopActivationConfig", typeJson: "{\"fqn\":\"aws.sagemakerFlowDefinition.SagemakerFlowDefinitionHumanLoopActivationConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerFlowDefinition.ISagemakerFlowDefinitionHumanLoopActivationConfig? HumanLoopActivationConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>human_loop_request_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_flow_definition#human_loop_request_source SagemakerFlowDefinition#human_loop_request_source}
        /// </remarks>
        [JsiiProperty(name: "humanLoopRequestSource", typeJson: "{\"fqn\":\"aws.sagemakerFlowDefinition.SagemakerFlowDefinitionHumanLoopRequestSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerFlowDefinition.ISagemakerFlowDefinitionHumanLoopRequestSource? HumanLoopRequestSource
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_flow_definition#id SagemakerFlowDefinition#id}.</summary>
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

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_flow_definition#region SagemakerFlowDefinition#region}
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_flow_definition#tags SagemakerFlowDefinition#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_flow_definition#tags_all SagemakerFlowDefinition#tags_all}.</summary>
        [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? TagsAll
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerFlowDefinitionConfig), fullyQualifiedName: "aws.sagemakerFlowDefinition.SagemakerFlowDefinitionConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerFlowDefinition.ISagemakerFlowDefinitionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_flow_definition#flow_definition_name SagemakerFlowDefinition#flow_definition_name}.</summary>
            [JsiiProperty(name: "flowDefinitionName", typeJson: "{\"primitive\":\"string\"}")]
            public string FlowDefinitionName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>human_loop_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_flow_definition#human_loop_config SagemakerFlowDefinition#human_loop_config}
            /// </remarks>
            [JsiiProperty(name: "humanLoopConfig", typeJson: "{\"fqn\":\"aws.sagemakerFlowDefinition.SagemakerFlowDefinitionHumanLoopConfig\"}")]
            public aws.SagemakerFlowDefinition.ISagemakerFlowDefinitionHumanLoopConfig HumanLoopConfig
            {
                get => GetInstanceProperty<aws.SagemakerFlowDefinition.ISagemakerFlowDefinitionHumanLoopConfig>()!;
            }

            /// <summary>output_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_flow_definition#output_config SagemakerFlowDefinition#output_config}
            /// </remarks>
            [JsiiProperty(name: "outputConfig", typeJson: "{\"fqn\":\"aws.sagemakerFlowDefinition.SagemakerFlowDefinitionOutputConfig\"}")]
            public aws.SagemakerFlowDefinition.ISagemakerFlowDefinitionOutputConfig OutputConfig
            {
                get => GetInstanceProperty<aws.SagemakerFlowDefinition.ISagemakerFlowDefinitionOutputConfig>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_flow_definition#role_arn SagemakerFlowDefinition#role_arn}.</summary>
            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>human_loop_activation_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_flow_definition#human_loop_activation_config SagemakerFlowDefinition#human_loop_activation_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "humanLoopActivationConfig", typeJson: "{\"fqn\":\"aws.sagemakerFlowDefinition.SagemakerFlowDefinitionHumanLoopActivationConfig\"}", isOptional: true)]
            public aws.SagemakerFlowDefinition.ISagemakerFlowDefinitionHumanLoopActivationConfig? HumanLoopActivationConfig
            {
                get => GetInstanceProperty<aws.SagemakerFlowDefinition.ISagemakerFlowDefinitionHumanLoopActivationConfig?>();
            }

            /// <summary>human_loop_request_source block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_flow_definition#human_loop_request_source SagemakerFlowDefinition#human_loop_request_source}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "humanLoopRequestSource", typeJson: "{\"fqn\":\"aws.sagemakerFlowDefinition.SagemakerFlowDefinitionHumanLoopRequestSource\"}", isOptional: true)]
            public aws.SagemakerFlowDefinition.ISagemakerFlowDefinitionHumanLoopRequestSource? HumanLoopRequestSource
            {
                get => GetInstanceProperty<aws.SagemakerFlowDefinition.ISagemakerFlowDefinitionHumanLoopRequestSource?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_flow_definition#id SagemakerFlowDefinition#id}.</summary>
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

            /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_flow_definition#region SagemakerFlowDefinition#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_flow_definition#tags SagemakerFlowDefinition#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_flow_definition#tags_all SagemakerFlowDefinition#tags_all}.</summary>
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
