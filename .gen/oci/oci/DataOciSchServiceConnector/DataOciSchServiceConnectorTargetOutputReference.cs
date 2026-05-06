using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciSchServiceConnector
{
    [JsiiClass(nativeType: typeof(oci.DataOciSchServiceConnector.DataOciSchServiceConnectorTargetOutputReference), fullyQualifiedName: "oci.dataOciSchServiceConnector.DataOciSchServiceConnectorTargetOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciSchServiceConnectorTargetOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciSchServiceConnectorTargetOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciSchServiceConnectorTargetOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciSchServiceConnectorTargetOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "batchRolloverSizeInMbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BatchRolloverSizeInMbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "batchRolloverTimeInMs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BatchRolloverTimeInMs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "batchSizeInKbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BatchSizeInKbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "batchSizeInNum", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BatchSizeInNum
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "batchTimeInSec", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BatchTimeInSec
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Bucket
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dimensions", typeJson: "{\"fqn\":\"oci.dataOciSchServiceConnector.DataOciSchServiceConnectorTargetDimensionsList\"}")]
        public virtual oci.DataOciSchServiceConnector.DataOciSchServiceConnectorTargetDimensionsList Dimensions
        {
            get => GetInstanceProperty<oci.DataOciSchServiceConnector.DataOciSchServiceConnectorTargetDimensionsList>()!;
        }

        [JsiiProperty(name: "enableFormattedMessaging", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable EnableFormattedMessaging
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "functionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FunctionId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Kind
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "logGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogGroupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "logSourceIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogSourceIdentifier
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "metric", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Metric
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "metricNamespace", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MetricNamespace
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Namespace
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "objectNamePrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ObjectNamePrefix
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "privateEndpointMetadata", typeJson: "{\"fqn\":\"oci.dataOciSchServiceConnector.DataOciSchServiceConnectorTargetPrivateEndpointMetadataList\"}")]
        public virtual oci.DataOciSchServiceConnector.DataOciSchServiceConnectorTargetPrivateEndpointMetadataList PrivateEndpointMetadata
        {
            get => GetInstanceProperty<oci.DataOciSchServiceConnector.DataOciSchServiceConnectorTargetPrivateEndpointMetadataList>()!;
        }

        [JsiiProperty(name: "streamId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StreamId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "topicId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TopicId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciSchServiceConnector.DataOciSchServiceConnectorTarget\"}", isOptional: true)]
        public virtual oci.DataOciSchServiceConnector.IDataOciSchServiceConnectorTarget? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciSchServiceConnector.IDataOciSchServiceConnectorTarget?>();
            set => SetInstanceProperty(value);
        }
    }
}
