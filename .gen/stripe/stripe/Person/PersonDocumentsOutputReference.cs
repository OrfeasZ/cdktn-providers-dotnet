using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Person
{
    [JsiiClass(nativeType: typeof(stripe.Person.PersonDocumentsOutputReference), fullyQualifiedName: "stripe.person.PersonDocumentsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PersonDocumentsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PersonDocumentsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PersonDocumentsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PersonDocumentsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCompanyAuthorization", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.person.PersonDocumentsCompanyAuthorization\"}}]")]
        public virtual void PutCompanyAuthorization(stripe.Person.IPersonDocumentsCompanyAuthorization @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Person.IPersonDocumentsCompanyAuthorization)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPassport", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.person.PersonDocumentsPassport\"}}]")]
        public virtual void PutPassport(stripe.Person.IPersonDocumentsPassport @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Person.IPersonDocumentsPassport)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVisa", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.person.PersonDocumentsVisa\"}}]")]
        public virtual void PutVisa(stripe.Person.IPersonDocumentsVisa @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Person.IPersonDocumentsVisa)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCompanyAuthorization")]
        public virtual void ResetCompanyAuthorization()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPassport")]
        public virtual void ResetPassport()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVisa")]
        public virtual void ResetVisa()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "companyAuthorization", typeJson: "{\"fqn\":\"stripe.person.PersonDocumentsCompanyAuthorizationOutputReference\"}")]
        public virtual stripe.Person.PersonDocumentsCompanyAuthorizationOutputReference CompanyAuthorization
        {
            get => GetInstanceProperty<stripe.Person.PersonDocumentsCompanyAuthorizationOutputReference>()!;
        }

        [JsiiProperty(name: "passport", typeJson: "{\"fqn\":\"stripe.person.PersonDocumentsPassportOutputReference\"}")]
        public virtual stripe.Person.PersonDocumentsPassportOutputReference Passport
        {
            get => GetInstanceProperty<stripe.Person.PersonDocumentsPassportOutputReference>()!;
        }

        [JsiiProperty(name: "visa", typeJson: "{\"fqn\":\"stripe.person.PersonDocumentsVisaOutputReference\"}")]
        public virtual stripe.Person.PersonDocumentsVisaOutputReference Visa
        {
            get => GetInstanceProperty<stripe.Person.PersonDocumentsVisaOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Person.IPersonDocumentsCompanyAuthorization" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "companyAuthorizationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.person.PersonDocumentsCompanyAuthorization\"}]}}", isOptional: true)]
        public virtual object? CompanyAuthorizationInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Person.IPersonDocumentsPassport" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "passportInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.person.PersonDocumentsPassport\"}]}}", isOptional: true)]
        public virtual object? PassportInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Person.IPersonDocumentsVisa" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "visaInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.person.PersonDocumentsVisa\"}]}}", isOptional: true)]
        public virtual object? VisaInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Person.IPersonDocuments" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.person.PersonDocuments\"}]}}", isOptional: true)]
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
                        case stripe.Person.IPersonDocuments cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.Person.IPersonDocuments).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
