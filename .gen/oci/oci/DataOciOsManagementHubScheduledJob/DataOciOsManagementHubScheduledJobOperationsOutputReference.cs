using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOsManagementHubScheduledJob
{
    [JsiiClass(nativeType: typeof(oci.DataOciOsManagementHubScheduledJob.DataOciOsManagementHubScheduledJobOperationsOutputReference), fullyQualifiedName: "oci.dataOciOsManagementHubScheduledJob.DataOciOsManagementHubScheduledJobOperationsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciOsManagementHubScheduledJobOperationsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciOsManagementHubScheduledJobOperationsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciOsManagementHubScheduledJobOperationsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOsManagementHubScheduledJobOperationsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "manageModuleStreamsDetails", typeJson: "{\"fqn\":\"oci.dataOciOsManagementHubScheduledJob.DataOciOsManagementHubScheduledJobOperationsManageModuleStreamsDetailsList\"}")]
        public virtual oci.DataOciOsManagementHubScheduledJob.DataOciOsManagementHubScheduledJobOperationsManageModuleStreamsDetailsList ManageModuleStreamsDetails
        {
            get => GetInstanceProperty<oci.DataOciOsManagementHubScheduledJob.DataOciOsManagementHubScheduledJobOperationsManageModuleStreamsDetailsList>()!;
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

        [JsiiProperty(name: "switchModuleStreamsDetails", typeJson: "{\"fqn\":\"oci.dataOciOsManagementHubScheduledJob.DataOciOsManagementHubScheduledJobOperationsSwitchModuleStreamsDetailsList\"}")]
        public virtual oci.DataOciOsManagementHubScheduledJob.DataOciOsManagementHubScheduledJobOperationsSwitchModuleStreamsDetailsList SwitchModuleStreamsDetails
        {
            get => GetInstanceProperty<oci.DataOciOsManagementHubScheduledJob.DataOciOsManagementHubScheduledJobOperationsSwitchModuleStreamsDetailsList>()!;
        }

        [JsiiProperty(name: "windowsUpdateNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] WindowsUpdateNames
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciOsManagementHubScheduledJob.DataOciOsManagementHubScheduledJobOperations\"}", isOptional: true)]
        public virtual oci.DataOciOsManagementHubScheduledJob.IDataOciOsManagementHubScheduledJobOperations? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciOsManagementHubScheduledJob.IDataOciOsManagementHubScheduledJobOperations?>();
            set => SetInstanceProperty(value);
        }
    }
}
