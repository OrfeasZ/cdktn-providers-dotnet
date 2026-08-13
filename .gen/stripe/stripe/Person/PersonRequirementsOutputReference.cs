using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Person
{
    [JsiiClass(nativeType: typeof(stripe.Person.PersonRequirementsOutputReference), fullyQualifiedName: "stripe.person.PersonRequirementsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PersonRequirementsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PersonRequirementsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PersonRequirementsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PersonRequirementsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "alternatives", typeJson: "{\"fqn\":\"stripe.person.PersonRequirementsAlternativesList\"}")]
        public virtual stripe.Person.PersonRequirementsAlternativesList Alternatives
        {
            get => GetInstanceProperty<stripe.Person.PersonRequirementsAlternativesList>()!;
        }

        [JsiiProperty(name: "currentlyDue", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] CurrentlyDue
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "errors", typeJson: "{\"fqn\":\"stripe.person.PersonRequirementsErrorsList\"}")]
        public virtual stripe.Person.PersonRequirementsErrorsList Errors
        {
            get => GetInstanceProperty<stripe.Person.PersonRequirementsErrorsList>()!;
        }

        [JsiiProperty(name: "eventuallyDue", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] EventuallyDue
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "pastDue", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PastDue
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "pendingVerification", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PendingVerification
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.person.PersonRequirements\"}", isOptional: true)]
        public virtual stripe.Person.IPersonRequirements? InternalValue
        {
            get => GetInstanceProperty<stripe.Person.IPersonRequirements?>();
            set => SetInstanceProperty(value);
        }
    }
}
