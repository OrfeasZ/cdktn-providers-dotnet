using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnFrontdoorBatchRuleSet
{
    [JsiiClass(nativeType: typeof(azurerm.CdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverrideOriginGroupOutputReference), fullyQualifiedName: "azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverrideOriginGroupOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverrideOriginGroupOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverrideOriginGroupOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverrideOriginGroupOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverrideOriginGroupOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "cdnFrontdoorOriginGroupIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CdnFrontdoorOriginGroupIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "forwardingProtocolInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ForwardingProtocolInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "cdnFrontdoorOriginGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CdnFrontdoorOriginGroupId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "forwardingProtocol", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ForwardingProtocol
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverrideOriginGroup\"}", isOptional: true)]
        public virtual azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverrideOriginGroup? InternalValue
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverrideOriginGroup?>();
            set => SetInstanceProperty(value);
        }
    }
}
