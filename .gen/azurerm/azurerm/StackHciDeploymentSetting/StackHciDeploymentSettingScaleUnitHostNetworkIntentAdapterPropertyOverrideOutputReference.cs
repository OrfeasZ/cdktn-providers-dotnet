using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StackHciDeploymentSetting
{
    [JsiiClass(nativeType: typeof(azurerm.StackHciDeploymentSetting.StackHciDeploymentSettingScaleUnitHostNetworkIntentAdapterPropertyOverrideOutputReference), fullyQualifiedName: "azurerm.stackHciDeploymentSetting.StackHciDeploymentSettingScaleUnitHostNetworkIntentAdapterPropertyOverrideOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class StackHciDeploymentSettingScaleUnitHostNetworkIntentAdapterPropertyOverrideOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public StackHciDeploymentSettingScaleUnitHostNetworkIntentAdapterPropertyOverrideOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected StackHciDeploymentSettingScaleUnitHostNetworkIntentAdapterPropertyOverrideOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StackHciDeploymentSettingScaleUnitHostNetworkIntentAdapterPropertyOverrideOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetJumboPacket")]
        public virtual void ResetJumboPacket()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetworkDirect")]
        public virtual void ResetNetworkDirect()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetworkDirectTechnology")]
        public virtual void ResetNetworkDirectTechnology()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "jumboPacketInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? JumboPacketInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkDirectInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NetworkDirectInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkDirectTechnologyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NetworkDirectTechnologyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "jumboPacket", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JumboPacket
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "networkDirect", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkDirect
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "networkDirectTechnology", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkDirectTechnology
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.stackHciDeploymentSetting.StackHciDeploymentSettingScaleUnitHostNetworkIntentAdapterPropertyOverride\"}", isOptional: true)]
        public virtual azurerm.StackHciDeploymentSetting.IStackHciDeploymentSettingScaleUnitHostNetworkIntentAdapterPropertyOverride? InternalValue
        {
            get => GetInstanceProperty<azurerm.StackHciDeploymentSetting.IStackHciDeploymentSettingScaleUnitHostNetworkIntentAdapterPropertyOverride?>();
            set => SetInstanceProperty(value);
        }
    }
}
