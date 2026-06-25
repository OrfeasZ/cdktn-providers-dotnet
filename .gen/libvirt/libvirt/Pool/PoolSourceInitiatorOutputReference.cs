using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Pool
{
    [JsiiClass(nativeType: typeof(libvirt.Pool.PoolSourceInitiatorOutputReference), fullyQualifiedName: "libvirt.pool.PoolSourceInitiatorOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PoolSourceInitiatorOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PoolSourceInitiatorOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PoolSourceInitiatorOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PoolSourceInitiatorOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putIqn", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.pool.PoolSourceInitiatorIqn\"}}]")]
        public virtual void PutIqn(libvirt.Pool.IPoolSourceInitiatorIqn @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Pool.IPoolSourceInitiatorIqn)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetIqn")]
        public virtual void ResetIqn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "iqn", typeJson: "{\"fqn\":\"libvirt.pool.PoolSourceInitiatorIqnOutputReference\"}")]
        public virtual libvirt.Pool.PoolSourceInitiatorIqnOutputReference Iqn
        {
            get => GetInstanceProperty<libvirt.Pool.PoolSourceInitiatorIqnOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Pool.IPoolSourceInitiatorIqn" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "iqnInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.pool.PoolSourceInitiatorIqn\"}]}}", isOptional: true)]
        public virtual object? IqnInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Pool.IPoolSourceInitiator" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.pool.PoolSourceInitiator\"}]}}", isOptional: true)]
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
                        case libvirt.Pool.IPoolSourceInitiator cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Pool.IPoolSourceInitiator).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
