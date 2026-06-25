using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDisasterRecoveryDrPlanExecution
{
    [JsiiClass(nativeType: typeof(oci.DataOciDisasterRecoveryDrPlanExecution.DataOciDisasterRecoveryDrPlanExecutionStepStatusCountsRemainingStepsOutputReference), fullyQualifiedName: "oci.dataOciDisasterRecoveryDrPlanExecution.DataOciDisasterRecoveryDrPlanExecutionStepStatusCountsRemainingStepsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDisasterRecoveryDrPlanExecutionStepStatusCountsRemainingStepsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDisasterRecoveryDrPlanExecutionStepStatusCountsRemainingStepsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDisasterRecoveryDrPlanExecutionStepStatusCountsRemainingStepsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDisasterRecoveryDrPlanExecutionStepStatusCountsRemainingStepsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "inProgress", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InProgress
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "paused", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Paused
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "queued", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Queued
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "totalRemaining", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalRemaining
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDisasterRecoveryDrPlanExecution.DataOciDisasterRecoveryDrPlanExecutionStepStatusCountsRemainingSteps\"}", isOptional: true)]
        public virtual oci.DataOciDisasterRecoveryDrPlanExecution.IDataOciDisasterRecoveryDrPlanExecutionStepStatusCountsRemainingSteps? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDisasterRecoveryDrPlanExecution.IDataOciDisasterRecoveryDrPlanExecutionStepStatusCountsRemainingSteps?>();
            set => SetInstanceProperty(value);
        }
    }
}
