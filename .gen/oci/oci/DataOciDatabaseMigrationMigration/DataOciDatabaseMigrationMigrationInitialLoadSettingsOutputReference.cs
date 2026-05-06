using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseMigrationMigration
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseMigrationMigration.DataOciDatabaseMigrationMigrationInitialLoadSettingsOutputReference), fullyQualifiedName: "oci.dataOciDatabaseMigrationMigration.DataOciDatabaseMigrationMigrationInitialLoadSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseMigrationMigrationInitialLoadSettingsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseMigrationMigrationInitialLoadSettingsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseMigrationMigrationInitialLoadSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseMigrationMigrationInitialLoadSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "compatibility", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Compatibility
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "dataPumpParameters", typeJson: "{\"fqn\":\"oci.dataOciDatabaseMigrationMigration.DataOciDatabaseMigrationMigrationInitialLoadSettingsDataPumpParametersList\"}")]
        public virtual oci.DataOciDatabaseMigrationMigration.DataOciDatabaseMigrationMigrationInitialLoadSettingsDataPumpParametersList DataPumpParameters
        {
            get => GetInstanceProperty<oci.DataOciDatabaseMigrationMigration.DataOciDatabaseMigrationMigrationInitialLoadSettingsDataPumpParametersList>()!;
        }

        [JsiiProperty(name: "exportDirectoryObject", typeJson: "{\"fqn\":\"oci.dataOciDatabaseMigrationMigration.DataOciDatabaseMigrationMigrationInitialLoadSettingsExportDirectoryObjectList\"}")]
        public virtual oci.DataOciDatabaseMigrationMigration.DataOciDatabaseMigrationMigrationInitialLoadSettingsExportDirectoryObjectList ExportDirectoryObject
        {
            get => GetInstanceProperty<oci.DataOciDatabaseMigrationMigration.DataOciDatabaseMigrationMigrationInitialLoadSettingsExportDirectoryObjectList>()!;
        }

        [JsiiProperty(name: "handleGrantErrors", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HandleGrantErrors
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "importDirectoryObject", typeJson: "{\"fqn\":\"oci.dataOciDatabaseMigrationMigration.DataOciDatabaseMigrationMigrationInitialLoadSettingsImportDirectoryObjectList\"}")]
        public virtual oci.DataOciDatabaseMigrationMigration.DataOciDatabaseMigrationMigrationInitialLoadSettingsImportDirectoryObjectList ImportDirectoryObject
        {
            get => GetInstanceProperty<oci.DataOciDatabaseMigrationMigration.DataOciDatabaseMigrationMigrationInitialLoadSettingsImportDirectoryObjectList>()!;
        }

        [JsiiProperty(name: "isConsistent", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsConsistent
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isIgnoreExistingObjects", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsIgnoreExistingObjects
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isTzUtc", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsTzUtc
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "jobMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JobMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "metadataRemaps", typeJson: "{\"fqn\":\"oci.dataOciDatabaseMigrationMigration.DataOciDatabaseMigrationMigrationInitialLoadSettingsMetadataRemapsList\"}")]
        public virtual oci.DataOciDatabaseMigrationMigration.DataOciDatabaseMigrationMigrationInitialLoadSettingsMetadataRemapsList MetadataRemaps
        {
            get => GetInstanceProperty<oci.DataOciDatabaseMigrationMigration.DataOciDatabaseMigrationMigrationInitialLoadSettingsMetadataRemapsList>()!;
        }

        [JsiiProperty(name: "primaryKeyCompatibility", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryKeyCompatibility
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tablespaceDetails", typeJson: "{\"fqn\":\"oci.dataOciDatabaseMigrationMigration.DataOciDatabaseMigrationMigrationInitialLoadSettingsTablespaceDetailsList\"}")]
        public virtual oci.DataOciDatabaseMigrationMigration.DataOciDatabaseMigrationMigrationInitialLoadSettingsTablespaceDetailsList TablespaceDetails
        {
            get => GetInstanceProperty<oci.DataOciDatabaseMigrationMigration.DataOciDatabaseMigrationMigrationInitialLoadSettingsTablespaceDetailsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseMigrationMigration.DataOciDatabaseMigrationMigrationInitialLoadSettings\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseMigrationMigration.IDataOciDatabaseMigrationMigrationInitialLoadSettings? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseMigrationMigration.IDataOciDatabaseMigrationMigrationInitialLoadSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
