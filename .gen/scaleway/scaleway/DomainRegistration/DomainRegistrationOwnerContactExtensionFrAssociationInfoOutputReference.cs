using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DomainRegistration
{
    [JsiiClass(nativeType: typeof(scaleway.DomainRegistration.DomainRegistrationOwnerContactExtensionFrAssociationInfoOutputReference), fullyQualifiedName: "scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionFrAssociationInfoOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DomainRegistrationOwnerContactExtensionFrAssociationInfoOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DomainRegistrationOwnerContactExtensionFrAssociationInfoOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DomainRegistrationOwnerContactExtensionFrAssociationInfoOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainRegistrationOwnerContactExtensionFrAssociationInfoOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetPublicationJo")]
        public virtual void ResetPublicationJo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPublicationJoPage")]
        public virtual void ResetPublicationJoPage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "publicationJoInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PublicationJoInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "publicationJoPageInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PublicationJoPageInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "publicationJo", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublicationJo
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "publicationJoPage", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PublicationJoPage
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionFrAssociationInfo\"}", isOptional: true)]
        public virtual scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFrAssociationInfo? InternalValue
        {
            get => GetInstanceProperty<scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFrAssociationInfo?>();
            set => SetInstanceProperty(value);
        }
    }
}
