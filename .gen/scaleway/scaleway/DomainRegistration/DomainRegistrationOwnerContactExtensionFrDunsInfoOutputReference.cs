using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DomainRegistration
{
    [JsiiClass(nativeType: typeof(scaleway.DomainRegistration.DomainRegistrationOwnerContactExtensionFrDunsInfoOutputReference), fullyQualifiedName: "scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionFrDunsInfoOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DomainRegistrationOwnerContactExtensionFrDunsInfoOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DomainRegistrationOwnerContactExtensionFrDunsInfoOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DomainRegistrationOwnerContactExtensionFrDunsInfoOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainRegistrationOwnerContactExtensionFrDunsInfoOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetDunsId")]
        public virtual void ResetDunsId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLocalId")]
        public virtual void ResetLocalId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "dunsIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DunsIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "localIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LocalIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "dunsId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DunsId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "localId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LocalId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionFrDunsInfo\"}", isOptional: true)]
        public virtual scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFrDunsInfo? InternalValue
        {
            get => GetInstanceProperty<scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFrDunsInfo?>();
            set => SetInstanceProperty(value);
        }
    }
}
