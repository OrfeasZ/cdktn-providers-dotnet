using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciLoggingUnifiedAgentConfiguration
{
    [JsiiClass(nativeType: typeof(oci.DataOciLoggingUnifiedAgentConfiguration.DataOciLoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilterOutputReference), fullyQualifiedName: "oci.dataOciLoggingUnifiedAgentConfiguration.DataOciLoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilterOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciLoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilterOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciLoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilterOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciLoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilterOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciLoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilterOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "allowList", typeJson: "{\"fqn\":\"oci.dataOciLoggingUnifiedAgentConfiguration.DataOciLoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilterAllowListStructList\"}")]
        public virtual oci.DataOciLoggingUnifiedAgentConfiguration.DataOciLoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilterAllowListStructList AllowList
        {
            get => GetInstanceProperty<oci.DataOciLoggingUnifiedAgentConfiguration.DataOciLoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilterAllowListStructList>()!;
        }

        [JsiiProperty(name: "customFilterType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomFilterType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customSections", typeJson: "{\"fqn\":\"oci.dataOciLoggingUnifiedAgentConfiguration.DataOciLoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilterCustomSectionsList\"}")]
        public virtual oci.DataOciLoggingUnifiedAgentConfiguration.DataOciLoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilterCustomSectionsList CustomSections
        {
            get => GetInstanceProperty<oci.DataOciLoggingUnifiedAgentConfiguration.DataOciLoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilterCustomSectionsList>()!;
        }

        [JsiiProperty(name: "denyList", typeJson: "{\"fqn\":\"oci.dataOciLoggingUnifiedAgentConfiguration.DataOciLoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilterDenyListStructList\"}")]
        public virtual oci.DataOciLoggingUnifiedAgentConfiguration.DataOciLoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilterDenyListStructList DenyList
        {
            get => GetInstanceProperty<oci.DataOciLoggingUnifiedAgentConfiguration.DataOciLoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilterDenyListStructList>()!;
        }

        [JsiiProperty(name: "emitInvalidRecordToError", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable EmitInvalidRecordToError
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "filterType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FilterType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hashValueField", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HashValueField
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "injectKeyPrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InjectKeyPrefix
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isAutoTypecastEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsAutoTypecastEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isRenewRecordEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsRenewRecordEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isRubyEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsRubyEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "keepKeys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] KeepKeys
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "keyName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "params", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap Params
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "parser", typeJson: "{\"fqn\":\"oci.dataOciLoggingUnifiedAgentConfiguration.DataOciLoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilterParserList\"}")]
        public virtual oci.DataOciLoggingUnifiedAgentConfiguration.DataOciLoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilterParserList Parser
        {
            get => GetInstanceProperty<oci.DataOciLoggingUnifiedAgentConfiguration.DataOciLoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilterParserList>()!;
        }

        [JsiiProperty(name: "recordList", typeJson: "{\"fqn\":\"oci.dataOciLoggingUnifiedAgentConfiguration.DataOciLoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilterRecordListStructList\"}")]
        public virtual oci.DataOciLoggingUnifiedAgentConfiguration.DataOciLoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilterRecordListStructList RecordList
        {
            get => GetInstanceProperty<oci.DataOciLoggingUnifiedAgentConfiguration.DataOciLoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilterRecordListStructList>()!;
        }

        [JsiiProperty(name: "removeKeyNameField", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable RemoveKeyNameField
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "removeKeys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] RemoveKeys
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "renewTimeKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RenewTimeKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "replaceInvalidSequence", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ReplaceInvalidSequence
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "reserveData", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ReserveData
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "reserveTime", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ReserveTime
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciLoggingUnifiedAgentConfiguration.DataOciLoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilter\"}", isOptional: true)]
        public virtual oci.DataOciLoggingUnifiedAgentConfiguration.IDataOciLoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilter? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciLoggingUnifiedAgentConfiguration.IDataOciLoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilter?>();
            set => SetInstanceProperty(value);
        }
    }
}
