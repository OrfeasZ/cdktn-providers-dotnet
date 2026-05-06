using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DesktopsDesktopPool
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/desktops_desktop_pool oci_desktops_desktop_pool}.</summary>
    [JsiiClass(nativeType: typeof(oci.DesktopsDesktopPool.DesktopsDesktopPool), fullyQualifiedName: "oci.desktopsDesktopPool.DesktopsDesktopPool", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.desktopsDesktopPool.DesktopsDesktopPoolConfig\"}}]")]
    public class DesktopsDesktopPool : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/desktops_desktop_pool oci_desktops_desktop_pool} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DesktopsDesktopPool(Constructs.Construct scope, string id, oci.DesktopsDesktopPool.IDesktopsDesktopPoolConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DesktopsDesktopPool.IDesktopsDesktopPoolConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DesktopsDesktopPool(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DesktopsDesktopPool(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DesktopsDesktopPool resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DesktopsDesktopPool to import.</param>
        /// <param name="importFromId">The id of the existing DesktopsDesktopPool that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DesktopsDesktopPool to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DesktopsDesktopPool to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/desktops_desktop_pool#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DesktopsDesktopPool that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DesktopsDesktopPool to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DesktopsDesktopPool.DesktopsDesktopPool), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAvailabilityPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.desktopsDesktopPool.DesktopsDesktopPoolAvailabilityPolicy\"}}]")]
        public virtual void PutAvailabilityPolicy(oci.DesktopsDesktopPool.IDesktopsDesktopPoolAvailabilityPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DesktopsDesktopPool.IDesktopsDesktopPoolAvailabilityPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDevicePolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.desktopsDesktopPool.DesktopsDesktopPoolDevicePolicy\"}}]")]
        public virtual void PutDevicePolicy(oci.DesktopsDesktopPool.IDesktopsDesktopPoolDevicePolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DesktopsDesktopPool.IDesktopsDesktopPoolDevicePolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putImage", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.desktopsDesktopPool.DesktopsDesktopPoolImage\"}}]")]
        public virtual void PutImage(oci.DesktopsDesktopPool.IDesktopsDesktopPoolImage @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DesktopsDesktopPool.IDesktopsDesktopPoolImage)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetworkConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.desktopsDesktopPool.DesktopsDesktopPoolNetworkConfiguration\"}}]")]
        public virtual void PutNetworkConfiguration(oci.DesktopsDesktopPool.IDesktopsDesktopPoolNetworkConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DesktopsDesktopPool.IDesktopsDesktopPoolNetworkConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPrivateAccessDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.desktopsDesktopPool.DesktopsDesktopPoolPrivateAccessDetails\"}}]")]
        public virtual void PutPrivateAccessDetails(oci.DesktopsDesktopPool.IDesktopsDesktopPoolPrivateAccessDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DesktopsDesktopPool.IDesktopsDesktopPoolPrivateAccessDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSessionLifecycleActions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.desktopsDesktopPool.DesktopsDesktopPoolSessionLifecycleActions\"}}]")]
        public virtual void PutSessionLifecycleActions(oci.DesktopsDesktopPool.IDesktopsDesktopPoolSessionLifecycleActions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DesktopsDesktopPool.IDesktopsDesktopPoolSessionLifecycleActions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putShapeConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.desktopsDesktopPool.DesktopsDesktopPoolShapeConfig\"}}]")]
        public virtual void PutShapeConfig(oci.DesktopsDesktopPool.IDesktopsDesktopPoolShapeConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DesktopsDesktopPool.IDesktopsDesktopPoolShapeConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.desktopsDesktopPool.DesktopsDesktopPoolTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.DesktopsDesktopPool.IDesktopsDesktopPoolTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DesktopsDesktopPool.IDesktopsDesktopPoolTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAreVolumesPreserved")]
        public virtual void ResetAreVolumesPreserved()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefinedTags")]
        public virtual void ResetDefinedTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFreeformTags")]
        public virtual void ResetFreeformTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNsgIds")]
        public virtual void ResetNsgIds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrivateAccessDetails")]
        public virtual void ResetPrivateAccessDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSessionLifecycleActions")]
        public virtual void ResetSessionLifecycleActions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetShapeConfig")]
        public virtual void ResetShapeConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeStartScheduled")]
        public virtual void ResetTimeStartScheduled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeStopScheduled")]
        public virtual void ResetTimeStopScheduled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUseDedicatedVmHost")]
        public virtual void ResetUseDedicatedVmHost()
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
        = GetStaticProperty<string>(typeof(oci.DesktopsDesktopPool.DesktopsDesktopPool))!;

        [JsiiProperty(name: "activeDesktops", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ActiveDesktops
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "availabilityPolicy", typeJson: "{\"fqn\":\"oci.desktopsDesktopPool.DesktopsDesktopPoolAvailabilityPolicyOutputReference\"}")]
        public virtual oci.DesktopsDesktopPool.DesktopsDesktopPoolAvailabilityPolicyOutputReference AvailabilityPolicy
        {
            get => GetInstanceProperty<oci.DesktopsDesktopPool.DesktopsDesktopPoolAvailabilityPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "devicePolicy", typeJson: "{\"fqn\":\"oci.desktopsDesktopPool.DesktopsDesktopPoolDevicePolicyOutputReference\"}")]
        public virtual oci.DesktopsDesktopPool.DesktopsDesktopPoolDevicePolicyOutputReference DevicePolicy
        {
            get => GetInstanceProperty<oci.DesktopsDesktopPool.DesktopsDesktopPoolDevicePolicyOutputReference>()!;
        }

        [JsiiProperty(name: "image", typeJson: "{\"fqn\":\"oci.desktopsDesktopPool.DesktopsDesktopPoolImageOutputReference\"}")]
        public virtual oci.DesktopsDesktopPool.DesktopsDesktopPoolImageOutputReference Image
        {
            get => GetInstanceProperty<oci.DesktopsDesktopPool.DesktopsDesktopPoolImageOutputReference>()!;
        }

        [JsiiProperty(name: "networkConfiguration", typeJson: "{\"fqn\":\"oci.desktopsDesktopPool.DesktopsDesktopPoolNetworkConfigurationOutputReference\"}")]
        public virtual oci.DesktopsDesktopPool.DesktopsDesktopPoolNetworkConfigurationOutputReference NetworkConfiguration
        {
            get => GetInstanceProperty<oci.DesktopsDesktopPool.DesktopsDesktopPoolNetworkConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "privateAccessDetails", typeJson: "{\"fqn\":\"oci.desktopsDesktopPool.DesktopsDesktopPoolPrivateAccessDetailsOutputReference\"}")]
        public virtual oci.DesktopsDesktopPool.DesktopsDesktopPoolPrivateAccessDetailsOutputReference PrivateAccessDetails
        {
            get => GetInstanceProperty<oci.DesktopsDesktopPool.DesktopsDesktopPoolPrivateAccessDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "sessionLifecycleActions", typeJson: "{\"fqn\":\"oci.desktopsDesktopPool.DesktopsDesktopPoolSessionLifecycleActionsOutputReference\"}")]
        public virtual oci.DesktopsDesktopPool.DesktopsDesktopPoolSessionLifecycleActionsOutputReference SessionLifecycleActions
        {
            get => GetInstanceProperty<oci.DesktopsDesktopPool.DesktopsDesktopPoolSessionLifecycleActionsOutputReference>()!;
        }

        [JsiiProperty(name: "shapeConfig", typeJson: "{\"fqn\":\"oci.desktopsDesktopPool.DesktopsDesktopPoolShapeConfigOutputReference\"}")]
        public virtual oci.DesktopsDesktopPool.DesktopsDesktopPoolShapeConfigOutputReference ShapeConfig
        {
            get => GetInstanceProperty<oci.DesktopsDesktopPool.DesktopsDesktopPoolShapeConfigOutputReference>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.desktopsDesktopPool.DesktopsDesktopPoolTimeoutsOutputReference\"}")]
        public virtual oci.DesktopsDesktopPool.DesktopsDesktopPoolTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.DesktopsDesktopPool.DesktopsDesktopPoolTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "arePrivilegedUsersInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ArePrivilegedUsersInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "areVolumesPreservedInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AreVolumesPreservedInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "availabilityDomainInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AvailabilityDomainInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "availabilityPolicyInput", typeJson: "{\"fqn\":\"oci.desktopsDesktopPool.DesktopsDesktopPoolAvailabilityPolicy\"}", isOptional: true)]
        public virtual oci.DesktopsDesktopPool.IDesktopsDesktopPoolAvailabilityPolicy? AvailabilityPolicyInput
        {
            get => GetInstanceProperty<oci.DesktopsDesktopPool.IDesktopsDesktopPoolAvailabilityPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "contactDetailsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ContactDetailsInput
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
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "devicePolicyInput", typeJson: "{\"fqn\":\"oci.desktopsDesktopPool.DesktopsDesktopPoolDevicePolicy\"}", isOptional: true)]
        public virtual oci.DesktopsDesktopPool.IDesktopsDesktopPoolDevicePolicy? DevicePolicyInput
        {
            get => GetInstanceProperty<oci.DesktopsDesktopPool.IDesktopsDesktopPoolDevicePolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
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
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "imageInput", typeJson: "{\"fqn\":\"oci.desktopsDesktopPool.DesktopsDesktopPoolImage\"}", isOptional: true)]
        public virtual oci.DesktopsDesktopPool.IDesktopsDesktopPoolImage? ImageInput
        {
            get => GetInstanceProperty<oci.DesktopsDesktopPool.IDesktopsDesktopPoolImage?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isStorageEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsStorageEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maximumSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaximumSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkConfigurationInput", typeJson: "{\"fqn\":\"oci.desktopsDesktopPool.DesktopsDesktopPoolNetworkConfiguration\"}", isOptional: true)]
        public virtual oci.DesktopsDesktopPool.IDesktopsDesktopPoolNetworkConfiguration? NetworkConfigurationInput
        {
            get => GetInstanceProperty<oci.DesktopsDesktopPool.IDesktopsDesktopPoolNetworkConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nsgIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? NsgIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "privateAccessDetailsInput", typeJson: "{\"fqn\":\"oci.desktopsDesktopPool.DesktopsDesktopPoolPrivateAccessDetails\"}", isOptional: true)]
        public virtual oci.DesktopsDesktopPool.IDesktopsDesktopPoolPrivateAccessDetails? PrivateAccessDetailsInput
        {
            get => GetInstanceProperty<oci.DesktopsDesktopPool.IDesktopsDesktopPoolPrivateAccessDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sessionLifecycleActionsInput", typeJson: "{\"fqn\":\"oci.desktopsDesktopPool.DesktopsDesktopPoolSessionLifecycleActions\"}", isOptional: true)]
        public virtual oci.DesktopsDesktopPool.IDesktopsDesktopPoolSessionLifecycleActions? SessionLifecycleActionsInput
        {
            get => GetInstanceProperty<oci.DesktopsDesktopPool.IDesktopsDesktopPoolSessionLifecycleActions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "shapeConfigInput", typeJson: "{\"fqn\":\"oci.desktopsDesktopPool.DesktopsDesktopPoolShapeConfig\"}", isOptional: true)]
        public virtual oci.DesktopsDesktopPool.IDesktopsDesktopPoolShapeConfig? ShapeConfigInput
        {
            get => GetInstanceProperty<oci.DesktopsDesktopPool.IDesktopsDesktopPoolShapeConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "shapeNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ShapeNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "standbySizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? StandbySizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageBackupPolicyIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StorageBackupPolicyIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageSizeInGbsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? StorageSizeInGbsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.desktopsDesktopPool.DesktopsDesktopPoolTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeStartScheduledInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimeStartScheduledInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeStopScheduledInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimeStopScheduledInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "useDedicatedVmHostInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UseDedicatedVmHostInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "arePrivilegedUsers", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object ArePrivilegedUsers
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

        [JsiiProperty(name: "areVolumesPreserved", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object AreVolumesPreserved
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

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "contactDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContactDetails
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

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
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

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "isStorageEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsStorageEnabled
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

        [JsiiProperty(name: "maximumSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaximumSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "nsgIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] NsgIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "shapeName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ShapeName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "standbySize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StandbySize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "storageBackupPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageBackupPolicyId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "storageSizeInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StorageSizeInGbs
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeStartScheduled", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeStartScheduled
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeStopScheduled", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeStopScheduled
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "useDedicatedVmHost", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UseDedicatedVmHost
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
