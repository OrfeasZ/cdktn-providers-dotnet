using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DisasterRecoveryDrPlanExecution
{
    [JsiiClass(nativeType: typeof(oci.DisasterRecoveryDrPlanExecution.DisasterRecoveryDrPlanExecutionStepStatusCountsOutputReference), fullyQualifiedName: "oci.disasterRecoveryDrPlanExecution.DisasterRecoveryDrPlanExecutionStepStatusCountsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DisasterRecoveryDrPlanExecutionStepStatusCountsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DisasterRecoveryDrPlanExecutionStepStatusCountsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DisasterRecoveryDrPlanExecutionStepStatusCountsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DisasterRecoveryDrPlanExecutionStepStatusCountsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "failedSteps", typeJson: "{\"fqn\":\"oci.disasterRecoveryDrPlanExecution.DisasterRecoveryDrPlanExecutionStepStatusCountsFailedStepsList\"}")]
        public virtual oci.DisasterRecoveryDrPlanExecution.DisasterRecoveryDrPlanExecutionStepStatusCountsFailedStepsList FailedSteps
        {
            get => GetInstanceProperty<oci.DisasterRecoveryDrPlanExecution.DisasterRecoveryDrPlanExecutionStepStatusCountsFailedStepsList>()!;
        }

        [JsiiProperty(name: "remainingSteps", typeJson: "{\"fqn\":\"oci.disasterRecoveryDrPlanExecution.DisasterRecoveryDrPlanExecutionStepStatusCountsRemainingStepsList\"}")]
        public virtual oci.DisasterRecoveryDrPlanExecution.DisasterRecoveryDrPlanExecutionStepStatusCountsRemainingStepsList RemainingSteps
        {
            get => GetInstanceProperty<oci.DisasterRecoveryDrPlanExecution.DisasterRecoveryDrPlanExecutionStepStatusCountsRemainingStepsList>()!;
        }

        [JsiiProperty(name: "skippedSteps", typeJson: "{\"fqn\":\"oci.disasterRecoveryDrPlanExecution.DisasterRecoveryDrPlanExecutionStepStatusCountsSkippedStepsList\"}")]
        public virtual oci.DisasterRecoveryDrPlanExecution.DisasterRecoveryDrPlanExecutionStepStatusCountsSkippedStepsList SkippedSteps
        {
            get => GetInstanceProperty<oci.DisasterRecoveryDrPlanExecution.DisasterRecoveryDrPlanExecutionStepStatusCountsSkippedStepsList>()!;
        }

        [JsiiProperty(name: "successfulSteps", typeJson: "{\"fqn\":\"oci.disasterRecoveryDrPlanExecution.DisasterRecoveryDrPlanExecutionStepStatusCountsSuccessfulStepsList\"}")]
        public virtual oci.DisasterRecoveryDrPlanExecution.DisasterRecoveryDrPlanExecutionStepStatusCountsSuccessfulStepsList SuccessfulSteps
        {
            get => GetInstanceProperty<oci.DisasterRecoveryDrPlanExecution.DisasterRecoveryDrPlanExecutionStepStatusCountsSuccessfulStepsList>()!;
        }

        [JsiiProperty(name: "totalSteps", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalSteps
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "warningSteps", typeJson: "{\"fqn\":\"oci.disasterRecoveryDrPlanExecution.DisasterRecoveryDrPlanExecutionStepStatusCountsWarningStepsList\"}")]
        public virtual oci.DisasterRecoveryDrPlanExecution.DisasterRecoveryDrPlanExecutionStepStatusCountsWarningStepsList WarningSteps
        {
            get => GetInstanceProperty<oci.DisasterRecoveryDrPlanExecution.DisasterRecoveryDrPlanExecutionStepStatusCountsWarningStepsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.disasterRecoveryDrPlanExecution.DisasterRecoveryDrPlanExecutionStepStatusCounts\"}", isOptional: true)]
        public virtual oci.DisasterRecoveryDrPlanExecution.IDisasterRecoveryDrPlanExecutionStepStatusCounts? InternalValue
        {
            get => GetInstanceProperty<oci.DisasterRecoveryDrPlanExecution.IDisasterRecoveryDrPlanExecutionStepStatusCounts?>();
            set => SetInstanceProperty(value);
        }
    }
}
