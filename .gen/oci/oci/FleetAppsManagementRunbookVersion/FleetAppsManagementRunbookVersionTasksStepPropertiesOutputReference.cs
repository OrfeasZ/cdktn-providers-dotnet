using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementRunbookVersion
{
    [JsiiClass(nativeType: typeof(oci.FleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionTasksStepPropertiesOutputReference), fullyQualifiedName: "oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionTasksStepPropertiesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class FleetAppsManagementRunbookVersionTasksStepPropertiesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public FleetAppsManagementRunbookVersionTasksStepPropertiesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected FleetAppsManagementRunbookVersionTasksStepPropertiesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FleetAppsManagementRunbookVersionTasksStepPropertiesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putNotificationPreferences", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionTasksStepPropertiesNotificationPreferences\"}}]")]
        public virtual void PutNotificationPreferences(oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionTasksStepPropertiesNotificationPreferences @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionTasksStepPropertiesNotificationPreferences)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPauseDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionTasksStepPropertiesPauseDetails\"}}]")]
        public virtual void PutPauseDetails(oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionTasksStepPropertiesPauseDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionTasksStepPropertiesPauseDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRunOn", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionTasksStepPropertiesRunOn\"}}]")]
        public virtual void PutRunOn(oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionTasksStepPropertiesRunOn @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionTasksStepPropertiesRunOn)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetNotificationPreferences")]
        public virtual void ResetNotificationPreferences()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPauseDetails")]
        public virtual void ResetPauseDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPreCondition")]
        public virtual void ResetPreCondition()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRunOn")]
        public virtual void ResetRunOn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "notificationPreferences", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionTasksStepPropertiesNotificationPreferencesOutputReference\"}")]
        public virtual oci.FleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionTasksStepPropertiesNotificationPreferencesOutputReference NotificationPreferences
        {
            get => GetInstanceProperty<oci.FleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionTasksStepPropertiesNotificationPreferencesOutputReference>()!;
        }

        [JsiiProperty(name: "pauseDetails", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionTasksStepPropertiesPauseDetailsOutputReference\"}")]
        public virtual oci.FleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionTasksStepPropertiesPauseDetailsOutputReference PauseDetails
        {
            get => GetInstanceProperty<oci.FleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionTasksStepPropertiesPauseDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "runOn", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionTasksStepPropertiesRunOnOutputReference\"}")]
        public virtual oci.FleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionTasksStepPropertiesRunOnOutputReference RunOn
        {
            get => GetInstanceProperty<oci.FleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionTasksStepPropertiesRunOnOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "actionOnFailureInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ActionOnFailureInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "notificationPreferencesInput", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionTasksStepPropertiesNotificationPreferences\"}", isOptional: true)]
        public virtual oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionTasksStepPropertiesNotificationPreferences? NotificationPreferencesInput
        {
            get => GetInstanceProperty<oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionTasksStepPropertiesNotificationPreferences?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pauseDetailsInput", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionTasksStepPropertiesPauseDetails\"}", isOptional: true)]
        public virtual oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionTasksStepPropertiesPauseDetails? PauseDetailsInput
        {
            get => GetInstanceProperty<oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionTasksStepPropertiesPauseDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "preConditionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PreConditionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "runOnInput", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionTasksStepPropertiesRunOn\"}", isOptional: true)]
        public virtual oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionTasksStepPropertiesRunOn? RunOnInput
        {
            get => GetInstanceProperty<oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionTasksStepPropertiesRunOn?>();
        }

        [JsiiProperty(name: "actionOnFailure", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ActionOnFailure
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "preCondition", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PreCondition
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionTasksStepProperties\"}", isOptional: true)]
        public virtual oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionTasksStepProperties? InternalValue
        {
            get => GetInstanceProperty<oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionTasksStepProperties?>();
            set => SetInstanceProperty(value);
        }
    }
}
