using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementCompliancePolicyRule
{
    [JsiiClass(nativeType: typeof(oci.FleetAppsManagementCompliancePolicyRule.FleetAppsManagementCompliancePolicyRulePatchSelectionOutputReference), fullyQualifiedName: "oci.fleetAppsManagementCompliancePolicyRule.FleetAppsManagementCompliancePolicyRulePatchSelectionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class FleetAppsManagementCompliancePolicyRulePatchSelectionOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public FleetAppsManagementCompliancePolicyRulePatchSelectionOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected FleetAppsManagementCompliancePolicyRulePatchSelectionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FleetAppsManagementCompliancePolicyRulePatchSelectionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetDaysSinceRelease")]
        public virtual void ResetDaysSinceRelease()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPatchLevel")]
        public virtual void ResetPatchLevel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPatchName")]
        public virtual void ResetPatchName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "daysSinceReleaseInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DaysSinceReleaseInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "patchLevelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PatchLevelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "patchNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PatchNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "selectionTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SelectionTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "daysSinceRelease", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DaysSinceRelease
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "patchLevel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PatchLevel
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "patchName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PatchName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "selectionType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SelectionType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.fleetAppsManagementCompliancePolicyRule.FleetAppsManagementCompliancePolicyRulePatchSelection\"}", isOptional: true)]
        public virtual oci.FleetAppsManagementCompliancePolicyRule.IFleetAppsManagementCompliancePolicyRulePatchSelection? InternalValue
        {
            get => GetInstanceProperty<oci.FleetAppsManagementCompliancePolicyRule.IFleetAppsManagementCompliancePolicyRulePatchSelection?>();
            set => SetInstanceProperty(value);
        }
    }
}
