using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsUser
{
    [JsiiClass(nativeType: typeof(oci.IdentityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserStateUserRecoveryLockedOutputReference), fullyQualifiedName: "oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserStateUserRecoveryLockedOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserStateUserRecoveryLockedOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserStateUserRecoveryLockedOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserStateUserRecoveryLockedOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserStateUserRecoveryLockedOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetLockDate")]
        public virtual void ResetLockDate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOn")]
        public virtual void ResetOn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "lockDateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LockDateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "onInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? OnInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "lockDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LockDate
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "on", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object On
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserStateUserRecoveryLocked\"}", isOptional: true)]
        public virtual oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserStateUserRecoveryLocked? InternalValue
        {
            get => GetInstanceProperty<oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserStateUserRecoveryLocked?>();
            set => SetInstanceProperty(value);
        }
    }
}
