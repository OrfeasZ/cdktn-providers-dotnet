using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.MongodbInstance
{
    [JsiiClass(nativeType: typeof(scaleway.MongodbInstance.MongodbInstancePrivateNetworkOutputReference), fullyQualifiedName: "scaleway.mongodbInstance.MongodbInstancePrivateNetworkOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MongodbInstancePrivateNetworkOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MongodbInstancePrivateNetworkOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MongodbInstancePrivateNetworkOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MongodbInstancePrivateNetworkOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "dnsRecords", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DnsRecords
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ips", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Ips
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Port
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "pnIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PnIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "pnId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PnId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"scaleway.mongodbInstance.MongodbInstancePrivateNetwork\"}", isOptional: true)]
        public virtual scaleway.MongodbInstance.IMongodbInstancePrivateNetwork? InternalValue
        {
            get => GetInstanceProperty<scaleway.MongodbInstance.IMongodbInstancePrivateNetwork?>();
            set => SetInstanceProperty(value);
        }
    }
}
