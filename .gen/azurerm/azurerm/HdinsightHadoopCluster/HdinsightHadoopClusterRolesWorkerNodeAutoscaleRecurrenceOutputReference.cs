using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightHadoopCluster
{
    [JsiiClass(nativeType: typeof(azurerm.HdinsightHadoopCluster.HdinsightHadoopClusterRolesWorkerNodeAutoscaleRecurrenceOutputReference), fullyQualifiedName: "azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterRolesWorkerNodeAutoscaleRecurrenceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class HdinsightHadoopClusterRolesWorkerNodeAutoscaleRecurrenceOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public HdinsightHadoopClusterRolesWorkerNodeAutoscaleRecurrenceOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected HdinsightHadoopClusterRolesWorkerNodeAutoscaleRecurrenceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected HdinsightHadoopClusterRolesWorkerNodeAutoscaleRecurrenceOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRolesWorkerNodeAutoscaleRecurrenceSchedule" />)[]</param>
        [JsiiMethod(name: "putSchedule", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterRolesWorkerNodeAutoscaleRecurrenceSchedule\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSchedule(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRolesWorkerNodeAutoscaleRecurrenceSchedule[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRolesWorkerNodeAutoscaleRecurrenceSchedule).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRolesWorkerNodeAutoscaleRecurrenceSchedule).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiProperty(name: "schedule", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterRolesWorkerNodeAutoscaleRecurrenceScheduleList\"}")]
        public virtual azurerm.HdinsightHadoopCluster.HdinsightHadoopClusterRolesWorkerNodeAutoscaleRecurrenceScheduleList Schedule
        {
            get => GetInstanceProperty<azurerm.HdinsightHadoopCluster.HdinsightHadoopClusterRolesWorkerNodeAutoscaleRecurrenceScheduleList>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRolesWorkerNodeAutoscaleRecurrenceSchedule" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scheduleInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterRolesWorkerNodeAutoscaleRecurrenceSchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ScheduleInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timezoneInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimezoneInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Timezone
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterRolesWorkerNodeAutoscaleRecurrence\"}", isOptional: true)]
        public virtual azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRolesWorkerNodeAutoscaleRecurrence? InternalValue
        {
            get => GetInstanceProperty<azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRolesWorkerNodeAutoscaleRecurrence?>();
            set => SetInstanceProperty(value);
        }
    }
}
