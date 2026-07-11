using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagedDevopsPool
{
    [JsiiClass(nativeType: typeof(azurerm.ManagedDevopsPool.ManagedDevopsPoolVirtualMachineScaleSetFabricOutputReference), fullyQualifiedName: "azurerm.managedDevopsPool.ManagedDevopsPoolVirtualMachineScaleSetFabricOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ManagedDevopsPoolVirtualMachineScaleSetFabricOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ManagedDevopsPoolVirtualMachineScaleSetFabricOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ManagedDevopsPoolVirtualMachineScaleSetFabricOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ManagedDevopsPoolVirtualMachineScaleSetFabricOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolVirtualMachineScaleSetFabricImage" />)[]</param>
        [JsiiMethod(name: "putImage", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolVirtualMachineScaleSetFabricImage\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutImage(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.ManagedDevopsPool.IManagedDevopsPoolVirtualMachineScaleSetFabricImage[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ManagedDevopsPool.IManagedDevopsPoolVirtualMachineScaleSetFabricImage).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ManagedDevopsPool.IManagedDevopsPoolVirtualMachineScaleSetFabricImage).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSecurity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolVirtualMachineScaleSetFabricSecurity\"}}]")]
        public virtual void PutSecurity(azurerm.ManagedDevopsPool.IManagedDevopsPoolVirtualMachineScaleSetFabricSecurity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ManagedDevopsPool.IManagedDevopsPoolVirtualMachineScaleSetFabricSecurity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStorage", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolVirtualMachineScaleSetFabricStorage\"}}]")]
        public virtual void PutStorage(azurerm.ManagedDevopsPool.IManagedDevopsPoolVirtualMachineScaleSetFabricStorage @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ManagedDevopsPool.IManagedDevopsPoolVirtualMachineScaleSetFabricStorage)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetOsDiskStorageAccountType")]
        public virtual void ResetOsDiskStorageAccountType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecurity")]
        public virtual void ResetSecurity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStorage")]
        public virtual void ResetStorage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSubnetId")]
        public virtual void ResetSubnetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "image", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolVirtualMachineScaleSetFabricImageList\"}")]
        public virtual azurerm.ManagedDevopsPool.ManagedDevopsPoolVirtualMachineScaleSetFabricImageList Image
        {
            get => GetInstanceProperty<azurerm.ManagedDevopsPool.ManagedDevopsPoolVirtualMachineScaleSetFabricImageList>()!;
        }

        [JsiiProperty(name: "security", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolVirtualMachineScaleSetFabricSecurityOutputReference\"}")]
        public virtual azurerm.ManagedDevopsPool.ManagedDevopsPoolVirtualMachineScaleSetFabricSecurityOutputReference Security
        {
            get => GetInstanceProperty<azurerm.ManagedDevopsPool.ManagedDevopsPoolVirtualMachineScaleSetFabricSecurityOutputReference>()!;
        }

        [JsiiProperty(name: "storage", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolVirtualMachineScaleSetFabricStorageOutputReference\"}")]
        public virtual azurerm.ManagedDevopsPool.ManagedDevopsPoolVirtualMachineScaleSetFabricStorageOutputReference Storage
        {
            get => GetInstanceProperty<azurerm.ManagedDevopsPool.ManagedDevopsPoolVirtualMachineScaleSetFabricStorageOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolVirtualMachineScaleSetFabricImage" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "imageInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolVirtualMachineScaleSetFabricImage\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ImageInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "osDiskStorageAccountTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OsDiskStorageAccountTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityInput", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolVirtualMachineScaleSetFabricSecurity\"}", isOptional: true)]
        public virtual azurerm.ManagedDevopsPool.IManagedDevopsPoolVirtualMachineScaleSetFabricSecurity? SecurityInput
        {
            get => GetInstanceProperty<azurerm.ManagedDevopsPool.IManagedDevopsPoolVirtualMachineScaleSetFabricSecurity?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "skuNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SkuNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageInput", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolVirtualMachineScaleSetFabricStorage\"}", isOptional: true)]
        public virtual azurerm.ManagedDevopsPool.IManagedDevopsPoolVirtualMachineScaleSetFabricStorage? StorageInput
        {
            get => GetInstanceProperty<azurerm.ManagedDevopsPool.IManagedDevopsPoolVirtualMachineScaleSetFabricStorage?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subnetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubnetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "osDiskStorageAccountType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OsDiskStorageAccountType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "skuName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SkuName
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

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolVirtualMachineScaleSetFabric\"}", isOptional: true)]
        public virtual azurerm.ManagedDevopsPool.IManagedDevopsPoolVirtualMachineScaleSetFabric? InternalValue
        {
            get => GetInstanceProperty<azurerm.ManagedDevopsPool.IManagedDevopsPoolVirtualMachineScaleSetFabric?>();
            set => SetInstanceProperty(value);
        }
    }
}
