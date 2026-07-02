using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciGenerativeAiProjects
{
    [JsiiClass(nativeType: typeof(oci.DataOciGenerativeAiProjects.DataOciGenerativeAiProjectsGenerativeAiProjectCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciGenerativeAiProjects.DataOciGenerativeAiProjectsGenerativeAiProjectCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciGenerativeAiProjectsGenerativeAiProjectCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciGenerativeAiProjectsGenerativeAiProjectCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciGenerativeAiProjectsGenerativeAiProjectCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciGenerativeAiProjectsGenerativeAiProjectCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "conversationConfig", typeJson: "{\"fqn\":\"oci.dataOciGenerativeAiProjects.DataOciGenerativeAiProjectsGenerativeAiProjectCollectionItemsConversationConfigList\"}")]
        public virtual oci.DataOciGenerativeAiProjects.DataOciGenerativeAiProjectsGenerativeAiProjectCollectionItemsConversationConfigList ConversationConfig
        {
            get => GetInstanceProperty<oci.DataOciGenerativeAiProjects.DataOciGenerativeAiProjectsGenerativeAiProjectCollectionItemsConversationConfigList>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "longTermMemoryConfig", typeJson: "{\"fqn\":\"oci.dataOciGenerativeAiProjects.DataOciGenerativeAiProjectsGenerativeAiProjectCollectionItemsLongTermMemoryConfigList\"}")]
        public virtual oci.DataOciGenerativeAiProjects.DataOciGenerativeAiProjectsGenerativeAiProjectCollectionItemsLongTermMemoryConfigList LongTermMemoryConfig
        {
            get => GetInstanceProperty<oci.DataOciGenerativeAiProjects.DataOciGenerativeAiProjectsGenerativeAiProjectCollectionItemsLongTermMemoryConfigList>()!;
        }

        [JsiiProperty(name: "shortTermMemoryOptimizationConfig", typeJson: "{\"fqn\":\"oci.dataOciGenerativeAiProjects.DataOciGenerativeAiProjectsGenerativeAiProjectCollectionItemsShortTermMemoryOptimizationConfigList\"}")]
        public virtual oci.DataOciGenerativeAiProjects.DataOciGenerativeAiProjectsGenerativeAiProjectCollectionItemsShortTermMemoryOptimizationConfigList ShortTermMemoryOptimizationConfig
        {
            get => GetInstanceProperty<oci.DataOciGenerativeAiProjects.DataOciGenerativeAiProjectsGenerativeAiProjectCollectionItemsShortTermMemoryOptimizationConfigList>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciGenerativeAiProjects.DataOciGenerativeAiProjectsGenerativeAiProjectCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciGenerativeAiProjects.IDataOciGenerativeAiProjectsGenerativeAiProjectCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciGenerativeAiProjects.IDataOciGenerativeAiProjectsGenerativeAiProjectCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
