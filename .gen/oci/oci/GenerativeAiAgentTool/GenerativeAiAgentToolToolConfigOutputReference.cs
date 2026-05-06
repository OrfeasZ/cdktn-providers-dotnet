using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiAgentTool
{
    [JsiiClass(nativeType: typeof(oci.GenerativeAiAgentTool.GenerativeAiAgentToolToolConfigOutputReference), fullyQualifiedName: "oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class GenerativeAiAgentToolToolConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public GenerativeAiAgentToolToolConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GenerativeAiAgentToolToolConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GenerativeAiAgentToolToolConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putApiSchema", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigApiSchema\"}}]")]
        public virtual void PutApiSchema(oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigApiSchema @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigApiSchema)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDatabaseConnection", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigDatabaseConnection\"}}]")]
        public virtual void PutDatabaseConnection(oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigDatabaseConnection @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigDatabaseConnection)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDatabaseSchema", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigDatabaseSchema\"}}]")]
        public virtual void PutDatabaseSchema(oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigDatabaseSchema @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigDatabaseSchema)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFunction", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigFunction\"}}]")]
        public virtual void PutFunction(oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigFunction @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigFunction)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGenerationLlmCustomization", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigGenerationLlmCustomization\"}}]")]
        public virtual void PutGenerationLlmCustomization(oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigGenerationLlmCustomization @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigGenerationLlmCustomization)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHttpEndpointAuthConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigHttpEndpointAuthConfig\"}}]")]
        public virtual void PutHttpEndpointAuthConfig(oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigHttpEndpointAuthConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigHttpEndpointAuthConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIclExamples", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigIclExamples\"}}]")]
        public virtual void PutIclExamples(oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigIclExamples @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigIclExamples)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKnowledgeBaseConfigs", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigKnowledgeBaseConfigs\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutKnowledgeBaseConfigs(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigKnowledgeBaseConfigs[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigKnowledgeBaseConfigs).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigKnowledgeBaseConfigs).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTableAndColumnDescription", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigTableAndColumnDescription\"}}]")]
        public virtual void PutTableAndColumnDescription(oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigTableAndColumnDescription @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigTableAndColumnDescription)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAgentEndpointId")]
        public virtual void ResetAgentEndpointId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetApiSchema")]
        public virtual void ResetApiSchema()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDatabaseConnection")]
        public virtual void ResetDatabaseConnection()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDatabaseSchema")]
        public virtual void ResetDatabaseSchema()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDialect")]
        public virtual void ResetDialect()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFunction")]
        public virtual void ResetFunction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGenerationLlmCustomization")]
        public virtual void ResetGenerationLlmCustomization()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttpEndpointAuthConfig")]
        public virtual void ResetHttpEndpointAuthConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIclExamples")]
        public virtual void ResetIclExamples()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKnowledgeBaseConfigs")]
        public virtual void ResetKnowledgeBaseConfigs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetModelSize")]
        public virtual void ResetModelSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetShouldEnableSelfCorrection")]
        public virtual void ResetShouldEnableSelfCorrection()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetShouldEnableSqlExecution")]
        public virtual void ResetShouldEnableSqlExecution()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSubnetId")]
        public virtual void ResetSubnetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTableAndColumnDescription")]
        public virtual void ResetTableAndColumnDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "apiSchema", typeJson: "{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigApiSchemaOutputReference\"}")]
        public virtual oci.GenerativeAiAgentTool.GenerativeAiAgentToolToolConfigApiSchemaOutputReference ApiSchema
        {
            get => GetInstanceProperty<oci.GenerativeAiAgentTool.GenerativeAiAgentToolToolConfigApiSchemaOutputReference>()!;
        }

        [JsiiProperty(name: "databaseConnection", typeJson: "{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigDatabaseConnectionOutputReference\"}")]
        public virtual oci.GenerativeAiAgentTool.GenerativeAiAgentToolToolConfigDatabaseConnectionOutputReference DatabaseConnection
        {
            get => GetInstanceProperty<oci.GenerativeAiAgentTool.GenerativeAiAgentToolToolConfigDatabaseConnectionOutputReference>()!;
        }

        [JsiiProperty(name: "databaseSchema", typeJson: "{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigDatabaseSchemaOutputReference\"}")]
        public virtual oci.GenerativeAiAgentTool.GenerativeAiAgentToolToolConfigDatabaseSchemaOutputReference DatabaseSchema
        {
            get => GetInstanceProperty<oci.GenerativeAiAgentTool.GenerativeAiAgentToolToolConfigDatabaseSchemaOutputReference>()!;
        }

        [JsiiProperty(name: "function", typeJson: "{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigFunctionOutputReference\"}")]
        public virtual oci.GenerativeAiAgentTool.GenerativeAiAgentToolToolConfigFunctionOutputReference Function
        {
            get => GetInstanceProperty<oci.GenerativeAiAgentTool.GenerativeAiAgentToolToolConfigFunctionOutputReference>()!;
        }

        [JsiiProperty(name: "generationLlmCustomization", typeJson: "{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigGenerationLlmCustomizationOutputReference\"}")]
        public virtual oci.GenerativeAiAgentTool.GenerativeAiAgentToolToolConfigGenerationLlmCustomizationOutputReference GenerationLlmCustomization
        {
            get => GetInstanceProperty<oci.GenerativeAiAgentTool.GenerativeAiAgentToolToolConfigGenerationLlmCustomizationOutputReference>()!;
        }

        [JsiiProperty(name: "httpEndpointAuthConfig", typeJson: "{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigHttpEndpointAuthConfigOutputReference\"}")]
        public virtual oci.GenerativeAiAgentTool.GenerativeAiAgentToolToolConfigHttpEndpointAuthConfigOutputReference HttpEndpointAuthConfig
        {
            get => GetInstanceProperty<oci.GenerativeAiAgentTool.GenerativeAiAgentToolToolConfigHttpEndpointAuthConfigOutputReference>()!;
        }

        [JsiiProperty(name: "iclExamples", typeJson: "{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigIclExamplesOutputReference\"}")]
        public virtual oci.GenerativeAiAgentTool.GenerativeAiAgentToolToolConfigIclExamplesOutputReference IclExamples
        {
            get => GetInstanceProperty<oci.GenerativeAiAgentTool.GenerativeAiAgentToolToolConfigIclExamplesOutputReference>()!;
        }

        [JsiiProperty(name: "knowledgeBaseConfigs", typeJson: "{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigKnowledgeBaseConfigsList\"}")]
        public virtual oci.GenerativeAiAgentTool.GenerativeAiAgentToolToolConfigKnowledgeBaseConfigsList KnowledgeBaseConfigs
        {
            get => GetInstanceProperty<oci.GenerativeAiAgentTool.GenerativeAiAgentToolToolConfigKnowledgeBaseConfigsList>()!;
        }

        [JsiiProperty(name: "tableAndColumnDescription", typeJson: "{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigTableAndColumnDescriptionOutputReference\"}")]
        public virtual oci.GenerativeAiAgentTool.GenerativeAiAgentToolToolConfigTableAndColumnDescriptionOutputReference TableAndColumnDescription
        {
            get => GetInstanceProperty<oci.GenerativeAiAgentTool.GenerativeAiAgentToolToolConfigTableAndColumnDescriptionOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "agentEndpointIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AgentEndpointIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "apiSchemaInput", typeJson: "{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigApiSchema\"}", isOptional: true)]
        public virtual oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigApiSchema? ApiSchemaInput
        {
            get => GetInstanceProperty<oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigApiSchema?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "databaseConnectionInput", typeJson: "{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigDatabaseConnection\"}", isOptional: true)]
        public virtual oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigDatabaseConnection? DatabaseConnectionInput
        {
            get => GetInstanceProperty<oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigDatabaseConnection?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "databaseSchemaInput", typeJson: "{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigDatabaseSchema\"}", isOptional: true)]
        public virtual oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigDatabaseSchema? DatabaseSchemaInput
        {
            get => GetInstanceProperty<oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigDatabaseSchema?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dialectInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DialectInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "functionInput", typeJson: "{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigFunction\"}", isOptional: true)]
        public virtual oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigFunction? FunctionInput
        {
            get => GetInstanceProperty<oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigFunction?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "generationLlmCustomizationInput", typeJson: "{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigGenerationLlmCustomization\"}", isOptional: true)]
        public virtual oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigGenerationLlmCustomization? GenerationLlmCustomizationInput
        {
            get => GetInstanceProperty<oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigGenerationLlmCustomization?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpEndpointAuthConfigInput", typeJson: "{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigHttpEndpointAuthConfig\"}", isOptional: true)]
        public virtual oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigHttpEndpointAuthConfig? HttpEndpointAuthConfigInput
        {
            get => GetInstanceProperty<oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigHttpEndpointAuthConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "iclExamplesInput", typeJson: "{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigIclExamples\"}", isOptional: true)]
        public virtual oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigIclExamples? IclExamplesInput
        {
            get => GetInstanceProperty<oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigIclExamples?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "knowledgeBaseConfigsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigKnowledgeBaseConfigs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? KnowledgeBaseConfigsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "modelSizeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ModelSizeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "shouldEnableSelfCorrectionInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ShouldEnableSelfCorrectionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "shouldEnableSqlExecutionInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ShouldEnableSqlExecutionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subnetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubnetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tableAndColumnDescriptionInput", typeJson: "{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigTableAndColumnDescription\"}", isOptional: true)]
        public virtual oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigTableAndColumnDescription? TableAndColumnDescriptionInput
        {
            get => GetInstanceProperty<oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigTableAndColumnDescription?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "toolConfigTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ToolConfigTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "agentEndpointId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AgentEndpointId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dialect", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Dialect
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "modelSize", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelSize
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "shouldEnableSelfCorrection", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object ShouldEnableSelfCorrection
        {
            get => GetInstanceProperty<object>()!;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "shouldEnableSqlExecution", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object ShouldEnableSqlExecution
        {
            get => GetInstanceProperty<object>()!;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "toolConfigType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ToolConfigType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfig\"}", isOptional: true)]
        public virtual oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfig? InternalValue
        {
            get => GetInstanceProperty<oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
