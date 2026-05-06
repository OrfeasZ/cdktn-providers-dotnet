using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflarePipelineStreams
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflarePipelineStreams.DataCloudflarePipelineStreamsResultOutputReference), fullyQualifiedName: "cloudflare.dataCloudflarePipelineStreams.DataCloudflarePipelineStreamsResultOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataCloudflarePipelineStreamsResultOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataCloudflarePipelineStreamsResultOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataCloudflarePipelineStreamsResultOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflarePipelineStreamsResultOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Endpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "format", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePipelineStreams.DataCloudflarePipelineStreamsResultFormatOutputReference\"}")]
        public virtual cloudflare.DataCloudflarePipelineStreams.DataCloudflarePipelineStreamsResultFormatOutputReference Format
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePipelineStreams.DataCloudflarePipelineStreamsResultFormatOutputReference>()!;
        }

        [JsiiProperty(name: "http", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePipelineStreams.DataCloudflarePipelineStreamsResultHttpOutputReference\"}")]
        public virtual cloudflare.DataCloudflarePipelineStreams.DataCloudflarePipelineStreamsResultHttpOutputReference Http
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePipelineStreams.DataCloudflarePipelineStreamsResultHttpOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "modifiedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModifiedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "schema", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePipelineStreams.DataCloudflarePipelineStreamsResultSchemaOutputReference\"}")]
        public virtual cloudflare.DataCloudflarePipelineStreams.DataCloudflarePipelineStreamsResultSchemaOutputReference Schema
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePipelineStreams.DataCloudflarePipelineStreamsResultSchemaOutputReference>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Version
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "workerBinding", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePipelineStreams.DataCloudflarePipelineStreamsResultWorkerBindingOutputReference\"}")]
        public virtual cloudflare.DataCloudflarePipelineStreams.DataCloudflarePipelineStreamsResultWorkerBindingOutputReference WorkerBinding
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePipelineStreams.DataCloudflarePipelineStreamsResultWorkerBindingOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePipelineStreams.DataCloudflarePipelineStreamsResult\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflarePipelineStreams.IDataCloudflarePipelineStreamsResult? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePipelineStreams.IDataCloudflarePipelineStreamsResult?>();
            set => SetInstanceProperty(value);
        }
    }
}
