using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDisasterRecoveryDrPlan
{
    [JsiiClass(nativeType: typeof(oci.DataOciDisasterRecoveryDrPlan.DataOciDisasterRecoveryDrPlanPlanGroupsStepsUserDefinedStepOutputReference), fullyQualifiedName: "oci.dataOciDisasterRecoveryDrPlan.DataOciDisasterRecoveryDrPlanPlanGroupsStepsUserDefinedStepOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDisasterRecoveryDrPlanPlanGroupsStepsUserDefinedStepOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDisasterRecoveryDrPlanPlanGroupsStepsUserDefinedStepOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDisasterRecoveryDrPlanPlanGroupsStepsUserDefinedStepOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDisasterRecoveryDrPlanPlanGroupsStepsUserDefinedStepOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "functionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FunctionId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "functionRegion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FunctionRegion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "objectStorageScriptLocation", typeJson: "{\"fqn\":\"oci.dataOciDisasterRecoveryDrPlan.DataOciDisasterRecoveryDrPlanPlanGroupsStepsUserDefinedStepObjectStorageScriptLocationList\"}")]
        public virtual oci.DataOciDisasterRecoveryDrPlan.DataOciDisasterRecoveryDrPlanPlanGroupsStepsUserDefinedStepObjectStorageScriptLocationList ObjectStorageScriptLocation
        {
            get => GetInstanceProperty<oci.DataOciDisasterRecoveryDrPlan.DataOciDisasterRecoveryDrPlanPlanGroupsStepsUserDefinedStepObjectStorageScriptLocationList>()!;
        }

        [JsiiProperty(name: "requestBody", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RequestBody
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "runAsUser", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RunAsUser
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "runOnInstanceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RunOnInstanceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "runOnInstanceRegion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RunOnInstanceRegion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scriptCommand", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScriptCommand
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "stepType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StepType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDisasterRecoveryDrPlan.DataOciDisasterRecoveryDrPlanPlanGroupsStepsUserDefinedStep\"}", isOptional: true)]
        public virtual oci.DataOciDisasterRecoveryDrPlan.IDataOciDisasterRecoveryDrPlanPlanGroupsStepsUserDefinedStep? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDisasterRecoveryDrPlan.IDataOciDisasterRecoveryDrPlanPlanGroupsStepsUserDefinedStep?>();
            set => SetInstanceProperty(value);
        }
    }
}
