using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FsxS3AccessPointAttachment
{
    [JsiiClass(nativeType: typeof(aws.FsxS3AccessPointAttachment.FsxS3AccessPointAttachmentOntapConfigurationFileSystemIdentityOutputReference), fullyQualifiedName: "aws.fsxS3AccessPointAttachment.FsxS3AccessPointAttachmentOntapConfigurationFileSystemIdentityOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class FsxS3AccessPointAttachmentOntapConfigurationFileSystemIdentityOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public FsxS3AccessPointAttachmentOntapConfigurationFileSystemIdentityOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FsxS3AccessPointAttachmentOntapConfigurationFileSystemIdentityOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FsxS3AccessPointAttachmentOntapConfigurationFileSystemIdentityOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.FsxS3AccessPointAttachment.IFsxS3AccessPointAttachmentOntapConfigurationFileSystemIdentityUnixUser" />)[]</param>
        [JsiiMethod(name: "putUnixUser", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.fsxS3AccessPointAttachment.FsxS3AccessPointAttachmentOntapConfigurationFileSystemIdentityUnixUser\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutUnixUser(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.FsxS3AccessPointAttachment.IFsxS3AccessPointAttachmentOntapConfigurationFileSystemIdentityUnixUser[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.FsxS3AccessPointAttachment.IFsxS3AccessPointAttachmentOntapConfigurationFileSystemIdentityUnixUser).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.FsxS3AccessPointAttachment.IFsxS3AccessPointAttachmentOntapConfigurationFileSystemIdentityUnixUser).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.FsxS3AccessPointAttachment.IFsxS3AccessPointAttachmentOntapConfigurationFileSystemIdentityWindowsUser" />)[]</param>
        [JsiiMethod(name: "putWindowsUser", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.fsxS3AccessPointAttachment.FsxS3AccessPointAttachmentOntapConfigurationFileSystemIdentityWindowsUser\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutWindowsUser(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.FsxS3AccessPointAttachment.IFsxS3AccessPointAttachmentOntapConfigurationFileSystemIdentityWindowsUser[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.FsxS3AccessPointAttachment.IFsxS3AccessPointAttachmentOntapConfigurationFileSystemIdentityWindowsUser).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.FsxS3AccessPointAttachment.IFsxS3AccessPointAttachmentOntapConfigurationFileSystemIdentityWindowsUser).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetUnixUser")]
        public virtual void ResetUnixUser()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWindowsUser")]
        public virtual void ResetWindowsUser()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "unixUser", typeJson: "{\"fqn\":\"aws.fsxS3AccessPointAttachment.FsxS3AccessPointAttachmentOntapConfigurationFileSystemIdentityUnixUserList\"}")]
        public virtual aws.FsxS3AccessPointAttachment.FsxS3AccessPointAttachmentOntapConfigurationFileSystemIdentityUnixUserList UnixUser
        {
            get => GetInstanceProperty<aws.FsxS3AccessPointAttachment.FsxS3AccessPointAttachmentOntapConfigurationFileSystemIdentityUnixUserList>()!;
        }

        [JsiiProperty(name: "windowsUser", typeJson: "{\"fqn\":\"aws.fsxS3AccessPointAttachment.FsxS3AccessPointAttachmentOntapConfigurationFileSystemIdentityWindowsUserList\"}")]
        public virtual aws.FsxS3AccessPointAttachment.FsxS3AccessPointAttachmentOntapConfigurationFileSystemIdentityWindowsUserList WindowsUser
        {
            get => GetInstanceProperty<aws.FsxS3AccessPointAttachment.FsxS3AccessPointAttachmentOntapConfigurationFileSystemIdentityWindowsUserList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.FsxS3AccessPointAttachment.IFsxS3AccessPointAttachmentOntapConfigurationFileSystemIdentityUnixUser" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "unixUserInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.fsxS3AccessPointAttachment.FsxS3AccessPointAttachmentOntapConfigurationFileSystemIdentityUnixUser\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? UnixUserInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.FsxS3AccessPointAttachment.IFsxS3AccessPointAttachmentOntapConfigurationFileSystemIdentityWindowsUser" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "windowsUserInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.fsxS3AccessPointAttachment.FsxS3AccessPointAttachmentOntapConfigurationFileSystemIdentityWindowsUser\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? WindowsUserInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="aws.FsxS3AccessPointAttachment.IFsxS3AccessPointAttachmentOntapConfigurationFileSystemIdentity" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.fsxS3AccessPointAttachment.FsxS3AccessPointAttachmentOntapConfigurationFileSystemIdentity\"}]}}", isOptional: true)]
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
                        case aws.FsxS3AccessPointAttachment.IFsxS3AccessPointAttachmentOntapConfigurationFileSystemIdentity cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.FsxS3AccessPointAttachment.IFsxS3AccessPointAttachmentOntapConfigurationFileSystemIdentity).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
