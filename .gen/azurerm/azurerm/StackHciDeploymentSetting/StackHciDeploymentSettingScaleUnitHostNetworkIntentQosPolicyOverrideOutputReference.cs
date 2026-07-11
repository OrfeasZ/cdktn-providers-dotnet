using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StackHciDeploymentSetting
{
    [JsiiClass(nativeType: typeof(azurerm.StackHciDeploymentSetting.StackHciDeploymentSettingScaleUnitHostNetworkIntentQosPolicyOverrideOutputReference), fullyQualifiedName: "azurerm.stackHciDeploymentSetting.StackHciDeploymentSettingScaleUnitHostNetworkIntentQosPolicyOverrideOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class StackHciDeploymentSettingScaleUnitHostNetworkIntentQosPolicyOverrideOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public StackHciDeploymentSettingScaleUnitHostNetworkIntentQosPolicyOverrideOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected StackHciDeploymentSettingScaleUnitHostNetworkIntentQosPolicyOverrideOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StackHciDeploymentSettingScaleUnitHostNetworkIntentQosPolicyOverrideOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetBandwidthPercentageSmb")]
        public virtual void ResetBandwidthPercentageSmb()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPriorityValue8021ActionCluster")]
        public virtual void ResetPriorityValue8021ActionCluster()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPriorityValue8021ActionSmb")]
        public virtual void ResetPriorityValue8021ActionSmb()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "bandwidthPercentageSmbInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BandwidthPercentageSmbInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "priorityValue8021ActionClusterInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PriorityValue8021ActionClusterInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "priorityValue8021ActionSmbInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PriorityValue8021ActionSmbInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "bandwidthPercentageSmb", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BandwidthPercentageSmb
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "priorityValue8021ActionCluster", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PriorityValue8021ActionCluster
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "priorityValue8021ActionSmb", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PriorityValue8021ActionSmb
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.stackHciDeploymentSetting.StackHciDeploymentSettingScaleUnitHostNetworkIntentQosPolicyOverride\"}", isOptional: true)]
        public virtual azurerm.StackHciDeploymentSetting.IStackHciDeploymentSettingScaleUnitHostNetworkIntentQosPolicyOverride? InternalValue
        {
            get => GetInstanceProperty<azurerm.StackHciDeploymentSetting.IStackHciDeploymentSettingScaleUnitHostNetworkIntentQosPolicyOverride?>();
            set => SetInstanceProperty(value);
        }
    }
}
