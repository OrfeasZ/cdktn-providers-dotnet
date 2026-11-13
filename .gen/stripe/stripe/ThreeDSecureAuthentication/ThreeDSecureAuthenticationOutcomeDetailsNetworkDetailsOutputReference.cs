using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.ThreeDSecureAuthentication
{
    [JsiiClass(nativeType: typeof(stripe.ThreeDSecureAuthentication.ThreeDSecureAuthenticationOutcomeDetailsNetworkDetailsOutputReference), fullyQualifiedName: "stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationOutcomeDetailsNetworkDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ThreeDSecureAuthenticationOutcomeDetailsNetworkDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ThreeDSecureAuthenticationOutcomeDetailsNetworkDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ThreeDSecureAuthenticationOutcomeDetailsNetworkDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ThreeDSecureAuthenticationOutcomeDetailsNetworkDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "cartesBancaires", typeJson: "{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationOutcomeDetailsNetworkDetailsCartesBancairesOutputReference\"}")]
        public virtual stripe.ThreeDSecureAuthentication.ThreeDSecureAuthenticationOutcomeDetailsNetworkDetailsCartesBancairesOutputReference CartesBancaires
        {
            get => GetInstanceProperty<stripe.ThreeDSecureAuthentication.ThreeDSecureAuthenticationOutcomeDetailsNetworkDetailsCartesBancairesOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationOutcomeDetailsNetworkDetails\"}", isOptional: true)]
        public virtual stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationOutcomeDetailsNetworkDetails? InternalValue
        {
            get => GetInstanceProperty<stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationOutcomeDetailsNetworkDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
