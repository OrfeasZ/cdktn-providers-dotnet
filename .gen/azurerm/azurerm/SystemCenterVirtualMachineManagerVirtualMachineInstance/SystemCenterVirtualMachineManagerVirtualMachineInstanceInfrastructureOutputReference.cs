using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SystemCenterVirtualMachineManagerVirtualMachineInstance
{
    [JsiiClass(nativeType: typeof(azurerm.SystemCenterVirtualMachineManagerVirtualMachineInstance.SystemCenterVirtualMachineManagerVirtualMachineInstanceInfrastructureOutputReference), fullyQualifiedName: "azurerm.systemCenterVirtualMachineManagerVirtualMachineInstance.SystemCenterVirtualMachineManagerVirtualMachineInstanceInfrastructureOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SystemCenterVirtualMachineManagerVirtualMachineInstanceInfrastructureOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SystemCenterVirtualMachineManagerVirtualMachineInstanceInfrastructureOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SystemCenterVirtualMachineManagerVirtualMachineInstanceInfrastructureOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SystemCenterVirtualMachineManagerVirtualMachineInstanceInfrastructureOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCheckpointType")]
        public virtual void ResetCheckpointType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSystemCenterVirtualMachineManagerCloudId")]
        public virtual void ResetSystemCenterVirtualMachineManagerCloudId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSystemCenterVirtualMachineManagerInventoryItemId")]
        public virtual void ResetSystemCenterVirtualMachineManagerInventoryItemId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSystemCenterVirtualMachineManagerTemplateId")]
        public virtual void ResetSystemCenterVirtualMachineManagerTemplateId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSystemCenterVirtualMachineManagerVirtualMachineServerId")]
        public virtual void ResetSystemCenterVirtualMachineManagerVirtualMachineServerId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "checkpointTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CheckpointTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "systemCenterVirtualMachineManagerCloudIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SystemCenterVirtualMachineManagerCloudIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "systemCenterVirtualMachineManagerInventoryItemIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SystemCenterVirtualMachineManagerInventoryItemIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "systemCenterVirtualMachineManagerTemplateIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SystemCenterVirtualMachineManagerTemplateIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "systemCenterVirtualMachineManagerVirtualMachineServerIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SystemCenterVirtualMachineManagerVirtualMachineServerIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "checkpointType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CheckpointType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "systemCenterVirtualMachineManagerCloudId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SystemCenterVirtualMachineManagerCloudId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "systemCenterVirtualMachineManagerInventoryItemId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SystemCenterVirtualMachineManagerInventoryItemId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "systemCenterVirtualMachineManagerTemplateId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SystemCenterVirtualMachineManagerTemplateId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "systemCenterVirtualMachineManagerVirtualMachineServerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SystemCenterVirtualMachineManagerVirtualMachineServerId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.systemCenterVirtualMachineManagerVirtualMachineInstance.SystemCenterVirtualMachineManagerVirtualMachineInstanceInfrastructure\"}", isOptional: true)]
        public virtual azurerm.SystemCenterVirtualMachineManagerVirtualMachineInstance.ISystemCenterVirtualMachineManagerVirtualMachineInstanceInfrastructure? InternalValue
        {
            get => GetInstanceProperty<azurerm.SystemCenterVirtualMachineManagerVirtualMachineInstance.ISystemCenterVirtualMachineManagerVirtualMachineInstanceInfrastructure?>();
            set => SetInstanceProperty(value);
        }
    }
}
