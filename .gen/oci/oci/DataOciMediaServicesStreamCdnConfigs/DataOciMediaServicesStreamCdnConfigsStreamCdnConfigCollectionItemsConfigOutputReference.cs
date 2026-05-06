using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciMediaServicesStreamCdnConfigs
{
    [JsiiClass(nativeType: typeof(oci.DataOciMediaServicesStreamCdnConfigs.DataOciMediaServicesStreamCdnConfigsStreamCdnConfigCollectionItemsConfigOutputReference), fullyQualifiedName: "oci.dataOciMediaServicesStreamCdnConfigs.DataOciMediaServicesStreamCdnConfigsStreamCdnConfigCollectionItemsConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciMediaServicesStreamCdnConfigsStreamCdnConfigCollectionItemsConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciMediaServicesStreamCdnConfigsStreamCdnConfigCollectionItemsConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciMediaServicesStreamCdnConfigsStreamCdnConfigCollectionItemsConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciMediaServicesStreamCdnConfigsStreamCdnConfigCollectionItemsConfigOutputReference(DeputyProps props): base(props)
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciMediaServicesStreamCdnConfigs.DataOciMediaServicesStreamCdnConfigsStreamCdnConfigCollectionItemsConfig\"}", isOptional: true)]
        public virtual oci.DataOciMediaServicesStreamCdnConfigs.IDataOciMediaServicesStreamCdnConfigsStreamCdnConfigCollectionItemsConfig? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciMediaServicesStreamCdnConfigs.IDataOciMediaServicesStreamCdnConfigsStreamCdnConfigCollectionItemsConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
