using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiAgentTool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfig")]
    public class GenerativeAiAgentToolToolConfig : oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#tool_config_type GenerativeAiAgentTool#tool_config_type}.</summary>
        [JsiiProperty(name: "toolConfigType", typeJson: "{\"primitive\":\"string\"}")]
        public string ToolConfigType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#agent_endpoint_id GenerativeAiAgentTool#agent_endpoint_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "agentEndpointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AgentEndpointId
        {
            get;
            set;
        }

        /// <summary>api_schema block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#api_schema GenerativeAiAgentTool#api_schema}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "apiSchema", typeJson: "{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigApiSchema\"}", isOptional: true)]
        public oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigApiSchema? ApiSchema
        {
            get;
            set;
        }

        /// <summary>database_connection block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#database_connection GenerativeAiAgentTool#database_connection}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "databaseConnection", typeJson: "{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigDatabaseConnection\"}", isOptional: true)]
        public oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigDatabaseConnection? DatabaseConnection
        {
            get;
            set;
        }

        /// <summary>database_schema block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#database_schema GenerativeAiAgentTool#database_schema}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "databaseSchema", typeJson: "{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigDatabaseSchema\"}", isOptional: true)]
        public oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigDatabaseSchema? DatabaseSchema
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#dialect GenerativeAiAgentTool#dialect}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dialect", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Dialect
        {
            get;
            set;
        }

        /// <summary>function block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#function GenerativeAiAgentTool#function}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "function", typeJson: "{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigFunction\"}", isOptional: true)]
        public oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigFunction? Function
        {
            get;
            set;
        }

        /// <summary>generation_llm_customization block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#generation_llm_customization GenerativeAiAgentTool#generation_llm_customization}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "generationLlmCustomization", typeJson: "{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigGenerationLlmCustomization\"}", isOptional: true)]
        public oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigGenerationLlmCustomization? GenerationLlmCustomization
        {
            get;
            set;
        }

        /// <summary>http_endpoint_auth_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#http_endpoint_auth_config GenerativeAiAgentTool#http_endpoint_auth_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "httpEndpointAuthConfig", typeJson: "{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigHttpEndpointAuthConfig\"}", isOptional: true)]
        public oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigHttpEndpointAuthConfig? HttpEndpointAuthConfig
        {
            get;
            set;
        }

        /// <summary>icl_examples block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#icl_examples GenerativeAiAgentTool#icl_examples}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "iclExamples", typeJson: "{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigIclExamples\"}", isOptional: true)]
        public oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigIclExamples? IclExamples
        {
            get;
            set;
        }

        private object? _knowledgeBaseConfigs;

        /// <summary>knowledge_base_configs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#knowledge_base_configs GenerativeAiAgentTool#knowledge_base_configs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "knowledgeBaseConfigs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigKnowledgeBaseConfigs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? KnowledgeBaseConfigs
        {
            get => _knowledgeBaseConfigs;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigKnowledgeBaseConfigs[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigKnowledgeBaseConfigs).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _knowledgeBaseConfigs = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#model_size GenerativeAiAgentTool#model_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "modelSize", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ModelSize
        {
            get;
            set;
        }

        private object? _shouldEnableSelfCorrection;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#should_enable_self_correction GenerativeAiAgentTool#should_enable_self_correction}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "shouldEnableSelfCorrection", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ShouldEnableSelfCorrection
        {
            get => _shouldEnableSelfCorrection;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _shouldEnableSelfCorrection = value;
            }
        }

        private object? _shouldEnableSqlExecution;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#should_enable_sql_execution GenerativeAiAgentTool#should_enable_sql_execution}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "shouldEnableSqlExecution", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ShouldEnableSqlExecution
        {
            get => _shouldEnableSqlExecution;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _shouldEnableSqlExecution = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#subnet_id GenerativeAiAgentTool#subnet_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SubnetId
        {
            get;
            set;
        }

        /// <summary>table_and_column_description block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#table_and_column_description GenerativeAiAgentTool#table_and_column_description}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tableAndColumnDescription", typeJson: "{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigTableAndColumnDescription\"}", isOptional: true)]
        public oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigTableAndColumnDescription? TableAndColumnDescription
        {
            get;
            set;
        }
    }
}
