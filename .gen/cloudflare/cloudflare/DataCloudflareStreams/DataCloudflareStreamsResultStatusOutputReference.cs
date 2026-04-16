using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareStreams
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareStreams.DataCloudflareStreamsResultStatusOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareStreams.DataCloudflareStreamsResultStatusOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareStreamsResultStatusOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareStreamsResultStatusOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareStreamsResultStatusOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareStreamsResultStatusOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "errorReasonCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ErrorReasonCode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "errorReasonText", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ErrorReasonText
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "pctComplete", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PctComplete
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareStreams.DataCloudflareStreamsResultStatus\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareStreams.IDataCloudflareStreamsResultStatus? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareStreams.IDataCloudflareStreamsResultStatus?>();
            set => SetInstanceProperty(value);
        }
    }
}
