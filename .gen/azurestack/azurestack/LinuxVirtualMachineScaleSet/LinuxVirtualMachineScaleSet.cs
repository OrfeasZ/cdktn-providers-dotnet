using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.LinuxVirtualMachineScaleSet
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine_scale_set azurestack_linux_virtual_machine_scale_set}.</summary>
    [JsiiClass(nativeType: typeof(azurestack.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSet), fullyQualifiedName: "azurestack.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSet", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurestack.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetConfig\"}}]")]
    public class LinuxVirtualMachineScaleSet : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine_scale_set azurestack_linux_virtual_machine_scale_set} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public LinuxVirtualMachineScaleSet(Constructs.Construct scope, string id, azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LinuxVirtualMachineScaleSet(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LinuxVirtualMachineScaleSet(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a LinuxVirtualMachineScaleSet resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the LinuxVirtualMachineScaleSet to import.</param>
        /// <param name="importFromId">The id of the existing LinuxVirtualMachineScaleSet that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the LinuxVirtualMachineScaleSet to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the LinuxVirtualMachineScaleSet to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine_scale_set#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing LinuxVirtualMachineScaleSet that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the LinuxVirtualMachineScaleSet to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azurestack.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSet), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAdditionalCapabilities", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurestack.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetAdditionalCapabilities\"}}]")]
        public virtual void PutAdditionalCapabilities(azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetAdditionalCapabilities @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetAdditionalCapabilities)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetAdminSshKey" />)[]</param>
        [JsiiMethod(name: "putAdminSshKey", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetAdminSshKey\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAdminSshKey(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetAdminSshKey[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetAdminSshKey).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetAdminSshKey).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAutomaticInstanceRepair", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurestack.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetAutomaticInstanceRepair\"}}]")]
        public virtual void PutAutomaticInstanceRepair(azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetAutomaticInstanceRepair @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetAutomaticInstanceRepair)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAutomaticOsUpgradePolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurestack.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetAutomaticOsUpgradePolicy\"}}]")]
        public virtual void PutAutomaticOsUpgradePolicy(azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetAutomaticOsUpgradePolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetAutomaticOsUpgradePolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBootDiagnostics", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurestack.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetBootDiagnostics\"}}]")]
        public virtual void PutBootDiagnostics(azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetBootDiagnostics @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetBootDiagnostics)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetDataDisk" />)[]</param>
        [JsiiMethod(name: "putDataDisk", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetDataDisk\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDataDisk(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetDataDisk[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetDataDisk).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetDataDisk).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetExtension" />)[]</param>
        [JsiiMethod(name: "putExtension", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetExtension\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutExtension(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetExtension[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetExtension).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetExtension).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetNetworkInterface" />)[]</param>
        [JsiiMethod(name: "putNetworkInterface", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetNetworkInterface\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutNetworkInterface(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetNetworkInterface[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetNetworkInterface).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetNetworkInterface).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOsDisk", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurestack.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetOsDisk\"}}]")]
        public virtual void PutOsDisk(azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetOsDisk @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetOsDisk)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPlan", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurestack.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetPlan\"}}]")]
        public virtual void PutPlan(azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetPlan @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetPlan)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetSecret" />)[]</param>
        [JsiiMethod(name: "putSecret", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetSecret\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSecret(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetSecret[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetSecret).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetSecret).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSourceImageReference", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurestack.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetSourceImageReference\"}}]")]
        public virtual void PutSourceImageReference(azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetSourceImageReference @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetSourceImageReference)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTerminateNotification", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurestack.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetTerminateNotification\"}}]")]
        public virtual void PutTerminateNotification(azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetTerminateNotification @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetTerminateNotification)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurestack.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetTimeouts\"}}]")]
        public virtual void PutTimeouts(azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAdditionalCapabilities")]
        public virtual void ResetAdditionalCapabilities()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAdminPassword")]
        public virtual void ResetAdminPassword()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAdminSshKey")]
        public virtual void ResetAdminSshKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutomaticInstanceRepair")]
        public virtual void ResetAutomaticInstanceRepair()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutomaticOsUpgradePolicy")]
        public virtual void ResetAutomaticOsUpgradePolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBootDiagnostics")]
        public virtual void ResetBootDiagnostics()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetComputerNamePrefix")]
        public virtual void ResetComputerNamePrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomData")]
        public virtual void ResetCustomData()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDataDisk")]
        public virtual void ResetDataDisk()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDisablePasswordAuthentication")]
        public virtual void ResetDisablePasswordAuthentication()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDoNotRunExtensionsOnOverprovisionedMachines")]
        public virtual void ResetDoNotRunExtensionsOnOverprovisionedMachines()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEncryptionAtHostEnabled")]
        public virtual void ResetEncryptionAtHostEnabled()
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

        [JsiiMethod(name: "resetPlatformFaultDomainCount")]
        public virtual void ResetPlatformFaultDomainCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProvisionVmAgent")]
        public virtual void ResetProvisionVmAgent()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScaleInPolicy")]
        public virtual void ResetScaleInPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecret")]
        public virtual void ResetSecret()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSinglePlacementGroup")]
        public virtual void ResetSinglePlacementGroup()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceImageId")]
        public virtual void ResetSourceImageId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceImageReference")]
        public virtual void ResetSourceImageReference()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTerminateNotification")]
        public virtual void ResetTerminateNotification()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUpgradeMode")]
        public virtual void ResetUpgradeMode()
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
        = GetStaticProperty<string>(typeof(azurestack.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSet))!;

        [JsiiProperty(name: "additionalCapabilities", typeJson: "{\"fqn\":\"azurestack.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetAdditionalCapabilitiesOutputReference\"}")]
        public virtual azurestack.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetAdditionalCapabilitiesOutputReference AdditionalCapabilities
        {
            get => GetInstanceProperty<azurestack.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetAdditionalCapabilitiesOutputReference>()!;
        }

        [JsiiProperty(name: "adminSshKey", typeJson: "{\"fqn\":\"azurestack.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetAdminSshKeyList\"}")]
        public virtual azurestack.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetAdminSshKeyList AdminSshKey
        {
            get => GetInstanceProperty<azurestack.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetAdminSshKeyList>()!;
        }

        [JsiiProperty(name: "automaticInstanceRepair", typeJson: "{\"fqn\":\"azurestack.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetAutomaticInstanceRepairOutputReference\"}")]
        public virtual azurestack.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetAutomaticInstanceRepairOutputReference AutomaticInstanceRepair
        {
            get => GetInstanceProperty<azurestack.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetAutomaticInstanceRepairOutputReference>()!;
        }

        [JsiiProperty(name: "automaticOsUpgradePolicy", typeJson: "{\"fqn\":\"azurestack.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetAutomaticOsUpgradePolicyOutputReference\"}")]
        public virtual azurestack.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetAutomaticOsUpgradePolicyOutputReference AutomaticOsUpgradePolicy
        {
            get => GetInstanceProperty<azurestack.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetAutomaticOsUpgradePolicyOutputReference>()!;
        }

        [JsiiProperty(name: "bootDiagnostics", typeJson: "{\"fqn\":\"azurestack.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetBootDiagnosticsOutputReference\"}")]
        public virtual azurestack.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetBootDiagnosticsOutputReference BootDiagnostics
        {
            get => GetInstanceProperty<azurestack.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetBootDiagnosticsOutputReference>()!;
        }

        [JsiiProperty(name: "dataDisk", typeJson: "{\"fqn\":\"azurestack.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetDataDiskList\"}")]
        public virtual azurestack.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetDataDiskList DataDisk
        {
            get => GetInstanceProperty<azurestack.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetDataDiskList>()!;
        }

        [JsiiProperty(name: "extension", typeJson: "{\"fqn\":\"azurestack.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetExtensionList\"}")]
        public virtual azurestack.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetExtensionList Extension
        {
            get => GetInstanceProperty<azurestack.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetExtensionList>()!;
        }

        [JsiiProperty(name: "networkInterface", typeJson: "{\"fqn\":\"azurestack.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetNetworkInterfaceList\"}")]
        public virtual azurestack.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetNetworkInterfaceList NetworkInterface
        {
            get => GetInstanceProperty<azurestack.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetNetworkInterfaceList>()!;
        }

        [JsiiProperty(name: "osDisk", typeJson: "{\"fqn\":\"azurestack.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetOsDiskOutputReference\"}")]
        public virtual azurestack.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetOsDiskOutputReference OsDisk
        {
            get => GetInstanceProperty<azurestack.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetOsDiskOutputReference>()!;
        }

        [JsiiProperty(name: "plan", typeJson: "{\"fqn\":\"azurestack.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetPlanOutputReference\"}")]
        public virtual azurestack.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetPlanOutputReference Plan
        {
            get => GetInstanceProperty<azurestack.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetPlanOutputReference>()!;
        }

        [JsiiProperty(name: "secret", typeJson: "{\"fqn\":\"azurestack.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetSecretList\"}")]
        public virtual azurestack.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetSecretList Secret
        {
            get => GetInstanceProperty<azurestack.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetSecretList>()!;
        }

        [JsiiProperty(name: "sourceImageReference", typeJson: "{\"fqn\":\"azurestack.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetSourceImageReferenceOutputReference\"}")]
        public virtual azurestack.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetSourceImageReferenceOutputReference SourceImageReference
        {
            get => GetInstanceProperty<azurestack.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetSourceImageReferenceOutputReference>()!;
        }

        [JsiiProperty(name: "terminateNotification", typeJson: "{\"fqn\":\"azurestack.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetTerminateNotificationOutputReference\"}")]
        public virtual azurestack.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetTerminateNotificationOutputReference TerminateNotification
        {
            get => GetInstanceProperty<azurestack.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetTerminateNotificationOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurestack.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetTimeoutsOutputReference\"}")]
        public virtual azurestack.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurestack.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "uniqueId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UniqueId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "additionalCapabilitiesInput", typeJson: "{\"fqn\":\"azurestack.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetAdditionalCapabilities\"}", isOptional: true)]
        public virtual azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetAdditionalCapabilities? AdditionalCapabilitiesInput
        {
            get => GetInstanceProperty<azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetAdditionalCapabilities?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "adminPasswordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AdminPasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetAdminSshKey" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "adminSshKeyInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetAdminSshKey\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AdminSshKeyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "adminUsernameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AdminUsernameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "automaticInstanceRepairInput", typeJson: "{\"fqn\":\"azurestack.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetAutomaticInstanceRepair\"}", isOptional: true)]
        public virtual azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetAutomaticInstanceRepair? AutomaticInstanceRepairInput
        {
            get => GetInstanceProperty<azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetAutomaticInstanceRepair?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "automaticOsUpgradePolicyInput", typeJson: "{\"fqn\":\"azurestack.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetAutomaticOsUpgradePolicy\"}", isOptional: true)]
        public virtual azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetAutomaticOsUpgradePolicy? AutomaticOsUpgradePolicyInput
        {
            get => GetInstanceProperty<azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetAutomaticOsUpgradePolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bootDiagnosticsInput", typeJson: "{\"fqn\":\"azurestack.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetBootDiagnostics\"}", isOptional: true)]
        public virtual azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetBootDiagnostics? BootDiagnosticsInput
        {
            get => GetInstanceProperty<azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetBootDiagnostics?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "computerNamePrefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ComputerNamePrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customDataInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CustomDataInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetDataDisk" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dataDiskInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetDataDisk\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DataDiskInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "disablePasswordAuthenticationInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? DisablePasswordAuthenticationInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "doNotRunExtensionsOnOverprovisionedMachinesInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? DoNotRunExtensionsOnOverprovisionedMachinesInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "encryptionAtHostEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EncryptionAtHostEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetExtension" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "extensionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetExtension\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instancesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? InstancesInput
        {
            get => GetInstanceProperty<double?>();
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetNetworkInterface" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkInterfaceInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetNetworkInterface\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? NetworkInterfaceInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "osDiskInput", typeJson: "{\"fqn\":\"azurestack.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetOsDisk\"}", isOptional: true)]
        public virtual azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetOsDisk? OsDiskInput
        {
            get => GetInstanceProperty<azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetOsDisk?>();
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
        [JsiiProperty(name: "planInput", typeJson: "{\"fqn\":\"azurestack.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetPlan\"}", isOptional: true)]
        public virtual azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetPlan? PlanInput
        {
            get => GetInstanceProperty<azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetPlan?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "platformFaultDomainCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PlatformFaultDomainCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provisionVmAgentInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ProvisionVmAgentInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scaleInPolicyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ScaleInPolicyInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetSecret" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secretInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetSecret\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SecretInput
        {
            get => GetInstanceProperty<object?>();
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
        [JsiiProperty(name: "skuInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SkuInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceImageIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceImageIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceImageReferenceInput", typeJson: "{\"fqn\":\"azurestack.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetSourceImageReference\"}", isOptional: true)]
        public virtual azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetSourceImageReference? SourceImageReferenceInput
        {
            get => GetInstanceProperty<azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetSourceImageReference?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "terminateNotificationInput", typeJson: "{\"fqn\":\"azurestack.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetTerminateNotification\"}", isOptional: true)]
        public virtual azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetTerminateNotification? TerminateNotificationInput
        {
            get => GetInstanceProperty<azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetTerminateNotification?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurestack.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "upgradeModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UpgradeModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "adminPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdminPassword
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "adminUsername", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdminUsername
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "computerNamePrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputerNamePrefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "customData", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomData
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "disablePasswordAuthentication", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object DisablePasswordAuthentication
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
        [JsiiProperty(name: "doNotRunExtensionsOnOverprovisionedMachines", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object DoNotRunExtensionsOnOverprovisionedMachines
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
        [JsiiProperty(name: "encryptionAtHostEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object EncryptionAtHostEnabled
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

        [JsiiProperty(name: "instances", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Instances
        {
            get => GetInstanceProperty<double>()!;
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

        [JsiiProperty(name: "platformFaultDomainCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PlatformFaultDomainCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "provisionVmAgent", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object ProvisionVmAgent
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

        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceGroupName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "scaleInPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScaleInPolicy
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

        [JsiiProperty(name: "sku", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Sku
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourceImageId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceImageId
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

        [JsiiProperty(name: "upgradeMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpgradeMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
