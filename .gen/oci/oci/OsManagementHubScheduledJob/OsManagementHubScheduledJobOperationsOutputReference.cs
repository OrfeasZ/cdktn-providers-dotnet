using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubScheduledJob
{
    [JsiiClass(nativeType: typeof(oci.OsManagementHubScheduledJob.OsManagementHubScheduledJobOperationsOutputReference), fullyQualifiedName: "oci.osManagementHubScheduledJob.OsManagementHubScheduledJobOperationsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class OsManagementHubScheduledJobOperationsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public OsManagementHubScheduledJobOperationsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OsManagementHubScheduledJobOperationsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OsManagementHubScheduledJobOperationsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putInstallSnapDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.osManagementHubScheduledJob.OsManagementHubScheduledJobOperationsInstallSnapDetails\"}}]")]
        public virtual void PutInstallSnapDetails(oci.OsManagementHubScheduledJob.IOsManagementHubScheduledJobOperationsInstallSnapDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.OsManagementHubScheduledJob.IOsManagementHubScheduledJobOperationsInstallSnapDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putManageModuleStreamsDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.osManagementHubScheduledJob.OsManagementHubScheduledJobOperationsManageModuleStreamsDetails\"}}]")]
        public virtual void PutManageModuleStreamsDetails(oci.OsManagementHubScheduledJob.IOsManagementHubScheduledJobOperationsManageModuleStreamsDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.OsManagementHubScheduledJob.IOsManagementHubScheduledJobOperationsManageModuleStreamsDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRemoveSnapDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.osManagementHubScheduledJob.OsManagementHubScheduledJobOperationsRemoveSnapDetails\"}}]")]
        public virtual void PutRemoveSnapDetails(oci.OsManagementHubScheduledJob.IOsManagementHubScheduledJobOperationsRemoveSnapDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.OsManagementHubScheduledJob.IOsManagementHubScheduledJobOperationsRemoveSnapDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSwitchModuleStreamsDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.osManagementHubScheduledJob.OsManagementHubScheduledJobOperationsSwitchModuleStreamsDetails\"}}]")]
        public virtual void PutSwitchModuleStreamsDetails(oci.OsManagementHubScheduledJob.IOsManagementHubScheduledJobOperationsSwitchModuleStreamsDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.OsManagementHubScheduledJob.IOsManagementHubScheduledJobOperationsSwitchModuleStreamsDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSwitchSnapChannelDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.osManagementHubScheduledJob.OsManagementHubScheduledJobOperationsSwitchSnapChannelDetails\"}}]")]
        public virtual void PutSwitchSnapChannelDetails(oci.OsManagementHubScheduledJob.IOsManagementHubScheduledJobOperationsSwitchSnapChannelDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.OsManagementHubScheduledJob.IOsManagementHubScheduledJobOperationsSwitchSnapChannelDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetInstallSnapDetails")]
        public virtual void ResetInstallSnapDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetManageModuleStreamsDetails")]
        public virtual void ResetManageModuleStreamsDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPackageNames")]
        public virtual void ResetPackageNames()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRebootTimeoutInMins")]
        public virtual void ResetRebootTimeoutInMins()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRemoveSnapDetails")]
        public virtual void ResetRemoveSnapDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSoftwareSourceIds")]
        public virtual void ResetSoftwareSourceIds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSwitchModuleStreamsDetails")]
        public virtual void ResetSwitchModuleStreamsDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSwitchSnapChannelDetails")]
        public virtual void ResetSwitchSnapChannelDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWindowsUpdateNames")]
        public virtual void ResetWindowsUpdateNames()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "installSnapDetails", typeJson: "{\"fqn\":\"oci.osManagementHubScheduledJob.OsManagementHubScheduledJobOperationsInstallSnapDetailsOutputReference\"}")]
        public virtual oci.OsManagementHubScheduledJob.OsManagementHubScheduledJobOperationsInstallSnapDetailsOutputReference InstallSnapDetails
        {
            get => GetInstanceProperty<oci.OsManagementHubScheduledJob.OsManagementHubScheduledJobOperationsInstallSnapDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "manageModuleStreamsDetails", typeJson: "{\"fqn\":\"oci.osManagementHubScheduledJob.OsManagementHubScheduledJobOperationsManageModuleStreamsDetailsOutputReference\"}")]
        public virtual oci.OsManagementHubScheduledJob.OsManagementHubScheduledJobOperationsManageModuleStreamsDetailsOutputReference ManageModuleStreamsDetails
        {
            get => GetInstanceProperty<oci.OsManagementHubScheduledJob.OsManagementHubScheduledJobOperationsManageModuleStreamsDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "removeSnapDetails", typeJson: "{\"fqn\":\"oci.osManagementHubScheduledJob.OsManagementHubScheduledJobOperationsRemoveSnapDetailsOutputReference\"}")]
        public virtual oci.OsManagementHubScheduledJob.OsManagementHubScheduledJobOperationsRemoveSnapDetailsOutputReference RemoveSnapDetails
        {
            get => GetInstanceProperty<oci.OsManagementHubScheduledJob.OsManagementHubScheduledJobOperationsRemoveSnapDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "switchModuleStreamsDetails", typeJson: "{\"fqn\":\"oci.osManagementHubScheduledJob.OsManagementHubScheduledJobOperationsSwitchModuleStreamsDetailsOutputReference\"}")]
        public virtual oci.OsManagementHubScheduledJob.OsManagementHubScheduledJobOperationsSwitchModuleStreamsDetailsOutputReference SwitchModuleStreamsDetails
        {
            get => GetInstanceProperty<oci.OsManagementHubScheduledJob.OsManagementHubScheduledJobOperationsSwitchModuleStreamsDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "switchSnapChannelDetails", typeJson: "{\"fqn\":\"oci.osManagementHubScheduledJob.OsManagementHubScheduledJobOperationsSwitchSnapChannelDetailsOutputReference\"}")]
        public virtual oci.OsManagementHubScheduledJob.OsManagementHubScheduledJobOperationsSwitchSnapChannelDetailsOutputReference SwitchSnapChannelDetails
        {
            get => GetInstanceProperty<oci.OsManagementHubScheduledJob.OsManagementHubScheduledJobOperationsSwitchSnapChannelDetailsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "installSnapDetailsInput", typeJson: "{\"fqn\":\"oci.osManagementHubScheduledJob.OsManagementHubScheduledJobOperationsInstallSnapDetails\"}", isOptional: true)]
        public virtual oci.OsManagementHubScheduledJob.IOsManagementHubScheduledJobOperationsInstallSnapDetails? InstallSnapDetailsInput
        {
            get => GetInstanceProperty<oci.OsManagementHubScheduledJob.IOsManagementHubScheduledJobOperationsInstallSnapDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "manageModuleStreamsDetailsInput", typeJson: "{\"fqn\":\"oci.osManagementHubScheduledJob.OsManagementHubScheduledJobOperationsManageModuleStreamsDetails\"}", isOptional: true)]
        public virtual oci.OsManagementHubScheduledJob.IOsManagementHubScheduledJobOperationsManageModuleStreamsDetails? ManageModuleStreamsDetailsInput
        {
            get => GetInstanceProperty<oci.OsManagementHubScheduledJob.IOsManagementHubScheduledJobOperationsManageModuleStreamsDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "operationTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OperationTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "packageNamesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? PackageNamesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rebootTimeoutInMinsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? RebootTimeoutInMinsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "removeSnapDetailsInput", typeJson: "{\"fqn\":\"oci.osManagementHubScheduledJob.OsManagementHubScheduledJobOperationsRemoveSnapDetails\"}", isOptional: true)]
        public virtual oci.OsManagementHubScheduledJob.IOsManagementHubScheduledJobOperationsRemoveSnapDetails? RemoveSnapDetailsInput
        {
            get => GetInstanceProperty<oci.OsManagementHubScheduledJob.IOsManagementHubScheduledJobOperationsRemoveSnapDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "softwareSourceIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SoftwareSourceIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "switchModuleStreamsDetailsInput", typeJson: "{\"fqn\":\"oci.osManagementHubScheduledJob.OsManagementHubScheduledJobOperationsSwitchModuleStreamsDetails\"}", isOptional: true)]
        public virtual oci.OsManagementHubScheduledJob.IOsManagementHubScheduledJobOperationsSwitchModuleStreamsDetails? SwitchModuleStreamsDetailsInput
        {
            get => GetInstanceProperty<oci.OsManagementHubScheduledJob.IOsManagementHubScheduledJobOperationsSwitchModuleStreamsDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "switchSnapChannelDetailsInput", typeJson: "{\"fqn\":\"oci.osManagementHubScheduledJob.OsManagementHubScheduledJobOperationsSwitchSnapChannelDetails\"}", isOptional: true)]
        public virtual oci.OsManagementHubScheduledJob.IOsManagementHubScheduledJobOperationsSwitchSnapChannelDetails? SwitchSnapChannelDetailsInput
        {
            get => GetInstanceProperty<oci.OsManagementHubScheduledJob.IOsManagementHubScheduledJobOperationsSwitchSnapChannelDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "windowsUpdateNamesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? WindowsUpdateNamesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "operationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OperationType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "packageNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PackageNames
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "rebootTimeoutInMins", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RebootTimeoutInMins
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "softwareSourceIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SoftwareSourceIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "windowsUpdateNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] WindowsUpdateNames
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="oci.OsManagementHubScheduledJob.IOsManagementHubScheduledJobOperations" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.osManagementHubScheduledJob.OsManagementHubScheduledJobOperations\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.OsManagementHubScheduledJob.IOsManagementHubScheduledJobOperations cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.OsManagementHubScheduledJob.IOsManagementHubScheduledJobOperations).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
