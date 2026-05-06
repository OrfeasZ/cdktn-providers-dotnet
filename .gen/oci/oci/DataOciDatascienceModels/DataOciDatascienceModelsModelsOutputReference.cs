using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatascienceModels
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatascienceModels.DataOciDatascienceModelsModelsOutputReference), fullyQualifiedName: "oci.dataOciDatascienceModels.DataOciDatascienceModelsModelsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatascienceModelsModelsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatascienceModelsModelsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatascienceModelsModelsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatascienceModelsModelsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "artifactContentDisposition", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ArtifactContentDisposition
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "artifactContentLength", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ArtifactContentLength
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "artifactContentMd5", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ArtifactContentMd5
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "artifactLastModified", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ArtifactLastModified
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "backupOperationDetails", typeJson: "{\"fqn\":\"oci.dataOciDatascienceModels.DataOciDatascienceModelsModelsBackupOperationDetailsList\"}")]
        public virtual oci.DataOciDatascienceModels.DataOciDatascienceModelsModelsBackupOperationDetailsList BackupOperationDetails
        {
            get => GetInstanceProperty<oci.DataOciDatascienceModels.DataOciDatascienceModelsModelsBackupOperationDetailsList>()!;
        }

        [JsiiProperty(name: "backupSetting", typeJson: "{\"fqn\":\"oci.dataOciDatascienceModels.DataOciDatascienceModelsModelsBackupSettingList\"}")]
        public virtual oci.DataOciDatascienceModels.DataOciDatascienceModelsModelsBackupSettingList BackupSetting
        {
            get => GetInstanceProperty<oci.DataOciDatascienceModels.DataOciDatascienceModelsModelsBackupSettingList>()!;
        }

        [JsiiProperty(name: "category", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Category
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "createdBy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedBy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customMetadataList", typeJson: "{\"fqn\":\"oci.dataOciDatascienceModels.DataOciDatascienceModelsModelsCustomMetadataListStructList\"}")]
        public virtual oci.DataOciDatascienceModels.DataOciDatascienceModelsModelsCustomMetadataListStructList CustomMetadataList
        {
            get => GetInstanceProperty<oci.DataOciDatascienceModels.DataOciDatascienceModelsModelsCustomMetadataListStructList>()!;
        }

        [JsiiProperty(name: "definedMetadataList", typeJson: "{\"fqn\":\"oci.dataOciDatascienceModels.DataOciDatascienceModelsModelsDefinedMetadataListStructList\"}")]
        public virtual oci.DataOciDatascienceModels.DataOciDatascienceModelsModelsDefinedMetadataListStructList DefinedMetadataList
        {
            get => GetInstanceProperty<oci.DataOciDatascienceModels.DataOciDatascienceModelsModelsDefinedMetadataListStructList>()!;
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

        [JsiiProperty(name: "emptyModel", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable EmptyModel
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
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

        [JsiiProperty(name: "inputSchema", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InputSchema
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isModelByReference", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsModelByReference
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "modelArtifact", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelArtifact
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "modelVersionSetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelVersionSetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "modelVersionSetName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelVersionSetName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "outputSchema", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OutputSchema
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProjectId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "retentionOperationDetails", typeJson: "{\"fqn\":\"oci.dataOciDatascienceModels.DataOciDatascienceModelsModelsRetentionOperationDetailsList\"}")]
        public virtual oci.DataOciDatascienceModels.DataOciDatascienceModelsModelsRetentionOperationDetailsList RetentionOperationDetails
        {
            get => GetInstanceProperty<oci.DataOciDatascienceModels.DataOciDatascienceModelsModelsRetentionOperationDetailsList>()!;
        }

        [JsiiProperty(name: "retentionSetting", typeJson: "{\"fqn\":\"oci.dataOciDatascienceModels.DataOciDatascienceModelsModelsRetentionSettingList\"}")]
        public virtual oci.DataOciDatascienceModels.DataOciDatascienceModelsModelsRetentionSettingList RetentionSetting
        {
            get => GetInstanceProperty<oci.DataOciDatascienceModels.DataOciDatascienceModelsModelsRetentionSettingList>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "versionLabel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VersionLabel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatascienceModels.DataOciDatascienceModelsModels\"}", isOptional: true)]
        public virtual oci.DataOciDatascienceModels.IDataOciDatascienceModelsModels? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatascienceModels.IDataOciDatascienceModelsModels?>();
            set => SetInstanceProperty(value);
        }
    }
}
