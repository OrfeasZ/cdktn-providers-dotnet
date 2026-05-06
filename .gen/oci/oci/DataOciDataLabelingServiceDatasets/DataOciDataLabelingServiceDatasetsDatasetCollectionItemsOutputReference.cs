using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataLabelingServiceDatasets
{
    [JsiiClass(nativeType: typeof(oci.DataOciDataLabelingServiceDatasets.DataOciDataLabelingServiceDatasetsDatasetCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciDataLabelingServiceDatasets.DataOciDataLabelingServiceDatasetsDatasetCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDataLabelingServiceDatasetsDatasetCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDataLabelingServiceDatasetsDatasetCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDataLabelingServiceDatasetsDatasetCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataLabelingServiceDatasetsDatasetCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "additionalProperties", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap AdditionalProperties
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "annotationFormat", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AnnotationFormat
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "datasetFormatDetails", typeJson: "{\"fqn\":\"oci.dataOciDataLabelingServiceDatasets.DataOciDataLabelingServiceDatasetsDatasetCollectionItemsDatasetFormatDetailsList\"}")]
        public virtual oci.DataOciDataLabelingServiceDatasets.DataOciDataLabelingServiceDatasetsDatasetCollectionItemsDatasetFormatDetailsList DatasetFormatDetails
        {
            get => GetInstanceProperty<oci.DataOciDataLabelingServiceDatasets.DataOciDataLabelingServiceDatasetsDatasetCollectionItemsDatasetFormatDetailsList>()!;
        }

        [JsiiProperty(name: "datasetSourceDetails", typeJson: "{\"fqn\":\"oci.dataOciDataLabelingServiceDatasets.DataOciDataLabelingServiceDatasetsDatasetCollectionItemsDatasetSourceDetailsList\"}")]
        public virtual oci.DataOciDataLabelingServiceDatasets.DataOciDataLabelingServiceDatasetsDatasetCollectionItemsDatasetSourceDetailsList DatasetSourceDetails
        {
            get => GetInstanceProperty<oci.DataOciDataLabelingServiceDatasets.DataOciDataLabelingServiceDatasetsDatasetCollectionItemsDatasetSourceDetailsList>()!;
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

        [JsiiProperty(name: "initialImportDatasetConfiguration", typeJson: "{\"fqn\":\"oci.dataOciDataLabelingServiceDatasets.DataOciDataLabelingServiceDatasetsDatasetCollectionItemsInitialImportDatasetConfigurationList\"}")]
        public virtual oci.DataOciDataLabelingServiceDatasets.DataOciDataLabelingServiceDatasetsDatasetCollectionItemsInitialImportDatasetConfigurationList InitialImportDatasetConfiguration
        {
            get => GetInstanceProperty<oci.DataOciDataLabelingServiceDatasets.DataOciDataLabelingServiceDatasetsDatasetCollectionItemsInitialImportDatasetConfigurationList>()!;
        }

        [JsiiProperty(name: "initialRecordGenerationConfiguration", typeJson: "{\"fqn\":\"oci.dataOciDataLabelingServiceDatasets.DataOciDataLabelingServiceDatasetsDatasetCollectionItemsInitialRecordGenerationConfigurationList\"}")]
        public virtual oci.DataOciDataLabelingServiceDatasets.DataOciDataLabelingServiceDatasetsDatasetCollectionItemsInitialRecordGenerationConfigurationList InitialRecordGenerationConfiguration
        {
            get => GetInstanceProperty<oci.DataOciDataLabelingServiceDatasets.DataOciDataLabelingServiceDatasetsDatasetCollectionItemsInitialRecordGenerationConfigurationList>()!;
        }

        [JsiiProperty(name: "labelingInstructions", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LabelingInstructions
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "labelSet", typeJson: "{\"fqn\":\"oci.dataOciDataLabelingServiceDatasets.DataOciDataLabelingServiceDatasetsDatasetCollectionItemsLabelSetList\"}")]
        public virtual oci.DataOciDataLabelingServiceDatasets.DataOciDataLabelingServiceDatasetsDatasetCollectionItemsLabelSetList LabelSet
        {
            get => GetInstanceProperty<oci.DataOciDataLabelingServiceDatasets.DataOciDataLabelingServiceDatasetsDatasetCollectionItemsLabelSetList>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleSubstate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleSubstate
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDataLabelingServiceDatasets.DataOciDataLabelingServiceDatasetsDatasetCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciDataLabelingServiceDatasets.IDataOciDataLabelingServiceDatasetsDatasetCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDataLabelingServiceDatasets.IDataOciDataLabelingServiceDatasetsDatasetCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
