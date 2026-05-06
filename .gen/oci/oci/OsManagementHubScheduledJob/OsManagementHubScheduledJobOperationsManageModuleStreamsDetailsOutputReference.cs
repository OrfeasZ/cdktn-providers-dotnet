using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubScheduledJob
{
    [JsiiClass(nativeType: typeof(oci.OsManagementHubScheduledJob.OsManagementHubScheduledJobOperationsManageModuleStreamsDetailsOutputReference), fullyQualifiedName: "oci.osManagementHubScheduledJob.OsManagementHubScheduledJobOperationsManageModuleStreamsDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class OsManagementHubScheduledJobOperationsManageModuleStreamsDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public OsManagementHubScheduledJobOperationsManageModuleStreamsDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected OsManagementHubScheduledJobOperationsManageModuleStreamsDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OsManagementHubScheduledJobOperationsManageModuleStreamsDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDisable", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.osManagementHubScheduledJob.OsManagementHubScheduledJobOperationsManageModuleStreamsDetailsDisable\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDisable(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.OsManagementHubScheduledJob.IOsManagementHubScheduledJobOperationsManageModuleStreamsDetailsDisable[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.OsManagementHubScheduledJob.IOsManagementHubScheduledJobOperationsManageModuleStreamsDetailsDisable).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.OsManagementHubScheduledJob.IOsManagementHubScheduledJobOperationsManageModuleStreamsDetailsDisable).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEnable", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.osManagementHubScheduledJob.OsManagementHubScheduledJobOperationsManageModuleStreamsDetailsEnable\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutEnable(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.OsManagementHubScheduledJob.IOsManagementHubScheduledJobOperationsManageModuleStreamsDetailsEnable[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.OsManagementHubScheduledJob.IOsManagementHubScheduledJobOperationsManageModuleStreamsDetailsEnable).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.OsManagementHubScheduledJob.IOsManagementHubScheduledJobOperationsManageModuleStreamsDetailsEnable).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putInstall", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.osManagementHubScheduledJob.OsManagementHubScheduledJobOperationsManageModuleStreamsDetailsInstall\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutInstall(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.OsManagementHubScheduledJob.IOsManagementHubScheduledJobOperationsManageModuleStreamsDetailsInstall[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.OsManagementHubScheduledJob.IOsManagementHubScheduledJobOperationsManageModuleStreamsDetailsInstall).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.OsManagementHubScheduledJob.IOsManagementHubScheduledJobOperationsManageModuleStreamsDetailsInstall).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRemove", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.osManagementHubScheduledJob.OsManagementHubScheduledJobOperationsManageModuleStreamsDetailsRemove\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRemove(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.OsManagementHubScheduledJob.IOsManagementHubScheduledJobOperationsManageModuleStreamsDetailsRemove[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.OsManagementHubScheduledJob.IOsManagementHubScheduledJobOperationsManageModuleStreamsDetailsRemove).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.OsManagementHubScheduledJob.IOsManagementHubScheduledJobOperationsManageModuleStreamsDetailsRemove).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDisable")]
        public virtual void ResetDisable()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnable")]
        public virtual void ResetEnable()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstall")]
        public virtual void ResetInstall()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRemove")]
        public virtual void ResetRemove()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "disable", typeJson: "{\"fqn\":\"oci.osManagementHubScheduledJob.OsManagementHubScheduledJobOperationsManageModuleStreamsDetailsDisableList\"}")]
        public virtual oci.OsManagementHubScheduledJob.OsManagementHubScheduledJobOperationsManageModuleStreamsDetailsDisableList Disable
        {
            get => GetInstanceProperty<oci.OsManagementHubScheduledJob.OsManagementHubScheduledJobOperationsManageModuleStreamsDetailsDisableList>()!;
        }

        [JsiiProperty(name: "enable", typeJson: "{\"fqn\":\"oci.osManagementHubScheduledJob.OsManagementHubScheduledJobOperationsManageModuleStreamsDetailsEnableList\"}")]
        public virtual oci.OsManagementHubScheduledJob.OsManagementHubScheduledJobOperationsManageModuleStreamsDetailsEnableList Enable
        {
            get => GetInstanceProperty<oci.OsManagementHubScheduledJob.OsManagementHubScheduledJobOperationsManageModuleStreamsDetailsEnableList>()!;
        }

        [JsiiProperty(name: "install", typeJson: "{\"fqn\":\"oci.osManagementHubScheduledJob.OsManagementHubScheduledJobOperationsManageModuleStreamsDetailsInstallList\"}")]
        public virtual oci.OsManagementHubScheduledJob.OsManagementHubScheduledJobOperationsManageModuleStreamsDetailsInstallList Install
        {
            get => GetInstanceProperty<oci.OsManagementHubScheduledJob.OsManagementHubScheduledJobOperationsManageModuleStreamsDetailsInstallList>()!;
        }

        [JsiiProperty(name: "remove", typeJson: "{\"fqn\":\"oci.osManagementHubScheduledJob.OsManagementHubScheduledJobOperationsManageModuleStreamsDetailsRemoveList\"}")]
        public virtual oci.OsManagementHubScheduledJob.OsManagementHubScheduledJobOperationsManageModuleStreamsDetailsRemoveList Remove
        {
            get => GetInstanceProperty<oci.OsManagementHubScheduledJob.OsManagementHubScheduledJobOperationsManageModuleStreamsDetailsRemoveList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "disableInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.osManagementHubScheduledJob.OsManagementHubScheduledJobOperationsManageModuleStreamsDetailsDisable\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DisableInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enableInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.osManagementHubScheduledJob.OsManagementHubScheduledJobOperationsManageModuleStreamsDetailsEnable\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? EnableInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "installInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.osManagementHubScheduledJob.OsManagementHubScheduledJobOperationsManageModuleStreamsDetailsInstall\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? InstallInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "removeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.osManagementHubScheduledJob.OsManagementHubScheduledJobOperationsManageModuleStreamsDetailsRemove\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RemoveInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.osManagementHubScheduledJob.OsManagementHubScheduledJobOperationsManageModuleStreamsDetails\"}", isOptional: true)]
        public virtual oci.OsManagementHubScheduledJob.IOsManagementHubScheduledJobOperationsManageModuleStreamsDetails? InternalValue
        {
            get => GetInstanceProperty<oci.OsManagementHubScheduledJob.IOsManagementHubScheduledJobOperationsManageModuleStreamsDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
