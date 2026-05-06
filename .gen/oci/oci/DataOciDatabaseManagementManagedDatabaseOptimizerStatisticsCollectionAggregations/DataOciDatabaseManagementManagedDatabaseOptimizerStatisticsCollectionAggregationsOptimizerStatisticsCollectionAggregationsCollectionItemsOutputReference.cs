using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionAggregations
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionAggregations.DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionAggregationsOptimizerStatisticsCollectionAggregationsCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionAggregations.DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionAggregationsOptimizerStatisticsCollectionAggregationsCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionAggregationsOptimizerStatisticsCollectionAggregationsCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionAggregationsOptimizerStatisticsCollectionAggregationsCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionAggregationsOptimizerStatisticsCollectionAggregationsCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionAggregationsOptimizerStatisticsCollectionAggregationsCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "completed", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Completed
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "failed", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Failed
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "groupBy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GroupBy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "inProgress", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InProgress
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "pending", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Pending
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "skipped", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Skipped
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "timedOut", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TimedOut
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "timeEnd", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeEnd
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeStart", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeStart
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "total", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Total
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "unknown", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Unknown
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionAggregations.DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionAggregationsOptimizerStatisticsCollectionAggregationsCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionAggregations.IDataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionAggregationsOptimizerStatisticsCollectionAggregationsCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionAggregations.IDataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionAggregationsOptimizerStatisticsCollectionAggregationsCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
