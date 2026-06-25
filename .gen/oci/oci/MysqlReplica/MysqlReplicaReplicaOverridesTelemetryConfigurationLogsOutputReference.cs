using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlReplica
{
    [JsiiClass(nativeType: typeof(oci.MysqlReplica.MysqlReplicaReplicaOverridesTelemetryConfigurationLogsOutputReference), fullyQualifiedName: "oci.mysqlReplica.MysqlReplicaReplicaOverridesTelemetryConfigurationLogsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class MysqlReplicaReplicaOverridesTelemetryConfigurationLogsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public MysqlReplicaReplicaOverridesTelemetryConfigurationLogsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MysqlReplicaReplicaOverridesTelemetryConfigurationLogsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MysqlReplicaReplicaOverridesTelemetryConfigurationLogsOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.MysqlReplica.IMysqlReplicaReplicaOverridesTelemetryConfigurationLogsDestinationConfigurations" />)[]</param>
        [JsiiMethod(name: "putDestinationConfigurations", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.mysqlReplica.MysqlReplicaReplicaOverridesTelemetryConfigurationLogsDestinationConfigurations\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDestinationConfigurations(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.MysqlReplica.IMysqlReplicaReplicaOverridesTelemetryConfigurationLogsDestinationConfigurations[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.MysqlReplica.IMysqlReplicaReplicaOverridesTelemetryConfigurationLogsDestinationConfigurations).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.MysqlReplica.IMysqlReplicaReplicaOverridesTelemetryConfigurationLogsDestinationConfigurations).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiProperty(name: "destinationConfigurations", typeJson: "{\"fqn\":\"oci.mysqlReplica.MysqlReplicaReplicaOverridesTelemetryConfigurationLogsDestinationConfigurationsList\"}")]
        public virtual oci.MysqlReplica.MysqlReplicaReplicaOverridesTelemetryConfigurationLogsDestinationConfigurationsList DestinationConfigurations
        {
            get => GetInstanceProperty<oci.MysqlReplica.MysqlReplicaReplicaOverridesTelemetryConfigurationLogsDestinationConfigurationsList>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.MysqlReplica.IMysqlReplicaReplicaOverridesTelemetryConfigurationLogsDestinationConfigurations" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "destinationConfigurationsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.mysqlReplica.MysqlReplicaReplicaOverridesTelemetryConfigurationLogsDestinationConfigurations\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DestinationConfigurationsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "destinationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DestinationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logTypesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? LogTypesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "destination", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Destination
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "logTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] LogTypes
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="oci.MysqlReplica.IMysqlReplicaReplicaOverridesTelemetryConfigurationLogs" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.mysqlReplica.MysqlReplicaReplicaOverridesTelemetryConfigurationLogs\"}]}}", isOptional: true)]
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
                        case oci.MysqlReplica.IMysqlReplicaReplicaOverridesTelemetryConfigurationLogs cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.MysqlReplica.IMysqlReplicaReplicaOverridesTelemetryConfigurationLogs).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
