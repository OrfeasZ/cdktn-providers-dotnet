using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstanceConfiguration
{
    [JsiiClass(nativeType: typeof(oci.CoreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsOutputReference), fullyQualifiedName: "oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CoreInstanceConfigurationInstanceDetailsLaunchDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CoreInstanceConfigurationInstanceDetailsLaunchDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CoreInstanceConfigurationInstanceDetailsLaunchDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CoreInstanceConfigurationInstanceDetailsLaunchDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAgentConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsAgentConfig\"}}]")]
        public virtual void PutAgentConfig(oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsLaunchDetailsAgentConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsLaunchDetailsAgentConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAvailabilityConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsAvailabilityConfig\"}}]")]
        public virtual void PutAvailabilityConfig(oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsLaunchDetailsAvailabilityConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsLaunchDetailsAvailabilityConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCreateVnicDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsCreateVnicDetails\"}}]")]
        public virtual void PutCreateVnicDetails(oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsLaunchDetailsCreateVnicDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsLaunchDetailsCreateVnicDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putInstanceOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsInstanceOptions\"}}]")]
        public virtual void PutInstanceOptions(oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsLaunchDetailsInstanceOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsLaunchDetailsInstanceOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLaunchOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsLaunchOptions\"}}]")]
        public virtual void PutLaunchOptions(oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsLaunchDetailsLaunchOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsLaunchDetailsLaunchOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLicensingConfigs", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsLicensingConfigs\"}}]")]
        public virtual void PutLicensingConfigs(oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsLaunchDetailsLicensingConfigs @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsLaunchDetailsLicensingConfigs)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPlacementConstraintDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsPlacementConstraintDetails\"}}]")]
        public virtual void PutPlacementConstraintDetails(oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsLaunchDetailsPlacementConstraintDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsLaunchDetailsPlacementConstraintDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPlatformConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsPlatformConfig\"}}]")]
        public virtual void PutPlatformConfig(oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsLaunchDetailsPlatformConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsLaunchDetailsPlatformConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPreemptibleInstanceConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsPreemptibleInstanceConfig\"}}]")]
        public virtual void PutPreemptibleInstanceConfig(oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsLaunchDetailsPreemptibleInstanceConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsLaunchDetailsPreemptibleInstanceConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putShapeConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsShapeConfig\"}}]")]
        public virtual void PutShapeConfig(oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsLaunchDetailsShapeConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsLaunchDetailsShapeConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSourceDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsSourceDetails\"}}]")]
        public virtual void PutSourceDetails(oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsLaunchDetailsSourceDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsLaunchDetailsSourceDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAgentConfig")]
        public virtual void ResetAgentConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAvailabilityConfig")]
        public virtual void ResetAvailabilityConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAvailabilityDomain")]
        public virtual void ResetAvailabilityDomain()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCapacityReservationId")]
        public virtual void ResetCapacityReservationId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClusterPlacementGroupId")]
        public virtual void ResetClusterPlacementGroupId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCompartmentId")]
        public virtual void ResetCompartmentId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetComputeClusterId")]
        public virtual void ResetComputeClusterId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCreateVnicDetails")]
        public virtual void ResetCreateVnicDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDedicatedVmHostId")]
        public virtual void ResetDedicatedVmHostId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefinedTags")]
        public virtual void ResetDefinedTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDisplayName")]
        public virtual void ResetDisplayName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExtendedMetadata")]
        public virtual void ResetExtendedMetadata()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFaultDomain")]
        public virtual void ResetFaultDomain()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFreeformTags")]
        public virtual void ResetFreeformTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceOptions")]
        public virtual void ResetInstanceOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIpxeScript")]
        public virtual void ResetIpxeScript()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsAiEnterpriseEnabled")]
        public virtual void ResetIsAiEnterpriseEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsPvEncryptionInTransitEnabled")]
        public virtual void ResetIsPvEncryptionInTransitEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLaunchMode")]
        public virtual void ResetLaunchMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLaunchOptions")]
        public virtual void ResetLaunchOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLicensingConfigs")]
        public virtual void ResetLicensingConfigs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMetadata")]
        public virtual void ResetMetadata()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPlacementConstraintDetails")]
        public virtual void ResetPlacementConstraintDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPlatformConfig")]
        public virtual void ResetPlatformConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPreemptibleInstanceConfig")]
        public virtual void ResetPreemptibleInstanceConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPreferredMaintenanceAction")]
        public virtual void ResetPreferredMaintenanceAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecurityAttributes")]
        public virtual void ResetSecurityAttributes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetShape")]
        public virtual void ResetShape()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetShapeConfig")]
        public virtual void ResetShapeConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceDetails")]
        public virtual void ResetSourceDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "agentConfig", typeJson: "{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsAgentConfigOutputReference\"}")]
        public virtual oci.CoreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsAgentConfigOutputReference AgentConfig
        {
            get => GetInstanceProperty<oci.CoreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsAgentConfigOutputReference>()!;
        }

        [JsiiProperty(name: "availabilityConfig", typeJson: "{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsAvailabilityConfigOutputReference\"}")]
        public virtual oci.CoreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsAvailabilityConfigOutputReference AvailabilityConfig
        {
            get => GetInstanceProperty<oci.CoreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsAvailabilityConfigOutputReference>()!;
        }

        [JsiiProperty(name: "createVnicDetails", typeJson: "{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsCreateVnicDetailsOutputReference\"}")]
        public virtual oci.CoreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsCreateVnicDetailsOutputReference CreateVnicDetails
        {
            get => GetInstanceProperty<oci.CoreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsCreateVnicDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "instanceOptions", typeJson: "{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsInstanceOptionsOutputReference\"}")]
        public virtual oci.CoreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsInstanceOptionsOutputReference InstanceOptions
        {
            get => GetInstanceProperty<oci.CoreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsInstanceOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "launchOptions", typeJson: "{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsLaunchOptionsOutputReference\"}")]
        public virtual oci.CoreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsLaunchOptionsOutputReference LaunchOptions
        {
            get => GetInstanceProperty<oci.CoreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsLaunchOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "licensingConfigs", typeJson: "{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsLicensingConfigsOutputReference\"}")]
        public virtual oci.CoreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsLicensingConfigsOutputReference LicensingConfigs
        {
            get => GetInstanceProperty<oci.CoreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsLicensingConfigsOutputReference>()!;
        }

        [JsiiProperty(name: "placementConstraintDetails", typeJson: "{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsPlacementConstraintDetailsOutputReference\"}")]
        public virtual oci.CoreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsPlacementConstraintDetailsOutputReference PlacementConstraintDetails
        {
            get => GetInstanceProperty<oci.CoreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsPlacementConstraintDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "platformConfig", typeJson: "{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsPlatformConfigOutputReference\"}")]
        public virtual oci.CoreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsPlatformConfigOutputReference PlatformConfig
        {
            get => GetInstanceProperty<oci.CoreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsPlatformConfigOutputReference>()!;
        }

        [JsiiProperty(name: "preemptibleInstanceConfig", typeJson: "{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsPreemptibleInstanceConfigOutputReference\"}")]
        public virtual oci.CoreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsPreemptibleInstanceConfigOutputReference PreemptibleInstanceConfig
        {
            get => GetInstanceProperty<oci.CoreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsPreemptibleInstanceConfigOutputReference>()!;
        }

        [JsiiProperty(name: "shapeConfig", typeJson: "{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsShapeConfigOutputReference\"}")]
        public virtual oci.CoreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsShapeConfigOutputReference ShapeConfig
        {
            get => GetInstanceProperty<oci.CoreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsShapeConfigOutputReference>()!;
        }

        [JsiiProperty(name: "sourceDetails", typeJson: "{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsSourceDetailsOutputReference\"}")]
        public virtual oci.CoreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsSourceDetailsOutputReference SourceDetails
        {
            get => GetInstanceProperty<oci.CoreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsSourceDetailsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "agentConfigInput", typeJson: "{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsAgentConfig\"}", isOptional: true)]
        public virtual oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsLaunchDetailsAgentConfig? AgentConfigInput
        {
            get => GetInstanceProperty<oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsLaunchDetailsAgentConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "availabilityConfigInput", typeJson: "{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsAvailabilityConfig\"}", isOptional: true)]
        public virtual oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsLaunchDetailsAvailabilityConfig? AvailabilityConfigInput
        {
            get => GetInstanceProperty<oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsLaunchDetailsAvailabilityConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "availabilityDomainInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AvailabilityDomainInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "capacityReservationIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CapacityReservationIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterPlacementGroupIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClusterPlacementGroupIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "computeClusterIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ComputeClusterIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "createVnicDetailsInput", typeJson: "{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsCreateVnicDetails\"}", isOptional: true)]
        public virtual oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsLaunchDetailsCreateVnicDetails? CreateVnicDetailsInput
        {
            get => GetInstanceProperty<oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsLaunchDetailsCreateVnicDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dedicatedVmHostIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DedicatedVmHostIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "definedTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? DefinedTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "extendedMetadataInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? ExtendedMetadataInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "faultDomainInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FaultDomainInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "freeformTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? FreeformTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceOptionsInput", typeJson: "{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsInstanceOptions\"}", isOptional: true)]
        public virtual oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsLaunchDetailsInstanceOptions? InstanceOptionsInput
        {
            get => GetInstanceProperty<oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsLaunchDetailsInstanceOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipxeScriptInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IpxeScriptInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isAiEnterpriseEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsAiEnterpriseEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isPvEncryptionInTransitEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsPvEncryptionInTransitEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "launchModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LaunchModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "launchOptionsInput", typeJson: "{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsLaunchOptions\"}", isOptional: true)]
        public virtual oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsLaunchDetailsLaunchOptions? LaunchOptionsInput
        {
            get => GetInstanceProperty<oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsLaunchDetailsLaunchOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "licensingConfigsInput", typeJson: "{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsLicensingConfigs\"}", isOptional: true)]
        public virtual oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsLaunchDetailsLicensingConfigs? LicensingConfigsInput
        {
            get => GetInstanceProperty<oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsLaunchDetailsLicensingConfigs?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metadataInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? MetadataInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "placementConstraintDetailsInput", typeJson: "{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsPlacementConstraintDetails\"}", isOptional: true)]
        public virtual oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsLaunchDetailsPlacementConstraintDetails? PlacementConstraintDetailsInput
        {
            get => GetInstanceProperty<oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsLaunchDetailsPlacementConstraintDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "platformConfigInput", typeJson: "{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsPlatformConfig\"}", isOptional: true)]
        public virtual oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsLaunchDetailsPlatformConfig? PlatformConfigInput
        {
            get => GetInstanceProperty<oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsLaunchDetailsPlatformConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "preemptibleInstanceConfigInput", typeJson: "{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsPreemptibleInstanceConfig\"}", isOptional: true)]
        public virtual oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsLaunchDetailsPreemptibleInstanceConfig? PreemptibleInstanceConfigInput
        {
            get => GetInstanceProperty<oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsLaunchDetailsPreemptibleInstanceConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "preferredMaintenanceActionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PreferredMaintenanceActionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityAttributesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? SecurityAttributesInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "shapeConfigInput", typeJson: "{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsShapeConfig\"}", isOptional: true)]
        public virtual oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsLaunchDetailsShapeConfig? ShapeConfigInput
        {
            get => GetInstanceProperty<oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsLaunchDetailsShapeConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "shapeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ShapeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceDetailsInput", typeJson: "{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsSourceDetails\"}", isOptional: true)]
        public virtual oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsLaunchDetailsSourceDetails? SourceDetailsInput
        {
            get => GetInstanceProperty<oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsLaunchDetailsSourceDetails?>();
        }

        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityDomain
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "capacityReservationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CapacityReservationId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "clusterPlacementGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterPlacementGroupId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "computeClusterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputeClusterId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dedicatedVmHostId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DedicatedVmHostId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> DefinedTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "extendedMetadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> ExtendedMetadata
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "faultDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FaultDomain
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> FreeformTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ipxeScript", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpxeScript
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "isAiEnterpriseEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsAiEnterpriseEnabled
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "isPvEncryptionInTransitEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsPvEncryptionInTransitEnabled
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "launchMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LaunchMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Metadata
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "preferredMaintenanceAction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PreferredMaintenanceAction
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "securityAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> SecurityAttributes
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "shape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Shape
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetails\"}", isOptional: true)]
        public virtual oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsLaunchDetails? InternalValue
        {
            get => GetInstanceProperty<oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsLaunchDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
