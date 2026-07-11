using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SentinelAlertRuleScheduled
{
    [JsiiClass(nativeType: typeof(azurerm.SentinelAlertRuleScheduled.SentinelAlertRuleScheduledIncidentOutputReference), fullyQualifiedName: "azurerm.sentinelAlertRuleScheduled.SentinelAlertRuleScheduledIncidentOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SentinelAlertRuleScheduledIncidentOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SentinelAlertRuleScheduledIncidentOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SentinelAlertRuleScheduledIncidentOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SentinelAlertRuleScheduledIncidentOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putGrouping", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.sentinelAlertRuleScheduled.SentinelAlertRuleScheduledIncidentGrouping\"}}]")]
        public virtual void PutGrouping(azurerm.SentinelAlertRuleScheduled.ISentinelAlertRuleScheduledIncidentGrouping @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.SentinelAlertRuleScheduled.ISentinelAlertRuleScheduledIncidentGrouping)}, new object[]{@value});
        }

        [JsiiProperty(name: "grouping", typeJson: "{\"fqn\":\"azurerm.sentinelAlertRuleScheduled.SentinelAlertRuleScheduledIncidentGroupingOutputReference\"}")]
        public virtual azurerm.SentinelAlertRuleScheduled.SentinelAlertRuleScheduledIncidentGroupingOutputReference Grouping
        {
            get => GetInstanceProperty<azurerm.SentinelAlertRuleScheduled.SentinelAlertRuleScheduledIncidentGroupingOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "createIncidentEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? CreateIncidentEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "groupingInput", typeJson: "{\"fqn\":\"azurerm.sentinelAlertRuleScheduled.SentinelAlertRuleScheduledIncidentGrouping\"}", isOptional: true)]
        public virtual azurerm.SentinelAlertRuleScheduled.ISentinelAlertRuleScheduledIncidentGrouping? GroupingInput
        {
            get => GetInstanceProperty<azurerm.SentinelAlertRuleScheduled.ISentinelAlertRuleScheduledIncidentGrouping?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "createIncidentEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object CreateIncidentEnabled
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.sentinelAlertRuleScheduled.SentinelAlertRuleScheduledIncident\"}", isOptional: true)]
        public virtual azurerm.SentinelAlertRuleScheduled.ISentinelAlertRuleScheduledIncident? InternalValue
        {
            get => GetInstanceProperty<azurerm.SentinelAlertRuleScheduled.ISentinelAlertRuleScheduledIncident?>();
            set => SetInstanceProperty(value);
        }
    }
}
