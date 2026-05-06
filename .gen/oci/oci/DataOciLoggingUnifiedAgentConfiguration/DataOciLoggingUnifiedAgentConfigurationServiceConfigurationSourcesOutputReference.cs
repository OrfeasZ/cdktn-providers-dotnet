using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciLoggingUnifiedAgentConfiguration
{
    [JsiiClass(nativeType: typeof(oci.DataOciLoggingUnifiedAgentConfiguration.DataOciLoggingUnifiedAgentConfigurationServiceConfigurationSourcesOutputReference), fullyQualifiedName: "oci.dataOciLoggingUnifiedAgentConfiguration.DataOciLoggingUnifiedAgentConfigurationServiceConfigurationSourcesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciLoggingUnifiedAgentConfigurationServiceConfigurationSourcesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciLoggingUnifiedAgentConfigurationServiceConfigurationSourcesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciLoggingUnifiedAgentConfigurationServiceConfigurationSourcesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciLoggingUnifiedAgentConfigurationServiceConfigurationSourcesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "advancedOptions", typeJson: "{\"fqn\":\"oci.dataOciLoggingUnifiedAgentConfiguration.DataOciLoggingUnifiedAgentConfigurationServiceConfigurationSourcesAdvancedOptionsList\"}")]
        public virtual oci.DataOciLoggingUnifiedAgentConfiguration.DataOciLoggingUnifiedAgentConfigurationServiceConfigurationSourcesAdvancedOptionsList AdvancedOptions
        {
            get => GetInstanceProperty<oci.DataOciLoggingUnifiedAgentConfiguration.DataOciLoggingUnifiedAgentConfigurationServiceConfigurationSourcesAdvancedOptionsList>()!;
        }

        [JsiiProperty(name: "channels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Channels
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "customPlugin", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomPlugin
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "parser", typeJson: "{\"fqn\":\"oci.dataOciLoggingUnifiedAgentConfiguration.DataOciLoggingUnifiedAgentConfigurationServiceConfigurationSourcesParserList\"}")]
        public virtual oci.DataOciLoggingUnifiedAgentConfiguration.DataOciLoggingUnifiedAgentConfigurationServiceConfigurationSourcesParserList Parser
        {
            get => GetInstanceProperty<oci.DataOciLoggingUnifiedAgentConfiguration.DataOciLoggingUnifiedAgentConfigurationServiceConfigurationSourcesParserList>()!;
        }

        [JsiiProperty(name: "paths", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Paths
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "sourceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciLoggingUnifiedAgentConfiguration.DataOciLoggingUnifiedAgentConfigurationServiceConfigurationSources\"}", isOptional: true)]
        public virtual oci.DataOciLoggingUnifiedAgentConfiguration.IDataOciLoggingUnifiedAgentConfigurationServiceConfigurationSources? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciLoggingUnifiedAgentConfiguration.IDataOciLoggingUnifiedAgentConfigurationServiceConfigurationSources?>();
            set => SetInstanceProperty(value);
        }
    }
}
