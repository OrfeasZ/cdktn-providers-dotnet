using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.ThreeDSecureAuthentication
{
    [JsiiClass(nativeType: typeof(stripe.ThreeDSecureAuthentication.ThreeDSecureAuthenticationOutcomeDetailsOutputReference), fullyQualifiedName: "stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationOutcomeDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ThreeDSecureAuthenticationOutcomeDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ThreeDSecureAuthenticationOutcomeDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ThreeDSecureAuthenticationOutcomeDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ThreeDSecureAuthenticationOutcomeDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "acsTransactionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AcsTransactionId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ares", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ares
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "aresTransStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AresTransStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cryptogram", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Cryptogram
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dsTransactionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DsTransactionId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "eci", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Eci
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networkDetails", typeJson: "{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationOutcomeDetailsNetworkDetailsOutputReference\"}")]
        public virtual stripe.ThreeDSecureAuthentication.ThreeDSecureAuthenticationOutcomeDetailsNetworkDetailsOutputReference NetworkDetails
        {
            get => GetInstanceProperty<stripe.ThreeDSecureAuthentication.ThreeDSecureAuthenticationOutcomeDetailsNetworkDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "protocolVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProtocolVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "requestorChallengeIndicator", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RequestorChallengeIndicator
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rreq", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Rreq
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rreqTransStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RreqTransStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "threeDsServerTransactionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ThreeDsServerTransactionId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationOutcomeDetails\"}", isOptional: true)]
        public virtual stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationOutcomeDetails? InternalValue
        {
            get => GetInstanceProperty<stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationOutcomeDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
