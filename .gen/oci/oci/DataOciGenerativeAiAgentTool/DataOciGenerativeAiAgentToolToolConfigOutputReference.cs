using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciGenerativeAiAgentTool
{
    [JsiiClass(nativeType: typeof(oci.DataOciGenerativeAiAgentTool.DataOciGenerativeAiAgentToolToolConfigOutputReference), fullyQualifiedName: "oci.dataOciGenerativeAiAgentTool.DataOciGenerativeAiAgentToolToolConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciGenerativeAiAgentToolToolConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciGenerativeAiAgentToolToolConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciGenerativeAiAgentToolToolConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciGenerativeAiAgentToolToolConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "agentEndpointId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AgentEndpointId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "apiSchema", typeJson: "{\"fqn\":\"oci.dataOciGenerativeAiAgentTool.DataOciGenerativeAiAgentToolToolConfigApiSchemaList\"}")]
        public virtual oci.DataOciGenerativeAiAgentTool.DataOciGenerativeAiAgentToolToolConfigApiSchemaList ApiSchema
        {
            get => GetInstanceProperty<oci.DataOciGenerativeAiAgentTool.DataOciGenerativeAiAgentToolToolConfigApiSchemaList>()!;
        }

        [JsiiProperty(name: "databaseConnection", typeJson: "{\"fqn\":\"oci.dataOciGenerativeAiAgentTool.DataOciGenerativeAiAgentToolToolConfigDatabaseConnectionList\"}")]
        public virtual oci.DataOciGenerativeAiAgentTool.DataOciGenerativeAiAgentToolToolConfigDatabaseConnectionList DatabaseConnection
        {
            get => GetInstanceProperty<oci.DataOciGenerativeAiAgentTool.DataOciGenerativeAiAgentToolToolConfigDatabaseConnectionList>()!;
        }

        [JsiiProperty(name: "databaseSchema", typeJson: "{\"fqn\":\"oci.dataOciGenerativeAiAgentTool.DataOciGenerativeAiAgentToolToolConfigDatabaseSchemaList\"}")]
        public virtual oci.DataOciGenerativeAiAgentTool.DataOciGenerativeAiAgentToolToolConfigDatabaseSchemaList DatabaseSchema
        {
            get => GetInstanceProperty<oci.DataOciGenerativeAiAgentTool.DataOciGenerativeAiAgentToolToolConfigDatabaseSchemaList>()!;
        }

        [JsiiProperty(name: "dialect", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Dialect
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "function", typeJson: "{\"fqn\":\"oci.dataOciGenerativeAiAgentTool.DataOciGenerativeAiAgentToolToolConfigFunctionList\"}")]
        public virtual oci.DataOciGenerativeAiAgentTool.DataOciGenerativeAiAgentToolToolConfigFunctionList Function
        {
            get => GetInstanceProperty<oci.DataOciGenerativeAiAgentTool.DataOciGenerativeAiAgentToolToolConfigFunctionList>()!;
        }

        [JsiiProperty(name: "generationLlmCustomization", typeJson: "{\"fqn\":\"oci.dataOciGenerativeAiAgentTool.DataOciGenerativeAiAgentToolToolConfigGenerationLlmCustomizationList\"}")]
        public virtual oci.DataOciGenerativeAiAgentTool.DataOciGenerativeAiAgentToolToolConfigGenerationLlmCustomizationList GenerationLlmCustomization
        {
            get => GetInstanceProperty<oci.DataOciGenerativeAiAgentTool.DataOciGenerativeAiAgentToolToolConfigGenerationLlmCustomizationList>()!;
        }

        [JsiiProperty(name: "httpEndpointAuthConfig", typeJson: "{\"fqn\":\"oci.dataOciGenerativeAiAgentTool.DataOciGenerativeAiAgentToolToolConfigHttpEndpointAuthConfigList\"}")]
        public virtual oci.DataOciGenerativeAiAgentTool.DataOciGenerativeAiAgentToolToolConfigHttpEndpointAuthConfigList HttpEndpointAuthConfig
        {
            get => GetInstanceProperty<oci.DataOciGenerativeAiAgentTool.DataOciGenerativeAiAgentToolToolConfigHttpEndpointAuthConfigList>()!;
        }

        [JsiiProperty(name: "iclExamples", typeJson: "{\"fqn\":\"oci.dataOciGenerativeAiAgentTool.DataOciGenerativeAiAgentToolToolConfigIclExamplesList\"}")]
        public virtual oci.DataOciGenerativeAiAgentTool.DataOciGenerativeAiAgentToolToolConfigIclExamplesList IclExamples
        {
            get => GetInstanceProperty<oci.DataOciGenerativeAiAgentTool.DataOciGenerativeAiAgentToolToolConfigIclExamplesList>()!;
        }

        [JsiiProperty(name: "knowledgeBaseConfigs", typeJson: "{\"fqn\":\"oci.dataOciGenerativeAiAgentTool.DataOciGenerativeAiAgentToolToolConfigKnowledgeBaseConfigsList\"}")]
        public virtual oci.DataOciGenerativeAiAgentTool.DataOciGenerativeAiAgentToolToolConfigKnowledgeBaseConfigsList KnowledgeBaseConfigs
        {
            get => GetInstanceProperty<oci.DataOciGenerativeAiAgentTool.DataOciGenerativeAiAgentToolToolConfigKnowledgeBaseConfigsList>()!;
        }

        [JsiiProperty(name: "modelSize", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelSize
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "shouldEnableSelfCorrection", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ShouldEnableSelfCorrection
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "shouldEnableSqlExecution", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ShouldEnableSqlExecution
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tableAndColumnDescription", typeJson: "{\"fqn\":\"oci.dataOciGenerativeAiAgentTool.DataOciGenerativeAiAgentToolToolConfigTableAndColumnDescriptionList\"}")]
        public virtual oci.DataOciGenerativeAiAgentTool.DataOciGenerativeAiAgentToolToolConfigTableAndColumnDescriptionList TableAndColumnDescription
        {
            get => GetInstanceProperty<oci.DataOciGenerativeAiAgentTool.DataOciGenerativeAiAgentToolToolConfigTableAndColumnDescriptionList>()!;
        }

        [JsiiProperty(name: "toolConfigType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ToolConfigType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciGenerativeAiAgentTool.DataOciGenerativeAiAgentToolToolConfig\"}", isOptional: true)]
        public virtual oci.DataOciGenerativeAiAgentTool.IDataOciGenerativeAiAgentToolToolConfig? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciGenerativeAiAgentTool.IDataOciGenerativeAiAgentToolToolConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
