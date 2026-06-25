using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.PsqlDbSystem
{
    [JsiiClass(nativeType: typeof(oci.PsqlDbSystem.PsqlDbSystemKerberosAuthDetailsOutputReference), fullyQualifiedName: "oci.psqlDbSystem.PsqlDbSystemKerberosAuthDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PsqlDbSystemKerberosAuthDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PsqlDbSystemKerberosAuthDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PsqlDbSystemKerberosAuthDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PsqlDbSystemKerberosAuthDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.PsqlDbSystem.IPsqlDbSystemKerberosAuthDetailsBackupCredentials" />)[]</param>
        [JsiiMethod(name: "putBackupCredentials", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemKerberosAuthDetailsBackupCredentials\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutBackupCredentials(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.PsqlDbSystem.IPsqlDbSystemKerberosAuthDetailsBackupCredentials[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.PsqlDbSystem.IPsqlDbSystemKerberosAuthDetailsBackupCredentials).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.PsqlDbSystem.IPsqlDbSystemKerberosAuthDetailsBackupCredentials).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.PsqlDbSystem.IPsqlDbSystemKerberosAuthDetailsCredentials" />)[]</param>
        [JsiiMethod(name: "putCredentials", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemKerberosAuthDetailsCredentials\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCredentials(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.PsqlDbSystem.IPsqlDbSystemKerberosAuthDetailsCredentials[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.PsqlDbSystem.IPsqlDbSystemKerberosAuthDetailsCredentials).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.PsqlDbSystem.IPsqlDbSystemKerberosAuthDetailsCredentials).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBackupCredentials")]
        public virtual void ResetBackupCredentials()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCredentials")]
        public virtual void ResetCredentials()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "backupCredentials", typeJson: "{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemKerberosAuthDetailsBackupCredentialsList\"}")]
        public virtual oci.PsqlDbSystem.PsqlDbSystemKerberosAuthDetailsBackupCredentialsList BackupCredentials
        {
            get => GetInstanceProperty<oci.PsqlDbSystem.PsqlDbSystemKerberosAuthDetailsBackupCredentialsList>()!;
        }

        [JsiiProperty(name: "credentials", typeJson: "{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemKerberosAuthDetailsCredentialsList\"}")]
        public virtual oci.PsqlDbSystem.PsqlDbSystemKerberosAuthDetailsCredentialsList Credentials
        {
            get => GetInstanceProperty<oci.PsqlDbSystem.PsqlDbSystemKerberosAuthDetailsCredentialsList>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.PsqlDbSystem.IPsqlDbSystemKerberosAuthDetailsBackupCredentials" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "backupCredentialsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemKerberosAuthDetailsBackupCredentials\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? BackupCredentialsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.PsqlDbSystem.IPsqlDbSystemKerberosAuthDetailsCredentials" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "credentialsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemKerberosAuthDetailsCredentials\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CredentialsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kindInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KindInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Kind
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemKerberosAuthDetails\"}", isOptional: true)]
        public virtual oci.PsqlDbSystem.IPsqlDbSystemKerberosAuthDetails? InternalValue
        {
            get => GetInstanceProperty<oci.PsqlDbSystem.IPsqlDbSystemKerberosAuthDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
