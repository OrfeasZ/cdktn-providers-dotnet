using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DomainRegistration
{
    [JsiiClass(nativeType: typeof(scaleway.DomainRegistration.DomainRegistrationOwnerContactExtensionEuOutputReference), fullyQualifiedName: "scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionEuOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DomainRegistrationOwnerContactExtensionEuOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DomainRegistrationOwnerContactExtensionEuOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DomainRegistrationOwnerContactExtensionEuOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainRegistrationOwnerContactExtensionEuOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetEuropeanCitizenship")]
        public virtual void ResetEuropeanCitizenship()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "europeanCitizenshipInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EuropeanCitizenshipInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "europeanCitizenship", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EuropeanCitizenship
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionEu\"}", isOptional: true)]
        public virtual scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionEu? InternalValue
        {
            get => GetInstanceProperty<scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionEu?>();
            set => SetInstanceProperty(value);
        }
    }
}
