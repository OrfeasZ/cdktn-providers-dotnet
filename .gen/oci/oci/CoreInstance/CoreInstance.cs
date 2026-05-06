using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstance
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance oci_core_instance}.</summary>
    [JsiiClass(nativeType: typeof(oci.CoreInstance.CoreInstance), fullyQualifiedName: "oci.coreInstance.CoreInstance", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.coreInstance.CoreInstanceConfig\"}}]")]
    public class CoreInstance : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance oci_core_instance} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public CoreInstance(Constructs.Construct scope, string id, oci.CoreInstance.ICoreInstanceConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.CoreInstance.ICoreInstanceConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CoreInstance(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CoreInstance(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a CoreInstance resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the CoreInstance to import.</param>
        /// <param name="importFromId">The id of the existing CoreInstance that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the CoreInstance to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the CoreInstance to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing CoreInstance that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the CoreInstance to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.CoreInstance.CoreInstance), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAgentConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreInstance.CoreInstanceAgentConfig\"}}]")]
        public virtual void PutAgentConfig(oci.CoreInstance.ICoreInstanceAgentConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreInstance.ICoreInstanceAgentConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAvailabilityConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreInstance.CoreInstanceAvailabilityConfig\"}}]")]
        public virtual void PutAvailabilityConfig(oci.CoreInstance.ICoreInstanceAvailabilityConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreInstance.ICoreInstanceAvailabilityConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCreateVnicDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreInstance.CoreInstanceCreateVnicDetails\"}}]")]
        public virtual void PutCreateVnicDetails(oci.CoreInstance.ICoreInstanceCreateVnicDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreInstance.ICoreInstanceCreateVnicDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putInstanceOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreInstance.CoreInstanceInstanceOptions\"}}]")]
        public virtual void PutInstanceOptions(oci.CoreInstance.ICoreInstanceInstanceOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreInstance.ICoreInstanceInstanceOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLaunchOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreInstance.CoreInstanceLaunchOptions\"}}]")]
        public virtual void PutLaunchOptions(oci.CoreInstance.ICoreInstanceLaunchOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreInstance.ICoreInstanceLaunchOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLaunchVolumeAttachments", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.coreInstance.CoreInstanceLaunchVolumeAttachments\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutLaunchVolumeAttachments(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.CoreInstance.ICoreInstanceLaunchVolumeAttachments[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CoreInstance.ICoreInstanceLaunchVolumeAttachments).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CoreInstance.ICoreInstanceLaunchVolumeAttachments).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLicensingConfigs", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreInstance.CoreInstanceLicensingConfigs\"}}]")]
        public virtual void PutLicensingConfigs(oci.CoreInstance.ICoreInstanceLicensingConfigs @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreInstance.ICoreInstanceLicensingConfigs)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPlacementConstraintDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreInstance.CoreInstancePlacementConstraintDetails\"}}]")]
        public virtual void PutPlacementConstraintDetails(oci.CoreInstance.ICoreInstancePlacementConstraintDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreInstance.ICoreInstancePlacementConstraintDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPlatformConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreInstance.CoreInstancePlatformConfig\"}}]")]
        public virtual void PutPlatformConfig(oci.CoreInstance.ICoreInstancePlatformConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreInstance.ICoreInstancePlatformConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPreemptibleInstanceConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreInstance.CoreInstancePreemptibleInstanceConfig\"}}]")]
        public virtual void PutPreemptibleInstanceConfig(oci.CoreInstance.ICoreInstancePreemptibleInstanceConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreInstance.ICoreInstancePreemptibleInstanceConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putShapeConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreInstance.CoreInstanceShapeConfig\"}}]")]
        public virtual void PutShapeConfig(oci.CoreInstance.ICoreInstanceShapeConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreInstance.ICoreInstanceShapeConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSourceDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreInstance.CoreInstanceSourceDetails\"}}]")]
        public virtual void PutSourceDetails(oci.CoreInstance.ICoreInstanceSourceDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreInstance.ICoreInstanceSourceDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreInstance.CoreInstanceTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.CoreInstance.ICoreInstanceTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreInstance.ICoreInstanceTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAgentConfig")]
        public virtual void ResetAgentConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAsync")]
        public virtual void ResetAsync()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAvailabilityConfig")]
        public virtual void ResetAvailabilityConfig()
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

        [JsiiMethod(name: "resetHostnameLabel")]
        public virtual void ResetHostnameLabel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetImage")]
        public virtual void ResetImage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceConfigurationId")]
        public virtual void ResetInstanceConfigurationId()
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

        [JsiiMethod(name: "resetLaunchOptions")]
        public virtual void ResetLaunchOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLaunchVolumeAttachments")]
        public virtual void ResetLaunchVolumeAttachments()
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

        [JsiiMethod(name: "resetPreserveBootVolume")]
        public virtual void ResetPreserveBootVolume()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPreserveDataVolumesCreatedAtLaunch")]
        public virtual void ResetPreserveDataVolumesCreatedAtLaunch()
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

        [JsiiMethod(name: "resetState")]
        public virtual void ResetState()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSubnetId")]
        public virtual void ResetSubnetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUpdateOperationConstraint")]
        public virtual void ResetUpdateOperationConstraint()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(oci.CoreInstance.CoreInstance))!;

        [JsiiProperty(name: "agentConfig", typeJson: "{\"fqn\":\"oci.coreInstance.CoreInstanceAgentConfigOutputReference\"}")]
        public virtual oci.CoreInstance.CoreInstanceAgentConfigOutputReference AgentConfig
        {
            get => GetInstanceProperty<oci.CoreInstance.CoreInstanceAgentConfigOutputReference>()!;
        }

        [JsiiProperty(name: "availabilityConfig", typeJson: "{\"fqn\":\"oci.coreInstance.CoreInstanceAvailabilityConfigOutputReference\"}")]
        public virtual oci.CoreInstance.CoreInstanceAvailabilityConfigOutputReference AvailabilityConfig
        {
            get => GetInstanceProperty<oci.CoreInstance.CoreInstanceAvailabilityConfigOutputReference>()!;
        }

        [JsiiProperty(name: "bootVolumeId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BootVolumeId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "createVnicDetails", typeJson: "{\"fqn\":\"oci.coreInstance.CoreInstanceCreateVnicDetailsOutputReference\"}")]
        public virtual oci.CoreInstance.CoreInstanceCreateVnicDetailsOutputReference CreateVnicDetails
        {
            get => GetInstanceProperty<oci.CoreInstance.CoreInstanceCreateVnicDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "instanceOptions", typeJson: "{\"fqn\":\"oci.coreInstance.CoreInstanceInstanceOptionsOutputReference\"}")]
        public virtual oci.CoreInstance.CoreInstanceInstanceOptionsOutputReference InstanceOptions
        {
            get => GetInstanceProperty<oci.CoreInstance.CoreInstanceInstanceOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "isCrossNumaNode", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsCrossNumaNode
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "launchMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LaunchMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "launchOptions", typeJson: "{\"fqn\":\"oci.coreInstance.CoreInstanceLaunchOptionsOutputReference\"}")]
        public virtual oci.CoreInstance.CoreInstanceLaunchOptionsOutputReference LaunchOptions
        {
            get => GetInstanceProperty<oci.CoreInstance.CoreInstanceLaunchOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "launchVolumeAttachments", typeJson: "{\"fqn\":\"oci.coreInstance.CoreInstanceLaunchVolumeAttachmentsList\"}")]
        public virtual oci.CoreInstance.CoreInstanceLaunchVolumeAttachmentsList LaunchVolumeAttachments
        {
            get => GetInstanceProperty<oci.CoreInstance.CoreInstanceLaunchVolumeAttachmentsList>()!;
        }

        [JsiiProperty(name: "licensingConfigs", typeJson: "{\"fqn\":\"oci.coreInstance.CoreInstanceLicensingConfigsOutputReference\"}")]
        public virtual oci.CoreInstance.CoreInstanceLicensingConfigsOutputReference LicensingConfigs
        {
            get => GetInstanceProperty<oci.CoreInstance.CoreInstanceLicensingConfigsOutputReference>()!;
        }

        [JsiiProperty(name: "placementConstraintDetails", typeJson: "{\"fqn\":\"oci.coreInstance.CoreInstancePlacementConstraintDetailsOutputReference\"}")]
        public virtual oci.CoreInstance.CoreInstancePlacementConstraintDetailsOutputReference PlacementConstraintDetails
        {
            get => GetInstanceProperty<oci.CoreInstance.CoreInstancePlacementConstraintDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "platformConfig", typeJson: "{\"fqn\":\"oci.coreInstance.CoreInstancePlatformConfigOutputReference\"}")]
        public virtual oci.CoreInstance.CoreInstancePlatformConfigOutputReference PlatformConfig
        {
            get => GetInstanceProperty<oci.CoreInstance.CoreInstancePlatformConfigOutputReference>()!;
        }

        [JsiiProperty(name: "preemptibleInstanceConfig", typeJson: "{\"fqn\":\"oci.coreInstance.CoreInstancePreemptibleInstanceConfigOutputReference\"}")]
        public virtual oci.CoreInstance.CoreInstancePreemptibleInstanceConfigOutputReference PreemptibleInstanceConfig
        {
            get => GetInstanceProperty<oci.CoreInstance.CoreInstancePreemptibleInstanceConfigOutputReference>()!;
        }

        [JsiiProperty(name: "privateIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivateIp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "publicIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublicIp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "securityAttributesState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecurityAttributesState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "shapeConfig", typeJson: "{\"fqn\":\"oci.coreInstance.CoreInstanceShapeConfigOutputReference\"}")]
        public virtual oci.CoreInstance.CoreInstanceShapeConfigOutputReference ShapeConfig
        {
            get => GetInstanceProperty<oci.CoreInstance.CoreInstanceShapeConfigOutputReference>()!;
        }

        [JsiiProperty(name: "sourceDetails", typeJson: "{\"fqn\":\"oci.coreInstance.CoreInstanceSourceDetailsOutputReference\"}")]
        public virtual oci.CoreInstance.CoreInstanceSourceDetailsOutputReference SourceDetails
        {
            get => GetInstanceProperty<oci.CoreInstance.CoreInstanceSourceDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeMaintenanceRebootDue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeMaintenanceRebootDue
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.coreInstance.CoreInstanceTimeoutsOutputReference\"}")]
        public virtual oci.CoreInstance.CoreInstanceTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.CoreInstance.CoreInstanceTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "agentConfigInput", typeJson: "{\"fqn\":\"oci.coreInstance.CoreInstanceAgentConfig\"}", isOptional: true)]
        public virtual oci.CoreInstance.ICoreInstanceAgentConfig? AgentConfigInput
        {
            get => GetInstanceProperty<oci.CoreInstance.ICoreInstanceAgentConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "asyncInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AsyncInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "availabilityConfigInput", typeJson: "{\"fqn\":\"oci.coreInstance.CoreInstanceAvailabilityConfig\"}", isOptional: true)]
        public virtual oci.CoreInstance.ICoreInstanceAvailabilityConfig? AvailabilityConfigInput
        {
            get => GetInstanceProperty<oci.CoreInstance.ICoreInstanceAvailabilityConfig?>();
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
        [JsiiProperty(name: "createVnicDetailsInput", typeJson: "{\"fqn\":\"oci.coreInstance.CoreInstanceCreateVnicDetails\"}", isOptional: true)]
        public virtual oci.CoreInstance.ICoreInstanceCreateVnicDetails? CreateVnicDetailsInput
        {
            get => GetInstanceProperty<oci.CoreInstance.ICoreInstanceCreateVnicDetails?>();
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
        [JsiiProperty(name: "hostnameLabelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HostnameLabelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "imageInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ImageInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceConfigurationIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstanceConfigurationIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceOptionsInput", typeJson: "{\"fqn\":\"oci.coreInstance.CoreInstanceInstanceOptions\"}", isOptional: true)]
        public virtual oci.CoreInstance.ICoreInstanceInstanceOptions? InstanceOptionsInput
        {
            get => GetInstanceProperty<oci.CoreInstance.ICoreInstanceInstanceOptions?>();
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
        [JsiiProperty(name: "launchOptionsInput", typeJson: "{\"fqn\":\"oci.coreInstance.CoreInstanceLaunchOptions\"}", isOptional: true)]
        public virtual oci.CoreInstance.ICoreInstanceLaunchOptions? LaunchOptionsInput
        {
            get => GetInstanceProperty<oci.CoreInstance.ICoreInstanceLaunchOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "launchVolumeAttachmentsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.coreInstance.CoreInstanceLaunchVolumeAttachments\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? LaunchVolumeAttachmentsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "licensingConfigsInput", typeJson: "{\"fqn\":\"oci.coreInstance.CoreInstanceLicensingConfigs\"}", isOptional: true)]
        public virtual oci.CoreInstance.ICoreInstanceLicensingConfigs? LicensingConfigsInput
        {
            get => GetInstanceProperty<oci.CoreInstance.ICoreInstanceLicensingConfigs?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metadataInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? MetadataInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "placementConstraintDetailsInput", typeJson: "{\"fqn\":\"oci.coreInstance.CoreInstancePlacementConstraintDetails\"}", isOptional: true)]
        public virtual oci.CoreInstance.ICoreInstancePlacementConstraintDetails? PlacementConstraintDetailsInput
        {
            get => GetInstanceProperty<oci.CoreInstance.ICoreInstancePlacementConstraintDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "platformConfigInput", typeJson: "{\"fqn\":\"oci.coreInstance.CoreInstancePlatformConfig\"}", isOptional: true)]
        public virtual oci.CoreInstance.ICoreInstancePlatformConfig? PlatformConfigInput
        {
            get => GetInstanceProperty<oci.CoreInstance.ICoreInstancePlatformConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "preemptibleInstanceConfigInput", typeJson: "{\"fqn\":\"oci.coreInstance.CoreInstancePreemptibleInstanceConfig\"}", isOptional: true)]
        public virtual oci.CoreInstance.ICoreInstancePreemptibleInstanceConfig? PreemptibleInstanceConfigInput
        {
            get => GetInstanceProperty<oci.CoreInstance.ICoreInstancePreemptibleInstanceConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "preserveBootVolumeInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? PreserveBootVolumeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "preserveDataVolumesCreatedAtLaunchInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? PreserveDataVolumesCreatedAtLaunchInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityAttributesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? SecurityAttributesInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "shapeConfigInput", typeJson: "{\"fqn\":\"oci.coreInstance.CoreInstanceShapeConfig\"}", isOptional: true)]
        public virtual oci.CoreInstance.ICoreInstanceShapeConfig? ShapeConfigInput
        {
            get => GetInstanceProperty<oci.CoreInstance.ICoreInstanceShapeConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "shapeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ShapeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceDetailsInput", typeJson: "{\"fqn\":\"oci.coreInstance.CoreInstanceSourceDetails\"}", isOptional: true)]
        public virtual oci.CoreInstance.ICoreInstanceSourceDetails? SourceDetailsInput
        {
            get => GetInstanceProperty<oci.CoreInstance.ICoreInstanceSourceDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subnetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubnetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.coreInstance.CoreInstanceTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "updateOperationConstraintInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UpdateOperationConstraintInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "async", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object Async
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

        [JsiiProperty(name: "hostnameLabel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostnameLabel
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Image
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceConfigurationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceConfigurationId
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Metadata
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "preserveBootVolume", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object PreserveBootVolume
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

        [JsiiProperty(name: "preserveDataVolumesCreatedAtLaunch", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object PreserveDataVolumesCreatedAtLaunch
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

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "updateOperationConstraint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdateOperationConstraint
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
