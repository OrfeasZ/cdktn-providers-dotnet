using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDisasterRecoveryDrPlans
{
    [JsiiClass(nativeType: typeof(oci.DataOciDisasterRecoveryDrPlans.DataOciDisasterRecoveryDrPlansDrPlanCollectionItemsPlanGroupsStepsUserDefinedStepOutputReference), fullyQualifiedName: "oci.dataOciDisasterRecoveryDrPlans.DataOciDisasterRecoveryDrPlansDrPlanCollectionItemsPlanGroupsStepsUserDefinedStepOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDisasterRecoveryDrPlansDrPlanCollectionItemsPlanGroupsStepsUserDefinedStepOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDisasterRecoveryDrPlansDrPlanCollectionItemsPlanGroupsStepsUserDefinedStepOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDisasterRecoveryDrPlansDrPlanCollectionItemsPlanGroupsStepsUserDefinedStepOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDisasterRecoveryDrPlansDrPlanCollectionItemsPlanGroupsStepsUserDefinedStepOutputReference(DeputyProps props): base(props)
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

        [JsiiProperty(name: "objectStorageScriptLocation", typeJson: "{\"fqn\":\"oci.dataOciDisasterRecoveryDrPlans.DataOciDisasterRecoveryDrPlansDrPlanCollectionItemsPlanGroupsStepsUserDefinedStepObjectStorageScriptLocationList\"}")]
        public virtual oci.DataOciDisasterRecoveryDrPlans.DataOciDisasterRecoveryDrPlansDrPlanCollectionItemsPlanGroupsStepsUserDefinedStepObjectStorageScriptLocationList ObjectStorageScriptLocation
        {
            get => GetInstanceProperty<oci.DataOciDisasterRecoveryDrPlans.DataOciDisasterRecoveryDrPlansDrPlanCollectionItemsPlanGroupsStepsUserDefinedStepObjectStorageScriptLocationList>()!;
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDisasterRecoveryDrPlans.DataOciDisasterRecoveryDrPlansDrPlanCollectionItemsPlanGroupsStepsUserDefinedStep\"}", isOptional: true)]
        public virtual oci.DataOciDisasterRecoveryDrPlans.IDataOciDisasterRecoveryDrPlansDrPlanCollectionItemsPlanGroupsStepsUserDefinedStep? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDisasterRecoveryDrPlans.IDataOciDisasterRecoveryDrPlansDrPlanCollectionItemsPlanGroupsStepsUserDefinedStep?>();
            set => SetInstanceProperty(value);
        }
    }
}
