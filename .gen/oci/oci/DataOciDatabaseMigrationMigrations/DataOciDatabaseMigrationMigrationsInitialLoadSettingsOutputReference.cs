using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseMigrationMigrations
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseMigrationMigrations.DataOciDatabaseMigrationMigrationsInitialLoadSettingsOutputReference), fullyQualifiedName: "oci.dataOciDatabaseMigrationMigrations.DataOciDatabaseMigrationMigrationsInitialLoadSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseMigrationMigrationsInitialLoadSettingsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseMigrationMigrationsInitialLoadSettingsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseMigrationMigrationsInitialLoadSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseMigrationMigrationsInitialLoadSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "compatibility", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Compatibility
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "dataPumpParameters", typeJson: "{\"fqn\":\"oci.dataOciDatabaseMigrationMigrations.DataOciDatabaseMigrationMigrationsInitialLoadSettingsDataPumpParametersList\"}")]
        public virtual oci.DataOciDatabaseMigrationMigrations.DataOciDatabaseMigrationMigrationsInitialLoadSettingsDataPumpParametersList DataPumpParameters
        {
            get => GetInstanceProperty<oci.DataOciDatabaseMigrationMigrations.DataOciDatabaseMigrationMigrationsInitialLoadSettingsDataPumpParametersList>()!;
        }

        [JsiiProperty(name: "exportDirectoryObject", typeJson: "{\"fqn\":\"oci.dataOciDatabaseMigrationMigrations.DataOciDatabaseMigrationMigrationsInitialLoadSettingsExportDirectoryObjectList\"}")]
        public virtual oci.DataOciDatabaseMigrationMigrations.DataOciDatabaseMigrationMigrationsInitialLoadSettingsExportDirectoryObjectList ExportDirectoryObject
        {
            get => GetInstanceProperty<oci.DataOciDatabaseMigrationMigrations.DataOciDatabaseMigrationMigrationsInitialLoadSettingsExportDirectoryObjectList>()!;
        }

        [JsiiProperty(name: "handleGrantErrors", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HandleGrantErrors
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "importDirectoryObject", typeJson: "{\"fqn\":\"oci.dataOciDatabaseMigrationMigrations.DataOciDatabaseMigrationMigrationsInitialLoadSettingsImportDirectoryObjectList\"}")]
        public virtual oci.DataOciDatabaseMigrationMigrations.DataOciDatabaseMigrationMigrationsInitialLoadSettingsImportDirectoryObjectList ImportDirectoryObject
        {
            get => GetInstanceProperty<oci.DataOciDatabaseMigrationMigrations.DataOciDatabaseMigrationMigrationsInitialLoadSettingsImportDirectoryObjectList>()!;
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

        [JsiiProperty(name: "metadataRemaps", typeJson: "{\"fqn\":\"oci.dataOciDatabaseMigrationMigrations.DataOciDatabaseMigrationMigrationsInitialLoadSettingsMetadataRemapsList\"}")]
        public virtual oci.DataOciDatabaseMigrationMigrations.DataOciDatabaseMigrationMigrationsInitialLoadSettingsMetadataRemapsList MetadataRemaps
        {
            get => GetInstanceProperty<oci.DataOciDatabaseMigrationMigrations.DataOciDatabaseMigrationMigrationsInitialLoadSettingsMetadataRemapsList>()!;
        }

        [JsiiProperty(name: "primaryKeyCompatibility", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryKeyCompatibility
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tablespaceDetails", typeJson: "{\"fqn\":\"oci.dataOciDatabaseMigrationMigrations.DataOciDatabaseMigrationMigrationsInitialLoadSettingsTablespaceDetailsList\"}")]
        public virtual oci.DataOciDatabaseMigrationMigrations.DataOciDatabaseMigrationMigrationsInitialLoadSettingsTablespaceDetailsList TablespaceDetails
        {
            get => GetInstanceProperty<oci.DataOciDatabaseMigrationMigrations.DataOciDatabaseMigrationMigrationsInitialLoadSettingsTablespaceDetailsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseMigrationMigrations.DataOciDatabaseMigrationMigrationsInitialLoadSettings\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseMigrationMigrations.IDataOciDatabaseMigrationMigrationsInitialLoadSettings? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseMigrationMigrations.IDataOciDatabaseMigrationMigrationsInitialLoadSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
