using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTask
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTask.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTaskItemsOutputReference), fullyQualifiedName: "oci.dataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTask.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTaskItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTaskItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTaskItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTaskItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTaskItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "daysToExpire", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DaysToExpire
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "instanceId", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InstanceId
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "owner", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Owner
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "recommendationCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RecommendationCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "sqlTuningAdvisorTaskId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SqlTuningAdvisorTaskId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "taskStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TaskStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeExecutionEnded", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeExecutionEnded
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeExecutionStarted", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeExecutionStarted
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalSqlStatements", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalSqlStatements
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTask.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTaskItems\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTask.IDataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTaskItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTask.IDataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTaskItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
