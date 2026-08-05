using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareWorkersScripts
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareWorkersScripts.DataCloudflareWorkersScriptsResultExportsOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareWorkersScripts.DataCloudflareWorkersScriptsResultExportsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the key of this item in the map.\"},\"name\":\"complexObjectKey\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareWorkersScriptsResultExportsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectKey">the key of this item in the map.</param>
        public DataCloudflareWorkersScriptsResultExportsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, string complexObjectKey): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectKey))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, string complexObjectKey)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectKey});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareWorkersScriptsResultExportsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareWorkersScriptsResultExportsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "cache", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkersScripts.DataCloudflareWorkersScriptsResultExportsCacheOutputReference\"}")]
        public virtual cloudflare.DataCloudflareWorkersScripts.DataCloudflareWorkersScriptsResultExportsCacheOutputReference Cache
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkersScripts.DataCloudflareWorkersScriptsResultExportsCacheOutputReference>()!;
        }

        [JsiiProperty(name: "renamedTo", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RenamedTo
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "storage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Storage
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "transferFrom", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TransferFrom
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "transferredTo", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TransferredTo
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkersScripts.DataCloudflareWorkersScriptsResultExports\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareWorkersScripts.IDataCloudflareWorkersScriptsResultExports? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkersScripts.IDataCloudflareWorkersScriptsResultExports?>();
            set => SetInstanceProperty(value);
        }
    }
}
