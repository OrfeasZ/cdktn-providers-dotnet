using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseExadataInfrastructureCompute
{
    [JsiiClass(nativeType: typeof(oci.DatabaseExadataInfrastructureCompute.DatabaseExadataInfrastructureComputeMaintenanceWindowOutputReference), fullyQualifiedName: "oci.databaseExadataInfrastructureCompute.DatabaseExadataInfrastructureComputeMaintenanceWindowOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DatabaseExadataInfrastructureComputeMaintenanceWindowOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DatabaseExadataInfrastructureComputeMaintenanceWindowOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DatabaseExadataInfrastructureComputeMaintenanceWindowOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseExadataInfrastructureComputeMaintenanceWindowOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "customActionTimeoutInMins", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CustomActionTimeoutInMins
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "daysOfWeek", typeJson: "{\"fqn\":\"oci.databaseExadataInfrastructureCompute.DatabaseExadataInfrastructureComputeMaintenanceWindowDaysOfWeekList\"}")]
        public virtual oci.DatabaseExadataInfrastructureCompute.DatabaseExadataInfrastructureComputeMaintenanceWindowDaysOfWeekList DaysOfWeek
        {
            get => GetInstanceProperty<oci.DatabaseExadataInfrastructureCompute.DatabaseExadataInfrastructureComputeMaintenanceWindowDaysOfWeekList>()!;
        }

        [JsiiProperty(name: "hoursOfDay", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        public virtual double[] HoursOfDay
        {
            get => GetInstanceProperty<double[]>()!;
        }

        [JsiiProperty(name: "isCustomActionTimeoutEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsCustomActionTimeoutEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isMonthlyPatchingEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsMonthlyPatchingEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "leadTimeInWeeks", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LeadTimeInWeeks
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "months", typeJson: "{\"fqn\":\"oci.databaseExadataInfrastructureCompute.DatabaseExadataInfrastructureComputeMaintenanceWindowMonthsList\"}")]
        public virtual oci.DatabaseExadataInfrastructureCompute.DatabaseExadataInfrastructureComputeMaintenanceWindowMonthsList Months
        {
            get => GetInstanceProperty<oci.DatabaseExadataInfrastructureCompute.DatabaseExadataInfrastructureComputeMaintenanceWindowMonthsList>()!;
        }

        [JsiiProperty(name: "patchingMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PatchingMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "preference", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Preference
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "weeksOfMonth", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        public virtual double[] WeeksOfMonth
        {
            get => GetInstanceProperty<double[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.databaseExadataInfrastructureCompute.DatabaseExadataInfrastructureComputeMaintenanceWindow\"}", isOptional: true)]
        public virtual oci.DatabaseExadataInfrastructureCompute.IDatabaseExadataInfrastructureComputeMaintenanceWindow? InternalValue
        {
            get => GetInstanceProperty<oci.DatabaseExadataInfrastructureCompute.IDatabaseExadataInfrastructureComputeMaintenanceWindow?>();
            set => SetInstanceProperty(value);
        }
    }
}
