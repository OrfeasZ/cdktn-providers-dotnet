using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciMarketplaceMarketplaceMetadataPublicKeys
{
    [JsiiClass(nativeType: typeof(oci.DataOciMarketplaceMarketplaceMetadataPublicKeys.DataOciMarketplaceMarketplaceMetadataPublicKeysMarketplaceMetadataPublicKeysOutputReference), fullyQualifiedName: "oci.dataOciMarketplaceMarketplaceMetadataPublicKeys.DataOciMarketplaceMarketplaceMetadataPublicKeysMarketplaceMetadataPublicKeysOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciMarketplaceMarketplaceMetadataPublicKeysMarketplaceMetadataPublicKeysOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciMarketplaceMarketplaceMetadataPublicKeysMarketplaceMetadataPublicKeysOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciMarketplaceMarketplaceMetadataPublicKeysMarketplaceMetadataPublicKeysOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciMarketplaceMarketplaceMetadataPublicKeysMarketplaceMetadataPublicKeysOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "certificateChain", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] CertificateChain
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "certificateThumbprint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateThumbprint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "exponent", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Exponent
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "keyAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyAlgorithm
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "keyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "keyType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "keyUse", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyUse
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "modulus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Modulus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciMarketplaceMarketplaceMetadataPublicKeys.DataOciMarketplaceMarketplaceMetadataPublicKeysMarketplaceMetadataPublicKeys\"}", isOptional: true)]
        public virtual oci.DataOciMarketplaceMarketplaceMetadataPublicKeys.IDataOciMarketplaceMarketplaceMetadataPublicKeysMarketplaceMetadataPublicKeys? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciMarketplaceMarketplaceMetadataPublicKeys.IDataOciMarketplaceMarketplaceMetadataPublicKeysMarketplaceMetadataPublicKeys?>();
            set => SetInstanceProperty(value);
        }
    }
}
