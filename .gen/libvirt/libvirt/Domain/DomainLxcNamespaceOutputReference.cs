using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainLxcNamespaceOutputReference), fullyQualifiedName: "libvirt.domain.DomainLxcNamespaceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DomainLxcNamespaceOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DomainLxcNamespaceOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DomainLxcNamespaceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainLxcNamespaceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putShareIpc", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainLxcNamespaceShareIpc\"}}]")]
        public virtual void PutShareIpc(libvirt.Domain.IDomainLxcNamespaceShareIpc @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainLxcNamespaceShareIpc)}, new object[]{@value});
        }

        [JsiiMethod(name: "putShareNet", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainLxcNamespaceShareNet\"}}]")]
        public virtual void PutShareNet(libvirt.Domain.IDomainLxcNamespaceShareNet @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainLxcNamespaceShareNet)}, new object[]{@value});
        }

        [JsiiMethod(name: "putShareUts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainLxcNamespaceShareUts\"}}]")]
        public virtual void PutShareUts(libvirt.Domain.IDomainLxcNamespaceShareUts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainLxcNamespaceShareUts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetShareIpc")]
        public virtual void ResetShareIpc()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetShareNet")]
        public virtual void ResetShareNet()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetShareUts")]
        public virtual void ResetShareUts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "shareIpc", typeJson: "{\"fqn\":\"libvirt.domain.DomainLxcNamespaceShareIpcOutputReference\"}")]
        public virtual libvirt.Domain.DomainLxcNamespaceShareIpcOutputReference ShareIpc
        {
            get => GetInstanceProperty<libvirt.Domain.DomainLxcNamespaceShareIpcOutputReference>()!;
        }

        [JsiiProperty(name: "shareNet", typeJson: "{\"fqn\":\"libvirt.domain.DomainLxcNamespaceShareNetOutputReference\"}")]
        public virtual libvirt.Domain.DomainLxcNamespaceShareNetOutputReference ShareNet
        {
            get => GetInstanceProperty<libvirt.Domain.DomainLxcNamespaceShareNetOutputReference>()!;
        }

        [JsiiProperty(name: "shareUts", typeJson: "{\"fqn\":\"libvirt.domain.DomainLxcNamespaceShareUtsOutputReference\"}")]
        public virtual libvirt.Domain.DomainLxcNamespaceShareUtsOutputReference ShareUts
        {
            get => GetInstanceProperty<libvirt.Domain.DomainLxcNamespaceShareUtsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "shareIpcInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainLxcNamespaceShareIpc\"}]}}", isOptional: true)]
        public virtual object? ShareIpcInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "shareNetInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainLxcNamespaceShareNet\"}]}}", isOptional: true)]
        public virtual object? ShareNetInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "shareUtsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainLxcNamespaceShareUts\"}]}}", isOptional: true)]
        public virtual object? ShareUtsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainLxcNamespace\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainLxcNamespace cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainLxcNamespace).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
