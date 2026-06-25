using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainDevicesDisksSourceVhostUserQemuVdAgentOutputReference), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksSourceVhostUserQemuVdAgentOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DomainDevicesDisksSourceVhostUserQemuVdAgentOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DomainDevicesDisksSourceVhostUserQemuVdAgentOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DomainDevicesDisksSourceVhostUserQemuVdAgentOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainDevicesDisksSourceVhostUserQemuVdAgentOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putClipBoard", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceVhostUserQemuVdAgentClipBoard\"}}]")]
        public virtual void PutClipBoard(libvirt.Domain.IDomainDevicesDisksSourceVhostUserQemuVdAgentClipBoard @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksSourceVhostUserQemuVdAgentClipBoard)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMouse", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceVhostUserQemuVdAgentMouse\"}}]")]
        public virtual void PutMouse(libvirt.Domain.IDomainDevicesDisksSourceVhostUserQemuVdAgentMouse @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksSourceVhostUserQemuVdAgentMouse)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetClipBoard")]
        public virtual void ResetClipBoard()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMouse")]
        public virtual void ResetMouse()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "clipBoard", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceVhostUserQemuVdAgentClipBoardOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksSourceVhostUserQemuVdAgentClipBoardOutputReference ClipBoard
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksSourceVhostUserQemuVdAgentClipBoardOutputReference>()!;
        }

        [JsiiProperty(name: "mouse", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceVhostUserQemuVdAgentMouseOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksSourceVhostUserQemuVdAgentMouseOutputReference Mouse
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksSourceVhostUserQemuVdAgentMouseOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksSourceVhostUserQemuVdAgentClipBoard" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clipBoardInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceVhostUserQemuVdAgentClipBoard\"}]}}", isOptional: true)]
        public virtual object? ClipBoardInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksSourceVhostUserQemuVdAgentMouse" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mouseInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceVhostUserQemuVdAgentMouse\"}]}}", isOptional: true)]
        public virtual object? MouseInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksSourceVhostUserQemuVdAgent" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceVhostUserQemuVdAgent\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainDevicesDisksSourceVhostUserQemuVdAgent cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesDisksSourceVhostUserQemuVdAgent).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
