using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainDevicesDisksMirrorSourceVhostUserQemuVdAgentOutputReference), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksMirrorSourceVhostUserQemuVdAgentOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DomainDevicesDisksMirrorSourceVhostUserQemuVdAgentOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DomainDevicesDisksMirrorSourceVhostUserQemuVdAgentOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DomainDevicesDisksMirrorSourceVhostUserQemuVdAgentOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainDevicesDisksMirrorSourceVhostUserQemuVdAgentOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putClipBoard", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceVhostUserQemuVdAgentClipBoard\"}}]")]
        public virtual void PutClipBoard(libvirt.Domain.IDomainDevicesDisksMirrorSourceVhostUserQemuVdAgentClipBoard @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorSourceVhostUserQemuVdAgentClipBoard)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMouse", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceVhostUserQemuVdAgentMouse\"}}]")]
        public virtual void PutMouse(libvirt.Domain.IDomainDevicesDisksMirrorSourceVhostUserQemuVdAgentMouse @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorSourceVhostUserQemuVdAgentMouse)}, new object[]{@value});
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

        [JsiiProperty(name: "clipBoard", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceVhostUserQemuVdAgentClipBoardOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorSourceVhostUserQemuVdAgentClipBoardOutputReference ClipBoard
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorSourceVhostUserQemuVdAgentClipBoardOutputReference>()!;
        }

        [JsiiProperty(name: "mouse", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceVhostUserQemuVdAgentMouseOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorSourceVhostUserQemuVdAgentMouseOutputReference Mouse
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorSourceVhostUserQemuVdAgentMouseOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorSourceVhostUserQemuVdAgentClipBoard" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clipBoardInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceVhostUserQemuVdAgentClipBoard\"}]}}", isOptional: true)]
        public virtual object? ClipBoardInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorSourceVhostUserQemuVdAgentMouse" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mouseInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceVhostUserQemuVdAgentMouse\"}]}}", isOptional: true)]
        public virtual object? MouseInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorSourceVhostUserQemuVdAgent" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceVhostUserQemuVdAgent\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainDevicesDisksMirrorSourceVhostUserQemuVdAgent cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesDisksMirrorSourceVhostUserQemuVdAgent).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
