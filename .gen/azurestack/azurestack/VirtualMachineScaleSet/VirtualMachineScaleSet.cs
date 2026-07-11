using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.VirtualMachineScaleSet
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set azurestack_virtual_machine_scale_set}.</summary>
    [JsiiClass(nativeType: typeof(azurestack.VirtualMachineScaleSet.VirtualMachineScaleSet), fullyQualifiedName: "azurestack.virtualMachineScaleSet.VirtualMachineScaleSet", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetConfig\"}}]")]
    public class VirtualMachineScaleSet : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set azurestack_virtual_machine_scale_set} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public VirtualMachineScaleSet(Constructs.Construct scope, string id, azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VirtualMachineScaleSet(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VirtualMachineScaleSet(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a VirtualMachineScaleSet resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the VirtualMachineScaleSet to import.</param>
        /// <param name="importFromId">The id of the existing VirtualMachineScaleSet that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the VirtualMachineScaleSet to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the VirtualMachineScaleSet to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing VirtualMachineScaleSet that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the VirtualMachineScaleSet to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azurestack.VirtualMachineScaleSet.VirtualMachineScaleSet), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putBootDiagnostics", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetBootDiagnostics\"}}]")]
        public virtual void PutBootDiagnostics(azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetBootDiagnostics @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetBootDiagnostics)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetExtension" />)[]</param>
        [JsiiMethod(name: "putExtension", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetExtension\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutExtension(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetExtension[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetExtension).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetExtension).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIdentity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetIdentity\"}}]")]
        public virtual void PutIdentity(azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetIdentity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetIdentity)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetNetworkProfile" />)[]</param>
        [JsiiMethod(name: "putNetworkProfile", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetNetworkProfile\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutNetworkProfile(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetNetworkProfile[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetNetworkProfile).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetNetworkProfile).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOsProfile", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetOsProfile\"}}]")]
        public virtual void PutOsProfile(azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfile @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfile)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOsProfileLinuxConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetOsProfileLinuxConfig\"}}]")]
        public virtual void PutOsProfileLinuxConfig(azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfileLinuxConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfileLinuxConfig)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfileSecrets" />)[]</param>
        [JsiiMethod(name: "putOsProfileSecrets", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetOsProfileSecrets\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutOsProfileSecrets(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfileSecrets[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfileSecrets).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfileSecrets).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOsProfileWindowsConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetOsProfileWindowsConfig\"}}]")]
        public virtual void PutOsProfileWindowsConfig(azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfileWindowsConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfileWindowsConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPlan", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetPlan\"}}]")]
        public virtual void PutPlan(azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetPlan @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetPlan)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRollingUpgradePolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetRollingUpgradePolicy\"}}]")]
        public virtual void PutRollingUpgradePolicy(azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetRollingUpgradePolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetRollingUpgradePolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSku", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetSku\"}}]")]
        public virtual void PutSku(azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetSku @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetSku)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetStorageProfileDataDisk" />)[]</param>
        [JsiiMethod(name: "putStorageProfileDataDisk", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetStorageProfileDataDisk\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutStorageProfileDataDisk(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetStorageProfileDataDisk[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetStorageProfileDataDisk).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetStorageProfileDataDisk).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStorageProfileImageReference", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetStorageProfileImageReference\"}}]")]
        public virtual void PutStorageProfileImageReference(azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetStorageProfileImageReference @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetStorageProfileImageReference)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStorageProfileOsDisk", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetStorageProfileOsDisk\"}}]")]
        public virtual void PutStorageProfileOsDisk(azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetStorageProfileOsDisk @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetStorageProfileOsDisk)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetTimeouts\"}}]")]
        public virtual void PutTimeouts(azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBootDiagnostics")]
        public virtual void ResetBootDiagnostics()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEvictionPolicy")]
        public virtual void ResetEvictionPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExtension")]
        public virtual void ResetExtension()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHealthProbeId")]
        public virtual void ResetHealthProbeId()
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

        [JsiiMethod(name: "resetOverprovision")]
        public virtual void ResetOverprovision()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPlan")]
        public virtual void ResetPlan()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPriority")]
        public virtual void ResetPriority()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRollingUpgradePolicy")]
        public virtual void ResetRollingUpgradePolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSinglePlacementGroup")]
        public virtual void ResetSinglePlacementGroup()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStorageProfileDataDisk")]
        public virtual void ResetStorageProfileDataDisk()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStorageProfileImageReference")]
        public virtual void ResetStorageProfileImageReference()
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
        = GetStaticProperty<string>(typeof(azurestack.VirtualMachineScaleSet.VirtualMachineScaleSet))!;

        [JsiiProperty(name: "bootDiagnostics", typeJson: "{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetBootDiagnosticsOutputReference\"}")]
        public virtual azurestack.VirtualMachineScaleSet.VirtualMachineScaleSetBootDiagnosticsOutputReference BootDiagnostics
        {
            get => GetInstanceProperty<azurestack.VirtualMachineScaleSet.VirtualMachineScaleSetBootDiagnosticsOutputReference>()!;
        }

        [JsiiProperty(name: "extension", typeJson: "{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetExtensionList\"}")]
        public virtual azurestack.VirtualMachineScaleSet.VirtualMachineScaleSetExtensionList Extension
        {
            get => GetInstanceProperty<azurestack.VirtualMachineScaleSet.VirtualMachineScaleSetExtensionList>()!;
        }

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetIdentityOutputReference\"}")]
        public virtual azurestack.VirtualMachineScaleSet.VirtualMachineScaleSetIdentityOutputReference Identity
        {
            get => GetInstanceProperty<azurestack.VirtualMachineScaleSet.VirtualMachineScaleSetIdentityOutputReference>()!;
        }

        [JsiiProperty(name: "networkProfile", typeJson: "{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetNetworkProfileList\"}")]
        public virtual azurestack.VirtualMachineScaleSet.VirtualMachineScaleSetNetworkProfileList NetworkProfile
        {
            get => GetInstanceProperty<azurestack.VirtualMachineScaleSet.VirtualMachineScaleSetNetworkProfileList>()!;
        }

        [JsiiProperty(name: "osProfile", typeJson: "{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetOsProfileOutputReference\"}")]
        public virtual azurestack.VirtualMachineScaleSet.VirtualMachineScaleSetOsProfileOutputReference OsProfile
        {
            get => GetInstanceProperty<azurestack.VirtualMachineScaleSet.VirtualMachineScaleSetOsProfileOutputReference>()!;
        }

        [JsiiProperty(name: "osProfileLinuxConfig", typeJson: "{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetOsProfileLinuxConfigOutputReference\"}")]
        public virtual azurestack.VirtualMachineScaleSet.VirtualMachineScaleSetOsProfileLinuxConfigOutputReference OsProfileLinuxConfig
        {
            get => GetInstanceProperty<azurestack.VirtualMachineScaleSet.VirtualMachineScaleSetOsProfileLinuxConfigOutputReference>()!;
        }

        [JsiiProperty(name: "osProfileSecrets", typeJson: "{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetOsProfileSecretsList\"}")]
        public virtual azurestack.VirtualMachineScaleSet.VirtualMachineScaleSetOsProfileSecretsList OsProfileSecrets
        {
            get => GetInstanceProperty<azurestack.VirtualMachineScaleSet.VirtualMachineScaleSetOsProfileSecretsList>()!;
        }

        [JsiiProperty(name: "osProfileWindowsConfig", typeJson: "{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetOsProfileWindowsConfigOutputReference\"}")]
        public virtual azurestack.VirtualMachineScaleSet.VirtualMachineScaleSetOsProfileWindowsConfigOutputReference OsProfileWindowsConfig
        {
            get => GetInstanceProperty<azurestack.VirtualMachineScaleSet.VirtualMachineScaleSetOsProfileWindowsConfigOutputReference>()!;
        }

        [JsiiProperty(name: "plan", typeJson: "{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetPlanOutputReference\"}")]
        public virtual azurestack.VirtualMachineScaleSet.VirtualMachineScaleSetPlanOutputReference Plan
        {
            get => GetInstanceProperty<azurestack.VirtualMachineScaleSet.VirtualMachineScaleSetPlanOutputReference>()!;
        }

        [JsiiProperty(name: "rollingUpgradePolicy", typeJson: "{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetRollingUpgradePolicyOutputReference\"}")]
        public virtual azurestack.VirtualMachineScaleSet.VirtualMachineScaleSetRollingUpgradePolicyOutputReference RollingUpgradePolicy
        {
            get => GetInstanceProperty<azurestack.VirtualMachineScaleSet.VirtualMachineScaleSetRollingUpgradePolicyOutputReference>()!;
        }

        [JsiiProperty(name: "sku", typeJson: "{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetSkuOutputReference\"}")]
        public virtual azurestack.VirtualMachineScaleSet.VirtualMachineScaleSetSkuOutputReference Sku
        {
            get => GetInstanceProperty<azurestack.VirtualMachineScaleSet.VirtualMachineScaleSetSkuOutputReference>()!;
        }

        [JsiiProperty(name: "storageProfileDataDisk", typeJson: "{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetStorageProfileDataDiskList\"}")]
        public virtual azurestack.VirtualMachineScaleSet.VirtualMachineScaleSetStorageProfileDataDiskList StorageProfileDataDisk
        {
            get => GetInstanceProperty<azurestack.VirtualMachineScaleSet.VirtualMachineScaleSetStorageProfileDataDiskList>()!;
        }

        [JsiiProperty(name: "storageProfileImageReference", typeJson: "{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetStorageProfileImageReferenceOutputReference\"}")]
        public virtual azurestack.VirtualMachineScaleSet.VirtualMachineScaleSetStorageProfileImageReferenceOutputReference StorageProfileImageReference
        {
            get => GetInstanceProperty<azurestack.VirtualMachineScaleSet.VirtualMachineScaleSetStorageProfileImageReferenceOutputReference>()!;
        }

        [JsiiProperty(name: "storageProfileOsDisk", typeJson: "{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetStorageProfileOsDiskOutputReference\"}")]
        public virtual azurestack.VirtualMachineScaleSet.VirtualMachineScaleSetStorageProfileOsDiskOutputReference StorageProfileOsDisk
        {
            get => GetInstanceProperty<azurestack.VirtualMachineScaleSet.VirtualMachineScaleSetStorageProfileOsDiskOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetTimeoutsOutputReference\"}")]
        public virtual azurestack.VirtualMachineScaleSet.VirtualMachineScaleSetTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurestack.VirtualMachineScaleSet.VirtualMachineScaleSetTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bootDiagnosticsInput", typeJson: "{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetBootDiagnostics\"}", isOptional: true)]
        public virtual azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetBootDiagnostics? BootDiagnosticsInput
        {
            get => GetInstanceProperty<azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetBootDiagnostics?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "evictionPolicyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EvictionPolicyInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetExtension" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "extensionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetExtension\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ExtensionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthProbeIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HealthProbeIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "identityInput", typeJson: "{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetIdentity\"}", isOptional: true)]
        public virtual azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetIdentity? IdentityInput
        {
            get => GetInstanceProperty<azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetIdentity?>();
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

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetNetworkProfile" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkProfileInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetNetworkProfile\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? NetworkProfileInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "osProfileInput", typeJson: "{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetOsProfile\"}", isOptional: true)]
        public virtual azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfile? OsProfileInput
        {
            get => GetInstanceProperty<azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfile?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "osProfileLinuxConfigInput", typeJson: "{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetOsProfileLinuxConfig\"}", isOptional: true)]
        public virtual azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfileLinuxConfig? OsProfileLinuxConfigInput
        {
            get => GetInstanceProperty<azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfileLinuxConfig?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfileSecrets" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "osProfileSecretsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetOsProfileSecrets\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? OsProfileSecretsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "osProfileWindowsConfigInput", typeJson: "{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetOsProfileWindowsConfig\"}", isOptional: true)]
        public virtual azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfileWindowsConfig? OsProfileWindowsConfigInput
        {
            get => GetInstanceProperty<azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfileWindowsConfig?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "overprovisionInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? OverprovisionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "planInput", typeJson: "{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetPlan\"}", isOptional: true)]
        public virtual azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetPlan? PlanInput
        {
            get => GetInstanceProperty<azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetPlan?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "priorityInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PriorityInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rollingUpgradePolicyInput", typeJson: "{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetRollingUpgradePolicy\"}", isOptional: true)]
        public virtual azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetRollingUpgradePolicy? RollingUpgradePolicyInput
        {
            get => GetInstanceProperty<azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetRollingUpgradePolicy?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "singlePlacementGroupInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? SinglePlacementGroupInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "skuInput", typeJson: "{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetSku\"}", isOptional: true)]
        public virtual azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetSku? SkuInput
        {
            get => GetInstanceProperty<azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetSku?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetStorageProfileDataDisk" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "storageProfileDataDiskInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetStorageProfileDataDisk\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? StorageProfileDataDiskInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageProfileImageReferenceInput", typeJson: "{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetStorageProfileImageReference\"}", isOptional: true)]
        public virtual azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetStorageProfileImageReference? StorageProfileImageReferenceInput
        {
            get => GetInstanceProperty<azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetStorageProfileImageReference?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageProfileOsDiskInput", typeJson: "{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetStorageProfileOsDisk\"}", isOptional: true)]
        public virtual azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetStorageProfileOsDisk? StorageProfileOsDiskInput
        {
            get => GetInstanceProperty<azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetStorageProfileOsDisk?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "upgradePolicyModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UpgradePolicyModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "zonesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ZonesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "evictionPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EvictionPolicy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "healthProbeId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HealthProbeId
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

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "overprovision", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object Overprovision
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

        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Priority
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

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "singlePlacementGroup", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object SinglePlacementGroup
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

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "upgradePolicyMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpgradePolicyMode
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
