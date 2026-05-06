using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciLoggingUnifiedAgentConfiguration
{
    [JsiiClass(nativeType: typeof(oci.DataOciLoggingUnifiedAgentConfiguration.DataOciLoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilterParserOutputReference), fullyQualifiedName: "oci.dataOciLoggingUnifiedAgentConfiguration.DataOciLoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilterParserOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciLoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilterParserOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciLoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilterParserOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciLoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilterParserOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciLoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilterParserOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "delimiter", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Delimiter
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "expression", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Expression
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "fieldTimeKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FieldTimeKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "format", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Format
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "formatFirstline", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FormatFirstline
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "grokFailureKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GrokFailureKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "grokNameKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GrokNameKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isEstimateCurrentEvent", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsEstimateCurrentEvent
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isKeepTimeKey", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsKeepTimeKey
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isMergeCriFields", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsMergeCriFields
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isNullEmptyString", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsNullEmptyString
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isSupportColonlessIdent", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsSupportColonlessIdent
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isWithPriority", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsWithPriority
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "keys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Keys
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "messageFormat", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MessageFormat
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "messageKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MessageKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "multiLineStartRegexp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MultiLineStartRegexp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nestedParser", typeJson: "{\"fqn\":\"oci.dataOciLoggingUnifiedAgentConfiguration.DataOciLoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilterParserNestedParserList\"}")]
        public virtual oci.DataOciLoggingUnifiedAgentConfiguration.DataOciLoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilterParserNestedParserList NestedParser
        {
            get => GetInstanceProperty<oci.DataOciLoggingUnifiedAgentConfiguration.DataOciLoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilterParserNestedParserList>()!;
        }

        [JsiiProperty(name: "nullValuePattern", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NullValuePattern
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "parseNested", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ParseNested
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "parserType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParserType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "patterns", typeJson: "{\"fqn\":\"oci.dataOciLoggingUnifiedAgentConfiguration.DataOciLoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilterParserPatternsList\"}")]
        public virtual oci.DataOciLoggingUnifiedAgentConfiguration.DataOciLoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilterParserPatternsList Patterns
        {
            get => GetInstanceProperty<oci.DataOciLoggingUnifiedAgentConfiguration.DataOciLoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilterParserPatternsList>()!;
        }

        [JsiiProperty(name: "recordInput", typeJson: "{\"fqn\":\"oci.dataOciLoggingUnifiedAgentConfiguration.DataOciLoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilterParserRecordInputList\"}")]
        public virtual oci.DataOciLoggingUnifiedAgentConfiguration.DataOciLoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilterParserRecordInputList RecordInput
        {
            get => GetInstanceProperty<oci.DataOciLoggingUnifiedAgentConfiguration.DataOciLoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilterParserRecordInputList>()!;
        }

        [JsiiProperty(name: "rfc5424TimeFormat", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Rfc5424TimeFormat
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "separator", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Separator
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "syslogParserType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SyslogParserType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeFormat", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeFormat
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeoutInMilliseconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TimeoutInMilliseconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "timeType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "types", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap Types
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciLoggingUnifiedAgentConfiguration.DataOciLoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilterParser\"}", isOptional: true)]
        public virtual oci.DataOciLoggingUnifiedAgentConfiguration.IDataOciLoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilterParser? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciLoggingUnifiedAgentConfiguration.IDataOciLoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilterParser?>();
            set => SetInstanceProperty(value);
        }
    }
}
