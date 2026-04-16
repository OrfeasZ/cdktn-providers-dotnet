using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanApp
{
    [JsiiClass(nativeType: typeof(digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecWorkerLogDestinationOutputReference), fullyQualifiedName: "digitalocean.dataDigitaloceanApp.DataDigitaloceanAppSpecWorkerLogDestinationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataDigitaloceanAppSpecWorkerLogDestinationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataDigitaloceanAppSpecWorkerLogDestinationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataDigitaloceanAppSpecWorkerLogDestinationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataDigitaloceanAppSpecWorkerLogDestinationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "datadog", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanApp.DataDigitaloceanAppSpecWorkerLogDestinationDatadogList\"}")]
        public virtual digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecWorkerLogDestinationDatadogList Datadog
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecWorkerLogDestinationDatadogList>()!;
        }

        [JsiiProperty(name: "logtail", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanApp.DataDigitaloceanAppSpecWorkerLogDestinationLogtailList\"}")]
        public virtual digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecWorkerLogDestinationLogtailList Logtail
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecWorkerLogDestinationLogtailList>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "openSearch", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanApp.DataDigitaloceanAppSpecWorkerLogDestinationOpenSearchList\"}")]
        public virtual digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecWorkerLogDestinationOpenSearchList OpenSearch
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecWorkerLogDestinationOpenSearchList>()!;
        }

        [JsiiProperty(name: "papertrail", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanApp.DataDigitaloceanAppSpecWorkerLogDestinationPapertrailList\"}")]
        public virtual digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecWorkerLogDestinationPapertrailList Papertrail
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecWorkerLogDestinationPapertrailList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanApp.DataDigitaloceanAppSpecWorkerLogDestination\"}", isOptional: true)]
        public virtual digitalocean.DataDigitaloceanApp.IDataDigitaloceanAppSpecWorkerLogDestination? InternalValue
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanApp.IDataDigitaloceanAppSpecWorkerLogDestination?>();
            set => SetInstanceProperty(value);
        }
    }
}
