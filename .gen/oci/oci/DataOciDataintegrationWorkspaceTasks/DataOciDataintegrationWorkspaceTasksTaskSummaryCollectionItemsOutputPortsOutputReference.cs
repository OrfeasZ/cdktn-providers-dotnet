using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataintegrationWorkspaceTasks
{
    [JsiiClass(nativeType: typeof(oci.DataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsOutputPortsOutputReference), fullyQualifiedName: "oci.dataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsOutputPortsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsOutputPortsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsOutputPortsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsOutputPortsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsOutputPortsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "configValues", typeJson: "{\"fqn\":\"oci.dataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsOutputPortsConfigValuesList\"}")]
        public virtual oci.DataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsOutputPortsConfigValuesList ConfigValues
        {
            get => GetInstanceProperty<oci.DataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsOutputPortsConfigValuesList>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "fields", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Fields
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Key
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "parentRef", typeJson: "{\"fqn\":\"oci.dataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsOutputPortsParentRefList\"}")]
        public virtual oci.DataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsOutputPortsParentRefList ParentRef
        {
            get => GetInstanceProperty<oci.DataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsOutputPortsParentRefList>()!;
        }

        [JsiiProperty(name: "portType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PortType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsOutputPorts\"}", isOptional: true)]
        public virtual oci.DataOciDataintegrationWorkspaceTasks.IDataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsOutputPorts? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDataintegrationWorkspaceTasks.IDataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsOutputPorts?>();
            set => SetInstanceProperty(value);
        }
    }
}
