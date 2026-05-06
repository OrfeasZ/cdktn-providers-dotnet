using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflarePipelineSink
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflarePipelineSink.DataCloudflarePipelineSinkSchemaFormatOutputReference), fullyQualifiedName: "cloudflare.dataCloudflarePipelineSink.DataCloudflarePipelineSinkSchemaFormatOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflarePipelineSinkSchemaFormatOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflarePipelineSinkSchemaFormatOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflarePipelineSinkSchemaFormatOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflarePipelineSinkSchemaFormatOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "compression", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Compression
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "decimalEncoding", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DecimalEncoding
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rowGroupBytes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RowGroupBytes
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "timestampFormat", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimestampFormat
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "unstructured", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Unstructured
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePipelineSink.DataCloudflarePipelineSinkSchemaFormat\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflarePipelineSink.IDataCloudflarePipelineSinkSchemaFormat? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePipelineSink.IDataCloudflarePipelineSinkSchemaFormat?>();
            set => SetInstanceProperty(value);
        }
    }
}
