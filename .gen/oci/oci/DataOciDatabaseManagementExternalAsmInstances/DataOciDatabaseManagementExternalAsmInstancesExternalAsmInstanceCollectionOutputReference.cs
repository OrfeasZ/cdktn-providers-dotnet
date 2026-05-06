using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseManagementExternalAsmInstances
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseManagementExternalAsmInstances.DataOciDatabaseManagementExternalAsmInstancesExternalAsmInstanceCollectionOutputReference), fullyQualifiedName: "oci.dataOciDatabaseManagementExternalAsmInstances.DataOciDatabaseManagementExternalAsmInstancesExternalAsmInstanceCollectionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseManagementExternalAsmInstancesExternalAsmInstanceCollectionOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseManagementExternalAsmInstancesExternalAsmInstanceCollectionOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseManagementExternalAsmInstancesExternalAsmInstanceCollectionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseManagementExternalAsmInstancesExternalAsmInstanceCollectionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "items", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementExternalAsmInstances.DataOciDatabaseManagementExternalAsmInstancesExternalAsmInstanceCollectionItemsList\"}")]
        public virtual oci.DataOciDatabaseManagementExternalAsmInstances.DataOciDatabaseManagementExternalAsmInstancesExternalAsmInstanceCollectionItemsList Items
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementExternalAsmInstances.DataOciDatabaseManagementExternalAsmInstancesExternalAsmInstanceCollectionItemsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementExternalAsmInstances.DataOciDatabaseManagementExternalAsmInstancesExternalAsmInstanceCollection\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseManagementExternalAsmInstances.IDataOciDatabaseManagementExternalAsmInstancesExternalAsmInstanceCollection? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementExternalAsmInstances.IDataOciDatabaseManagementExternalAsmInstancesExternalAsmInstanceCollection?>();
            set => SetInstanceProperty(value);
        }
    }
}
