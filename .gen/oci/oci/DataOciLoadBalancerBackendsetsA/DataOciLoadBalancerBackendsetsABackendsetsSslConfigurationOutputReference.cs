using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciLoadBalancerBackendsetsA
{
    [JsiiClass(nativeType: typeof(oci.DataOciLoadBalancerBackendsetsA.DataOciLoadBalancerBackendsetsABackendsetsSslConfigurationOutputReference), fullyQualifiedName: "oci.dataOciLoadBalancerBackendsetsA.DataOciLoadBalancerBackendsetsABackendsetsSslConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciLoadBalancerBackendsetsABackendsetsSslConfigurationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciLoadBalancerBackendsetsABackendsetsSslConfigurationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciLoadBalancerBackendsetsABackendsetsSslConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciLoadBalancerBackendsetsABackendsetsSslConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "certificateIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] CertificateIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "certificateName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cipherSuiteName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CipherSuiteName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "protocols", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Protocols
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "serverOrderPreference", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServerOrderPreference
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "trustedCertificateAuthorityIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] TrustedCertificateAuthorityIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "verifyDepth", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double VerifyDepth
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "verifyPeerCertificate", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable VerifyPeerCertificate
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciLoadBalancerBackendsetsA.DataOciLoadBalancerBackendsetsABackendsetsSslConfiguration\"}", isOptional: true)]
        public virtual oci.DataOciLoadBalancerBackendsetsA.IDataOciLoadBalancerBackendsetsABackendsetsSslConfiguration? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciLoadBalancerBackendsetsA.IDataOciLoadBalancerBackendsetsABackendsetsSslConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
