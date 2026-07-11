using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.WindowsVirtualMachine
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine azurestack_windows_virtual_machine}.</summary>
    [JsiiClass(nativeType: typeof(azurestack.WindowsVirtualMachine.WindowsVirtualMachine), fullyQualifiedName: "azurestack.windowsVirtualMachine.WindowsVirtualMachine", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurestack.windowsVirtualMachine.WindowsVirtualMachineConfig\"}}]")]
    public class WindowsVirtualMachine : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine azurestack_windows_virtual_machine} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public WindowsVirtualMachine(Constructs.Construct scope, string id, azurestack.WindowsVirtualMachine.IWindowsVirtualMachineConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurestack.WindowsVirtualMachine.IWindowsVirtualMachineConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WindowsVirtualMachine(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WindowsVirtualMachine(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a WindowsVirtualMachine resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the WindowsVirtualMachine to import.</param>
        /// <param name="importFromId">The id of the existing WindowsVirtualMachine that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the WindowsVirtualMachine to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the WindowsVirtualMachine to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing WindowsVirtualMachine that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the WindowsVirtualMachine to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azurestack.WindowsVirtualMachine.WindowsVirtualMachine), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAdditionalCapabilities", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurestack.windowsVirtualMachine.WindowsVirtualMachineAdditionalCapabilities\"}}]")]
        public virtual void PutAdditionalCapabilities(azurestack.WindowsVirtualMachine.IWindowsVirtualMachineAdditionalCapabilities @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurestack.WindowsVirtualMachine.IWindowsVirtualMachineAdditionalCapabilities)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.WindowsVirtualMachine.IWindowsVirtualMachineAdditionalUnattendContent" />)[]</param>
        [JsiiMethod(name: "putAdditionalUnattendContent", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.windowsVirtualMachine.WindowsVirtualMachineAdditionalUnattendContent\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAdditionalUnattendContent(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurestack.WindowsVirtualMachine.IWindowsVirtualMachineAdditionalUnattendContent[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurestack.WindowsVirtualMachine.IWindowsVirtualMachineAdditionalUnattendContent).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurestack.WindowsVirtualMachine.IWindowsVirtualMachineAdditionalUnattendContent).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBootDiagnostics", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurestack.windowsVirtualMachine.WindowsVirtualMachineBootDiagnostics\"}}]")]
        public virtual void PutBootDiagnostics(azurestack.WindowsVirtualMachine.IWindowsVirtualMachineBootDiagnostics @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurestack.WindowsVirtualMachine.IWindowsVirtualMachineBootDiagnostics)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOsDisk", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurestack.windowsVirtualMachine.WindowsVirtualMachineOsDisk\"}}]")]
        public virtual void PutOsDisk(azurestack.WindowsVirtualMachine.IWindowsVirtualMachineOsDisk @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurestack.WindowsVirtualMachine.IWindowsVirtualMachineOsDisk)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPlan", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurestack.windowsVirtualMachine.WindowsVirtualMachinePlan\"}}]")]
        public virtual void PutPlan(azurestack.WindowsVirtualMachine.IWindowsVirtualMachinePlan @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurestack.WindowsVirtualMachine.IWindowsVirtualMachinePlan)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.WindowsVirtualMachine.IWindowsVirtualMachineSecret" />)[]</param>
        [JsiiMethod(name: "putSecret", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.windowsVirtualMachine.WindowsVirtualMachineSecret\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSecret(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurestack.WindowsVirtualMachine.IWindowsVirtualMachineSecret[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurestack.WindowsVirtualMachine.IWindowsVirtualMachineSecret).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurestack.WindowsVirtualMachine.IWindowsVirtualMachineSecret).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSourceImageReference", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurestack.windowsVirtualMachine.WindowsVirtualMachineSourceImageReference\"}}]")]
        public virtual void PutSourceImageReference(azurestack.WindowsVirtualMachine.IWindowsVirtualMachineSourceImageReference @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurestack.WindowsVirtualMachine.IWindowsVirtualMachineSourceImageReference)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurestack.windowsVirtualMachine.WindowsVirtualMachineTimeouts\"}}]")]
        public virtual void PutTimeouts(azurestack.WindowsVirtualMachine.IWindowsVirtualMachineTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurestack.WindowsVirtualMachine.IWindowsVirtualMachineTimeouts)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.WindowsVirtualMachine.IWindowsVirtualMachineWinrmListener" />)[]</param>
        [JsiiMethod(name: "putWinrmListener", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.windowsVirtualMachine.WindowsVirtualMachineWinrmListener\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutWinrmListener(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurestack.WindowsVirtualMachine.IWindowsVirtualMachineWinrmListener[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurestack.WindowsVirtualMachine.IWindowsVirtualMachineWinrmListener).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurestack.WindowsVirtualMachine.IWindowsVirtualMachineWinrmListener).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
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

        [JsiiMethod(name: "resetAllowExtensionOperations")]
        public virtual void ResetAllowExtensionOperations()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
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

        [JsiiMethod(name: "resetComputerName")]
        public virtual void ResetComputerName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomData")]
        public virtual void ResetCustomData()
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

        [JsiiMethod(name: "resetEvictionPolicy")]
        public virtual void ResetEvictionPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExtensionsTimeBudget")]
        public virtual void ResetExtensionsTimeBudget()
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

        [JsiiMethod(name: "resetMaxBidPrice")]
        public virtual void ResetMaxBidPrice()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPatchMode")]
        public virtual void ResetPatchMode()
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

        [JsiiMethod(name: "resetProvisionVmAgent")]
        public virtual void ResetProvisionVmAgent()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecret")]
        public virtual void ResetSecret()
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

        [JsiiMethod(name: "resetVirtualMachineScaleSetId")]
        public virtual void ResetVirtualMachineScaleSetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWinrmListener")]
        public virtual void ResetWinrmListener()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetZone")]
        public virtual void ResetZone()
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
        = GetStaticProperty<string>(typeof(azurestack.WindowsVirtualMachine.WindowsVirtualMachine))!;

        [JsiiProperty(name: "additionalCapabilities", typeJson: "{\"fqn\":\"azurestack.windowsVirtualMachine.WindowsVirtualMachineAdditionalCapabilitiesOutputReference\"}")]
        public virtual azurestack.WindowsVirtualMachine.WindowsVirtualMachineAdditionalCapabilitiesOutputReference AdditionalCapabilities
        {
            get => GetInstanceProperty<azurestack.WindowsVirtualMachine.WindowsVirtualMachineAdditionalCapabilitiesOutputReference>()!;
        }

        [JsiiProperty(name: "additionalUnattendContent", typeJson: "{\"fqn\":\"azurestack.windowsVirtualMachine.WindowsVirtualMachineAdditionalUnattendContentList\"}")]
        public virtual azurestack.WindowsVirtualMachine.WindowsVirtualMachineAdditionalUnattendContentList AdditionalUnattendContent
        {
            get => GetInstanceProperty<azurestack.WindowsVirtualMachine.WindowsVirtualMachineAdditionalUnattendContentList>()!;
        }

        [JsiiProperty(name: "bootDiagnostics", typeJson: "{\"fqn\":\"azurestack.windowsVirtualMachine.WindowsVirtualMachineBootDiagnosticsOutputReference\"}")]
        public virtual azurestack.WindowsVirtualMachine.WindowsVirtualMachineBootDiagnosticsOutputReference BootDiagnostics
        {
            get => GetInstanceProperty<azurestack.WindowsVirtualMachine.WindowsVirtualMachineBootDiagnosticsOutputReference>()!;
        }

        [JsiiProperty(name: "osDisk", typeJson: "{\"fqn\":\"azurestack.windowsVirtualMachine.WindowsVirtualMachineOsDiskOutputReference\"}")]
        public virtual azurestack.WindowsVirtualMachine.WindowsVirtualMachineOsDiskOutputReference OsDisk
        {
            get => GetInstanceProperty<azurestack.WindowsVirtualMachine.WindowsVirtualMachineOsDiskOutputReference>()!;
        }

        [JsiiProperty(name: "plan", typeJson: "{\"fqn\":\"azurestack.windowsVirtualMachine.WindowsVirtualMachinePlanOutputReference\"}")]
        public virtual azurestack.WindowsVirtualMachine.WindowsVirtualMachinePlanOutputReference Plan
        {
            get => GetInstanceProperty<azurestack.WindowsVirtualMachine.WindowsVirtualMachinePlanOutputReference>()!;
        }

        [JsiiProperty(name: "privateIpAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivateIpAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "privateIpAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PrivateIpAddresses
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "publicIpAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublicIpAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "publicIpAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PublicIpAddresses
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "secret", typeJson: "{\"fqn\":\"azurestack.windowsVirtualMachine.WindowsVirtualMachineSecretList\"}")]
        public virtual azurestack.WindowsVirtualMachine.WindowsVirtualMachineSecretList Secret
        {
            get => GetInstanceProperty<azurestack.WindowsVirtualMachine.WindowsVirtualMachineSecretList>()!;
        }

        [JsiiProperty(name: "sourceImageReference", typeJson: "{\"fqn\":\"azurestack.windowsVirtualMachine.WindowsVirtualMachineSourceImageReferenceOutputReference\"}")]
        public virtual azurestack.WindowsVirtualMachine.WindowsVirtualMachineSourceImageReferenceOutputReference SourceImageReference
        {
            get => GetInstanceProperty<azurestack.WindowsVirtualMachine.WindowsVirtualMachineSourceImageReferenceOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurestack.windowsVirtualMachine.WindowsVirtualMachineTimeoutsOutputReference\"}")]
        public virtual azurestack.WindowsVirtualMachine.WindowsVirtualMachineTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurestack.WindowsVirtualMachine.WindowsVirtualMachineTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "virtualMachineId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VirtualMachineId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "winrmListener", typeJson: "{\"fqn\":\"azurestack.windowsVirtualMachine.WindowsVirtualMachineWinrmListenerList\"}")]
        public virtual azurestack.WindowsVirtualMachine.WindowsVirtualMachineWinrmListenerList WinrmListener
        {
            get => GetInstanceProperty<azurestack.WindowsVirtualMachine.WindowsVirtualMachineWinrmListenerList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "additionalCapabilitiesInput", typeJson: "{\"fqn\":\"azurestack.windowsVirtualMachine.WindowsVirtualMachineAdditionalCapabilities\"}", isOptional: true)]
        public virtual azurestack.WindowsVirtualMachine.IWindowsVirtualMachineAdditionalCapabilities? AdditionalCapabilitiesInput
        {
            get => GetInstanceProperty<azurestack.WindowsVirtualMachine.IWindowsVirtualMachineAdditionalCapabilities?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.WindowsVirtualMachine.IWindowsVirtualMachineAdditionalUnattendContent" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "additionalUnattendContentInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.windowsVirtualMachine.WindowsVirtualMachineAdditionalUnattendContent\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allowExtensionOperationsInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AllowExtensionOperationsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "availabilitySetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AvailabilitySetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bootDiagnosticsInput", typeJson: "{\"fqn\":\"azurestack.windowsVirtualMachine.WindowsVirtualMachineBootDiagnostics\"}", isOptional: true)]
        public virtual azurestack.WindowsVirtualMachine.IWindowsVirtualMachineBootDiagnostics? BootDiagnosticsInput
        {
            get => GetInstanceProperty<azurestack.WindowsVirtualMachine.IWindowsVirtualMachineBootDiagnostics?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "computerNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ComputerNameInput
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

        [JsiiOptional]
        [JsiiProperty(name: "evictionPolicyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EvictionPolicyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "extensionsTimeBudgetInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExtensionsTimeBudgetInput
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
        [JsiiProperty(name: "maxBidPriceInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxBidPriceInput
        {
            get => GetInstanceProperty<double?>();
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
        [JsiiProperty(name: "osDiskInput", typeJson: "{\"fqn\":\"azurestack.windowsVirtualMachine.WindowsVirtualMachineOsDisk\"}", isOptional: true)]
        public virtual azurestack.WindowsVirtualMachine.IWindowsVirtualMachineOsDisk? OsDiskInput
        {
            get => GetInstanceProperty<azurestack.WindowsVirtualMachine.IWindowsVirtualMachineOsDisk?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "patchModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PatchModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "planInput", typeJson: "{\"fqn\":\"azurestack.windowsVirtualMachine.WindowsVirtualMachinePlan\"}", isOptional: true)]
        public virtual azurestack.WindowsVirtualMachine.IWindowsVirtualMachinePlan? PlanInput
        {
            get => GetInstanceProperty<azurestack.WindowsVirtualMachine.IWindowsVirtualMachinePlan?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "priorityInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PriorityInput
        {
            get => GetInstanceProperty<string?>();
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

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.WindowsVirtualMachine.IWindowsVirtualMachineSecret" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secretInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.windowsVirtualMachine.WindowsVirtualMachineSecret\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SecretInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sizeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SizeInput
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
        [JsiiProperty(name: "sourceImageReferenceInput", typeJson: "{\"fqn\":\"azurestack.windowsVirtualMachine.WindowsVirtualMachineSourceImageReference\"}", isOptional: true)]
        public virtual azurestack.WindowsVirtualMachine.IWindowsVirtualMachineSourceImageReference? SourceImageReferenceInput
        {
            get => GetInstanceProperty<azurestack.WindowsVirtualMachine.IWindowsVirtualMachineSourceImageReference?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurestack.WindowsVirtualMachine.IWindowsVirtualMachineTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurestack.windowsVirtualMachine.WindowsVirtualMachineTimeouts\"}]}}", isOptional: true)]
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
        [JsiiProperty(name: "virtualMachineScaleSetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VirtualMachineScaleSetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.WindowsVirtualMachine.IWindowsVirtualMachineWinrmListener" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "winrmListenerInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.windowsVirtualMachine.WindowsVirtualMachineWinrmListener\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? WinrmListenerInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "zoneInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ZoneInput
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

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "allowExtensionOperations", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object AllowExtensionOperations
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

        [JsiiProperty(name: "availabilitySetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilitySetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "computerName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputerName
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

        [JsiiProperty(name: "evictionPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EvictionPolicy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "extensionsTimeBudget", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExtensionsTimeBudget
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

        [JsiiProperty(name: "maxBidPrice", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxBidPrice
        {
            get => GetInstanceProperty<double>()!;
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

        [JsiiProperty(name: "patchMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PatchMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Priority
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Size
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

        [JsiiProperty(name: "virtualMachineScaleSetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VirtualMachineScaleSetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "zone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Zone
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
