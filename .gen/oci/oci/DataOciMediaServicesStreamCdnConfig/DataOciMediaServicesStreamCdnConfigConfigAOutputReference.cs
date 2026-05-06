using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciMediaServicesStreamCdnConfig
{
    [JsiiClass(nativeType: typeof(oci.DataOciMediaServicesStreamCdnConfig.DataOciMediaServicesStreamCdnConfigConfigAOutputReference), fullyQualifiedName: "oci.dataOciMediaServicesStreamCdnConfig.DataOciMediaServicesStreamCdnConfigConfigAOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciMediaServicesStreamCdnConfigConfigAOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciMediaServicesStreamCdnConfigConfigAOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciMediaServicesStreamCdnConfigConfigAOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciMediaServicesStreamCdnConfigConfigAOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "edgeHostname", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EdgeHostname
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "edgePathPrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EdgePathPrefix
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "edgeTokenKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EdgeTokenKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "edgeTokenSalt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EdgeTokenSalt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isEdgeTokenAuth", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsEdgeTokenAuth
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "originAuthSecretKeyA", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OriginAuthSecretKeyA
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "originAuthSecretKeyB", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OriginAuthSecretKeyB
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "originAuthSecretKeyNonceA", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OriginAuthSecretKeyNonceA
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "originAuthSecretKeyNonceB", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OriginAuthSecretKeyNonceB
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "originAuthSignEncryption", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OriginAuthSignEncryption
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "originAuthSignType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OriginAuthSignType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciMediaServicesStreamCdnConfig.DataOciMediaServicesStreamCdnConfigConfigA\"}", isOptional: true)]
        public virtual oci.DataOciMediaServicesStreamCdnConfig.IDataOciMediaServicesStreamCdnConfigConfigA? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciMediaServicesStreamCdnConfig.IDataOciMediaServicesStreamCdnConfigConfigA?>();
            set => SetInstanceProperty(value);
        }
    }
}
