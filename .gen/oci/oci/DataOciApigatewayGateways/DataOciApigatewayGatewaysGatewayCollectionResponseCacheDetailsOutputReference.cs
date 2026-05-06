using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciApigatewayGateways
{
    [JsiiClass(nativeType: typeof(oci.DataOciApigatewayGateways.DataOciApigatewayGatewaysGatewayCollectionResponseCacheDetailsOutputReference), fullyQualifiedName: "oci.dataOciApigatewayGateways.DataOciApigatewayGatewaysGatewayCollectionResponseCacheDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciApigatewayGatewaysGatewayCollectionResponseCacheDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciApigatewayGatewaysGatewayCollectionResponseCacheDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciApigatewayGatewaysGatewayCollectionResponseCacheDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciApigatewayGatewaysGatewayCollectionResponseCacheDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "authenticationSecretId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthenticationSecretId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "authenticationSecretVersionNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthenticationSecretVersionNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "connectTimeoutInMs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ConnectTimeoutInMs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "isSslEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsSslEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isSslVerifyDisabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsSslVerifyDisabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "readTimeoutInMs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ReadTimeoutInMs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "sendTimeoutInMs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SendTimeoutInMs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "servers", typeJson: "{\"fqn\":\"oci.dataOciApigatewayGateways.DataOciApigatewayGatewaysGatewayCollectionResponseCacheDetailsServersList\"}")]
        public virtual oci.DataOciApigatewayGateways.DataOciApigatewayGatewaysGatewayCollectionResponseCacheDetailsServersList Servers
        {
            get => GetInstanceProperty<oci.DataOciApigatewayGateways.DataOciApigatewayGatewaysGatewayCollectionResponseCacheDetailsServersList>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciApigatewayGateways.DataOciApigatewayGatewaysGatewayCollectionResponseCacheDetails\"}", isOptional: true)]
        public virtual oci.DataOciApigatewayGateways.IDataOciApigatewayGatewaysGatewayCollectionResponseCacheDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciApigatewayGateways.IDataOciApigatewayGatewaysGatewayCollectionResponseCacheDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
