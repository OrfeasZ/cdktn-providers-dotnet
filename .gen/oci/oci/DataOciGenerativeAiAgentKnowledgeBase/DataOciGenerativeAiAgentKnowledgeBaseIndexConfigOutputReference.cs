using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciGenerativeAiAgentKnowledgeBase
{
    [JsiiClass(nativeType: typeof(oci.DataOciGenerativeAiAgentKnowledgeBase.DataOciGenerativeAiAgentKnowledgeBaseIndexConfigOutputReference), fullyQualifiedName: "oci.dataOciGenerativeAiAgentKnowledgeBase.DataOciGenerativeAiAgentKnowledgeBaseIndexConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciGenerativeAiAgentKnowledgeBaseIndexConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciGenerativeAiAgentKnowledgeBaseIndexConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciGenerativeAiAgentKnowledgeBaseIndexConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciGenerativeAiAgentKnowledgeBaseIndexConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "clusterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseConnection", typeJson: "{\"fqn\":\"oci.dataOciGenerativeAiAgentKnowledgeBase.DataOciGenerativeAiAgentKnowledgeBaseIndexConfigDatabaseConnectionList\"}")]
        public virtual oci.DataOciGenerativeAiAgentKnowledgeBase.DataOciGenerativeAiAgentKnowledgeBaseIndexConfigDatabaseConnectionList DatabaseConnection
        {
            get => GetInstanceProperty<oci.DataOciGenerativeAiAgentKnowledgeBase.DataOciGenerativeAiAgentKnowledgeBaseIndexConfigDatabaseConnectionList>()!;
        }

        [JsiiProperty(name: "databaseFunctions", typeJson: "{\"fqn\":\"oci.dataOciGenerativeAiAgentKnowledgeBase.DataOciGenerativeAiAgentKnowledgeBaseIndexConfigDatabaseFunctionsList\"}")]
        public virtual oci.DataOciGenerativeAiAgentKnowledgeBase.DataOciGenerativeAiAgentKnowledgeBaseIndexConfigDatabaseFunctionsList DatabaseFunctions
        {
            get => GetInstanceProperty<oci.DataOciGenerativeAiAgentKnowledgeBase.DataOciGenerativeAiAgentKnowledgeBaseIndexConfigDatabaseFunctionsList>()!;
        }

        [JsiiProperty(name: "indexConfigType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IndexConfigType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "indexes", typeJson: "{\"fqn\":\"oci.dataOciGenerativeAiAgentKnowledgeBase.DataOciGenerativeAiAgentKnowledgeBaseIndexConfigIndexesList\"}")]
        public virtual oci.DataOciGenerativeAiAgentKnowledgeBase.DataOciGenerativeAiAgentKnowledgeBaseIndexConfigIndexesList Indexes
        {
            get => GetInstanceProperty<oci.DataOciGenerativeAiAgentKnowledgeBase.DataOciGenerativeAiAgentKnowledgeBaseIndexConfigIndexesList>()!;
        }

        [JsiiProperty(name: "secretDetail", typeJson: "{\"fqn\":\"oci.dataOciGenerativeAiAgentKnowledgeBase.DataOciGenerativeAiAgentKnowledgeBaseIndexConfigSecretDetailList\"}")]
        public virtual oci.DataOciGenerativeAiAgentKnowledgeBase.DataOciGenerativeAiAgentKnowledgeBaseIndexConfigSecretDetailList SecretDetail
        {
            get => GetInstanceProperty<oci.DataOciGenerativeAiAgentKnowledgeBase.DataOciGenerativeAiAgentKnowledgeBaseIndexConfigSecretDetailList>()!;
        }

        [JsiiProperty(name: "shouldEnableHybridSearch", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ShouldEnableHybridSearch
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciGenerativeAiAgentKnowledgeBase.DataOciGenerativeAiAgentKnowledgeBaseIndexConfig\"}", isOptional: true)]
        public virtual oci.DataOciGenerativeAiAgentKnowledgeBase.IDataOciGenerativeAiAgentKnowledgeBaseIndexConfig? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciGenerativeAiAgentKnowledgeBase.IDataOciGenerativeAiAgentKnowledgeBaseIndexConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
