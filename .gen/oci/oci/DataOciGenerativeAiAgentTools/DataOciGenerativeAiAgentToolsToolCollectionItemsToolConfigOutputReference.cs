using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciGenerativeAiAgentTools
{
    [JsiiClass(nativeType: typeof(oci.DataOciGenerativeAiAgentTools.DataOciGenerativeAiAgentToolsToolCollectionItemsToolConfigOutputReference), fullyQualifiedName: "oci.dataOciGenerativeAiAgentTools.DataOciGenerativeAiAgentToolsToolCollectionItemsToolConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciGenerativeAiAgentToolsToolCollectionItemsToolConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciGenerativeAiAgentToolsToolCollectionItemsToolConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciGenerativeAiAgentToolsToolCollectionItemsToolConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciGenerativeAiAgentToolsToolCollectionItemsToolConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "agentEndpointId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AgentEndpointId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "apiSchema", typeJson: "{\"fqn\":\"oci.dataOciGenerativeAiAgentTools.DataOciGenerativeAiAgentToolsToolCollectionItemsToolConfigApiSchemaList\"}")]
        public virtual oci.DataOciGenerativeAiAgentTools.DataOciGenerativeAiAgentToolsToolCollectionItemsToolConfigApiSchemaList ApiSchema
        {
            get => GetInstanceProperty<oci.DataOciGenerativeAiAgentTools.DataOciGenerativeAiAgentToolsToolCollectionItemsToolConfigApiSchemaList>()!;
        }

        [JsiiProperty(name: "databaseConnection", typeJson: "{\"fqn\":\"oci.dataOciGenerativeAiAgentTools.DataOciGenerativeAiAgentToolsToolCollectionItemsToolConfigDatabaseConnectionList\"}")]
        public virtual oci.DataOciGenerativeAiAgentTools.DataOciGenerativeAiAgentToolsToolCollectionItemsToolConfigDatabaseConnectionList DatabaseConnection
        {
            get => GetInstanceProperty<oci.DataOciGenerativeAiAgentTools.DataOciGenerativeAiAgentToolsToolCollectionItemsToolConfigDatabaseConnectionList>()!;
        }

        [JsiiProperty(name: "databaseSchema", typeJson: "{\"fqn\":\"oci.dataOciGenerativeAiAgentTools.DataOciGenerativeAiAgentToolsToolCollectionItemsToolConfigDatabaseSchemaList\"}")]
        public virtual oci.DataOciGenerativeAiAgentTools.DataOciGenerativeAiAgentToolsToolCollectionItemsToolConfigDatabaseSchemaList DatabaseSchema
        {
            get => GetInstanceProperty<oci.DataOciGenerativeAiAgentTools.DataOciGenerativeAiAgentToolsToolCollectionItemsToolConfigDatabaseSchemaList>()!;
        }

        [JsiiProperty(name: "dialect", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Dialect
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "function", typeJson: "{\"fqn\":\"oci.dataOciGenerativeAiAgentTools.DataOciGenerativeAiAgentToolsToolCollectionItemsToolConfigFunctionList\"}")]
        public virtual oci.DataOciGenerativeAiAgentTools.DataOciGenerativeAiAgentToolsToolCollectionItemsToolConfigFunctionList Function
        {
            get => GetInstanceProperty<oci.DataOciGenerativeAiAgentTools.DataOciGenerativeAiAgentToolsToolCollectionItemsToolConfigFunctionList>()!;
        }

        [JsiiProperty(name: "generationLlmCustomization", typeJson: "{\"fqn\":\"oci.dataOciGenerativeAiAgentTools.DataOciGenerativeAiAgentToolsToolCollectionItemsToolConfigGenerationLlmCustomizationList\"}")]
        public virtual oci.DataOciGenerativeAiAgentTools.DataOciGenerativeAiAgentToolsToolCollectionItemsToolConfigGenerationLlmCustomizationList GenerationLlmCustomization
        {
            get => GetInstanceProperty<oci.DataOciGenerativeAiAgentTools.DataOciGenerativeAiAgentToolsToolCollectionItemsToolConfigGenerationLlmCustomizationList>()!;
        }

        [JsiiProperty(name: "httpEndpointAuthConfig", typeJson: "{\"fqn\":\"oci.dataOciGenerativeAiAgentTools.DataOciGenerativeAiAgentToolsToolCollectionItemsToolConfigHttpEndpointAuthConfigList\"}")]
        public virtual oci.DataOciGenerativeAiAgentTools.DataOciGenerativeAiAgentToolsToolCollectionItemsToolConfigHttpEndpointAuthConfigList HttpEndpointAuthConfig
        {
            get => GetInstanceProperty<oci.DataOciGenerativeAiAgentTools.DataOciGenerativeAiAgentToolsToolCollectionItemsToolConfigHttpEndpointAuthConfigList>()!;
        }

        [JsiiProperty(name: "iclExamples", typeJson: "{\"fqn\":\"oci.dataOciGenerativeAiAgentTools.DataOciGenerativeAiAgentToolsToolCollectionItemsToolConfigIclExamplesList\"}")]
        public virtual oci.DataOciGenerativeAiAgentTools.DataOciGenerativeAiAgentToolsToolCollectionItemsToolConfigIclExamplesList IclExamples
        {
            get => GetInstanceProperty<oci.DataOciGenerativeAiAgentTools.DataOciGenerativeAiAgentToolsToolCollectionItemsToolConfigIclExamplesList>()!;
        }

        [JsiiProperty(name: "knowledgeBaseConfigs", typeJson: "{\"fqn\":\"oci.dataOciGenerativeAiAgentTools.DataOciGenerativeAiAgentToolsToolCollectionItemsToolConfigKnowledgeBaseConfigsList\"}")]
        public virtual oci.DataOciGenerativeAiAgentTools.DataOciGenerativeAiAgentToolsToolCollectionItemsToolConfigKnowledgeBaseConfigsList KnowledgeBaseConfigs
        {
            get => GetInstanceProperty<oci.DataOciGenerativeAiAgentTools.DataOciGenerativeAiAgentToolsToolCollectionItemsToolConfigKnowledgeBaseConfigsList>()!;
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

        [JsiiProperty(name: "tableAndColumnDescription", typeJson: "{\"fqn\":\"oci.dataOciGenerativeAiAgentTools.DataOciGenerativeAiAgentToolsToolCollectionItemsToolConfigTableAndColumnDescriptionList\"}")]
        public virtual oci.DataOciGenerativeAiAgentTools.DataOciGenerativeAiAgentToolsToolCollectionItemsToolConfigTableAndColumnDescriptionList TableAndColumnDescription
        {
            get => GetInstanceProperty<oci.DataOciGenerativeAiAgentTools.DataOciGenerativeAiAgentToolsToolCollectionItemsToolConfigTableAndColumnDescriptionList>()!;
        }

        [JsiiProperty(name: "toolConfigType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ToolConfigType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciGenerativeAiAgentTools.DataOciGenerativeAiAgentToolsToolCollectionItemsToolConfig\"}", isOptional: true)]
        public virtual oci.DataOciGenerativeAiAgentTools.IDataOciGenerativeAiAgentToolsToolCollectionItemsToolConfig? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciGenerativeAiAgentTools.IDataOciGenerativeAiAgentToolsToolCollectionItemsToolConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
