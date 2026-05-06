using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDisasterRecoveryDrPlans
{
    [JsiiClass(nativeType: typeof(oci.DataOciDisasterRecoveryDrPlans.DataOciDisasterRecoveryDrPlansDrPlanCollectionItemsPlanGroupsStepsOutputReference), fullyQualifiedName: "oci.dataOciDisasterRecoveryDrPlans.DataOciDisasterRecoveryDrPlansDrPlanCollectionItemsPlanGroupsStepsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDisasterRecoveryDrPlansDrPlanCollectionItemsPlanGroupsStepsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDisasterRecoveryDrPlansDrPlanCollectionItemsPlanGroupsStepsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDisasterRecoveryDrPlansDrPlanCollectionItemsPlanGroupsStepsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDisasterRecoveryDrPlansDrPlanCollectionItemsPlanGroupsStepsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "errorMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ErrorMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "groupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GroupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "memberId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MemberId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "refreshStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RefreshStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Timeout
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "typeDisplayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TypeDisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "userDefinedStep", typeJson: "{\"fqn\":\"oci.dataOciDisasterRecoveryDrPlans.DataOciDisasterRecoveryDrPlansDrPlanCollectionItemsPlanGroupsStepsUserDefinedStepList\"}")]
        public virtual oci.DataOciDisasterRecoveryDrPlans.DataOciDisasterRecoveryDrPlansDrPlanCollectionItemsPlanGroupsStepsUserDefinedStepList UserDefinedStep
        {
            get => GetInstanceProperty<oci.DataOciDisasterRecoveryDrPlans.DataOciDisasterRecoveryDrPlansDrPlanCollectionItemsPlanGroupsStepsUserDefinedStepList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDisasterRecoveryDrPlans.DataOciDisasterRecoveryDrPlansDrPlanCollectionItemsPlanGroupsSteps\"}", isOptional: true)]
        public virtual oci.DataOciDisasterRecoveryDrPlans.IDataOciDisasterRecoveryDrPlansDrPlanCollectionItemsPlanGroupsSteps? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDisasterRecoveryDrPlans.IDataOciDisasterRecoveryDrPlansDrPlanCollectionItemsPlanGroupsSteps?>();
            set => SetInstanceProperty(value);
        }
    }
}
