using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Person
{
    [JsiiClass(nativeType: typeof(stripe.Person.PersonAdditionalTosAcceptancesOutputReference), fullyQualifiedName: "stripe.person.PersonAdditionalTosAcceptancesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PersonAdditionalTosAcceptancesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PersonAdditionalTosAcceptancesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PersonAdditionalTosAcceptancesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PersonAdditionalTosAcceptancesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAccount", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.person.PersonAdditionalTosAcceptancesAccount\"}}]")]
        public virtual void PutAccount(stripe.Person.IPersonAdditionalTosAcceptancesAccount @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Person.IPersonAdditionalTosAcceptancesAccount)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAccount")]
        public virtual void ResetAccount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "account", typeJson: "{\"fqn\":\"stripe.person.PersonAdditionalTosAcceptancesAccountOutputReference\"}")]
        public virtual stripe.Person.PersonAdditionalTosAcceptancesAccountOutputReference Account
        {
            get => GetInstanceProperty<stripe.Person.PersonAdditionalTosAcceptancesAccountOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Person.IPersonAdditionalTosAcceptancesAccount" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "accountInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.person.PersonAdditionalTosAcceptancesAccount\"}]}}", isOptional: true)]
        public virtual object? AccountInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Person.IPersonAdditionalTosAcceptances" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.person.PersonAdditionalTosAcceptances\"}]}}", isOptional: true)]
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
                        case stripe.Person.IPersonAdditionalTosAcceptances cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.Person.IPersonAdditionalTosAcceptances).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
