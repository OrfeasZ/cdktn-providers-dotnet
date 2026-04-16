using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsService
{
    [JsiiClass(nativeType: typeof(aws.EcsService.EcsServiceServiceConnectConfigurationServiceClientAliasTestTrafficRulesHeaderOutputReference), fullyQualifiedName: "aws.ecsService.EcsServiceServiceConnectConfigurationServiceClientAliasTestTrafficRulesHeaderOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class EcsServiceServiceConnectConfigurationServiceClientAliasTestTrafficRulesHeaderOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public EcsServiceServiceConnectConfigurationServiceClientAliasTestTrafficRulesHeaderOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected EcsServiceServiceConnectConfigurationServiceClientAliasTestTrafficRulesHeaderOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EcsServiceServiceConnectConfigurationServiceClientAliasTestTrafficRulesHeaderOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putValue", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ecsService.EcsServiceServiceConnectConfigurationServiceClientAliasTestTrafficRulesHeaderValue\"}}]")]
        public virtual void PutValue(aws.EcsService.IEcsServiceServiceConnectConfigurationServiceClientAliasTestTrafficRulesHeaderValue @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EcsService.IEcsServiceServiceConnectConfigurationServiceClientAliasTestTrafficRulesHeaderValue)}, new object[]{@value});
        }

        [JsiiProperty(name: "value", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceServiceConnectConfigurationServiceClientAliasTestTrafficRulesHeaderValueOutputReference\"}")]
        public virtual aws.EcsService.EcsServiceServiceConnectConfigurationServiceClientAliasTestTrafficRulesHeaderValueOutputReference Value
        {
            get => GetInstanceProperty<aws.EcsService.EcsServiceServiceConnectConfigurationServiceClientAliasTestTrafficRulesHeaderValueOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "valueInput", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceServiceConnectConfigurationServiceClientAliasTestTrafficRulesHeaderValue\"}", isOptional: true)]
        public virtual aws.EcsService.IEcsServiceServiceConnectConfigurationServiceClientAliasTestTrafficRulesHeaderValue? ValueInput
        {
            get => GetInstanceProperty<aws.EcsService.IEcsServiceServiceConnectConfigurationServiceClientAliasTestTrafficRulesHeaderValue?>();
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceServiceConnectConfigurationServiceClientAliasTestTrafficRulesHeader\"}", isOptional: true)]
        public virtual aws.EcsService.IEcsServiceServiceConnectConfigurationServiceClientAliasTestTrafficRulesHeader? InternalValue
        {
            get => GetInstanceProperty<aws.EcsService.IEcsServiceServiceConnectConfigurationServiceClientAliasTestTrafficRulesHeader?>();
            set => SetInstanceProperty(value);
        }
    }
}
