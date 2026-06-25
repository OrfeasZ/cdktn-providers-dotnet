using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseToolsDatabaseToolsIdentities
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseToolsDatabaseToolsIdentities.DataOciDatabaseToolsDatabaseToolsIdentitiesDatabaseToolsIdentityCollectionItemsLocksOutputReference), fullyQualifiedName: "oci.dataOciDatabaseToolsDatabaseToolsIdentities.DataOciDatabaseToolsDatabaseToolsIdentitiesDatabaseToolsIdentityCollectionItemsLocksOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseToolsDatabaseToolsIdentitiesDatabaseToolsIdentityCollectionItemsLocksOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseToolsDatabaseToolsIdentitiesDatabaseToolsIdentityCollectionItemsLocksOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseToolsDatabaseToolsIdentitiesDatabaseToolsIdentityCollectionItemsLocksOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseToolsDatabaseToolsIdentitiesDatabaseToolsIdentityCollectionItemsLocksOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "message", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Message
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "relatedResourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RelatedResourceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseToolsDatabaseToolsIdentities.DataOciDatabaseToolsDatabaseToolsIdentitiesDatabaseToolsIdentityCollectionItemsLocks\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseToolsDatabaseToolsIdentities.IDataOciDatabaseToolsDatabaseToolsIdentitiesDatabaseToolsIdentityCollectionItemsLocks? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseToolsDatabaseToolsIdentities.IDataOciDatabaseToolsDatabaseToolsIdentitiesDatabaseToolsIdentityCollectionItemsLocks?>();
            set => SetInstanceProperty(value);
        }
    }
}
