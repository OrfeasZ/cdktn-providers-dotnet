using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.EventsRule
{
    [JsiiByValue(fqn: "oci.eventsRule.EventsRuleActions")]
    public class EventsRuleActions : oci.EventsRule.IEventsRuleActions
    {
        private object? _action;

        /// <summary>action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/events_rule#action EventsRule#action}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.EventsRule.IEventsRuleActionsAction" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "action", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.eventsRule.EventsRuleActionsAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Action
        {
            get => _action;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.EventsRule.IEventsRuleActionsAction[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.EventsRule.IEventsRuleActionsAction).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _action = value;
            }
        }

        private object? _actions;

        /// <summary>actions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/events_rule#actions EventsRule#actions}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.EventsRule.IEventsRuleActionsActions" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "actions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.eventsRule.EventsRuleActionsActions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Actions
        {
            get => _actions;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.EventsRule.IEventsRuleActionsActions[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.EventsRule.IEventsRuleActionsActions).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _actions = value;
            }
        }
    }
}
