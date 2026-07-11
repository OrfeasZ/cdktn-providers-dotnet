using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StackHciDeploymentSetting
{
    [JsiiClass(nativeType: typeof(azurerm.StackHciDeploymentSetting.StackHciDeploymentSettingScaleUnitOptionalServiceOutputReference), fullyQualifiedName: "azurerm.stackHciDeploymentSetting.StackHciDeploymentSettingScaleUnitOptionalServiceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class StackHciDeploymentSettingScaleUnitOptionalServiceOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public StackHciDeploymentSettingScaleUnitOptionalServiceOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected StackHciDeploymentSettingScaleUnitOptionalServiceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StackHciDeploymentSettingScaleUnitOptionalServiceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "customLocationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CustomLocationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "customLocation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomLocation
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.stackHciDeploymentSetting.StackHciDeploymentSettingScaleUnitOptionalService\"}", isOptional: true)]
        public virtual azurerm.StackHciDeploymentSetting.IStackHciDeploymentSettingScaleUnitOptionalService? InternalValue
        {
            get => GetInstanceProperty<azurerm.StackHciDeploymentSetting.IStackHciDeploymentSettingScaleUnitOptionalService?>();
            set => SetInstanceProperty(value);
        }
    }
}
