using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOsManagementHubScheduledJobs
{
    [JsiiClass(nativeType: typeof(oci.DataOciOsManagementHubScheduledJobs.DataOciOsManagementHubScheduledJobsScheduledJobCollectionItemsOperationsOutputReference), fullyQualifiedName: "oci.dataOciOsManagementHubScheduledJobs.DataOciOsManagementHubScheduledJobsScheduledJobCollectionItemsOperationsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciOsManagementHubScheduledJobsScheduledJobCollectionItemsOperationsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciOsManagementHubScheduledJobsScheduledJobCollectionItemsOperationsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciOsManagementHubScheduledJobsScheduledJobCollectionItemsOperationsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOsManagementHubScheduledJobsScheduledJobCollectionItemsOperationsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "manageModuleStreamsDetails", typeJson: "{\"fqn\":\"oci.dataOciOsManagementHubScheduledJobs.DataOciOsManagementHubScheduledJobsScheduledJobCollectionItemsOperationsManageModuleStreamsDetailsList\"}")]
        public virtual oci.DataOciOsManagementHubScheduledJobs.DataOciOsManagementHubScheduledJobsScheduledJobCollectionItemsOperationsManageModuleStreamsDetailsList ManageModuleStreamsDetails
        {
            get => GetInstanceProperty<oci.DataOciOsManagementHubScheduledJobs.DataOciOsManagementHubScheduledJobsScheduledJobCollectionItemsOperationsManageModuleStreamsDetailsList>()!;
        }

        [JsiiProperty(name: "operationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OperationType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "packageNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PackageNames
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "rebootTimeoutInMins", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RebootTimeoutInMins
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "softwareSourceIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SoftwareSourceIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "switchModuleStreamsDetails", typeJson: "{\"fqn\":\"oci.dataOciOsManagementHubScheduledJobs.DataOciOsManagementHubScheduledJobsScheduledJobCollectionItemsOperationsSwitchModuleStreamsDetailsList\"}")]
        public virtual oci.DataOciOsManagementHubScheduledJobs.DataOciOsManagementHubScheduledJobsScheduledJobCollectionItemsOperationsSwitchModuleStreamsDetailsList SwitchModuleStreamsDetails
        {
            get => GetInstanceProperty<oci.DataOciOsManagementHubScheduledJobs.DataOciOsManagementHubScheduledJobsScheduledJobCollectionItemsOperationsSwitchModuleStreamsDetailsList>()!;
        }

        [JsiiProperty(name: "windowsUpdateNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] WindowsUpdateNames
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciOsManagementHubScheduledJobs.DataOciOsManagementHubScheduledJobsScheduledJobCollectionItemsOperations\"}", isOptional: true)]
        public virtual oci.DataOciOsManagementHubScheduledJobs.IDataOciOsManagementHubScheduledJobsScheduledJobCollectionItemsOperations? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciOsManagementHubScheduledJobs.IDataOciOsManagementHubScheduledJobsScheduledJobCollectionItemsOperations?>();
            set => SetInstanceProperty(value);
        }
    }
}
