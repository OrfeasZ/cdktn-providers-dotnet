using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataSafeTargetDatabases
{
    [JsiiClass(nativeType: typeof(oci.DataOciDataSafeTargetDatabases.DataOciDataSafeTargetDatabasesTargetDatabasesOutputReference), fullyQualifiedName: "oci.dataOciDataSafeTargetDatabases.DataOciDataSafeTargetDatabasesTargetDatabasesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDataSafeTargetDatabasesTargetDatabasesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDataSafeTargetDatabasesTargetDatabasesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDataSafeTargetDatabasesTargetDatabasesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeTargetDatabasesTargetDatabasesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "associatedResourceIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AssociatedResourceIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "connectionOption", typeJson: "{\"fqn\":\"oci.dataOciDataSafeTargetDatabases.DataOciDataSafeTargetDatabasesTargetDatabasesConnectionOptionList\"}")]
        public virtual oci.DataOciDataSafeTargetDatabases.DataOciDataSafeTargetDatabasesTargetDatabasesConnectionOptionList ConnectionOption
        {
            get => GetInstanceProperty<oci.DataOciDataSafeTargetDatabases.DataOciDataSafeTargetDatabasesTargetDatabasesConnectionOptionList>()!;
        }

        [JsiiProperty(name: "credentials", typeJson: "{\"fqn\":\"oci.dataOciDataSafeTargetDatabases.DataOciDataSafeTargetDatabasesTargetDatabasesCredentialsList\"}")]
        public virtual oci.DataOciDataSafeTargetDatabases.DataOciDataSafeTargetDatabasesTargetDatabasesCredentialsList Credentials
        {
            get => GetInstanceProperty<oci.DataOciDataSafeTargetDatabases.DataOciDataSafeTargetDatabasesTargetDatabasesCredentialsList>()!;
        }

        [JsiiProperty(name: "databaseDetails", typeJson: "{\"fqn\":\"oci.dataOciDataSafeTargetDatabases.DataOciDataSafeTargetDatabasesTargetDatabasesDatabaseDetailsList\"}")]
        public virtual oci.DataOciDataSafeTargetDatabases.DataOciDataSafeTargetDatabasesTargetDatabasesDatabaseDetailsList DatabaseDetails
        {
            get => GetInstanceProperty<oci.DataOciDataSafeTargetDatabases.DataOciDataSafeTargetDatabasesTargetDatabasesDatabaseDetailsList>()!;
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

        [JsiiProperty(name: "peerTargetDatabaseDetails", typeJson: "{\"fqn\":\"oci.dataOciDataSafeTargetDatabases.DataOciDataSafeTargetDatabasesTargetDatabasesPeerTargetDatabaseDetailsList\"}")]
        public virtual oci.DataOciDataSafeTargetDatabases.DataOciDataSafeTargetDatabasesTargetDatabasesPeerTargetDatabaseDetailsList PeerTargetDatabaseDetails
        {
            get => GetInstanceProperty<oci.DataOciDataSafeTargetDatabases.DataOciDataSafeTargetDatabasesTargetDatabasesPeerTargetDatabaseDetailsList>()!;
        }

        [JsiiProperty(name: "peerTargetDatabases", typeJson: "{\"fqn\":\"oci.dataOciDataSafeTargetDatabases.DataOciDataSafeTargetDatabasesTargetDatabasesPeerTargetDatabasesList\"}")]
        public virtual oci.DataOciDataSafeTargetDatabases.DataOciDataSafeTargetDatabasesTargetDatabasesPeerTargetDatabasesList PeerTargetDatabases
        {
            get => GetInstanceProperty<oci.DataOciDataSafeTargetDatabases.DataOciDataSafeTargetDatabasesTargetDatabasesPeerTargetDatabasesList>()!;
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

        [JsiiProperty(name: "tlsConfig", typeJson: "{\"fqn\":\"oci.dataOciDataSafeTargetDatabases.DataOciDataSafeTargetDatabasesTargetDatabasesTlsConfigList\"}")]
        public virtual oci.DataOciDataSafeTargetDatabases.DataOciDataSafeTargetDatabasesTargetDatabasesTlsConfigList TlsConfig
        {
            get => GetInstanceProperty<oci.DataOciDataSafeTargetDatabases.DataOciDataSafeTargetDatabasesTargetDatabasesTlsConfigList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDataSafeTargetDatabases.DataOciDataSafeTargetDatabasesTargetDatabases\"}", isOptional: true)]
        public virtual oci.DataOciDataSafeTargetDatabases.IDataOciDataSafeTargetDatabasesTargetDatabases? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDataSafeTargetDatabases.IDataOciDataSafeTargetDatabasesTargetDatabases?>();
            set => SetInstanceProperty(value);
        }
    }
}
