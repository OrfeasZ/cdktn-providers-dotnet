using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciSchServiceConnectors
{
    [JsiiClass(nativeType: typeof(oci.DataOciSchServiceConnectors.DataOciSchServiceConnectorsServiceConnectorCollectionItemsSourceOutputReference), fullyQualifiedName: "oci.dataOciSchServiceConnectors.DataOciSchServiceConnectorsServiceConnectorCollectionItemsSourceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciSchServiceConnectorsServiceConnectorCollectionItemsSourceOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciSchServiceConnectorsServiceConnectorCollectionItemsSourceOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciSchServiceConnectorsServiceConnectorCollectionItemsSourceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciSchServiceConnectorsServiceConnectorCollectionItemsSourceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "configMap", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfigMap
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cursor", typeJson: "{\"fqn\":\"oci.dataOciSchServiceConnectors.DataOciSchServiceConnectorsServiceConnectorCollectionItemsSourceCursorList\"}")]
        public virtual oci.DataOciSchServiceConnectors.DataOciSchServiceConnectorsServiceConnectorCollectionItemsSourceCursorList Cursor
        {
            get => GetInstanceProperty<oci.DataOciSchServiceConnectors.DataOciSchServiceConnectorsServiceConnectorCollectionItemsSourceCursorList>()!;
        }

        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Kind
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "logSources", typeJson: "{\"fqn\":\"oci.dataOciSchServiceConnectors.DataOciSchServiceConnectorsServiceConnectorCollectionItemsSourceLogSourcesList\"}")]
        public virtual oci.DataOciSchServiceConnectors.DataOciSchServiceConnectorsServiceConnectorCollectionItemsSourceLogSourcesList LogSources
        {
            get => GetInstanceProperty<oci.DataOciSchServiceConnectors.DataOciSchServiceConnectorsServiceConnectorCollectionItemsSourceLogSourcesList>()!;
        }

        [JsiiProperty(name: "monitoringSources", typeJson: "{\"fqn\":\"oci.dataOciSchServiceConnectors.DataOciSchServiceConnectorsServiceConnectorCollectionItemsSourceMonitoringSourcesList\"}")]
        public virtual oci.DataOciSchServiceConnectors.DataOciSchServiceConnectorsServiceConnectorCollectionItemsSourceMonitoringSourcesList MonitoringSources
        {
            get => GetInstanceProperty<oci.DataOciSchServiceConnectors.DataOciSchServiceConnectorsServiceConnectorCollectionItemsSourceMonitoringSourcesList>()!;
        }

        [JsiiProperty(name: "pluginName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PluginName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "privateEndpointMetadata", typeJson: "{\"fqn\":\"oci.dataOciSchServiceConnectors.DataOciSchServiceConnectorsServiceConnectorCollectionItemsSourcePrivateEndpointMetadataList\"}")]
        public virtual oci.DataOciSchServiceConnectors.DataOciSchServiceConnectorsServiceConnectorCollectionItemsSourcePrivateEndpointMetadataList PrivateEndpointMetadata
        {
            get => GetInstanceProperty<oci.DataOciSchServiceConnectors.DataOciSchServiceConnectorsServiceConnectorCollectionItemsSourcePrivateEndpointMetadataList>()!;
        }

        [JsiiProperty(name: "streamId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StreamId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciSchServiceConnectors.DataOciSchServiceConnectorsServiceConnectorCollectionItemsSource\"}", isOptional: true)]
        public virtual oci.DataOciSchServiceConnectors.IDataOciSchServiceConnectorsServiceConnectorCollectionItemsSource? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciSchServiceConnectors.IDataOciSchServiceConnectorsServiceConnectorCollectionItemsSource?>();
            set => SetInstanceProperty(value);
        }
    }
}
