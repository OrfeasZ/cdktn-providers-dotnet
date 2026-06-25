using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainDevicesTpmsBackendExternalSourceQemuVdAgentOutputReference), fullyQualifiedName: "libvirt.domain.DomainDevicesTpmsBackendExternalSourceQemuVdAgentOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DomainDevicesTpmsBackendExternalSourceQemuVdAgentOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DomainDevicesTpmsBackendExternalSourceQemuVdAgentOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DomainDevicesTpmsBackendExternalSourceQemuVdAgentOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainDevicesTpmsBackendExternalSourceQemuVdAgentOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putClipBoard", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendExternalSourceQemuVdAgentClipBoard\"}}]")]
        public virtual void PutClipBoard(libvirt.Domain.IDomainDevicesTpmsBackendExternalSourceQemuVdAgentClipBoard @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesTpmsBackendExternalSourceQemuVdAgentClipBoard)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMouse", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendExternalSourceQemuVdAgentMouse\"}}]")]
        public virtual void PutMouse(libvirt.Domain.IDomainDevicesTpmsBackendExternalSourceQemuVdAgentMouse @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesTpmsBackendExternalSourceQemuVdAgentMouse)}, new object[]{@value});
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

        [JsiiProperty(name: "clipBoard", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendExternalSourceQemuVdAgentClipBoardOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesTpmsBackendExternalSourceQemuVdAgentClipBoardOutputReference ClipBoard
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesTpmsBackendExternalSourceQemuVdAgentClipBoardOutputReference>()!;
        }

        [JsiiProperty(name: "mouse", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendExternalSourceQemuVdAgentMouseOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesTpmsBackendExternalSourceQemuVdAgentMouseOutputReference Mouse
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesTpmsBackendExternalSourceQemuVdAgentMouseOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesTpmsBackendExternalSourceQemuVdAgentClipBoard" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clipBoardInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendExternalSourceQemuVdAgentClipBoard\"}]}}", isOptional: true)]
        public virtual object? ClipBoardInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesTpmsBackendExternalSourceQemuVdAgentMouse" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mouseInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendExternalSourceQemuVdAgentMouse\"}]}}", isOptional: true)]
        public virtual object? MouseInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesTpmsBackendExternalSourceQemuVdAgent" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendExternalSourceQemuVdAgent\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainDevicesTpmsBackendExternalSourceQemuVdAgent cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesTpmsBackendExternalSourceQemuVdAgent).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
