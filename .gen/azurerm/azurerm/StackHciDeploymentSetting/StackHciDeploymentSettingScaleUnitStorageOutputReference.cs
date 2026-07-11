using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StackHciDeploymentSetting
{
    [JsiiClass(nativeType: typeof(azurerm.StackHciDeploymentSetting.StackHciDeploymentSettingScaleUnitStorageOutputReference), fullyQualifiedName: "azurerm.stackHciDeploymentSetting.StackHciDeploymentSettingScaleUnitStorageOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class StackHciDeploymentSettingScaleUnitStorageOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public StackHciDeploymentSettingScaleUnitStorageOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected StackHciDeploymentSettingScaleUnitStorageOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StackHciDeploymentSettingScaleUnitStorageOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "configurationModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConfigurationModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "configurationMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfigurationMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.stackHciDeploymentSetting.StackHciDeploymentSettingScaleUnitStorage\"}", isOptional: true)]
        public virtual azurerm.StackHciDeploymentSetting.IStackHciDeploymentSettingScaleUnitStorage? InternalValue
        {
            get => GetInstanceProperty<azurerm.StackHciDeploymentSetting.IStackHciDeploymentSettingScaleUnitStorage?>();
            set => SetInstanceProperty(value);
        }
    }
}
