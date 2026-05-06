using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciLoggingUnifiedAgentConfiguration
{
    [JsiiClass(nativeType: typeof(oci.DataOciLoggingUnifiedAgentConfiguration.DataOciLoggingUnifiedAgentConfigurationServiceConfigurationOutputReference), fullyQualifiedName: "oci.dataOciLoggingUnifiedAgentConfiguration.DataOciLoggingUnifiedAgentConfigurationServiceConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciLoggingUnifiedAgentConfigurationServiceConfigurationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciLoggingUnifiedAgentConfigurationServiceConfigurationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciLoggingUnifiedAgentConfigurationServiceConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciLoggingUnifiedAgentConfigurationServiceConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "applicationConfigurations", typeJson: "{\"fqn\":\"oci.dataOciLoggingUnifiedAgentConfiguration.DataOciLoggingUnifiedAgentConfigurationServiceConfigurationApplicationConfigurationsList\"}")]
        public virtual oci.DataOciLoggingUnifiedAgentConfiguration.DataOciLoggingUnifiedAgentConfigurationServiceConfigurationApplicationConfigurationsList ApplicationConfigurations
        {
            get => GetInstanceProperty<oci.DataOciLoggingUnifiedAgentConfiguration.DataOciLoggingUnifiedAgentConfigurationServiceConfigurationApplicationConfigurationsList>()!;
        }

        [JsiiProperty(name: "configurationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfigurationType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "destination", typeJson: "{\"fqn\":\"oci.dataOciLoggingUnifiedAgentConfiguration.DataOciLoggingUnifiedAgentConfigurationServiceConfigurationDestinationList\"}")]
        public virtual oci.DataOciLoggingUnifiedAgentConfiguration.DataOciLoggingUnifiedAgentConfigurationServiceConfigurationDestinationList Destination
        {
            get => GetInstanceProperty<oci.DataOciLoggingUnifiedAgentConfiguration.DataOciLoggingUnifiedAgentConfigurationServiceConfigurationDestinationList>()!;
        }

        [JsiiProperty(name: "sources", typeJson: "{\"fqn\":\"oci.dataOciLoggingUnifiedAgentConfiguration.DataOciLoggingUnifiedAgentConfigurationServiceConfigurationSourcesList\"}")]
        public virtual oci.DataOciLoggingUnifiedAgentConfiguration.DataOciLoggingUnifiedAgentConfigurationServiceConfigurationSourcesList Sources
        {
            get => GetInstanceProperty<oci.DataOciLoggingUnifiedAgentConfiguration.DataOciLoggingUnifiedAgentConfigurationServiceConfigurationSourcesList>()!;
        }

        [JsiiProperty(name: "unifiedAgentConfigurationFilter", typeJson: "{\"fqn\":\"oci.dataOciLoggingUnifiedAgentConfiguration.DataOciLoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilterList\"}")]
        public virtual oci.DataOciLoggingUnifiedAgentConfiguration.DataOciLoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilterList UnifiedAgentConfigurationFilter
        {
            get => GetInstanceProperty<oci.DataOciLoggingUnifiedAgentConfiguration.DataOciLoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilterList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciLoggingUnifiedAgentConfiguration.DataOciLoggingUnifiedAgentConfigurationServiceConfiguration\"}", isOptional: true)]
        public virtual oci.DataOciLoggingUnifiedAgentConfiguration.IDataOciLoggingUnifiedAgentConfigurationServiceConfiguration? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciLoggingUnifiedAgentConfiguration.IDataOciLoggingUnifiedAgentConfigurationServiceConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
