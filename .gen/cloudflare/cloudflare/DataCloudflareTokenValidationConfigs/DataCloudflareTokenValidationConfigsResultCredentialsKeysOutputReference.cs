using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareTokenValidationConfigs
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareTokenValidationConfigs.DataCloudflareTokenValidationConfigsResultCredentialsKeysOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareTokenValidationConfigs.DataCloudflareTokenValidationConfigsResultCredentialsKeysOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataCloudflareTokenValidationConfigsResultCredentialsKeysOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataCloudflareTokenValidationConfigsResultCredentialsKeysOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataCloudflareTokenValidationConfigsResultCredentialsKeysOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareTokenValidationConfigsResultCredentialsKeysOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "alg", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Alg
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "crv", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Crv
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "e", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string E
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "kid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Kid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "kty", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Kty
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "n", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string N
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "x", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string X
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "y", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Y
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareTokenValidationConfigs.DataCloudflareTokenValidationConfigsResultCredentialsKeys\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareTokenValidationConfigs.IDataCloudflareTokenValidationConfigsResultCredentialsKeys? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareTokenValidationConfigs.IDataCloudflareTokenValidationConfigsResultCredentialsKeys?>();
            set => SetInstanceProperty(value);
        }
    }
}
