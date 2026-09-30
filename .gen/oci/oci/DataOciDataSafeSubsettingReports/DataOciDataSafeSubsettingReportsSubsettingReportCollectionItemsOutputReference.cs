using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataSafeSubsettingReports
{
    [JsiiClass(nativeType: typeof(oci.DataOciDataSafeSubsettingReports.DataOciDataSafeSubsettingReportsSubsettingReportCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciDataSafeSubsettingReports.DataOciDataSafeSubsettingReportsSubsettingReportCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDataSafeSubsettingReportsSubsettingReportCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDataSafeSubsettingReportsSubsettingReportCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDataSafeSubsettingReportsSubsettingReportCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeSubsettingReportsSubsettingReportCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseSizeAfterSubsettingInKbs", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseSizeAfterSubsettingInKbs
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseSizeBeforeSubsettingInKbs", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseSizeBeforeSubsettingInKbs
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isRedoLoggingEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsRedoLoggingEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isRefreshStatsEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsRefreshStatsEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "maskingPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaskingPolicyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maskingReportId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaskingReportId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maskingWorkRequestId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaskingWorkRequestId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "parallelDegree", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParallelDegree
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "recompile", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Recompile
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subsettingPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubsettingPolicyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subsettingStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubsettingStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subsettingWorkRequestId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubsettingWorkRequestId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "targetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeSubsettingFinished", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeSubsettingFinished
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeSubsettingStarted", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeSubsettingStarted
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalPostSubsettingScriptErrors", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TotalPostSubsettingScriptErrors
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalPreSubsettingScriptErrors", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TotalPreSubsettingScriptErrors
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalSubsettedObjects", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TotalSubsettedObjects
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalSubsettedRows", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TotalSubsettedRows
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalSubsettedSchemas", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TotalSubsettedSchemas
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSubsettingReports.DataOciDataSafeSubsettingReportsSubsettingReportCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciDataSafeSubsettingReports.IDataOciDataSafeSubsettingReportsSubsettingReportCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSubsettingReports.IDataOciDataSafeSubsettingReportsSubsettingReportCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
