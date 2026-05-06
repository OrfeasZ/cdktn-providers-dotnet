using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciRecoveryProtectedDatabases
{
    [JsiiClass(nativeType: typeof(oci.DataOciRecoveryProtectedDatabases.DataOciRecoveryProtectedDatabasesProtectedDatabaseCollectionItemsMetricsOutputReference), fullyQualifiedName: "oci.dataOciRecoveryProtectedDatabases.DataOciRecoveryProtectedDatabasesProtectedDatabaseCollectionItemsMetricsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciRecoveryProtectedDatabasesProtectedDatabaseCollectionItemsMetricsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciRecoveryProtectedDatabasesProtectedDatabaseCollectionItemsMetricsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciRecoveryProtectedDatabasesProtectedDatabaseCollectionItemsMetricsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciRecoveryProtectedDatabasesProtectedDatabaseCollectionItemsMetricsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "backupSpaceEstimateInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BackupSpaceEstimateInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "backupSpaceUsedInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BackupSpaceUsedInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "currentRetentionPeriodInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CurrentRetentionPeriodInSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "dbSizeInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DbSizeInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "isRedoLogsEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsRedoLogsEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "minimumRecoveryNeededInDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinimumRecoveryNeededInDays
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "retentionPeriodInDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RetentionPeriodInDays
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "unprotectedWindowInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double UnprotectedWindowInSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciRecoveryProtectedDatabases.DataOciRecoveryProtectedDatabasesProtectedDatabaseCollectionItemsMetrics\"}", isOptional: true)]
        public virtual oci.DataOciRecoveryProtectedDatabases.IDataOciRecoveryProtectedDatabasesProtectedDatabaseCollectionItemsMetrics? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciRecoveryProtectedDatabases.IDataOciRecoveryProtectedDatabasesProtectedDatabaseCollectionItemsMetrics?>();
            set => SetInstanceProperty(value);
        }
    }
}
