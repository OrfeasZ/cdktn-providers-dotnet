using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.LinuxVirtualMachine
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine azurestack_linux_virtual_machine}.</summary>
    [JsiiClass(nativeType: typeof(azurestack.LinuxVirtualMachine.LinuxVirtualMachine), fullyQualifiedName: "azurestack.linuxVirtualMachine.LinuxVirtualMachine", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurestack.linuxVirtualMachine.LinuxVirtualMachineConfig\"}}]")]
    public class LinuxVirtualMachine : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine azurestack_linux_virtual_machine} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public LinuxVirtualMachine(Constructs.Construct scope, string id, azurestack.LinuxVirtualMachine.ILinuxVirtualMachineConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurestack.LinuxVirtualMachine.ILinuxVirtualMachineConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LinuxVirtualMachine(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LinuxVirtualMachine(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a LinuxVirtualMachine resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the LinuxVirtualMachine to import.</param>
        /// <param name="importFromId">The id of the existing LinuxVirtualMachine that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the LinuxVirtualMachine to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the LinuxVirtualMachine to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing LinuxVirtualMachine that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the LinuxVirtualMachine to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azurestack.LinuxVirtualMachine.LinuxVirtualMachine), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAdditionalCapabilities", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurestack.linuxVirtualMachine.LinuxVirtualMachineAdditionalCapabilities\"}}]")]
        public virtual void PutAdditionalCapabilities(azurestack.LinuxVirtualMachine.ILinuxVirtualMachineAdditionalCapabilities @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurestack.LinuxVirtualMachine.ILinuxVirtualMachineAdditionalCapabilities)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.LinuxVirtualMachine.ILinuxVirtualMachineAdminSshKey" />)[]</param>
        [JsiiMethod(name: "putAdminSshKey", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.linuxVirtualMachine.LinuxVirtualMachineAdminSshKey\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAdminSshKey(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurestack.LinuxVirtualMachine.ILinuxVirtualMachineAdminSshKey[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurestack.LinuxVirtualMachine.ILinuxVirtualMachineAdminSshKey).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurestack.LinuxVirtualMachine.ILinuxVirtualMachineAdminSshKey).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBootDiagnostics", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurestack.linuxVirtualMachine.LinuxVirtualMachineBootDiagnostics\"}}]")]
        public virtual void PutBootDiagnostics(azurestack.LinuxVirtualMachine.ILinuxVirtualMachineBootDiagnostics @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurestack.LinuxVirtualMachine.ILinuxVirtualMachineBootDiagnostics)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOsDisk", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurestack.linuxVirtualMachine.LinuxVirtualMachineOsDisk\"}}]")]
        public virtual void PutOsDisk(azurestack.LinuxVirtualMachine.ILinuxVirtualMachineOsDisk @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurestack.LinuxVirtualMachine.ILinuxVirtualMachineOsDisk)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPlan", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurestack.linuxVirtualMachine.LinuxVirtualMachinePlan\"}}]")]
        public virtual void PutPlan(azurestack.LinuxVirtualMachine.ILinuxVirtualMachinePlan @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurestack.LinuxVirtualMachine.ILinuxVirtualMachinePlan)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.LinuxVirtualMachine.ILinuxVirtualMachineSecret" />)[]</param>
        [JsiiMethod(name: "putSecret", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.linuxVirtualMachine.LinuxVirtualMachineSecret\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSecret(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurestack.LinuxVirtualMachine.ILinuxVirtualMachineSecret[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurestack.LinuxVirtualMachine.ILinuxVirtualMachineSecret).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurestack.LinuxVirtualMachine.ILinuxVirtualMachineSecret).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSourceImageReference", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurestack.linuxVirtualMachine.LinuxVirtualMachineSourceImageReference\"}}]")]
        public virtual void PutSourceImageReference(azurestack.LinuxVirtualMachine.ILinuxVirtualMachineSourceImageReference @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurestack.LinuxVirtualMachine.ILinuxVirtualMachineSourceImageReference)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurestack.linuxVirtualMachine.LinuxVirtualMachineTimeouts\"}}]")]
        public virtual void PutTimeouts(azurestack.LinuxVirtualMachine.ILinuxVirtualMachineTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurestack.LinuxVirtualMachine.ILinuxVirtualMachineTimeouts)}, new object[]{@value});
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

        [JsiiMethod(name: "resetDisablePasswordAuthentication")]
        public virtual void ResetDisablePasswordAuthentication()
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

        [JsiiMethod(name: "resetVirtualMachineScaleSetId")]
        public virtual void ResetVirtualMachineScaleSetId()
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
        = GetStaticProperty<string>(typeof(azurestack.LinuxVirtualMachine.LinuxVirtualMachine))!;

        [JsiiProperty(name: "additionalCapabilities", typeJson: "{\"fqn\":\"azurestack.linuxVirtualMachine.LinuxVirtualMachineAdditionalCapabilitiesOutputReference\"}")]
        public virtual azurestack.LinuxVirtualMachine.LinuxVirtualMachineAdditionalCapabilitiesOutputReference AdditionalCapabilities
        {
            get => GetInstanceProperty<azurestack.LinuxVirtualMachine.LinuxVirtualMachineAdditionalCapabilitiesOutputReference>()!;
        }

        [JsiiProperty(name: "adminSshKey", typeJson: "{\"fqn\":\"azurestack.linuxVirtualMachine.LinuxVirtualMachineAdminSshKeyList\"}")]
        public virtual azurestack.LinuxVirtualMachine.LinuxVirtualMachineAdminSshKeyList AdminSshKey
        {
            get => GetInstanceProperty<azurestack.LinuxVirtualMachine.LinuxVirtualMachineAdminSshKeyList>()!;
        }

        [JsiiProperty(name: "bootDiagnostics", typeJson: "{\"fqn\":\"azurestack.linuxVirtualMachine.LinuxVirtualMachineBootDiagnosticsOutputReference\"}")]
        public virtual azurestack.LinuxVirtualMachine.LinuxVirtualMachineBootDiagnosticsOutputReference BootDiagnostics
        {
            get => GetInstanceProperty<azurestack.LinuxVirtualMachine.LinuxVirtualMachineBootDiagnosticsOutputReference>()!;
        }

        [JsiiProperty(name: "osDisk", typeJson: "{\"fqn\":\"azurestack.linuxVirtualMachine.LinuxVirtualMachineOsDiskOutputReference\"}")]
        public virtual azurestack.LinuxVirtualMachine.LinuxVirtualMachineOsDiskOutputReference OsDisk
        {
            get => GetInstanceProperty<azurestack.LinuxVirtualMachine.LinuxVirtualMachineOsDiskOutputReference>()!;
        }

        [JsiiProperty(name: "plan", typeJson: "{\"fqn\":\"azurestack.linuxVirtualMachine.LinuxVirtualMachinePlanOutputReference\"}")]
        public virtual azurestack.LinuxVirtualMachine.LinuxVirtualMachinePlanOutputReference Plan
        {
            get => GetInstanceProperty<azurestack.LinuxVirtualMachine.LinuxVirtualMachinePlanOutputReference>()!;
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

        [JsiiProperty(name: "secret", typeJson: "{\"fqn\":\"azurestack.linuxVirtualMachine.LinuxVirtualMachineSecretList\"}")]
        public virtual azurestack.LinuxVirtualMachine.LinuxVirtualMachineSecretList Secret
        {
            get => GetInstanceProperty<azurestack.LinuxVirtualMachine.LinuxVirtualMachineSecretList>()!;
        }

        [JsiiProperty(name: "sourceImageReference", typeJson: "{\"fqn\":\"azurestack.linuxVirtualMachine.LinuxVirtualMachineSourceImageReferenceOutputReference\"}")]
        public virtual azurestack.LinuxVirtualMachine.LinuxVirtualMachineSourceImageReferenceOutputReference SourceImageReference
        {
            get => GetInstanceProperty<azurestack.LinuxVirtualMachine.LinuxVirtualMachineSourceImageReferenceOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurestack.linuxVirtualMachine.LinuxVirtualMachineTimeoutsOutputReference\"}")]
        public virtual azurestack.LinuxVirtualMachine.LinuxVirtualMachineTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurestack.LinuxVirtualMachine.LinuxVirtualMachineTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "virtualMachineId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VirtualMachineId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "additionalCapabilitiesInput", typeJson: "{\"fqn\":\"azurestack.linuxVirtualMachine.LinuxVirtualMachineAdditionalCapabilities\"}", isOptional: true)]
        public virtual azurestack.LinuxVirtualMachine.ILinuxVirtualMachineAdditionalCapabilities? AdditionalCapabilitiesInput
        {
            get => GetInstanceProperty<azurestack.LinuxVirtualMachine.ILinuxVirtualMachineAdditionalCapabilities?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "adminPasswordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AdminPasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.LinuxVirtualMachine.ILinuxVirtualMachineAdminSshKey" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "adminSshKeyInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.linuxVirtualMachine.LinuxVirtualMachineAdminSshKey\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        [JsiiProperty(name: "bootDiagnosticsInput", typeJson: "{\"fqn\":\"azurestack.linuxVirtualMachine.LinuxVirtualMachineBootDiagnostics\"}", isOptional: true)]
        public virtual azurestack.LinuxVirtualMachine.ILinuxVirtualMachineBootDiagnostics? BootDiagnosticsInput
        {
            get => GetInstanceProperty<azurestack.LinuxVirtualMachine.ILinuxVirtualMachineBootDiagnostics?>();
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
        [JsiiProperty(name: "disablePasswordAuthenticationInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? DisablePasswordAuthenticationInput
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
        [JsiiProperty(name: "osDiskInput", typeJson: "{\"fqn\":\"azurestack.linuxVirtualMachine.LinuxVirtualMachineOsDisk\"}", isOptional: true)]
        public virtual azurestack.LinuxVirtualMachine.ILinuxVirtualMachineOsDisk? OsDiskInput
        {
            get => GetInstanceProperty<azurestack.LinuxVirtualMachine.ILinuxVirtualMachineOsDisk?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "planInput", typeJson: "{\"fqn\":\"azurestack.linuxVirtualMachine.LinuxVirtualMachinePlan\"}", isOptional: true)]
        public virtual azurestack.LinuxVirtualMachine.ILinuxVirtualMachinePlan? PlanInput
        {
            get => GetInstanceProperty<azurestack.LinuxVirtualMachine.ILinuxVirtualMachinePlan?>();
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.LinuxVirtualMachine.ILinuxVirtualMachineSecret" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secretInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.linuxVirtualMachine.LinuxVirtualMachineSecret\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        [JsiiProperty(name: "sourceImageReferenceInput", typeJson: "{\"fqn\":\"azurestack.linuxVirtualMachine.LinuxVirtualMachineSourceImageReference\"}", isOptional: true)]
        public virtual azurestack.LinuxVirtualMachine.ILinuxVirtualMachineSourceImageReference? SourceImageReferenceInput
        {
            get => GetInstanceProperty<azurestack.LinuxVirtualMachine.ILinuxVirtualMachineSourceImageReference?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurestack.LinuxVirtualMachine.ILinuxVirtualMachineTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurestack.linuxVirtualMachine.LinuxVirtualMachineTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "virtualMachineScaleSetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VirtualMachineScaleSetIdInput
        {
            get => GetInstanceProperty<string?>();
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
