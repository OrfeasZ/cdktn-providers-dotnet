using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DifStack
{
    [JsiiClass(nativeType: typeof(oci.DifStack.DifStackGgcsOutputReference), fullyQualifiedName: "oci.difStack.DifStackGgcsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DifStackGgcsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DifStackGgcsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DifStackGgcsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DifStackGgcsOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DifStack.IDifStackGgcsConnections" />)[]</param>
        [JsiiMethod(name: "putConnections", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.difStack.DifStackGgcsConnections\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutConnections(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DifStack.IDifStackGgcsConnections[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DifStack.IDifStackGgcsConnections).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DifStack.IDifStackGgcsConnections).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DifStack.IDifStackGgcsSources" />)[]</param>
        [JsiiMethod(name: "putSources", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.difStack.DifStackGgcsSources\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSources(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DifStack.IDifStackGgcsSources[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DifStack.IDifStackGgcsSources).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DifStack.IDifStackGgcsSources).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DifStack.IDifStackGgcsTargets" />)[]</param>
        [JsiiMethod(name: "putTargets", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.difStack.DifStackGgcsTargets\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutTargets(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DifStack.IDifStackGgcsTargets[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DifStack.IDifStackGgcsTargets).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DifStack.IDifStackGgcsTargets).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DifStack.IDifStackGgcsUsers" />)[]</param>
        [JsiiMethod(name: "putUsers", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.difStack.DifStackGgcsUsers\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutUsers(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DifStack.IDifStackGgcsUsers[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DifStack.IDifStackGgcsUsers).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DifStack.IDifStackGgcsUsers).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetArtifactObjectStoragePath")]
        public virtual void ResetArtifactObjectStoragePath()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConnections")]
        public virtual void ResetConnections()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOggVersion")]
        public virtual void ResetOggVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPublicSubnetId")]
        public virtual void ResetPublicSubnetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSources")]
        public virtual void ResetSources()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargets")]
        public virtual void ResetTargets()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUsers")]
        public virtual void ResetUsers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "connections", typeJson: "{\"fqn\":\"oci.difStack.DifStackGgcsConnectionsList\"}")]
        public virtual oci.DifStack.DifStackGgcsConnectionsList Connections
        {
            get => GetInstanceProperty<oci.DifStack.DifStackGgcsConnectionsList>()!;
        }

        [JsiiProperty(name: "sources", typeJson: "{\"fqn\":\"oci.difStack.DifStackGgcsSourcesList\"}")]
        public virtual oci.DifStack.DifStackGgcsSourcesList Sources
        {
            get => GetInstanceProperty<oci.DifStack.DifStackGgcsSourcesList>()!;
        }

        [JsiiProperty(name: "targets", typeJson: "{\"fqn\":\"oci.difStack.DifStackGgcsTargetsList\"}")]
        public virtual oci.DifStack.DifStackGgcsTargetsList Targets
        {
            get => GetInstanceProperty<oci.DifStack.DifStackGgcsTargetsList>()!;
        }

        [JsiiProperty(name: "users", typeJson: "{\"fqn\":\"oci.difStack.DifStackGgcsUsersList\"}")]
        public virtual oci.DifStack.DifStackGgcsUsersList Users
        {
            get => GetInstanceProperty<oci.DifStack.DifStackGgcsUsersList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "artifactObjectStoragePathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ArtifactObjectStoragePathInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DifStack.IDifStackGgcsConnections" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connectionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.difStack.DifStackGgcsConnections\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ConnectionsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstanceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ocpuInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? OcpuInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "oggVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OggVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "passwordSecretIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PasswordSecretIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "publicSubnetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PublicSubnetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DifStack.IDifStackGgcsSources" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sourcesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.difStack.DifStackGgcsSources\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SourcesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subnetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubnetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DifStack.IDifStackGgcsTargets" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "targetsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.difStack.DifStackGgcsTargets\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? TargetsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DifStack.IDifStackGgcsUsers" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "usersInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.difStack.DifStackGgcsUsers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? UsersInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "artifactObjectStoragePath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ArtifactObjectStoragePath
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ocpu", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Ocpu
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "oggVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OggVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "passwordSecretId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PasswordSecretId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "publicSubnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublicSubnetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="oci.DifStack.IDifStackGgcs" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.difStack.DifStackGgcs\"}]}}", isOptional: true)]
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
                        case oci.DifStack.IDifStackGgcs cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DifStack.IDifStackGgcs).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
