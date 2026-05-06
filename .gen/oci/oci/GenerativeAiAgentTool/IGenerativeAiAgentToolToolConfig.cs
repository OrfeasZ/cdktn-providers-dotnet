using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiAgentTool
{
    [JsiiInterface(nativeType: typeof(IGenerativeAiAgentToolToolConfig), fullyQualifiedName: "oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfig")]
    public interface IGenerativeAiAgentToolToolConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#tool_config_type GenerativeAiAgentTool#tool_config_type}.</summary>
        [JsiiProperty(name: "toolConfigType", typeJson: "{\"primitive\":\"string\"}")]
        string ToolConfigType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#agent_endpoint_id GenerativeAiAgentTool#agent_endpoint_id}.</summary>
        [JsiiProperty(name: "agentEndpointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AgentEndpointId
        {
            get
            {
                return null;
            }
        }

        /// <summary>api_schema block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#api_schema GenerativeAiAgentTool#api_schema}
        /// </remarks>
        [JsiiProperty(name: "apiSchema", typeJson: "{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigApiSchema\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigApiSchema? ApiSchema
        {
            get
            {
                return null;
            }
        }

        /// <summary>database_connection block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#database_connection GenerativeAiAgentTool#database_connection}
        /// </remarks>
        [JsiiProperty(name: "databaseConnection", typeJson: "{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigDatabaseConnection\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigDatabaseConnection? DatabaseConnection
        {
            get
            {
                return null;
            }
        }

        /// <summary>database_schema block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#database_schema GenerativeAiAgentTool#database_schema}
        /// </remarks>
        [JsiiProperty(name: "databaseSchema", typeJson: "{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigDatabaseSchema\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigDatabaseSchema? DatabaseSchema
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#dialect GenerativeAiAgentTool#dialect}.</summary>
        [JsiiProperty(name: "dialect", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Dialect
        {
            get
            {
                return null;
            }
        }

        /// <summary>function block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#function GenerativeAiAgentTool#function}
        /// </remarks>
        [JsiiProperty(name: "function", typeJson: "{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigFunction\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigFunction? Function
        {
            get
            {
                return null;
            }
        }

        /// <summary>generation_llm_customization block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#generation_llm_customization GenerativeAiAgentTool#generation_llm_customization}
        /// </remarks>
        [JsiiProperty(name: "generationLlmCustomization", typeJson: "{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigGenerationLlmCustomization\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigGenerationLlmCustomization? GenerationLlmCustomization
        {
            get
            {
                return null;
            }
        }

        /// <summary>http_endpoint_auth_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#http_endpoint_auth_config GenerativeAiAgentTool#http_endpoint_auth_config}
        /// </remarks>
        [JsiiProperty(name: "httpEndpointAuthConfig", typeJson: "{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigHttpEndpointAuthConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigHttpEndpointAuthConfig? HttpEndpointAuthConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>icl_examples block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#icl_examples GenerativeAiAgentTool#icl_examples}
        /// </remarks>
        [JsiiProperty(name: "iclExamples", typeJson: "{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigIclExamples\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigIclExamples? IclExamples
        {
            get
            {
                return null;
            }
        }

        /// <summary>knowledge_base_configs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#knowledge_base_configs GenerativeAiAgentTool#knowledge_base_configs}
        /// </remarks>
        [JsiiProperty(name: "knowledgeBaseConfigs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigKnowledgeBaseConfigs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? KnowledgeBaseConfigs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#model_size GenerativeAiAgentTool#model_size}.</summary>
        [JsiiProperty(name: "modelSize", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ModelSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#should_enable_self_correction GenerativeAiAgentTool#should_enable_self_correction}.</summary>
        [JsiiProperty(name: "shouldEnableSelfCorrection", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ShouldEnableSelfCorrection
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#should_enable_sql_execution GenerativeAiAgentTool#should_enable_sql_execution}.</summary>
        [JsiiProperty(name: "shouldEnableSqlExecution", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ShouldEnableSqlExecution
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#subnet_id GenerativeAiAgentTool#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SubnetId
        {
            get
            {
                return null;
            }
        }

        /// <summary>table_and_column_description block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#table_and_column_description GenerativeAiAgentTool#table_and_column_description}
        /// </remarks>
        [JsiiProperty(name: "tableAndColumnDescription", typeJson: "{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigTableAndColumnDescription\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigTableAndColumnDescription? TableAndColumnDescription
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGenerativeAiAgentToolToolConfig), fullyQualifiedName: "oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfig")]
        internal sealed class _Proxy : DeputyBase, oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#tool_config_type GenerativeAiAgentTool#tool_config_type}.</summary>
            [JsiiProperty(name: "toolConfigType", typeJson: "{\"primitive\":\"string\"}")]
            public string ToolConfigType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#agent_endpoint_id GenerativeAiAgentTool#agent_endpoint_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "agentEndpointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AgentEndpointId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>api_schema block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#api_schema GenerativeAiAgentTool#api_schema}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "apiSchema", typeJson: "{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigApiSchema\"}", isOptional: true)]
            public oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigApiSchema? ApiSchema
            {
                get => GetInstanceProperty<oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigApiSchema?>();
            }

            /// <summary>database_connection block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#database_connection GenerativeAiAgentTool#database_connection}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "databaseConnection", typeJson: "{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigDatabaseConnection\"}", isOptional: true)]
            public oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigDatabaseConnection? DatabaseConnection
            {
                get => GetInstanceProperty<oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigDatabaseConnection?>();
            }

            /// <summary>database_schema block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#database_schema GenerativeAiAgentTool#database_schema}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "databaseSchema", typeJson: "{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigDatabaseSchema\"}", isOptional: true)]
            public oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigDatabaseSchema? DatabaseSchema
            {
                get => GetInstanceProperty<oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigDatabaseSchema?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#dialect GenerativeAiAgentTool#dialect}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dialect", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Dialect
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>function block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#function GenerativeAiAgentTool#function}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "function", typeJson: "{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigFunction\"}", isOptional: true)]
            public oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigFunction? Function
            {
                get => GetInstanceProperty<oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigFunction?>();
            }

            /// <summary>generation_llm_customization block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#generation_llm_customization GenerativeAiAgentTool#generation_llm_customization}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "generationLlmCustomization", typeJson: "{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigGenerationLlmCustomization\"}", isOptional: true)]
            public oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigGenerationLlmCustomization? GenerationLlmCustomization
            {
                get => GetInstanceProperty<oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigGenerationLlmCustomization?>();
            }

            /// <summary>http_endpoint_auth_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#http_endpoint_auth_config GenerativeAiAgentTool#http_endpoint_auth_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpEndpointAuthConfig", typeJson: "{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigHttpEndpointAuthConfig\"}", isOptional: true)]
            public oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigHttpEndpointAuthConfig? HttpEndpointAuthConfig
            {
                get => GetInstanceProperty<oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigHttpEndpointAuthConfig?>();
            }

            /// <summary>icl_examples block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#icl_examples GenerativeAiAgentTool#icl_examples}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "iclExamples", typeJson: "{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigIclExamples\"}", isOptional: true)]
            public oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigIclExamples? IclExamples
            {
                get => GetInstanceProperty<oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigIclExamples?>();
            }

            /// <summary>knowledge_base_configs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#knowledge_base_configs GenerativeAiAgentTool#knowledge_base_configs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "knowledgeBaseConfigs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigKnowledgeBaseConfigs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? KnowledgeBaseConfigs
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#model_size GenerativeAiAgentTool#model_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "modelSize", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ModelSize
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#should_enable_self_correction GenerativeAiAgentTool#should_enable_self_correction}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "shouldEnableSelfCorrection", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ShouldEnableSelfCorrection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#should_enable_sql_execution GenerativeAiAgentTool#should_enable_sql_execution}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "shouldEnableSqlExecution", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ShouldEnableSqlExecution
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#subnet_id GenerativeAiAgentTool#subnet_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SubnetId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>table_and_column_description block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#table_and_column_description GenerativeAiAgentTool#table_and_column_description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tableAndColumnDescription", typeJson: "{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigTableAndColumnDescription\"}", isOptional: true)]
            public oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigTableAndColumnDescription? TableAndColumnDescription
            {
                get => GetInstanceProperty<oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigTableAndColumnDescription?>();
            }
        }
    }
}
