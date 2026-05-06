using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperations
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperations.DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperationsOptimizerStatisticsCollectionOperationsCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperations.DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperationsOptimizerStatisticsCollectionOperationsCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperationsOptimizerStatisticsCollectionOperationsCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperationsOptimizerStatisticsCollectionOperationsCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperationsOptimizerStatisticsCollectionOperationsCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperationsOptimizerStatisticsCollectionOperationsCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "completedCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CompletedCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "database", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperations.DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperationsOptimizerStatisticsCollectionOperationsCollectionItemsDatabaseList\"}")]
        public virtual oci.DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperations.DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperationsOptimizerStatisticsCollectionOperationsCollectionItemsDatabaseList Database
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperations.DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperationsOptimizerStatisticsCollectionOperationsCollectionItemsDatabaseList>()!;
        }

        [JsiiProperty(name: "durationInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DurationInSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "endTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EndTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "failedCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FailedCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Id
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "inProgressCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InProgressCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "jobName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JobName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "operationName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OperationName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "startTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StartTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Target
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tasks", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperations.DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperationsOptimizerStatisticsCollectionOperationsCollectionItemsTasksList\"}")]
        public virtual oci.DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperations.DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperationsOptimizerStatisticsCollectionOperationsCollectionItemsTasksList Tasks
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperations.DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperationsOptimizerStatisticsCollectionOperationsCollectionItemsTasksList>()!;
        }

        [JsiiProperty(name: "timedOutCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TimedOutCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "totalObjectsCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalObjectsCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperations.DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperationsOptimizerStatisticsCollectionOperationsCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperations.IDataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperationsOptimizerStatisticsCollectionOperationsCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperations.IDataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperationsOptimizerStatisticsCollectionOperationsCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
