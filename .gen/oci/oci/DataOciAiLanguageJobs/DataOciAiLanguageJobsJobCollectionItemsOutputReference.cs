using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciAiLanguageJobs
{
    [JsiiClass(nativeType: typeof(oci.DataOciAiLanguageJobs.DataOciAiLanguageJobsJobCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciAiLanguageJobs.DataOciAiLanguageJobsJobCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciAiLanguageJobsJobCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciAiLanguageJobsJobCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciAiLanguageJobsJobCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciAiLanguageJobsJobCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "completedDocuments", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CompletedDocuments
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "createdBy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedBy
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "failedDocuments", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FailedDocuments
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "inputConfiguration", typeJson: "{\"fqn\":\"oci.dataOciAiLanguageJobs.DataOciAiLanguageJobsJobCollectionItemsInputConfigurationList\"}")]
        public virtual oci.DataOciAiLanguageJobs.DataOciAiLanguageJobsJobCollectionItemsInputConfigurationList InputConfiguration
        {
            get => GetInstanceProperty<oci.DataOciAiLanguageJobs.DataOciAiLanguageJobsJobCollectionItemsInputConfigurationList>()!;
        }

        [JsiiProperty(name: "inputLocation", typeJson: "{\"fqn\":\"oci.dataOciAiLanguageJobs.DataOciAiLanguageJobsJobCollectionItemsInputLocationList\"}")]
        public virtual oci.DataOciAiLanguageJobs.DataOciAiLanguageJobsJobCollectionItemsInputLocationList InputLocation
        {
            get => GetInstanceProperty<oci.DataOciAiLanguageJobs.DataOciAiLanguageJobsJobCollectionItemsInputLocationList>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "modelMetadataDetails", typeJson: "{\"fqn\":\"oci.dataOciAiLanguageJobs.DataOciAiLanguageJobsJobCollectionItemsModelMetadataDetailsList\"}")]
        public virtual oci.DataOciAiLanguageJobs.DataOciAiLanguageJobsJobCollectionItemsModelMetadataDetailsList ModelMetadataDetails
        {
            get => GetInstanceProperty<oci.DataOciAiLanguageJobs.DataOciAiLanguageJobsJobCollectionItemsModelMetadataDetailsList>()!;
        }

        [JsiiProperty(name: "outputLocation", typeJson: "{\"fqn\":\"oci.dataOciAiLanguageJobs.DataOciAiLanguageJobsJobCollectionItemsOutputLocationList\"}")]
        public virtual oci.DataOciAiLanguageJobs.DataOciAiLanguageJobsJobCollectionItemsOutputLocationList OutputLocation
        {
            get => GetInstanceProperty<oci.DataOciAiLanguageJobs.DataOciAiLanguageJobsJobCollectionItemsOutputLocationList>()!;
        }

        [JsiiProperty(name: "pendingDocuments", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PendingDocuments
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "percentComplete", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PercentComplete
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeAccepted", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeAccepted
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCompleted", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCompleted
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeStarted", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeStarted
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalDocuments", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalDocuments
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "ttlInDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TtlInDays
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "warningsCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double WarningsCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciAiLanguageJobs.DataOciAiLanguageJobsJobCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciAiLanguageJobs.IDataOciAiLanguageJobsJobCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciAiLanguageJobs.IDataOciAiLanguageJobsJobCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
