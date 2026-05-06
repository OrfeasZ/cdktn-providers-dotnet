using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataintegrationWorkspaceTasks
{
    [JsiiClass(nativeType: typeof(oci.DataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "apiCallMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApiCallMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "authConfig", typeJson: "{\"fqn\":\"oci.dataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsAuthConfigList\"}")]
        public virtual oci.DataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsAuthConfigList AuthConfig
        {
            get => GetInstanceProperty<oci.DataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsAuthConfigList>()!;
        }

        [JsiiProperty(name: "cancelRestCallConfig", typeJson: "{\"fqn\":\"oci.dataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsCancelRestCallConfigList\"}")]
        public virtual oci.DataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsCancelRestCallConfigList CancelRestCallConfig
        {
            get => GetInstanceProperty<oci.DataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsCancelRestCallConfigList>()!;
        }

        [JsiiProperty(name: "configProviderDelegate", typeJson: "{\"fqn\":\"oci.dataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsConfigProviderDelegateList\"}")]
        public virtual oci.DataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsConfigProviderDelegateList ConfigProviderDelegate
        {
            get => GetInstanceProperty<oci.DataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsConfigProviderDelegateList>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "executeRestCallConfig", typeJson: "{\"fqn\":\"oci.dataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsExecuteRestCallConfigList\"}")]
        public virtual oci.DataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsExecuteRestCallConfigList ExecuteRestCallConfig
        {
            get => GetInstanceProperty<oci.DataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsExecuteRestCallConfigList>()!;
        }

        [JsiiProperty(name: "identifier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Identifier
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "inputPorts", typeJson: "{\"fqn\":\"oci.dataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsInputPortsList\"}")]
        public virtual oci.DataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsInputPortsList InputPorts
        {
            get => GetInstanceProperty<oci.DataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsInputPortsList>()!;
        }

        [JsiiProperty(name: "isSingleLoad", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsSingleLoad
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Key
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "keyMap", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap KeyMap
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"oci.dataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsMetadataList\"}")]
        public virtual oci.DataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsMetadataList Metadata
        {
            get => GetInstanceProperty<oci.DataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsMetadataList>()!;
        }

        [JsiiProperty(name: "modelType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "modelVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "objectStatus", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ObjectStatus
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "objectVersion", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ObjectVersion
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "opConfigValues", typeJson: "{\"fqn\":\"oci.dataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsOpConfigValuesList\"}")]
        public virtual oci.DataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsOpConfigValuesList OpConfigValues
        {
            get => GetInstanceProperty<oci.DataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsOpConfigValuesList>()!;
        }

        [JsiiProperty(name: "operation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Operation
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "outputPorts", typeJson: "{\"fqn\":\"oci.dataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsOutputPortsList\"}")]
        public virtual oci.DataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsOutputPortsList OutputPorts
        {
            get => GetInstanceProperty<oci.DataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsOutputPortsList>()!;
        }

        [JsiiProperty(name: "parallelLoadLimit", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ParallelLoadLimit
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "parameters", typeJson: "{\"fqn\":\"oci.dataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsParametersList\"}")]
        public virtual oci.DataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsParametersList Parameters
        {
            get => GetInstanceProperty<oci.DataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsParametersList>()!;
        }

        [JsiiProperty(name: "parentRef", typeJson: "{\"fqn\":\"oci.dataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsParentRefList\"}")]
        public virtual oci.DataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsParentRefList ParentRef
        {
            get => GetInstanceProperty<oci.DataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsParentRefList>()!;
        }

        [JsiiProperty(name: "pollRestCallConfig", typeJson: "{\"fqn\":\"oci.dataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsPollRestCallConfigList\"}")]
        public virtual oci.DataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsPollRestCallConfigList PollRestCallConfig
        {
            get => GetInstanceProperty<oci.DataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsPollRestCallConfigList>()!;
        }

        [JsiiProperty(name: "registryMetadata", typeJson: "{\"fqn\":\"oci.dataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsRegistryMetadataList\"}")]
        public virtual oci.DataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsRegistryMetadataList RegistryMetadata
        {
            get => GetInstanceProperty<oci.DataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsRegistryMetadataList>()!;
        }

        [JsiiProperty(name: "typedExpressions", typeJson: "{\"fqn\":\"oci.dataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsTypedExpressionsList\"}")]
        public virtual oci.DataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsTypedExpressionsList TypedExpressions
        {
            get => GetInstanceProperty<oci.DataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsTypedExpressionsList>()!;
        }

        [JsiiProperty(name: "workspaceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkspaceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciDataintegrationWorkspaceTasks.IDataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDataintegrationWorkspaceTasks.IDataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
