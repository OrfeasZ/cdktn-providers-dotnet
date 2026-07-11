using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.VirtualMachine
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine azurestack_virtual_machine}.</summary>
    [JsiiClass(nativeType: typeof(azurestack.VirtualMachine.VirtualMachine), fullyQualifiedName: "azurestack.virtualMachine.VirtualMachine", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurestack.virtualMachine.VirtualMachineConfig\"}}]")]
    public class VirtualMachine : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine azurestack_virtual_machine} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public VirtualMachine(Constructs.Construct scope, string id, azurestack.VirtualMachine.IVirtualMachineConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurestack.VirtualMachine.IVirtualMachineConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VirtualMachine(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VirtualMachine(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a VirtualMachine resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the VirtualMachine to import.</param>
        /// <param name="importFromId">The id of the existing VirtualMachine that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the VirtualMachine to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the VirtualMachine to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing VirtualMachine that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the VirtualMachine to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azurestack.VirtualMachine.VirtualMachine), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putBootDiagnostics", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurestack.virtualMachine.VirtualMachineBootDiagnostics\"}}]")]
        public virtual void PutBootDiagnostics(azurestack.VirtualMachine.IVirtualMachineBootDiagnostics @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurestack.VirtualMachine.IVirtualMachineBootDiagnostics)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIdentity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurestack.virtualMachine.VirtualMachineIdentity\"}}]")]
        public virtual void PutIdentity(azurestack.VirtualMachine.IVirtualMachineIdentity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurestack.VirtualMachine.IVirtualMachineIdentity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOsProfile", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurestack.virtualMachine.VirtualMachineOsProfile\"}}]")]
        public virtual void PutOsProfile(azurestack.VirtualMachine.IVirtualMachineOsProfile @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurestack.VirtualMachine.IVirtualMachineOsProfile)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOsProfileLinuxConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurestack.virtualMachine.VirtualMachineOsProfileLinuxConfig\"}}]")]
        public virtual void PutOsProfileLinuxConfig(azurestack.VirtualMachine.IVirtualMachineOsProfileLinuxConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurestack.VirtualMachine.IVirtualMachineOsProfileLinuxConfig)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.VirtualMachine.IVirtualMachineOsProfileSecrets" />)[]</param>
        [JsiiMethod(name: "putOsProfileSecrets", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.virtualMachine.VirtualMachineOsProfileSecrets\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutOsProfileSecrets(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurestack.VirtualMachine.IVirtualMachineOsProfileSecrets[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurestack.VirtualMachine.IVirtualMachineOsProfileSecrets).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurestack.VirtualMachine.IVirtualMachineOsProfileSecrets).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOsProfileWindowsConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurestack.virtualMachine.VirtualMachineOsProfileWindowsConfig\"}}]")]
        public virtual void PutOsProfileWindowsConfig(azurestack.VirtualMachine.IVirtualMachineOsProfileWindowsConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurestack.VirtualMachine.IVirtualMachineOsProfileWindowsConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPlan", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurestack.virtualMachine.VirtualMachinePlan\"}}]")]
        public virtual void PutPlan(azurestack.VirtualMachine.IVirtualMachinePlan @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurestack.VirtualMachine.IVirtualMachinePlan)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.VirtualMachine.IVirtualMachineStorageDataDisk" />)[]</param>
        [JsiiMethod(name: "putStorageDataDisk", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.virtualMachine.VirtualMachineStorageDataDisk\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutStorageDataDisk(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurestack.VirtualMachine.IVirtualMachineStorageDataDisk[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurestack.VirtualMachine.IVirtualMachineStorageDataDisk).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurestack.VirtualMachine.IVirtualMachineStorageDataDisk).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStorageImageReference", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurestack.virtualMachine.VirtualMachineStorageImageReference\"}}]")]
        public virtual void PutStorageImageReference(azurestack.VirtualMachine.IVirtualMachineStorageImageReference @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurestack.VirtualMachine.IVirtualMachineStorageImageReference)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStorageOsDisk", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurestack.virtualMachine.VirtualMachineStorageOsDisk\"}}]")]
        public virtual void PutStorageOsDisk(azurestack.VirtualMachine.IVirtualMachineStorageOsDisk @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurestack.VirtualMachine.IVirtualMachineStorageOsDisk)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurestack.virtualMachine.VirtualMachineTimeouts\"}}]")]
        public virtual void PutTimeouts(azurestack.VirtualMachine.IVirtualMachineTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurestack.VirtualMachine.IVirtualMachineTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAvailabilitySetId")]
        public virtual void ResetAvailabilitySetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBootDiagnostics")]
        public virtual void ResetBootDiagnostics()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeleteDataDisksOnTermination")]
        public virtual void ResetDeleteDataDisksOnTermination()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeleteOsDiskOnTermination")]
        public virtual void ResetDeleteOsDiskOnTermination()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIdentity")]
        public virtual void ResetIdentity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLicenseType")]
        public virtual void ResetLicenseType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOsProfile")]
        public virtual void ResetOsProfile()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOsProfileLinuxConfig")]
        public virtual void ResetOsProfileLinuxConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOsProfileSecrets")]
        public virtual void ResetOsProfileSecrets()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOsProfileWindowsConfig")]
        public virtual void ResetOsProfileWindowsConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPlan")]
        public virtual void ResetPlan()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrimaryNetworkInterfaceId")]
        public virtual void ResetPrimaryNetworkInterfaceId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStorageDataDisk")]
        public virtual void ResetStorageDataDisk()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStorageImageReference")]
        public virtual void ResetStorageImageReference()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetZones")]
        public virtual void ResetZones()
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
        = GetStaticProperty<string>(typeof(azurestack.VirtualMachine.VirtualMachine))!;

        [JsiiProperty(name: "bootDiagnostics", typeJson: "{\"fqn\":\"azurestack.virtualMachine.VirtualMachineBootDiagnosticsOutputReference\"}")]
        public virtual azurestack.VirtualMachine.VirtualMachineBootDiagnosticsOutputReference BootDiagnostics
        {
            get => GetInstanceProperty<azurestack.VirtualMachine.VirtualMachineBootDiagnosticsOutputReference>()!;
        }

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurestack.virtualMachine.VirtualMachineIdentityOutputReference\"}")]
        public virtual azurestack.VirtualMachine.VirtualMachineIdentityOutputReference Identity
        {
            get => GetInstanceProperty<azurestack.VirtualMachine.VirtualMachineIdentityOutputReference>()!;
        }

        [JsiiProperty(name: "osProfile", typeJson: "{\"fqn\":\"azurestack.virtualMachine.VirtualMachineOsProfileOutputReference\"}")]
        public virtual azurestack.VirtualMachine.VirtualMachineOsProfileOutputReference OsProfile
        {
            get => GetInstanceProperty<azurestack.VirtualMachine.VirtualMachineOsProfileOutputReference>()!;
        }

        [JsiiProperty(name: "osProfileLinuxConfig", typeJson: "{\"fqn\":\"azurestack.virtualMachine.VirtualMachineOsProfileLinuxConfigOutputReference\"}")]
        public virtual azurestack.VirtualMachine.VirtualMachineOsProfileLinuxConfigOutputReference OsProfileLinuxConfig
        {
            get => GetInstanceProperty<azurestack.VirtualMachine.VirtualMachineOsProfileLinuxConfigOutputReference>()!;
        }

        [JsiiProperty(name: "osProfileSecrets", typeJson: "{\"fqn\":\"azurestack.virtualMachine.VirtualMachineOsProfileSecretsList\"}")]
        public virtual azurestack.VirtualMachine.VirtualMachineOsProfileSecretsList OsProfileSecrets
        {
            get => GetInstanceProperty<azurestack.VirtualMachine.VirtualMachineOsProfileSecretsList>()!;
        }

        [JsiiProperty(name: "osProfileWindowsConfig", typeJson: "{\"fqn\":\"azurestack.virtualMachine.VirtualMachineOsProfileWindowsConfigOutputReference\"}")]
        public virtual azurestack.VirtualMachine.VirtualMachineOsProfileWindowsConfigOutputReference OsProfileWindowsConfig
        {
            get => GetInstanceProperty<azurestack.VirtualMachine.VirtualMachineOsProfileWindowsConfigOutputReference>()!;
        }

        [JsiiProperty(name: "plan", typeJson: "{\"fqn\":\"azurestack.virtualMachine.VirtualMachinePlanOutputReference\"}")]
        public virtual azurestack.VirtualMachine.VirtualMachinePlanOutputReference Plan
        {
            get => GetInstanceProperty<azurestack.VirtualMachine.VirtualMachinePlanOutputReference>()!;
        }

        [JsiiProperty(name: "storageDataDisk", typeJson: "{\"fqn\":\"azurestack.virtualMachine.VirtualMachineStorageDataDiskList\"}")]
        public virtual azurestack.VirtualMachine.VirtualMachineStorageDataDiskList StorageDataDisk
        {
            get => GetInstanceProperty<azurestack.VirtualMachine.VirtualMachineStorageDataDiskList>()!;
        }

        [JsiiProperty(name: "storageImageReference", typeJson: "{\"fqn\":\"azurestack.virtualMachine.VirtualMachineStorageImageReferenceOutputReference\"}")]
        public virtual azurestack.VirtualMachine.VirtualMachineStorageImageReferenceOutputReference StorageImageReference
        {
            get => GetInstanceProperty<azurestack.VirtualMachine.VirtualMachineStorageImageReferenceOutputReference>()!;
        }

        [JsiiProperty(name: "storageOsDisk", typeJson: "{\"fqn\":\"azurestack.virtualMachine.VirtualMachineStorageOsDiskOutputReference\"}")]
        public virtual azurestack.VirtualMachine.VirtualMachineStorageOsDiskOutputReference StorageOsDisk
        {
            get => GetInstanceProperty<azurestack.VirtualMachine.VirtualMachineStorageOsDiskOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurestack.virtualMachine.VirtualMachineTimeoutsOutputReference\"}")]
        public virtual azurestack.VirtualMachine.VirtualMachineTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurestack.VirtualMachine.VirtualMachineTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "availabilitySetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AvailabilitySetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bootDiagnosticsInput", typeJson: "{\"fqn\":\"azurestack.virtualMachine.VirtualMachineBootDiagnostics\"}", isOptional: true)]
        public virtual azurestack.VirtualMachine.IVirtualMachineBootDiagnostics? BootDiagnosticsInput
        {
            get => GetInstanceProperty<azurestack.VirtualMachine.IVirtualMachineBootDiagnostics?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "deleteDataDisksOnTerminationInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? DeleteDataDisksOnTerminationInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "deleteOsDiskOnTerminationInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? DeleteOsDiskOnTerminationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "identityInput", typeJson: "{\"fqn\":\"azurestack.virtualMachine.VirtualMachineIdentity\"}", isOptional: true)]
        public virtual azurestack.VirtualMachine.IVirtualMachineIdentity? IdentityInput
        {
            get => GetInstanceProperty<azurestack.VirtualMachine.IVirtualMachineIdentity?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "licenseTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LicenseTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "locationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LocationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkInterfaceIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? NetworkInterfaceIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "osProfileInput", typeJson: "{\"fqn\":\"azurestack.virtualMachine.VirtualMachineOsProfile\"}", isOptional: true)]
        public virtual azurestack.VirtualMachine.IVirtualMachineOsProfile? OsProfileInput
        {
            get => GetInstanceProperty<azurestack.VirtualMachine.IVirtualMachineOsProfile?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "osProfileLinuxConfigInput", typeJson: "{\"fqn\":\"azurestack.virtualMachine.VirtualMachineOsProfileLinuxConfig\"}", isOptional: true)]
        public virtual azurestack.VirtualMachine.IVirtualMachineOsProfileLinuxConfig? OsProfileLinuxConfigInput
        {
            get => GetInstanceProperty<azurestack.VirtualMachine.IVirtualMachineOsProfileLinuxConfig?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.VirtualMachine.IVirtualMachineOsProfileSecrets" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "osProfileSecretsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.virtualMachine.VirtualMachineOsProfileSecrets\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? OsProfileSecretsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "osProfileWindowsConfigInput", typeJson: "{\"fqn\":\"azurestack.virtualMachine.VirtualMachineOsProfileWindowsConfig\"}", isOptional: true)]
        public virtual azurestack.VirtualMachine.IVirtualMachineOsProfileWindowsConfig? OsProfileWindowsConfigInput
        {
            get => GetInstanceProperty<azurestack.VirtualMachine.IVirtualMachineOsProfileWindowsConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "planInput", typeJson: "{\"fqn\":\"azurestack.virtualMachine.VirtualMachinePlan\"}", isOptional: true)]
        public virtual azurestack.VirtualMachine.IVirtualMachinePlan? PlanInput
        {
            get => GetInstanceProperty<azurestack.VirtualMachine.IVirtualMachinePlan?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "primaryNetworkInterfaceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrimaryNetworkInterfaceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.VirtualMachine.IVirtualMachineStorageDataDisk" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "storageDataDiskInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.virtualMachine.VirtualMachineStorageDataDisk\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? StorageDataDiskInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageImageReferenceInput", typeJson: "{\"fqn\":\"azurestack.virtualMachine.VirtualMachineStorageImageReference\"}", isOptional: true)]
        public virtual azurestack.VirtualMachine.IVirtualMachineStorageImageReference? StorageImageReferenceInput
        {
            get => GetInstanceProperty<azurestack.VirtualMachine.IVirtualMachineStorageImageReference?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageOsDiskInput", typeJson: "{\"fqn\":\"azurestack.virtualMachine.VirtualMachineStorageOsDisk\"}", isOptional: true)]
        public virtual azurestack.VirtualMachine.IVirtualMachineStorageOsDisk? StorageOsDiskInput
        {
            get => GetInstanceProperty<azurestack.VirtualMachine.IVirtualMachineStorageOsDisk?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurestack.VirtualMachine.IVirtualMachineTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurestack.virtualMachine.VirtualMachineTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vmSizeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VmSizeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "zonesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ZonesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "availabilitySetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilitySetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "deleteDataDisksOnTermination", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object DeleteDataDisksOnTermination
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

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "deleteOsDiskOnTermination", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object DeleteOsDiskOnTermination
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

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "licenseType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LicenseType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "networkInterfaceIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] NetworkInterfaceIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "primaryNetworkInterfaceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryNetworkInterfaceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceGroupName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vmSize", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VmSize
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "zones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Zones
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
