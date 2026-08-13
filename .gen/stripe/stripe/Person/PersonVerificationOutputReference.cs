using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Person
{
    [JsiiClass(nativeType: typeof(stripe.Person.PersonVerificationOutputReference), fullyQualifiedName: "stripe.person.PersonVerificationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PersonVerificationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PersonVerificationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PersonVerificationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PersonVerificationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAdditionalDocument", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.person.PersonVerificationAdditionalDocument\"}}]")]
        public virtual void PutAdditionalDocument(stripe.Person.IPersonVerificationAdditionalDocument @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Person.IPersonVerificationAdditionalDocument)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDocument", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.person.PersonVerificationDocument\"}}]")]
        public virtual void PutDocument(stripe.Person.IPersonVerificationDocument @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Person.IPersonVerificationDocument)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAdditionalDocument")]
        public virtual void ResetAdditionalDocument()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDocument")]
        public virtual void ResetDocument()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "additionalDocument", typeJson: "{\"fqn\":\"stripe.person.PersonVerificationAdditionalDocumentOutputReference\"}")]
        public virtual stripe.Person.PersonVerificationAdditionalDocumentOutputReference AdditionalDocument
        {
            get => GetInstanceProperty<stripe.Person.PersonVerificationAdditionalDocumentOutputReference>()!;
        }

        [JsiiProperty(name: "details", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Details
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "detailsCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DetailsCode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "document", typeJson: "{\"fqn\":\"stripe.person.PersonVerificationDocumentOutputReference\"}")]
        public virtual stripe.Person.PersonVerificationDocumentOutputReference Document
        {
            get => GetInstanceProperty<stripe.Person.PersonVerificationDocumentOutputReference>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Person.IPersonVerificationAdditionalDocument" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "additionalDocumentInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.person.PersonVerificationAdditionalDocument\"}]}}", isOptional: true)]
        public virtual object? AdditionalDocumentInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Person.IPersonVerificationDocument" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "documentInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.person.PersonVerificationDocument\"}]}}", isOptional: true)]
        public virtual object? DocumentInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Person.IPersonVerification" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.person.PersonVerification\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case stripe.Person.IPersonVerification cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.Person.IPersonVerification).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
