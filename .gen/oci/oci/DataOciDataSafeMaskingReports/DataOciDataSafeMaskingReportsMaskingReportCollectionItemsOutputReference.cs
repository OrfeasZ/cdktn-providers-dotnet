using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataSafeMaskingReports
{
    [JsiiClass(nativeType: typeof(oci.DataOciDataSafeMaskingReports.DataOciDataSafeMaskingReportsMaskingReportCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciDataSafeMaskingReports.DataOciDataSafeMaskingReportsMaskingReportCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDataSafeMaskingReportsMaskingReportCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDataSafeMaskingReportsMaskingReportCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDataSafeMaskingReportsMaskingReportCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeMaskingReportsMaskingReportCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isDropTempTablesEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsDropTempTablesEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
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

        [JsiiProperty(name: "maskingStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaskingStatus
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

        [JsiiProperty(name: "timeMaskingFinished", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeMaskingFinished
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeMaskingStarted", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeMaskingStarted
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalMaskedColumns", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TotalMaskedColumns
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalMaskedObjects", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TotalMaskedObjects
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalMaskedSchemas", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TotalMaskedSchemas
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalMaskedSensitiveTypes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TotalMaskedSensitiveTypes
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalMaskedValues", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TotalMaskedValues
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalPostMaskingScriptErrors", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TotalPostMaskingScriptErrors
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalPreMaskingScriptErrors", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TotalPreMaskingScriptErrors
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDataSafeMaskingReports.DataOciDataSafeMaskingReportsMaskingReportCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciDataSafeMaskingReports.IDataOciDataSafeMaskingReportsMaskingReportCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDataSafeMaskingReports.IDataOciDataSafeMaskingReportsMaskingReportCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
