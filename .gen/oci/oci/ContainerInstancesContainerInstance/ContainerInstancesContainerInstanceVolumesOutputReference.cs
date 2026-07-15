using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerInstancesContainerInstance
{
    [JsiiClass(nativeType: typeof(oci.ContainerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumesOutputReference), fullyQualifiedName: "oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class ContainerInstancesContainerInstanceVolumesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public ContainerInstancesContainerInstanceVolumesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected ContainerInstancesContainerInstanceVolumesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ContainerInstancesContainerInstanceVolumesOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVolumesConfigs" />)[]</param>
        [JsiiMethod(name: "putConfigs", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumesConfigs\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutConfigs(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVolumesConfigs[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVolumesConfigs).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVolumesConfigs).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putExport", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumesExport\"}}]")]
        public virtual void PutExport(oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVolumesExport @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVolumesExport)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMountCommand", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumesMountCommand\"}}]")]
        public virtual void PutMountCommand(oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVolumesMountCommand @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVolumesMountCommand)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMountTarget", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumesMountTarget\"}}]")]
        public virtual void PutMountTarget(oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVolumesMountTarget @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVolumesMountTarget)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSecurity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumesSecurity\"}}]")]
        public virtual void PutSecurity(oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVolumesSecurity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVolumesSecurity)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBackingStore")]
        public virtual void ResetBackingStore()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConfigs")]
        public virtual void ResetConfigs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExport")]
        public virtual void ResetExport()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMountCommand")]
        public virtual void ResetMountCommand()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMountTarget")]
        public virtual void ResetMountTarget()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecurity")]
        public virtual void ResetSecurity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSubnetId")]
        public virtual void ResetSubnetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "configs", typeJson: "{\"fqn\":\"oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumesConfigsList\"}")]
        public virtual oci.ContainerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumesConfigsList Configs
        {
            get => GetInstanceProperty<oci.ContainerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumesConfigsList>()!;
        }

        [JsiiProperty(name: "export", typeJson: "{\"fqn\":\"oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumesExportOutputReference\"}")]
        public virtual oci.ContainerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumesExportOutputReference Export
        {
            get => GetInstanceProperty<oci.ContainerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumesExportOutputReference>()!;
        }

        [JsiiProperty(name: "mountCommand", typeJson: "{\"fqn\":\"oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumesMountCommandOutputReference\"}")]
        public virtual oci.ContainerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumesMountCommandOutputReference MountCommand
        {
            get => GetInstanceProperty<oci.ContainerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumesMountCommandOutputReference>()!;
        }

        [JsiiProperty(name: "mountTarget", typeJson: "{\"fqn\":\"oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumesMountTargetOutputReference\"}")]
        public virtual oci.ContainerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumesMountTargetOutputReference MountTarget
        {
            get => GetInstanceProperty<oci.ContainerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumesMountTargetOutputReference>()!;
        }

        [JsiiProperty(name: "security", typeJson: "{\"fqn\":\"oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumesSecurityOutputReference\"}")]
        public virtual oci.ContainerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumesSecurityOutputReference Security
        {
            get => GetInstanceProperty<oci.ContainerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumesSecurityOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "backingStoreInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BackingStoreInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVolumesConfigs" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "configsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumesConfigs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ConfigsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "exportInput", typeJson: "{\"fqn\":\"oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumesExport\"}", isOptional: true)]
        public virtual oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVolumesExport? ExportInput
        {
            get => GetInstanceProperty<oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVolumesExport?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mountCommandInput", typeJson: "{\"fqn\":\"oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumesMountCommand\"}", isOptional: true)]
        public virtual oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVolumesMountCommand? MountCommandInput
        {
            get => GetInstanceProperty<oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVolumesMountCommand?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mountTargetInput", typeJson: "{\"fqn\":\"oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumesMountTarget\"}", isOptional: true)]
        public virtual oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVolumesMountTarget? MountTargetInput
        {
            get => GetInstanceProperty<oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVolumesMountTarget?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityInput", typeJson: "{\"fqn\":\"oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumesSecurity\"}", isOptional: true)]
        public virtual oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVolumesSecurity? SecurityInput
        {
            get => GetInstanceProperty<oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVolumesSecurity?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subnetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubnetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "volumeTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VolumeTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "backingStore", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BackingStore
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

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "volumeType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VolumeType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVolumes" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumes\"}]}}", isOptional: true)]
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
                        case oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVolumes cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVolumes).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
