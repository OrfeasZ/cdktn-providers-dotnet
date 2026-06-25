using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlReplica
{
    [JsiiClass(nativeType: typeof(oci.MysqlReplica.MysqlReplicaReplicaOverridesTelemetryConfigurationOutputReference), fullyQualifiedName: "oci.mysqlReplica.MysqlReplicaReplicaOverridesTelemetryConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MysqlReplicaReplicaOverridesTelemetryConfigurationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MysqlReplicaReplicaOverridesTelemetryConfigurationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MysqlReplicaReplicaOverridesTelemetryConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MysqlReplicaReplicaOverridesTelemetryConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.MysqlReplica.IMysqlReplicaReplicaOverridesTelemetryConfigurationLogs" />)[]</param>
        [JsiiMethod(name: "putLogs", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.mysqlReplica.MysqlReplicaReplicaOverridesTelemetryConfigurationLogs\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutLogs(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.MysqlReplica.IMysqlReplicaReplicaOverridesTelemetryConfigurationLogs[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.MysqlReplica.IMysqlReplicaReplicaOverridesTelemetryConfigurationLogs).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.MysqlReplica.IMysqlReplicaReplicaOverridesTelemetryConfigurationLogs).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetLogs")]
        public virtual void ResetLogs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "logs", typeJson: "{\"fqn\":\"oci.mysqlReplica.MysqlReplicaReplicaOverridesTelemetryConfigurationLogsList\"}")]
        public virtual oci.MysqlReplica.MysqlReplicaReplicaOverridesTelemetryConfigurationLogsList Logs
        {
            get => GetInstanceProperty<oci.MysqlReplica.MysqlReplicaReplicaOverridesTelemetryConfigurationLogsList>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.MysqlReplica.IMysqlReplicaReplicaOverridesTelemetryConfigurationLogs" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "logsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.mysqlReplica.MysqlReplicaReplicaOverridesTelemetryConfigurationLogs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? LogsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.mysqlReplica.MysqlReplicaReplicaOverridesTelemetryConfiguration\"}", isOptional: true)]
        public virtual oci.MysqlReplica.IMysqlReplicaReplicaOverridesTelemetryConfiguration? InternalValue
        {
            get => GetInstanceProperty<oci.MysqlReplica.IMysqlReplicaReplicaOverridesTelemetryConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
