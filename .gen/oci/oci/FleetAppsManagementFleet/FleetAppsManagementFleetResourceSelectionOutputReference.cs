using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementFleet
{
    [JsiiClass(nativeType: typeof(oci.FleetAppsManagementFleet.FleetAppsManagementFleetResourceSelectionOutputReference), fullyQualifiedName: "oci.fleetAppsManagementFleet.FleetAppsManagementFleetResourceSelectionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class FleetAppsManagementFleetResourceSelectionOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public FleetAppsManagementFleetResourceSelectionOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FleetAppsManagementFleetResourceSelectionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FleetAppsManagementFleetResourceSelectionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putRuleSelectionCriteria", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.fleetAppsManagementFleet.FleetAppsManagementFleetResourceSelectionRuleSelectionCriteria\"}}]")]
        public virtual void PutRuleSelectionCriteria(oci.FleetAppsManagementFleet.IFleetAppsManagementFleetResourceSelectionRuleSelectionCriteria @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.FleetAppsManagementFleet.IFleetAppsManagementFleetResourceSelectionRuleSelectionCriteria)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetRuleSelectionCriteria")]
        public virtual void ResetRuleSelectionCriteria()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "ruleSelectionCriteria", typeJson: "{\"fqn\":\"oci.fleetAppsManagementFleet.FleetAppsManagementFleetResourceSelectionRuleSelectionCriteriaOutputReference\"}")]
        public virtual oci.FleetAppsManagementFleet.FleetAppsManagementFleetResourceSelectionRuleSelectionCriteriaOutputReference RuleSelectionCriteria
        {
            get => GetInstanceProperty<oci.FleetAppsManagementFleet.FleetAppsManagementFleetResourceSelectionRuleSelectionCriteriaOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceSelectionTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceSelectionTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ruleSelectionCriteriaInput", typeJson: "{\"fqn\":\"oci.fleetAppsManagementFleet.FleetAppsManagementFleetResourceSelectionRuleSelectionCriteria\"}", isOptional: true)]
        public virtual oci.FleetAppsManagementFleet.IFleetAppsManagementFleetResourceSelectionRuleSelectionCriteria? RuleSelectionCriteriaInput
        {
            get => GetInstanceProperty<oci.FleetAppsManagementFleet.IFleetAppsManagementFleetResourceSelectionRuleSelectionCriteria?>();
        }

        [JsiiProperty(name: "resourceSelectionType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceSelectionType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.fleetAppsManagementFleet.FleetAppsManagementFleetResourceSelection\"}", isOptional: true)]
        public virtual oci.FleetAppsManagementFleet.IFleetAppsManagementFleetResourceSelection? InternalValue
        {
            get => GetInstanceProperty<oci.FleetAppsManagementFleet.IFleetAppsManagementFleetResourceSelection?>();
            set => SetInstanceProperty(value);
        }
    }
}
