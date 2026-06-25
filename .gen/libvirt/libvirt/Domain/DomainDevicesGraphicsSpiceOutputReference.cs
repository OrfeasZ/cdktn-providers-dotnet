using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainDevicesGraphicsSpiceOutputReference), fullyQualifiedName: "libvirt.domain.DomainDevicesGraphicsSpiceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DomainDevicesGraphicsSpiceOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DomainDevicesGraphicsSpiceOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DomainDevicesGraphicsSpiceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainDevicesGraphicsSpiceOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesGraphicsSpiceChannel" />)[]</param>
        [JsiiMethod(name: "putChannel", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSpiceChannel\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutChannel(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case libvirt.Domain.IDomainDevicesGraphicsSpiceChannel[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesGraphicsSpiceChannel).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesGraphicsSpiceChannel).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putClipBoard", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSpiceClipBoard\"}}]")]
        public virtual void PutClipBoard(libvirt.Domain.IDomainDevicesGraphicsSpiceClipBoard @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesGraphicsSpiceClipBoard)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFileTransfer", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSpiceFileTransfer\"}}]")]
        public virtual void PutFileTransfer(libvirt.Domain.IDomainDevicesGraphicsSpiceFileTransfer @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesGraphicsSpiceFileTransfer)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGl", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSpiceGl\"}}]")]
        public virtual void PutGl(libvirt.Domain.IDomainDevicesGraphicsSpiceGl @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesGraphicsSpiceGl)}, new object[]{@value});
        }

        [JsiiMethod(name: "putImage", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSpiceImage\"}}]")]
        public virtual void PutImage(libvirt.Domain.IDomainDevicesGraphicsSpiceImage @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesGraphicsSpiceImage)}, new object[]{@value});
        }

        [JsiiMethod(name: "putJpeg", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSpiceJpeg\"}}]")]
        public virtual void PutJpeg(libvirt.Domain.IDomainDevicesGraphicsSpiceJpeg @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesGraphicsSpiceJpeg)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesGraphicsSpiceListeners" />)[]</param>
        [JsiiMethod(name: "putListeners", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSpiceListeners\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutListeners(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case libvirt.Domain.IDomainDevicesGraphicsSpiceListeners[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesGraphicsSpiceListeners).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesGraphicsSpiceListeners).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMouse", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSpiceMouse\"}}]")]
        public virtual void PutMouse(libvirt.Domain.IDomainDevicesGraphicsSpiceMouse @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesGraphicsSpiceMouse)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPlayback", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSpicePlayback\"}}]")]
        public virtual void PutPlayback(libvirt.Domain.IDomainDevicesGraphicsSpicePlayback @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesGraphicsSpicePlayback)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStreaming", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSpiceStreaming\"}}]")]
        public virtual void PutStreaming(libvirt.Domain.IDomainDevicesGraphicsSpiceStreaming @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesGraphicsSpiceStreaming)}, new object[]{@value});
        }

        [JsiiMethod(name: "putZlib", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSpiceZlib\"}}]")]
        public virtual void PutZlib(libvirt.Domain.IDomainDevicesGraphicsSpiceZlib @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesGraphicsSpiceZlib)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAutoPort")]
        public virtual void ResetAutoPort()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetChannel")]
        public virtual void ResetChannel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClipBoard")]
        public virtual void ResetClipBoard()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConnected")]
        public virtual void ResetConnected()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefaultMode")]
        public virtual void ResetDefaultMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFileTransfer")]
        public virtual void ResetFileTransfer()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGl")]
        public virtual void ResetGl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetImage")]
        public virtual void ResetImage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJpeg")]
        public virtual void ResetJpeg()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKeymap")]
        public virtual void ResetKeymap()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetListen")]
        public virtual void ResetListen()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetListeners")]
        public virtual void ResetListeners()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMouse")]
        public virtual void ResetMouse()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPasswd")]
        public virtual void ResetPasswd()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPasswdValidTo")]
        public virtual void ResetPasswdValidTo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPlayback")]
        public virtual void ResetPlayback()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPort")]
        public virtual void ResetPort()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStreaming")]
        public virtual void ResetStreaming()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTlsPort")]
        public virtual void ResetTlsPort()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetZlib")]
        public virtual void ResetZlib()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "channel", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSpiceChannelList\"}")]
        public virtual libvirt.Domain.DomainDevicesGraphicsSpiceChannelList Channel
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesGraphicsSpiceChannelList>()!;
        }

        [JsiiProperty(name: "clipBoard", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSpiceClipBoardOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesGraphicsSpiceClipBoardOutputReference ClipBoard
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesGraphicsSpiceClipBoardOutputReference>()!;
        }

        [JsiiProperty(name: "fileTransfer", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSpiceFileTransferOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesGraphicsSpiceFileTransferOutputReference FileTransfer
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesGraphicsSpiceFileTransferOutputReference>()!;
        }

        [JsiiProperty(name: "gl", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSpiceGlOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesGraphicsSpiceGlOutputReference Gl
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesGraphicsSpiceGlOutputReference>()!;
        }

        [JsiiProperty(name: "image", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSpiceImageOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesGraphicsSpiceImageOutputReference Image
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesGraphicsSpiceImageOutputReference>()!;
        }

        [JsiiProperty(name: "jpeg", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSpiceJpegOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesGraphicsSpiceJpegOutputReference Jpeg
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesGraphicsSpiceJpegOutputReference>()!;
        }

        [JsiiProperty(name: "listeners", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSpiceListenersList\"}")]
        public virtual libvirt.Domain.DomainDevicesGraphicsSpiceListenersList Listeners
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesGraphicsSpiceListenersList>()!;
        }

        [JsiiProperty(name: "mouse", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSpiceMouseOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesGraphicsSpiceMouseOutputReference Mouse
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesGraphicsSpiceMouseOutputReference>()!;
        }

        [JsiiProperty(name: "playback", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSpicePlaybackOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesGraphicsSpicePlaybackOutputReference Playback
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesGraphicsSpicePlaybackOutputReference>()!;
        }

        [JsiiProperty(name: "streaming", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSpiceStreamingOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesGraphicsSpiceStreamingOutputReference Streaming
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesGraphicsSpiceStreamingOutputReference>()!;
        }

        [JsiiProperty(name: "zlib", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSpiceZlibOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesGraphicsSpiceZlibOutputReference Zlib
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesGraphicsSpiceZlibOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "autoPortInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AutoPortInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesGraphicsSpiceChannel" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "channelInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSpiceChannel\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ChannelInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesGraphicsSpiceClipBoard" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clipBoardInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSpiceClipBoard\"}]}}", isOptional: true)]
        public virtual object? ClipBoardInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectedInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConnectedInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DefaultModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesGraphicsSpiceFileTransfer" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fileTransferInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSpiceFileTransfer\"}]}}", isOptional: true)]
        public virtual object? FileTransferInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesGraphicsSpiceGl" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "glInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSpiceGl\"}]}}", isOptional: true)]
        public virtual object? GlInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesGraphicsSpiceImage" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "imageInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSpiceImage\"}]}}", isOptional: true)]
        public virtual object? ImageInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesGraphicsSpiceJpeg" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "jpegInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSpiceJpeg\"}]}}", isOptional: true)]
        public virtual object? JpegInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keymapInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KeymapInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesGraphicsSpiceListeners" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "listenersInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSpiceListeners\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ListenersInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "listenInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ListenInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesGraphicsSpiceMouse" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mouseInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSpiceMouse\"}]}}", isOptional: true)]
        public virtual object? MouseInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "passwdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PasswdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "passwdValidToInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PasswdValidToInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesGraphicsSpicePlayback" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "playbackInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSpicePlayback\"}]}}", isOptional: true)]
        public virtual object? PlaybackInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "portInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PortInput
        {
            get => GetInstanceProperty<double?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesGraphicsSpiceStreaming" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "streamingInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSpiceStreaming\"}]}}", isOptional: true)]
        public virtual object? StreamingInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tlsPortInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TlsPortInput
        {
            get => GetInstanceProperty<double?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesGraphicsSpiceZlib" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "zlibInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSpiceZlib\"}]}}", isOptional: true)]
        public virtual object? ZlibInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "autoPort", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object AutoPort
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "connected", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Connected
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "defaultMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "keymap", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Keymap
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "listen", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Listen
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "passwd", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Passwd
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "passwdValidTo", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PasswdValidTo
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Port
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tlsPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TlsPort
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesGraphicsSpice" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSpice\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainDevicesGraphicsSpice cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesGraphicsSpice).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
