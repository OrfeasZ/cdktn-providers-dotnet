using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnFrontdoorBatchRuleSet
{
    [JsiiClass(nativeType: typeof(azurerm.CdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverrideOutputReference), fullyQualifiedName: "azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverrideOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverrideOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverrideOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverrideOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverrideOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCaching", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverrideCaching\"}}]")]
        public virtual void PutCaching(azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverrideCaching @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverrideCaching)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOriginGroup", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverrideOriginGroup\"}}]")]
        public virtual void PutOriginGroup(azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverrideOriginGroup @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverrideOriginGroup)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetOriginGroup")]
        public virtual void ResetOriginGroup()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "caching", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverrideCachingOutputReference\"}")]
        public virtual azurerm.CdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverrideCachingOutputReference Caching
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverrideCachingOutputReference>()!;
        }

        [JsiiProperty(name: "originGroup", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverrideOriginGroupOutputReference\"}")]
        public virtual azurerm.CdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverrideOriginGroupOutputReference OriginGroup
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverrideOriginGroupOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cachingInput", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverrideCaching\"}", isOptional: true)]
        public virtual azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverrideCaching? CachingInput
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverrideCaching?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "originGroupInput", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverrideOriginGroup\"}", isOptional: true)]
        public virtual azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverrideOriginGroup? OriginGroupInput
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverrideOriginGroup?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverride\"}", isOptional: true)]
        public virtual azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverride? InternalValue
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverride?>();
            set => SetInstanceProperty(value);
        }
    }
}
