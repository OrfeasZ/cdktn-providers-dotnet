using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentFlow
{
    [JsiiInterface(nativeType: typeof(IBedrockagentFlowDefinitionNodeConfiguration), fullyQualifiedName: "aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfiguration")]
    public interface IBedrockagentFlowDefinitionNodeConfiguration
    {
        /// <summary>agent block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_flow#agent BedrockagentFlow#agent}
        /// </remarks>
        [JsiiProperty(name: "agent", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationAgent\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Agent
        {
            get
            {
                return null;
            }
        }

        /// <summary>collector block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_flow#collector BedrockagentFlow#collector}
        /// </remarks>
        [JsiiProperty(name: "collector", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationCollector\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Collector
        {
            get
            {
                return null;
            }
        }

        /// <summary>condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_flow#condition BedrockagentFlow#condition}
        /// </remarks>
        [JsiiProperty(name: "condition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Condition
        {
            get
            {
                return null;
            }
        }

        /// <summary>inline_code block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_flow#inline_code BedrockagentFlow#inline_code}
        /// </remarks>
        [JsiiProperty(name: "inlineCode", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationInlineCode\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? InlineCode
        {
            get
            {
                return null;
            }
        }

        /// <summary>input block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_flow#input BedrockagentFlow#input}
        /// </remarks>
        [JsiiProperty(name: "input", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationInput\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Input
        {
            get
            {
                return null;
            }
        }

        /// <summary>iterator block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_flow#iterator BedrockagentFlow#iterator}
        /// </remarks>
        [JsiiProperty(name: "iterator", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationIterator\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Iterator
        {
            get
            {
                return null;
            }
        }

        /// <summary>knowledge_base block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_flow#knowledge_base BedrockagentFlow#knowledge_base}
        /// </remarks>
        [JsiiProperty(name: "knowledgeBase", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationKnowledgeBase\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? KnowledgeBase
        {
            get
            {
                return null;
            }
        }

        /// <summary>lambda_function block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_flow#lambda_function BedrockagentFlow#lambda_function}
        /// </remarks>
        [JsiiProperty(name: "lambdaFunction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationLambdaFunction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LambdaFunction
        {
            get
            {
                return null;
            }
        }

        /// <summary>lex block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_flow#lex BedrockagentFlow#lex}
        /// </remarks>
        [JsiiProperty(name: "lex", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationLex\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Lex
        {
            get
            {
                return null;
            }
        }

        /// <summary>output block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_flow#output BedrockagentFlow#output}
        /// </remarks>
        [JsiiProperty(name: "output", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationOutput\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Output
        {
            get
            {
                return null;
            }
        }

        /// <summary>prompt block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_flow#prompt BedrockagentFlow#prompt}
        /// </remarks>
        [JsiiProperty(name: "prompt", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationPrompt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Prompt
        {
            get
            {
                return null;
            }
        }

        /// <summary>retrieval block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_flow#retrieval BedrockagentFlow#retrieval}
        /// </remarks>
        [JsiiProperty(name: "retrieval", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationRetrieval\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Retrieval
        {
            get
            {
                return null;
            }
        }

        /// <summary>storage block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_flow#storage BedrockagentFlow#storage}
        /// </remarks>
        [JsiiProperty(name: "storage", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationStorage\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Storage
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentFlowDefinitionNodeConfiguration), fullyQualifiedName: "aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentFlow.IBedrockagentFlowDefinitionNodeConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>agent block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_flow#agent BedrockagentFlow#agent}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "agent", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationAgent\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Agent
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>collector block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_flow#collector BedrockagentFlow#collector}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "collector", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationCollector\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Collector
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>condition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_flow#condition BedrockagentFlow#condition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "condition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Condition
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>inline_code block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_flow#inline_code BedrockagentFlow#inline_code}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "inlineCode", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationInlineCode\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? InlineCode
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>input block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_flow#input BedrockagentFlow#input}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "input", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationInput\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Input
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>iterator block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_flow#iterator BedrockagentFlow#iterator}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "iterator", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationIterator\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Iterator
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>knowledge_base block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_flow#knowledge_base BedrockagentFlow#knowledge_base}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "knowledgeBase", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationKnowledgeBase\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? KnowledgeBase
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>lambda_function block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_flow#lambda_function BedrockagentFlow#lambda_function}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lambdaFunction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationLambdaFunction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LambdaFunction
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>lex block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_flow#lex BedrockagentFlow#lex}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lex", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationLex\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Lex
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>output block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_flow#output BedrockagentFlow#output}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "output", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationOutput\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Output
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>prompt block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_flow#prompt BedrockagentFlow#prompt}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "prompt", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationPrompt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Prompt
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>retrieval block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_flow#retrieval BedrockagentFlow#retrieval}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "retrieval", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationRetrieval\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Retrieval
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>storage block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_flow#storage BedrockagentFlow#storage}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "storage", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationStorage\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Storage
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
