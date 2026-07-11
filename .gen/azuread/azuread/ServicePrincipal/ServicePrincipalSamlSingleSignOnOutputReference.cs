using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.ServicePrincipal
{
    [JsiiClass(nativeType: typeof(azuread.ServicePrincipal.ServicePrincipalSamlSingleSignOnOutputReference), fullyQualifiedName: "azuread.servicePrincipal.ServicePrincipalSamlSingleSignOnOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ServicePrincipalSamlSingleSignOnOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ServicePrincipalSamlSingleSignOnOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ServicePrincipalSamlSingleSignOnOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ServicePrincipalSamlSingleSignOnOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetRelayState")]
        public virtual void ResetRelayState()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "relayStateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RelayStateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "relayState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RelayState
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azuread.servicePrincipal.ServicePrincipalSamlSingleSignOn\"}", isOptional: true)]
        public virtual azuread.ServicePrincipal.IServicePrincipalSamlSingleSignOn? InternalValue
        {
            get => GetInstanceProperty<azuread.ServicePrincipal.IServicePrincipalSamlSingleSignOn?>();
            set => SetInstanceProperty(value);
        }
    }
}
