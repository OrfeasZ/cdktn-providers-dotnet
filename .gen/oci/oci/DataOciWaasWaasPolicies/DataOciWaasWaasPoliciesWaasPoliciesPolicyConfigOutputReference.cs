using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciWaasWaasPolicies
{
    [JsiiClass(nativeType: typeof(oci.DataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesPolicyConfigOutputReference), fullyQualifiedName: "oci.dataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesPolicyConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciWaasWaasPoliciesWaasPoliciesPolicyConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciWaasWaasPoliciesWaasPoliciesPolicyConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciWaasWaasPoliciesWaasPoliciesPolicyConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciWaasWaasPoliciesWaasPoliciesPolicyConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "certificateId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cipherGroup", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CipherGroup
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clientAddressHeader", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientAddressHeader
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "healthChecks", typeJson: "{\"fqn\":\"oci.dataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesPolicyConfigHealthChecksList\"}")]
        public virtual oci.DataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesPolicyConfigHealthChecksList HealthChecks
        {
            get => GetInstanceProperty<oci.DataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesPolicyConfigHealthChecksList>()!;
        }

        [JsiiProperty(name: "isBehindCdn", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsBehindCdn
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isCacheControlRespected", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsCacheControlRespected
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isHttpsEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsHttpsEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isHttpsForced", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsHttpsForced
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isOriginCompressionEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsOriginCompressionEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isResponseBufferingEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsResponseBufferingEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isSniEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsSniEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "loadBalancingMethod", typeJson: "{\"fqn\":\"oci.dataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesPolicyConfigLoadBalancingMethodList\"}")]
        public virtual oci.DataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesPolicyConfigLoadBalancingMethodList LoadBalancingMethod
        {
            get => GetInstanceProperty<oci.DataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesPolicyConfigLoadBalancingMethodList>()!;
        }

        [JsiiProperty(name: "tlsProtocols", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] TlsProtocols
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "websocketPathPrefixes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] WebsocketPathPrefixes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesPolicyConfig\"}", isOptional: true)]
        public virtual oci.DataOciWaasWaasPolicies.IDataOciWaasWaasPoliciesWaasPoliciesPolicyConfig? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciWaasWaasPolicies.IDataOciWaasWaasPoliciesWaasPoliciesPolicyConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
