using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxWebAppSlot
{
    [JsiiClass(nativeType: typeof(azurerm.LinuxWebAppSlot.LinuxWebAppSlotLogsOutputReference), fullyQualifiedName: "azurerm.linuxWebAppSlot.LinuxWebAppSlotLogsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class LinuxWebAppSlotLogsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public LinuxWebAppSlotLogsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected LinuxWebAppSlotLogsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LinuxWebAppSlotLogsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putApplicationLogs", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.linuxWebAppSlot.LinuxWebAppSlotLogsApplicationLogs\"}}]")]
        public virtual void PutApplicationLogs(azurerm.LinuxWebAppSlot.ILinuxWebAppSlotLogsApplicationLogs @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.LinuxWebAppSlot.ILinuxWebAppSlotLogsApplicationLogs)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHttpLogs", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.linuxWebAppSlot.LinuxWebAppSlotLogsHttpLogs\"}}]")]
        public virtual void PutHttpLogs(azurerm.LinuxWebAppSlot.ILinuxWebAppSlotLogsHttpLogs @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.LinuxWebAppSlot.ILinuxWebAppSlotLogsHttpLogs)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetApplicationLogs")]
        public virtual void ResetApplicationLogs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDetailedErrorMessages")]
        public virtual void ResetDetailedErrorMessages()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFailedRequestTracing")]
        public virtual void ResetFailedRequestTracing()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttpLogs")]
        public virtual void ResetHttpLogs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "applicationLogs", typeJson: "{\"fqn\":\"azurerm.linuxWebAppSlot.LinuxWebAppSlotLogsApplicationLogsOutputReference\"}")]
        public virtual azurerm.LinuxWebAppSlot.LinuxWebAppSlotLogsApplicationLogsOutputReference ApplicationLogs
        {
            get => GetInstanceProperty<azurerm.LinuxWebAppSlot.LinuxWebAppSlotLogsApplicationLogsOutputReference>()!;
        }

        [JsiiProperty(name: "httpLogs", typeJson: "{\"fqn\":\"azurerm.linuxWebAppSlot.LinuxWebAppSlotLogsHttpLogsOutputReference\"}")]
        public virtual azurerm.LinuxWebAppSlot.LinuxWebAppSlotLogsHttpLogsOutputReference HttpLogs
        {
            get => GetInstanceProperty<azurerm.LinuxWebAppSlot.LinuxWebAppSlotLogsHttpLogsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "applicationLogsInput", typeJson: "{\"fqn\":\"azurerm.linuxWebAppSlot.LinuxWebAppSlotLogsApplicationLogs\"}", isOptional: true)]
        public virtual azurerm.LinuxWebAppSlot.ILinuxWebAppSlotLogsApplicationLogs? ApplicationLogsInput
        {
            get => GetInstanceProperty<azurerm.LinuxWebAppSlot.ILinuxWebAppSlotLogsApplicationLogs?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "detailedErrorMessagesInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? DetailedErrorMessagesInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "failedRequestTracingInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? FailedRequestTracingInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpLogsInput", typeJson: "{\"fqn\":\"azurerm.linuxWebAppSlot.LinuxWebAppSlotLogsHttpLogs\"}", isOptional: true)]
        public virtual azurerm.LinuxWebAppSlot.ILinuxWebAppSlotLogsHttpLogs? HttpLogsInput
        {
            get => GetInstanceProperty<azurerm.LinuxWebAppSlot.ILinuxWebAppSlotLogsHttpLogs?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "detailedErrorMessages", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object DetailedErrorMessages
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

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "failedRequestTracing", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object FailedRequestTracing
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

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.linuxWebAppSlot.LinuxWebAppSlotLogs\"}", isOptional: true)]
        public virtual azurerm.LinuxWebAppSlot.ILinuxWebAppSlotLogs? InternalValue
        {
            get => GetInstanceProperty<azurerm.LinuxWebAppSlot.ILinuxWebAppSlotLogs?>();
            set => SetInstanceProperty(value);
        }
    }
}
