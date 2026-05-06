using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementRunbookVersion
{
    [JsiiClass(nativeType: typeof(oci.FleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionTasksStepPropertiesRunOnPreviousTaskInstanceDetailsOutputVariableDetailsOutputReference), fullyQualifiedName: "oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionTasksStepPropertiesRunOnPreviousTaskInstanceDetailsOutputVariableDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class FleetAppsManagementRunbookVersionTasksStepPropertiesRunOnPreviousTaskInstanceDetailsOutputVariableDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public FleetAppsManagementRunbookVersionTasksStepPropertiesRunOnPreviousTaskInstanceDetailsOutputVariableDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected FleetAppsManagementRunbookVersionTasksStepPropertiesRunOnPreviousTaskInstanceDetailsOutputVariableDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FleetAppsManagementRunbookVersionTasksStepPropertiesRunOnPreviousTaskInstanceDetailsOutputVariableDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetOutputVariableName")]
        public virtual void ResetOutputVariableName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStepName")]
        public virtual void ResetStepName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "outputVariableNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OutputVariableNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stepNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StepNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "outputVariableName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OutputVariableName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "stepName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StepName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionTasksStepPropertiesRunOnPreviousTaskInstanceDetailsOutputVariableDetails\"}", isOptional: true)]
        public virtual oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionTasksStepPropertiesRunOnPreviousTaskInstanceDetailsOutputVariableDetails? InternalValue
        {
            get => GetInstanceProperty<oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionTasksStepPropertiesRunOnPreviousTaskInstanceDetailsOutputVariableDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
