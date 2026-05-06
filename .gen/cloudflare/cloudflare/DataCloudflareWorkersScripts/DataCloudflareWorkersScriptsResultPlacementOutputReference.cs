using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareWorkersScripts
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareWorkersScripts.DataCloudflareWorkersScriptsResultPlacementOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareWorkersScripts.DataCloudflareWorkersScriptsResultPlacementOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareWorkersScriptsResultPlacementOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareWorkersScriptsResultPlacementOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareWorkersScriptsResultPlacementOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareWorkersScriptsResultPlacementOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "host", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Host
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Hostname
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lastAnalyzedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastAnalyzedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Mode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkersScripts.DataCloudflareWorkersScriptsResultPlacementTargetList\"}")]
        public virtual cloudflare.DataCloudflareWorkersScripts.DataCloudflareWorkersScriptsResultPlacementTargetList Target
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkersScripts.DataCloudflareWorkersScriptsResultPlacementTargetList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkersScripts.DataCloudflareWorkersScriptsResultPlacement\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareWorkersScripts.IDataCloudflareWorkersScriptsResultPlacement? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkersScripts.IDataCloudflareWorkersScriptsResultPlacement?>();
            set => SetInstanceProperty(value);
        }
    }
}
