using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementRunbookVersion
{
    [JsiiClass(nativeType: typeof(oci.FleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionGroupsPropertiesOutputReference), fullyQualifiedName: "oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionGroupsPropertiesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class FleetAppsManagementRunbookVersionGroupsPropertiesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public FleetAppsManagementRunbookVersionGroupsPropertiesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected FleetAppsManagementRunbookVersionGroupsPropertiesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FleetAppsManagementRunbookVersionGroupsPropertiesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putNotificationPreferences", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionGroupsPropertiesNotificationPreferences\"}}]")]
        public virtual void PutNotificationPreferences(oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionGroupsPropertiesNotificationPreferences @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionGroupsPropertiesNotificationPreferences)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPauseDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionGroupsPropertiesPauseDetails\"}}]")]
        public virtual void PutPauseDetails(oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionGroupsPropertiesPauseDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionGroupsPropertiesPauseDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRunOn", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionGroupsPropertiesRunOn\"}}]")]
        public virtual void PutRunOn(oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionGroupsPropertiesRunOn @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionGroupsPropertiesRunOn)}, new object[]{@value});
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

        [JsiiProperty(name: "notificationPreferences", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionGroupsPropertiesNotificationPreferencesOutputReference\"}")]
        public virtual oci.FleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionGroupsPropertiesNotificationPreferencesOutputReference NotificationPreferences
        {
            get => GetInstanceProperty<oci.FleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionGroupsPropertiesNotificationPreferencesOutputReference>()!;
        }

        [JsiiProperty(name: "pauseDetails", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionGroupsPropertiesPauseDetailsOutputReference\"}")]
        public virtual oci.FleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionGroupsPropertiesPauseDetailsOutputReference PauseDetails
        {
            get => GetInstanceProperty<oci.FleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionGroupsPropertiesPauseDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "runOn", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionGroupsPropertiesRunOnOutputReference\"}")]
        public virtual oci.FleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionGroupsPropertiesRunOnOutputReference RunOn
        {
            get => GetInstanceProperty<oci.FleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionGroupsPropertiesRunOnOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "actionOnFailureInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ActionOnFailureInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "notificationPreferencesInput", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionGroupsPropertiesNotificationPreferences\"}", isOptional: true)]
        public virtual oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionGroupsPropertiesNotificationPreferences? NotificationPreferencesInput
        {
            get => GetInstanceProperty<oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionGroupsPropertiesNotificationPreferences?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pauseDetailsInput", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionGroupsPropertiesPauseDetails\"}", isOptional: true)]
        public virtual oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionGroupsPropertiesPauseDetails? PauseDetailsInput
        {
            get => GetInstanceProperty<oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionGroupsPropertiesPauseDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "preConditionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PreConditionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "runOnInput", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionGroupsPropertiesRunOn\"}", isOptional: true)]
        public virtual oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionGroupsPropertiesRunOn? RunOnInput
        {
            get => GetInstanceProperty<oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionGroupsPropertiesRunOn?>();
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionGroupsProperties\"}", isOptional: true)]
        public virtual oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionGroupsProperties? InternalValue
        {
            get => GetInstanceProperty<oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionGroupsProperties?>();
            set => SetInstanceProperty(value);
        }
    }
}
