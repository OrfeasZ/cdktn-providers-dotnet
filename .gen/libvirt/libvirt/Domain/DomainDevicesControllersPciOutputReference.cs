using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainDevicesControllersPciOutputReference), fullyQualifiedName: "libvirt.domain.DomainDevicesControllersPciOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DomainDevicesControllersPciOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DomainDevicesControllersPciOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DomainDevicesControllersPciOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainDevicesControllersPciOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putModel", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesControllersPciModel\"}}]")]
        public virtual void PutModel(libvirt.Domain.IDomainDevicesControllersPciModel @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesControllersPciModel)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTarget", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesControllersPciTarget\"}}]")]
        public virtual void PutTarget(libvirt.Domain.IDomainDevicesControllersPciTarget @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesControllersPciTarget)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetHole64")]
        public virtual void ResetHole64()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHole64Unit")]
        public virtual void ResetHole64Unit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetModel")]
        public virtual void ResetModel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTarget")]
        public virtual void ResetTarget()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "model", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesControllersPciModelOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesControllersPciModelOutputReference Model
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesControllersPciModelOutputReference>()!;
        }

        [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesControllersPciTargetOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesControllersPciTargetOutputReference Target
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesControllersPciTargetOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "hole64Input", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? Hole64Input
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hole64UnitInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? Hole64UnitInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesControllersPciModel" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "modelInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesControllersPciModel\"}]}}", isOptional: true)]
        public virtual object? ModelInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesControllersPciTarget" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "targetInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesControllersPciTarget\"}]}}", isOptional: true)]
        public virtual object? TargetInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "hole64", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Hole64
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "hole64Unit", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Hole64Unit
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesControllersPci" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesControllersPci\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainDevicesControllersPci cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesControllersPci).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
