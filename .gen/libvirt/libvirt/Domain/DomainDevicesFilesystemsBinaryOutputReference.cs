using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainDevicesFilesystemsBinaryOutputReference), fullyQualifiedName: "libvirt.domain.DomainDevicesFilesystemsBinaryOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DomainDevicesFilesystemsBinaryOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DomainDevicesFilesystemsBinaryOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DomainDevicesFilesystemsBinaryOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainDevicesFilesystemsBinaryOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCache", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsBinaryCache\"}}]")]
        public virtual void PutCache(libvirt.Domain.IDomainDevicesFilesystemsBinaryCache @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesFilesystemsBinaryCache)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLock", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsBinaryLock\"}}]")]
        public virtual void PutLock(libvirt.Domain.IDomainDevicesFilesystemsBinaryLock @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesFilesystemsBinaryLock)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOpenFiles", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsBinaryOpenFiles\"}}]")]
        public virtual void PutOpenFiles(libvirt.Domain.IDomainDevicesFilesystemsBinaryOpenFiles @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesFilesystemsBinaryOpenFiles)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSandbox", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsBinarySandbox\"}}]")]
        public virtual void PutSandbox(libvirt.Domain.IDomainDevicesFilesystemsBinarySandbox @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesFilesystemsBinarySandbox)}, new object[]{@value});
        }

        [JsiiMethod(name: "putThreadPool", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsBinaryThreadPool\"}}]")]
        public virtual void PutThreadPool(libvirt.Domain.IDomainDevicesFilesystemsBinaryThreadPool @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesFilesystemsBinaryThreadPool)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCache")]
        public virtual void ResetCache()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLock")]
        public virtual void ResetLock()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOpenFiles")]
        public virtual void ResetOpenFiles()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPath")]
        public virtual void ResetPath()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSandbox")]
        public virtual void ResetSandbox()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetThreadPool")]
        public virtual void ResetThreadPool()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetXattr")]
        public virtual void ResetXattr()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "cache", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsBinaryCacheOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesFilesystemsBinaryCacheOutputReference Cache
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesFilesystemsBinaryCacheOutputReference>()!;
        }

        [JsiiProperty(name: "lock", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsBinaryLockOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesFilesystemsBinaryLockOutputReference Lock
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesFilesystemsBinaryLockOutputReference>()!;
        }

        [JsiiProperty(name: "openFiles", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsBinaryOpenFilesOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesFilesystemsBinaryOpenFilesOutputReference OpenFiles
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesFilesystemsBinaryOpenFilesOutputReference>()!;
        }

        [JsiiProperty(name: "sandbox", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsBinarySandboxOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesFilesystemsBinarySandboxOutputReference Sandbox
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesFilesystemsBinarySandboxOutputReference>()!;
        }

        [JsiiProperty(name: "threadPool", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsBinaryThreadPoolOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesFilesystemsBinaryThreadPoolOutputReference ThreadPool
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesFilesystemsBinaryThreadPoolOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesFilesystemsBinaryCache" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cacheInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsBinaryCache\"}]}}", isOptional: true)]
        public virtual object? CacheInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesFilesystemsBinaryLock" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lockInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsBinaryLock\"}]}}", isOptional: true)]
        public virtual object? LockInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesFilesystemsBinaryOpenFiles" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "openFilesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsBinaryOpenFiles\"}]}}", isOptional: true)]
        public virtual object? OpenFilesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PathInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesFilesystemsBinarySandbox" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sandboxInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsBinarySandbox\"}]}}", isOptional: true)]
        public virtual object? SandboxInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesFilesystemsBinaryThreadPool" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "threadPoolInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsBinaryThreadPool\"}]}}", isOptional: true)]
        public virtual object? ThreadPoolInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "xattrInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? XattrInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Path
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "xattr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Xattr
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesFilesystemsBinary" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsBinary\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainDevicesFilesystemsBinary cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesFilesystemsBinary).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
