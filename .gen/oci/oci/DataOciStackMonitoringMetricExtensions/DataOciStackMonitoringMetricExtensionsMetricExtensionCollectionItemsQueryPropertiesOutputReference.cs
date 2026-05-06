using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciStackMonitoringMetricExtensions
{
    [JsiiClass(nativeType: typeof(oci.DataOciStackMonitoringMetricExtensions.DataOciStackMonitoringMetricExtensionsMetricExtensionCollectionItemsQueryPropertiesOutputReference), fullyQualifiedName: "oci.dataOciStackMonitoringMetricExtensions.DataOciStackMonitoringMetricExtensionsMetricExtensionCollectionItemsQueryPropertiesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciStackMonitoringMetricExtensionsMetricExtensionCollectionItemsQueryPropertiesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciStackMonitoringMetricExtensionsMetricExtensionCollectionItemsQueryPropertiesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciStackMonitoringMetricExtensionsMetricExtensionCollectionItemsQueryPropertiesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciStackMonitoringMetricExtensionsMetricExtensionCollectionItemsQueryPropertiesOutputReference(DeputyProps props): base(props)
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

        [JsiiProperty(name: "inParamDetails", typeJson: "{\"fqn\":\"oci.dataOciStackMonitoringMetricExtensions.DataOciStackMonitoringMetricExtensionsMetricExtensionCollectionItemsQueryPropertiesInParamDetailsList\"}")]
        public virtual oci.DataOciStackMonitoringMetricExtensions.DataOciStackMonitoringMetricExtensionsMetricExtensionCollectionItemsQueryPropertiesInParamDetailsList InParamDetails
        {
            get => GetInstanceProperty<oci.DataOciStackMonitoringMetricExtensions.DataOciStackMonitoringMetricExtensionsMetricExtensionCollectionItemsQueryPropertiesInParamDetailsList>()!;
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

        [JsiiProperty(name: "outParamDetails", typeJson: "{\"fqn\":\"oci.dataOciStackMonitoringMetricExtensions.DataOciStackMonitoringMetricExtensionsMetricExtensionCollectionItemsQueryPropertiesOutParamDetailsList\"}")]
        public virtual oci.DataOciStackMonitoringMetricExtensions.DataOciStackMonitoringMetricExtensionsMetricExtensionCollectionItemsQueryPropertiesOutParamDetailsList OutParamDetails
        {
            get => GetInstanceProperty<oci.DataOciStackMonitoringMetricExtensions.DataOciStackMonitoringMetricExtensionsMetricExtensionCollectionItemsQueryPropertiesOutParamDetailsList>()!;
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

        [JsiiProperty(name: "scriptDetails", typeJson: "{\"fqn\":\"oci.dataOciStackMonitoringMetricExtensions.DataOciStackMonitoringMetricExtensionsMetricExtensionCollectionItemsQueryPropertiesScriptDetailsList\"}")]
        public virtual oci.DataOciStackMonitoringMetricExtensions.DataOciStackMonitoringMetricExtensionsMetricExtensionCollectionItemsQueryPropertiesScriptDetailsList ScriptDetails
        {
            get => GetInstanceProperty<oci.DataOciStackMonitoringMetricExtensions.DataOciStackMonitoringMetricExtensionsMetricExtensionCollectionItemsQueryPropertiesScriptDetailsList>()!;
        }

        [JsiiProperty(name: "sqlDetails", typeJson: "{\"fqn\":\"oci.dataOciStackMonitoringMetricExtensions.DataOciStackMonitoringMetricExtensionsMetricExtensionCollectionItemsQueryPropertiesSqlDetailsList\"}")]
        public virtual oci.DataOciStackMonitoringMetricExtensions.DataOciStackMonitoringMetricExtensionsMetricExtensionCollectionItemsQueryPropertiesSqlDetailsList SqlDetails
        {
            get => GetInstanceProperty<oci.DataOciStackMonitoringMetricExtensions.DataOciStackMonitoringMetricExtensionsMetricExtensionCollectionItemsQueryPropertiesSqlDetailsList>()!;
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciStackMonitoringMetricExtensions.DataOciStackMonitoringMetricExtensionsMetricExtensionCollectionItemsQueryProperties\"}", isOptional: true)]
        public virtual oci.DataOciStackMonitoringMetricExtensions.IDataOciStackMonitoringMetricExtensionsMetricExtensionCollectionItemsQueryProperties? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciStackMonitoringMetricExtensions.IDataOciStackMonitoringMetricExtensionsMetricExtensionCollectionItemsQueryProperties?>();
            set => SetInstanceProperty(value);
        }
    }
}
