using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainDevicesDisksBackingStoreSourceReservationsSourceQemuVdAgentOutputReference), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksBackingStoreSourceReservationsSourceQemuVdAgentOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DomainDevicesDisksBackingStoreSourceReservationsSourceQemuVdAgentOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DomainDevicesDisksBackingStoreSourceReservationsSourceQemuVdAgentOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DomainDevicesDisksBackingStoreSourceReservationsSourceQemuVdAgentOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainDevicesDisksBackingStoreSourceReservationsSourceQemuVdAgentOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putClipBoard", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackingStoreSourceReservationsSourceQemuVdAgentClipBoard\"}}]")]
        public virtual void PutClipBoard(libvirt.Domain.IDomainDevicesDisksBackingStoreSourceReservationsSourceQemuVdAgentClipBoard @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksBackingStoreSourceReservationsSourceQemuVdAgentClipBoard)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMouse", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackingStoreSourceReservationsSourceQemuVdAgentMouse\"}}]")]
        public virtual void PutMouse(libvirt.Domain.IDomainDevicesDisksBackingStoreSourceReservationsSourceQemuVdAgentMouse @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksBackingStoreSourceReservationsSourceQemuVdAgentMouse)}, new object[]{@value});
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

        [JsiiProperty(name: "clipBoard", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackingStoreSourceReservationsSourceQemuVdAgentClipBoardOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksBackingStoreSourceReservationsSourceQemuVdAgentClipBoardOutputReference ClipBoard
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksBackingStoreSourceReservationsSourceQemuVdAgentClipBoardOutputReference>()!;
        }

        [JsiiProperty(name: "mouse", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackingStoreSourceReservationsSourceQemuVdAgentMouseOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksBackingStoreSourceReservationsSourceQemuVdAgentMouseOutputReference Mouse
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksBackingStoreSourceReservationsSourceQemuVdAgentMouseOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "clipBoardInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackingStoreSourceReservationsSourceQemuVdAgentClipBoard\"}]}}", isOptional: true)]
        public virtual object? ClipBoardInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mouseInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackingStoreSourceReservationsSourceQemuVdAgentMouse\"}]}}", isOptional: true)]
        public virtual object? MouseInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackingStoreSourceReservationsSourceQemuVdAgent\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainDevicesDisksBackingStoreSourceReservationsSourceQemuVdAgent cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesDisksBackingStoreSourceReservationsSourceQemuVdAgent).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
