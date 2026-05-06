using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSqlExecutionPlan
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSqlExecutionPlan.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSqlExecutionPlanPlanOutputReference), fullyQualifiedName: "oci.dataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSqlExecutionPlan.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSqlExecutionPlanPlanOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSqlExecutionPlanPlanOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSqlExecutionPlanPlanOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSqlExecutionPlanPlanOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSqlExecutionPlanPlanOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "accessPredicates", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccessPredicates
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "attribute", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Attribute
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bytes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Bytes
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cardinality", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Cardinality
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cost", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Cost
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "cpuCost", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CpuCost
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "filterPredicates", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FilterPredicates
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ioCost", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double IoCost
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "numberOfSearchColumn", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NumberOfSearchColumn
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "object", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Object
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "objectNode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ObjectNode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "objectOwner", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ObjectOwner
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "objectPosition", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ObjectPosition
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "objectType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ObjectType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "operation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Operation
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "optimizerMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OptimizerMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "options", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Options
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "other", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Other
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "otherTag", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OtherTag
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "parentStepId", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ParentStepId
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "partitionId", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PartitionId
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "partitionStart", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PartitionStart
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "partitionStop", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PartitionStop
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "planHashValue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlanHashValue
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "position", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Position
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "remarks", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Remarks
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "stepId", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StepId
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "tempSpace", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TempSpace
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "time", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Time
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSqlExecutionPlan.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSqlExecutionPlanPlan\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSqlExecutionPlan.IDataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSqlExecutionPlanPlan? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSqlExecutionPlan.IDataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSqlExecutionPlanPlan?>();
            set => SetInstanceProperty(value);
        }
    }
}
