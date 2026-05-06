using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseKeyStores
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseKeyStores.DataOciDatabaseKeyStoresKeyStoresOutputReference), fullyQualifiedName: "oci.dataOciDatabaseKeyStores.DataOciDatabaseKeyStoresKeyStoresOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseKeyStoresKeyStoresOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseKeyStoresKeyStoresOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseKeyStoresKeyStoresOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseKeyStoresKeyStoresOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "associatedDatabases", typeJson: "{\"fqn\":\"oci.dataOciDatabaseKeyStores.DataOciDatabaseKeyStoresKeyStoresAssociatedDatabasesList\"}")]
        public virtual oci.DataOciDatabaseKeyStores.DataOciDatabaseKeyStoresKeyStoresAssociatedDatabasesList AssociatedDatabases
        {
            get => GetInstanceProperty<oci.DataOciDatabaseKeyStores.DataOciDatabaseKeyStoresKeyStoresAssociatedDatabasesList>()!;
        }

        [JsiiProperty(name: "associatedLongTermBackupCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AssociatedLongTermBackupCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "associatedLongTermBackups", typeJson: "{\"fqn\":\"oci.dataOciDatabaseKeyStores.DataOciDatabaseKeyStoresKeyStoresAssociatedLongTermBackupsList\"}")]
        public virtual oci.DataOciDatabaseKeyStores.DataOciDatabaseKeyStoresKeyStoresAssociatedLongTermBackupsList AssociatedLongTermBackups
        {
            get => GetInstanceProperty<oci.DataOciDatabaseKeyStores.DataOciDatabaseKeyStoresKeyStoresAssociatedLongTermBackupsList>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "confirmDetailsTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ConfirmDetailsTrigger
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
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

        [JsiiProperty(name: "typeDetails", typeJson: "{\"fqn\":\"oci.dataOciDatabaseKeyStores.DataOciDatabaseKeyStoresKeyStoresTypeDetailsList\"}")]
        public virtual oci.DataOciDatabaseKeyStores.DataOciDatabaseKeyStoresKeyStoresTypeDetailsList TypeDetails
        {
            get => GetInstanceProperty<oci.DataOciDatabaseKeyStores.DataOciDatabaseKeyStoresKeyStoresTypeDetailsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseKeyStores.DataOciDatabaseKeyStoresKeyStores\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseKeyStores.IDataOciDatabaseKeyStoresKeyStores? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseKeyStores.IDataOciDatabaseKeyStoresKeyStores?>();
            set => SetInstanceProperty(value);
        }
    }
}
