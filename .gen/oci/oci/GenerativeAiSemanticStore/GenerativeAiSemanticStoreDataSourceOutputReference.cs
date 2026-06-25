using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiSemanticStore
{
    [JsiiClass(nativeType: typeof(oci.GenerativeAiSemanticStore.GenerativeAiSemanticStoreDataSourceOutputReference), fullyQualifiedName: "oci.generativeAiSemanticStore.GenerativeAiSemanticStoreDataSourceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class GenerativeAiSemanticStoreDataSourceOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public GenerativeAiSemanticStoreDataSourceOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected GenerativeAiSemanticStoreDataSourceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GenerativeAiSemanticStoreDataSourceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectionTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConnectionTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enrichmentConnectionIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EnrichmentConnectionIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "queryingConnectionIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? QueryingConnectionIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "connectionType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConnectionType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enrichmentConnectionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EnrichmentConnectionId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "queryingConnectionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string QueryingConnectionId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.generativeAiSemanticStore.GenerativeAiSemanticStoreDataSource\"}", isOptional: true)]
        public virtual oci.GenerativeAiSemanticStore.IGenerativeAiSemanticStoreDataSource? InternalValue
        {
            get => GetInstanceProperty<oci.GenerativeAiSemanticStore.IGenerativeAiSemanticStoreDataSource?>();
            set => SetInstanceProperty(value);
        }
    }
}
