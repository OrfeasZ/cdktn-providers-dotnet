using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.EventsRule
{
    [JsiiInterface(nativeType: typeof(IEventsRuleActions), fullyQualifiedName: "oci.eventsRule.EventsRuleActions")]
    public interface IEventsRuleActions
    {
        /// <summary>action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/events_rule#action EventsRule#action}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.EventsRule.IEventsRuleActionsAction" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.eventsRule.EventsRuleActionsAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Action
        {
            get
            {
                return null;
            }
        }

        /// <summary>actions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/events_rule#actions EventsRule#actions}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.EventsRule.IEventsRuleActionsActions" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "actions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.eventsRule.EventsRuleActionsActions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Actions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEventsRuleActions), fullyQualifiedName: "oci.eventsRule.EventsRuleActions")]
        internal sealed class _Proxy : DeputyBase, oci.EventsRule.IEventsRuleActions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/events_rule#action EventsRule#action}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.EventsRule.IEventsRuleActionsAction" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "action", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.eventsRule.EventsRuleActionsAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Action
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>actions block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/events_rule#actions EventsRule#actions}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.EventsRule.IEventsRuleActionsActions" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "actions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.eventsRule.EventsRuleActionsActions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Actions
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
