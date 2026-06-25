using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlMysqlDbSystem
{
    [JsiiClass(nativeType: typeof(oci.MysqlMysqlDbSystem.MysqlMysqlDbSystemMaintenanceOutputReference), fullyQualifiedName: "oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemMaintenanceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MysqlMysqlDbSystemMaintenanceOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MysqlMysqlDbSystemMaintenanceOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MysqlMysqlDbSystemMaintenanceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MysqlMysqlDbSystemMaintenanceOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemMaintenanceMaintenanceDisabledWindows" />)[]</param>
        [JsiiMethod(name: "putMaintenanceDisabledWindows", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemMaintenanceMaintenanceDisabledWindows\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutMaintenanceDisabledWindows(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemMaintenanceMaintenanceDisabledWindows[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemMaintenanceMaintenanceDisabledWindows).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemMaintenanceMaintenanceDisabledWindows).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetMaintenanceDisabledWindows")]
        public virtual void ResetMaintenanceDisabledWindows()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaintenanceScheduleType")]
        public virtual void ResetMaintenanceScheduleType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVersionPreference")]
        public virtual void ResetVersionPreference()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVersionTrackPreference")]
        public virtual void ResetVersionTrackPreference()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "maintenanceDisabledWindows", typeJson: "{\"fqn\":\"oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemMaintenanceMaintenanceDisabledWindowsList\"}")]
        public virtual oci.MysqlMysqlDbSystem.MysqlMysqlDbSystemMaintenanceMaintenanceDisabledWindowsList MaintenanceDisabledWindows
        {
            get => GetInstanceProperty<oci.MysqlMysqlDbSystem.MysqlMysqlDbSystemMaintenanceMaintenanceDisabledWindowsList>()!;
        }

        [JsiiProperty(name: "targetVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeScheduled", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeScheduled
        {
            get => GetInstanceProperty<string>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemMaintenanceMaintenanceDisabledWindows" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maintenanceDisabledWindowsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemMaintenanceMaintenanceDisabledWindows\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? MaintenanceDisabledWindowsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maintenanceScheduleTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MaintenanceScheduleTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "versionPreferenceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VersionPreferenceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "versionTrackPreferenceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VersionTrackPreferenceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "windowStartTimeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WindowStartTimeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "maintenanceScheduleType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaintenanceScheduleType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "versionPreference", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VersionPreference
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "versionTrackPreference", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VersionTrackPreference
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "windowStartTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WindowStartTime
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemMaintenance\"}", isOptional: true)]
        public virtual oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemMaintenance? InternalValue
        {
            get => GetInstanceProperty<oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemMaintenance?>();
            set => SetInstanceProperty(value);
        }
    }
}
