using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainCpuNumaCellCachesOutputReference), fullyQualifiedName: "libvirt.domain.DomainCpuNumaCellCachesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DomainCpuNumaCellCachesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DomainCpuNumaCellCachesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DomainCpuNumaCellCachesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainCpuNumaCellCachesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putLine", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainCpuNumaCellCachesLine\"}}]")]
        public virtual void PutLine(libvirt.Domain.IDomainCpuNumaCellCachesLine @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainCpuNumaCellCachesLine)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSize", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainCpuNumaCellCachesSize\"}}]")]
        public virtual void PutSize(libvirt.Domain.IDomainCpuNumaCellCachesSize @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainCpuNumaCellCachesSize)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetLine")]
        public virtual void ResetLine()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSize")]
        public virtual void ResetSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "line", typeJson: "{\"fqn\":\"libvirt.domain.DomainCpuNumaCellCachesLineOutputReference\"}")]
        public virtual libvirt.Domain.DomainCpuNumaCellCachesLineOutputReference Line
        {
            get => GetInstanceProperty<libvirt.Domain.DomainCpuNumaCellCachesLineOutputReference>()!;
        }

        [JsiiProperty(name: "size", typeJson: "{\"fqn\":\"libvirt.domain.DomainCpuNumaCellCachesSizeOutputReference\"}")]
        public virtual libvirt.Domain.DomainCpuNumaCellCachesSizeOutputReference Size
        {
            get => GetInstanceProperty<libvirt.Domain.DomainCpuNumaCellCachesSizeOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "associativityInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AssociativityInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "levelInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? LevelInput
        {
            get => GetInstanceProperty<double?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainCpuNumaCellCachesLine" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lineInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainCpuNumaCellCachesLine\"}]}}", isOptional: true)]
        public virtual object? LineInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "policyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PolicyInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainCpuNumaCellCachesSize" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sizeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainCpuNumaCellCachesSize\"}]}}", isOptional: true)]
        public virtual object? SizeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "associativity", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Associativity
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "level", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Level
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "policy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Policy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainCpuNumaCellCaches" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainCpuNumaCellCaches\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainCpuNumaCellCaches cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainCpuNumaCellCaches).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
