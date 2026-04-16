using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsOdbCloudAutonomousVmCluster
{
    [JsiiClass(nativeType: typeof(aws.DataAwsOdbCloudAutonomousVmCluster.DataAwsOdbCloudAutonomousVmClusterMaintenanceWindowOutputReference), fullyQualifiedName: "aws.dataAwsOdbCloudAutonomousVmCluster.DataAwsOdbCloudAutonomousVmClusterMaintenanceWindowOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsOdbCloudAutonomousVmClusterMaintenanceWindowOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsOdbCloudAutonomousVmClusterMaintenanceWindowOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAwsOdbCloudAutonomousVmClusterMaintenanceWindowOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsOdbCloudAutonomousVmClusterMaintenanceWindowOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "daysOfWeek", typeJson: "{\"fqn\":\"aws.dataAwsOdbCloudAutonomousVmCluster.DataAwsOdbCloudAutonomousVmClusterMaintenanceWindowDaysOfWeekList\"}")]
        public virtual aws.DataAwsOdbCloudAutonomousVmCluster.DataAwsOdbCloudAutonomousVmClusterMaintenanceWindowDaysOfWeekList DaysOfWeek
        {
            get => GetInstanceProperty<aws.DataAwsOdbCloudAutonomousVmCluster.DataAwsOdbCloudAutonomousVmClusterMaintenanceWindowDaysOfWeekList>()!;
        }

        [JsiiProperty(name: "hoursOfDay", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        public virtual double[] HoursOfDay
        {
            get => GetInstanceProperty<double[]>()!;
        }

        [JsiiProperty(name: "leadTimeInWeeks", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LeadTimeInWeeks
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "months", typeJson: "{\"fqn\":\"aws.dataAwsOdbCloudAutonomousVmCluster.DataAwsOdbCloudAutonomousVmClusterMaintenanceWindowMonthsList\"}")]
        public virtual aws.DataAwsOdbCloudAutonomousVmCluster.DataAwsOdbCloudAutonomousVmClusterMaintenanceWindowMonthsList Months
        {
            get => GetInstanceProperty<aws.DataAwsOdbCloudAutonomousVmCluster.DataAwsOdbCloudAutonomousVmClusterMaintenanceWindowMonthsList>()!;
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsOdbCloudAutonomousVmCluster.DataAwsOdbCloudAutonomousVmClusterMaintenanceWindow\"}", isOptional: true)]
        public virtual aws.DataAwsOdbCloudAutonomousVmCluster.IDataAwsOdbCloudAutonomousVmClusterMaintenanceWindow? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsOdbCloudAutonomousVmCluster.IDataAwsOdbCloudAutonomousVmClusterMaintenanceWindow?>();
            set => SetInstanceProperty(value);
        }
    }
}
