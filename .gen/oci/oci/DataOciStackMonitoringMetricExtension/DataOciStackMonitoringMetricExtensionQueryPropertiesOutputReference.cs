using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciStackMonitoringMetricExtension
{
    [JsiiClass(nativeType: typeof(oci.DataOciStackMonitoringMetricExtension.DataOciStackMonitoringMetricExtensionQueryPropertiesOutputReference), fullyQualifiedName: "oci.dataOciStackMonitoringMetricExtension.DataOciStackMonitoringMetricExtensionQueryPropertiesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciStackMonitoringMetricExtensionQueryPropertiesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciStackMonitoringMetricExtensionQueryPropertiesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciStackMonitoringMetricExtensionQueryPropertiesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciStackMonitoringMetricExtensionQueryPropertiesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "arguments", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arguments
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "autoRowPrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutoRowPrefix
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "collectionMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CollectionMethod
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "command", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Command
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "delimiter", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Delimiter
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "identityMetric", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdentityMetric
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "inParamDetails", typeJson: "{\"fqn\":\"oci.dataOciStackMonitoringMetricExtension.DataOciStackMonitoringMetricExtensionQueryPropertiesInParamDetailsList\"}")]
        public virtual oci.DataOciStackMonitoringMetricExtension.DataOciStackMonitoringMetricExtensionQueryPropertiesInParamDetailsList InParamDetails
        {
            get => GetInstanceProperty<oci.DataOciStackMonitoringMetricExtension.DataOciStackMonitoringMetricExtensionQueryPropertiesInParamDetailsList>()!;
        }

        [JsiiProperty(name: "isMetricServiceEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsMetricServiceEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "jmxAttributes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JmxAttributes
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "managedBeanQuery", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagedBeanQuery
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "outParamDetails", typeJson: "{\"fqn\":\"oci.dataOciStackMonitoringMetricExtension.DataOciStackMonitoringMetricExtensionQueryPropertiesOutParamDetailsList\"}")]
        public virtual oci.DataOciStackMonitoringMetricExtension.DataOciStackMonitoringMetricExtensionQueryPropertiesOutParamDetailsList OutParamDetails
        {
            get => GetInstanceProperty<oci.DataOciStackMonitoringMetricExtension.DataOciStackMonitoringMetricExtensionQueryPropertiesOutParamDetailsList>()!;
        }

        [JsiiProperty(name: "protocolType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProtocolType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "responseContentType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResponseContentType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scriptDetails", typeJson: "{\"fqn\":\"oci.dataOciStackMonitoringMetricExtension.DataOciStackMonitoringMetricExtensionQueryPropertiesScriptDetailsList\"}")]
        public virtual oci.DataOciStackMonitoringMetricExtension.DataOciStackMonitoringMetricExtensionQueryPropertiesScriptDetailsList ScriptDetails
        {
            get => GetInstanceProperty<oci.DataOciStackMonitoringMetricExtension.DataOciStackMonitoringMetricExtensionQueryPropertiesScriptDetailsList>()!;
        }

        [JsiiProperty(name: "sqlDetails", typeJson: "{\"fqn\":\"oci.dataOciStackMonitoringMetricExtension.DataOciStackMonitoringMetricExtensionQueryPropertiesSqlDetailsList\"}")]
        public virtual oci.DataOciStackMonitoringMetricExtension.DataOciStackMonitoringMetricExtensionQueryPropertiesSqlDetailsList SqlDetails
        {
            get => GetInstanceProperty<oci.DataOciStackMonitoringMetricExtension.DataOciStackMonitoringMetricExtensionQueryPropertiesSqlDetailsList>()!;
        }

        [JsiiProperty(name: "sqlType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SqlType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "startsWith", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StartsWith
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Url
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciStackMonitoringMetricExtension.DataOciStackMonitoringMetricExtensionQueryProperties\"}", isOptional: true)]
        public virtual oci.DataOciStackMonitoringMetricExtension.IDataOciStackMonitoringMetricExtensionQueryProperties? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciStackMonitoringMetricExtension.IDataOciStackMonitoringMetricExtensionQueryProperties?>();
            set => SetInstanceProperty(value);
        }
    }
}
