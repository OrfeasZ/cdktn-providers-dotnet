using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.WindowsVirtualMachineScaleSet
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine_scale_set azurestack_windows_virtual_machine_scale_set}.</summary>
    [JsiiClass(nativeType: typeof(azurestack.WindowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSet), fullyQualifiedName: "azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSet", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetConfig\"}}]")]
    public class WindowsVirtualMachineScaleSet : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine_scale_set azurestack_windows_virtual_machine_scale_set} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public WindowsVirtualMachineScaleSet(Constructs.Construct scope, string id, azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WindowsVirtualMachineScaleSet(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WindowsVirtualMachineScaleSet(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a WindowsVirtualMachineScaleSet resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the WindowsVirtualMachineScaleSet to import.</param>
        /// <param name="importFromId">The id of the existing WindowsVirtualMachineScaleSet that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the WindowsVirtualMachineScaleSet to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the WindowsVirtualMachineScaleSet to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine_scale_set#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing WindowsVirtualMachineScaleSet that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the WindowsVirtualMachineScaleSet to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azurestack.WindowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSet), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAdditionalCapabilities", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetAdditionalCapabilities\"}}]")]
        public virtual void PutAdditionalCapabilities(azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetAdditionalCapabilities @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetAdditionalCapabilities)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetAdditionalUnattendContent" />)[]</param>
        [JsiiMethod(name: "putAdditionalUnattendContent", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetAdditionalUnattendContent\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAdditionalUnattendContent(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetAdditionalUnattendContent[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetAdditionalUnattendContent).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetAdditionalUnattendContent).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAutomaticInstanceRepair", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetAutomaticInstanceRepair\"}}]")]
        public virtual void PutAutomaticInstanceRepair(azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetAutomaticInstanceRepair @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetAutomaticInstanceRepair)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAutomaticOsUpgradePolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetAutomaticOsUpgradePolicy\"}}]")]
        public virtual void PutAutomaticOsUpgradePolicy(azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetAutomaticOsUpgradePolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetAutomaticOsUpgradePolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBootDiagnostics", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetBootDiagnostics\"}}]")]
        public virtual void PutBootDiagnostics(azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetBootDiagnostics @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetBootDiagnostics)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetDataDisk" />)[]</param>
        [JsiiMethod(name: "putDataDisk", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetDataDisk\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDataDisk(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetDataDisk[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetDataDisk).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetDataDisk).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetExtension" />)[]</param>
        [JsiiMethod(name: "putExtension", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetExtension\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutExtension(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetExtension[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetExtension).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetExtension).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetNetworkInterface" />)[]</param>
        [JsiiMethod(name: "putNetworkInterface", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetNetworkInterface\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutNetworkInterface(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetNetworkInterface[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetNetworkInterface).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetNetworkInterface).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOsDisk", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetOsDisk\"}}]")]
        public virtual void PutOsDisk(azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetOsDisk @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetOsDisk)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPlan", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetPlan\"}}]")]
        public virtual void PutPlan(azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetPlan @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetPlan)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetSecret" />)[]</param>
        [JsiiMethod(name: "putSecret", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetSecret\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSecret(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetSecret[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetSecret).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetSecret).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSourceImageReference", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetSourceImageReference\"}}]")]
        public virtual void PutSourceImageReference(azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetSourceImageReference @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetSourceImageReference)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTerminateNotification", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetTerminateNotification\"}}]")]
        public virtual void PutTerminateNotification(azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetTerminateNotification @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetTerminateNotification)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetTimeouts\"}}]")]
        public virtual void PutTimeouts(azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetTimeouts)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetWinrmListener" />)[]</param>
        [JsiiMethod(name: "putWinrmListener", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetWinrmListener\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutWinrmListener(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetWinrmListener[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetWinrmListener).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetWinrmListener).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAdditionalCapabilities")]
        public virtual void ResetAdditionalCapabilities()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAdditionalUnattendContent")]
        public virtual void ResetAdditionalUnattendContent()
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

        [JsiiMethod(name: "resetDoNotRunExtensionsOnOverprovisionedMachines")]
        public virtual void ResetDoNotRunExtensionsOnOverprovisionedMachines()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnableAutomaticUpdates")]
        public virtual void ResetEnableAutomaticUpdates()
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

        [JsiiMethod(name: "resetLicenseType")]
        public virtual void ResetLicenseType()
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

        [JsiiMethod(name: "resetTimezone")]
        public virtual void ResetTimezone()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUpgradeMode")]
        public virtual void ResetUpgradeMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWinrmListener")]
        public virtual void ResetWinrmListener()
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
        = GetStaticProperty<string>(typeof(azurestack.WindowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSet))!;

        [JsiiProperty(name: "additionalCapabilities", typeJson: "{\"fqn\":\"azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetAdditionalCapabilitiesOutputReference\"}")]
        public virtual azurestack.WindowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetAdditionalCapabilitiesOutputReference AdditionalCapabilities
        {
            get => GetInstanceProperty<azurestack.WindowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetAdditionalCapabilitiesOutputReference>()!;
        }

        [JsiiProperty(name: "additionalUnattendContent", typeJson: "{\"fqn\":\"azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetAdditionalUnattendContentList\"}")]
        public virtual azurestack.WindowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetAdditionalUnattendContentList AdditionalUnattendContent
        {
            get => GetInstanceProperty<azurestack.WindowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetAdditionalUnattendContentList>()!;
        }

        [JsiiProperty(name: "automaticInstanceRepair", typeJson: "{\"fqn\":\"azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetAutomaticInstanceRepairOutputReference\"}")]
        public virtual azurestack.WindowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetAutomaticInstanceRepairOutputReference AutomaticInstanceRepair
        {
            get => GetInstanceProperty<azurestack.WindowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetAutomaticInstanceRepairOutputReference>()!;
        }

        [JsiiProperty(name: "automaticOsUpgradePolicy", typeJson: "{\"fqn\":\"azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetAutomaticOsUpgradePolicyOutputReference\"}")]
        public virtual azurestack.WindowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetAutomaticOsUpgradePolicyOutputReference AutomaticOsUpgradePolicy
        {
            get => GetInstanceProperty<azurestack.WindowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetAutomaticOsUpgradePolicyOutputReference>()!;
        }

        [JsiiProperty(name: "bootDiagnostics", typeJson: "{\"fqn\":\"azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetBootDiagnosticsOutputReference\"}")]
        public virtual azurestack.WindowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetBootDiagnosticsOutputReference BootDiagnostics
        {
            get => GetInstanceProperty<azurestack.WindowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetBootDiagnosticsOutputReference>()!;
        }

        [JsiiProperty(name: "dataDisk", typeJson: "{\"fqn\":\"azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetDataDiskList\"}")]
        public virtual azurestack.WindowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetDataDiskList DataDisk
        {
            get => GetInstanceProperty<azurestack.WindowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetDataDiskList>()!;
        }

        [JsiiProperty(name: "extension", typeJson: "{\"fqn\":\"azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetExtensionList\"}")]
        public virtual azurestack.WindowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetExtensionList Extension
        {
            get => GetInstanceProperty<azurestack.WindowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetExtensionList>()!;
        }

        [JsiiProperty(name: "networkInterface", typeJson: "{\"fqn\":\"azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetNetworkInterfaceList\"}")]
        public virtual azurestack.WindowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetNetworkInterfaceList NetworkInterface
        {
            get => GetInstanceProperty<azurestack.WindowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetNetworkInterfaceList>()!;
        }

        [JsiiProperty(name: "osDisk", typeJson: "{\"fqn\":\"azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetOsDiskOutputReference\"}")]
        public virtual azurestack.WindowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetOsDiskOutputReference OsDisk
        {
            get => GetInstanceProperty<azurestack.WindowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetOsDiskOutputReference>()!;
        }

        [JsiiProperty(name: "plan", typeJson: "{\"fqn\":\"azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetPlanOutputReference\"}")]
        public virtual azurestack.WindowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetPlanOutputReference Plan
        {
            get => GetInstanceProperty<azurestack.WindowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetPlanOutputReference>()!;
        }

        [JsiiProperty(name: "secret", typeJson: "{\"fqn\":\"azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetSecretList\"}")]
        public virtual azurestack.WindowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetSecretList Secret
        {
            get => GetInstanceProperty<azurestack.WindowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetSecretList>()!;
        }

        [JsiiProperty(name: "sourceImageReference", typeJson: "{\"fqn\":\"azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetSourceImageReferenceOutputReference\"}")]
        public virtual azurestack.WindowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetSourceImageReferenceOutputReference SourceImageReference
        {
            get => GetInstanceProperty<azurestack.WindowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetSourceImageReferenceOutputReference>()!;
        }

        [JsiiProperty(name: "terminateNotification", typeJson: "{\"fqn\":\"azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetTerminateNotificationOutputReference\"}")]
        public virtual azurestack.WindowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetTerminateNotificationOutputReference TerminateNotification
        {
            get => GetInstanceProperty<azurestack.WindowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetTerminateNotificationOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetTimeoutsOutputReference\"}")]
        public virtual azurestack.WindowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurestack.WindowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "uniqueId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UniqueId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "winrmListener", typeJson: "{\"fqn\":\"azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetWinrmListenerList\"}")]
        public virtual azurestack.WindowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetWinrmListenerList WinrmListener
        {
            get => GetInstanceProperty<azurestack.WindowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetWinrmListenerList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "additionalCapabilitiesInput", typeJson: "{\"fqn\":\"azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetAdditionalCapabilities\"}", isOptional: true)]
        public virtual azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetAdditionalCapabilities? AdditionalCapabilitiesInput
        {
            get => GetInstanceProperty<azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetAdditionalCapabilities?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetAdditionalUnattendContent" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "additionalUnattendContentInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetAdditionalUnattendContent\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AdditionalUnattendContentInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "adminPasswordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AdminPasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "adminUsernameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AdminUsernameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "automaticInstanceRepairInput", typeJson: "{\"fqn\":\"azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetAutomaticInstanceRepair\"}", isOptional: true)]
        public virtual azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetAutomaticInstanceRepair? AutomaticInstanceRepairInput
        {
            get => GetInstanceProperty<azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetAutomaticInstanceRepair?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "automaticOsUpgradePolicyInput", typeJson: "{\"fqn\":\"azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetAutomaticOsUpgradePolicy\"}", isOptional: true)]
        public virtual azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetAutomaticOsUpgradePolicy? AutomaticOsUpgradePolicyInput
        {
            get => GetInstanceProperty<azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetAutomaticOsUpgradePolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bootDiagnosticsInput", typeJson: "{\"fqn\":\"azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetBootDiagnostics\"}", isOptional: true)]
        public virtual azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetBootDiagnostics? BootDiagnosticsInput
        {
            get => GetInstanceProperty<azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetBootDiagnostics?>();
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetDataDisk" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dataDiskInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetDataDisk\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DataDiskInput
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
        [JsiiProperty(name: "enableAutomaticUpdatesInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnableAutomaticUpdatesInput
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetExtension" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "extensionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetExtension\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetNetworkInterface" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkInterfaceInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetNetworkInterface\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? NetworkInterfaceInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "osDiskInput", typeJson: "{\"fqn\":\"azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetOsDisk\"}", isOptional: true)]
        public virtual azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetOsDisk? OsDiskInput
        {
            get => GetInstanceProperty<azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetOsDisk?>();
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
        [JsiiProperty(name: "planInput", typeJson: "{\"fqn\":\"azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetPlan\"}", isOptional: true)]
        public virtual azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetPlan? PlanInput
        {
            get => GetInstanceProperty<azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetPlan?>();
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetSecret" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secretInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetSecret\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        [JsiiProperty(name: "sourceImageReferenceInput", typeJson: "{\"fqn\":\"azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetSourceImageReference\"}", isOptional: true)]
        public virtual azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetSourceImageReference? SourceImageReferenceInput
        {
            get => GetInstanceProperty<azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetSourceImageReference?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "terminateNotificationInput", typeJson: "{\"fqn\":\"azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetTerminateNotification\"}", isOptional: true)]
        public virtual azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetTerminateNotification? TerminateNotificationInput
        {
            get => GetInstanceProperty<azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetTerminateNotification?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timezoneInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimezoneInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "upgradeModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UpgradeModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetWinrmListener" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "winrmListenerInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetWinrmListener\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? WinrmListenerInput
        {
            get => GetInstanceProperty<object?>();
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
        [JsiiProperty(name: "enableAutomaticUpdates", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object EnableAutomaticUpdates
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

        [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Timezone
        {
            get => GetInstanceProperty<string>()!;
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
