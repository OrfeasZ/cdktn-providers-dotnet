using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WaitingRoomEvent
{
    [JsiiInterface(nativeType: typeof(IWaitingRoomEventConfig), fullyQualifiedName: "cloudflare.waitingRoomEvent.WaitingRoomEventConfig")]
    public interface IWaitingRoomEventConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>An ISO 8601 timestamp that marks the end of the event.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/waiting_room_event#event_end_time WaitingRoomEvent#event_end_time}
        /// </remarks>
        [JsiiProperty(name: "eventEndTime", typeJson: "{\"primitive\":\"string\"}")]
        string EventEndTime
        {
            get;
        }

        /// <summary>An ISO 8601 timestamp that marks the start of the event.</summary>
        /// <remarks>
        /// At this time, queued users will be processed with the event's configuration. The start time must be at least one minute before <c>event_end_time</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/waiting_room_event#event_start_time WaitingRoomEvent#event_start_time}
        /// </remarks>
        [JsiiProperty(name: "eventStartTime", typeJson: "{\"primitive\":\"string\"}")]
        string EventStartTime
        {
            get;
        }

        /// <summary>A unique name to identify the event. Only alphanumeric characters, hyphens and underscores are allowed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/waiting_room_event#name WaitingRoomEvent#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/waiting_room_event#waiting_room_id WaitingRoomEvent#waiting_room_id}.</summary>
        [JsiiProperty(name: "waitingRoomId", typeJson: "{\"primitive\":\"string\"}")]
        string WaitingRoomId
        {
            get;
        }

        /// <summary>If set, the event will override the waiting room's `custom_page_html` property while it is active.</summary>
        /// <remarks>
        /// If null, the event will inherit it.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/waiting_room_event#custom_page_html WaitingRoomEvent#custom_page_html}
        /// </remarks>
        [JsiiProperty(name: "customPageHtml", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CustomPageHtml
        {
            get
            {
                return null;
            }
        }

        /// <summary>A note that you can use to add more details about the event.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/waiting_room_event#description WaitingRoomEvent#description}
        /// </remarks>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>If set, the event will override the waiting room's `disable_session_renewal` property while it is active.</summary>
        /// <remarks>
        /// If null, the event will inherit it.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/waiting_room_event#disable_session_renewal WaitingRoomEvent#disable_session_renewal}
        /// </remarks>
        [JsiiProperty(name: "disableSessionRenewal", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DisableSessionRenewal
        {
            get
            {
                return null;
            }
        }

        /// <summary>If set, the event will override the waiting room's `new_users_per_minute` property while it is active.</summary>
        /// <remarks>
        /// If null, the event will inherit it. This can only be set if the event's <c>total_active_users</c> property is also set.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/waiting_room_event#new_users_per_minute WaitingRoomEvent#new_users_per_minute}
        /// </remarks>
        [JsiiProperty(name: "newUsersPerMinute", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? NewUsersPerMinute
        {
            get
            {
                return null;
            }
        }

        /// <summary>An ISO 8601 timestamp that marks when to begin queueing all users before the event starts.</summary>
        /// <remarks>
        /// The prequeue must start at least five minutes before <c>event_start_time</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/waiting_room_event#prequeue_start_time WaitingRoomEvent#prequeue_start_time}
        /// </remarks>
        [JsiiProperty(name: "prequeueStartTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PrequeueStartTime
        {
            get
            {
                return null;
            }
        }

        /// <summary>If set, the event will override the waiting room's `queueing_method` property while it is active.</summary>
        /// <remarks>
        /// If null, the event will inherit it.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/waiting_room_event#queueing_method WaitingRoomEvent#queueing_method}
        /// </remarks>
        [JsiiProperty(name: "queueingMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? QueueingMethod
        {
            get
            {
                return null;
            }
        }

        /// <summary>If set, the event will override the waiting room's `session_duration` property while it is active.</summary>
        /// <remarks>
        /// If null, the event will inherit it.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/waiting_room_event#session_duration WaitingRoomEvent#session_duration}
        /// </remarks>
        [JsiiProperty(name: "sessionDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SessionDuration
        {
            get
            {
                return null;
            }
        }

        /// <summary>If enabled, users in the prequeue will be shuffled randomly at the `event_start_time`.</summary>
        /// <remarks>
        /// Requires that <c>prequeue_start_time</c> is not null. This is useful for situations when many users will join the event prequeue at the same time and you want to shuffle them to ensure fairness. Naturally, it makes the most sense to enable this feature when the <c>queueing_method</c> during the event respects ordering such as <strong>fifo</strong>, or else the shuffling may be unnecessary.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/waiting_room_event#shuffle_at_event_start WaitingRoomEvent#shuffle_at_event_start}
        /// </remarks>
        [JsiiProperty(name: "shuffleAtEventStart", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ShuffleAtEventStart
        {
            get
            {
                return null;
            }
        }

        /// <summary>Suspends or allows an event.</summary>
        /// <remarks>
        /// If set to <c>true</c>, the event is ignored and traffic will be handled based on the waiting room configuration.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/waiting_room_event#suspended WaitingRoomEvent#suspended}
        /// </remarks>
        [JsiiProperty(name: "suspended", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Suspended
        {
            get
            {
                return null;
            }
        }

        /// <summary>If set, the event will override the waiting room's `total_active_users` property while it is active.</summary>
        /// <remarks>
        /// If null, the event will inherit it. This can only be set if the event's <c>new_users_per_minute</c> property is also set.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/waiting_room_event#total_active_users WaitingRoomEvent#total_active_users}
        /// </remarks>
        [JsiiProperty(name: "totalActiveUsers", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TotalActiveUsers
        {
            get
            {
                return null;
            }
        }

        /// <summary>If set, the event will override the waiting room's `turnstile_action` property while it is active.</summary>
        /// <remarks>
        /// If null, the event will inherit it.
        /// Available values: "log", "infinite_queue".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/waiting_room_event#turnstile_action WaitingRoomEvent#turnstile_action}
        /// </remarks>
        [JsiiProperty(name: "turnstileAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TurnstileAction
        {
            get
            {
                return null;
            }
        }

        /// <summary>If set, the event will override the waiting room's `turnstile_mode` property while it is active.</summary>
        /// <remarks>
        /// If null, the event will inherit it.
        /// Available values: "off", "invisible", "visible_non_interactive", "visible_managed".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/waiting_room_event#turnstile_mode WaitingRoomEvent#turnstile_mode}
        /// </remarks>
        [JsiiProperty(name: "turnstileMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TurnstileMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/waiting_room_event#zone_id WaitingRoomEvent#zone_id}
        /// </remarks>
        [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ZoneId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWaitingRoomEventConfig), fullyQualifiedName: "cloudflare.waitingRoomEvent.WaitingRoomEventConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.WaitingRoomEvent.IWaitingRoomEventConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>An ISO 8601 timestamp that marks the end of the event.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/waiting_room_event#event_end_time WaitingRoomEvent#event_end_time}
            /// </remarks>
            [JsiiProperty(name: "eventEndTime", typeJson: "{\"primitive\":\"string\"}")]
            public string EventEndTime
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>An ISO 8601 timestamp that marks the start of the event.</summary>
            /// <remarks>
            /// At this time, queued users will be processed with the event's configuration. The start time must be at least one minute before <c>event_end_time</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/waiting_room_event#event_start_time WaitingRoomEvent#event_start_time}
            /// </remarks>
            [JsiiProperty(name: "eventStartTime", typeJson: "{\"primitive\":\"string\"}")]
            public string EventStartTime
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>A unique name to identify the event. Only alphanumeric characters, hyphens and underscores are allowed.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/waiting_room_event#name WaitingRoomEvent#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/waiting_room_event#waiting_room_id WaitingRoomEvent#waiting_room_id}.</summary>
            [JsiiProperty(name: "waitingRoomId", typeJson: "{\"primitive\":\"string\"}")]
            public string WaitingRoomId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>If set, the event will override the waiting room's `custom_page_html` property while it is active.</summary>
            /// <remarks>
            /// If null, the event will inherit it.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/waiting_room_event#custom_page_html WaitingRoomEvent#custom_page_html}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customPageHtml", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CustomPageHtml
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A note that you can use to add more details about the event.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/waiting_room_event#description WaitingRoomEvent#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>If set, the event will override the waiting room's `disable_session_renewal` property while it is active.</summary>
            /// <remarks>
            /// If null, the event will inherit it.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/waiting_room_event#disable_session_renewal WaitingRoomEvent#disable_session_renewal}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "disableSessionRenewal", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? DisableSessionRenewal
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>If set, the event will override the waiting room's `new_users_per_minute` property while it is active.</summary>
            /// <remarks>
            /// If null, the event will inherit it. This can only be set if the event's <c>total_active_users</c> property is also set.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/waiting_room_event#new_users_per_minute WaitingRoomEvent#new_users_per_minute}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "newUsersPerMinute", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? NewUsersPerMinute
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>An ISO 8601 timestamp that marks when to begin queueing all users before the event starts.</summary>
            /// <remarks>
            /// The prequeue must start at least five minutes before <c>event_start_time</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/waiting_room_event#prequeue_start_time WaitingRoomEvent#prequeue_start_time}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "prequeueStartTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PrequeueStartTime
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>If set, the event will override the waiting room's `queueing_method` property while it is active.</summary>
            /// <remarks>
            /// If null, the event will inherit it.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/waiting_room_event#queueing_method WaitingRoomEvent#queueing_method}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "queueingMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? QueueingMethod
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>If set, the event will override the waiting room's `session_duration` property while it is active.</summary>
            /// <remarks>
            /// If null, the event will inherit it.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/waiting_room_event#session_duration WaitingRoomEvent#session_duration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sessionDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SessionDuration
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>If enabled, users in the prequeue will be shuffled randomly at the `event_start_time`.</summary>
            /// <remarks>
            /// Requires that <c>prequeue_start_time</c> is not null. This is useful for situations when many users will join the event prequeue at the same time and you want to shuffle them to ensure fairness. Naturally, it makes the most sense to enable this feature when the <c>queueing_method</c> during the event respects ordering such as <strong>fifo</strong>, or else the shuffling may be unnecessary.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/waiting_room_event#shuffle_at_event_start WaitingRoomEvent#shuffle_at_event_start}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "shuffleAtEventStart", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ShuffleAtEventStart
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Suspends or allows an event.</summary>
            /// <remarks>
            /// If set to <c>true</c>, the event is ignored and traffic will be handled based on the waiting room configuration.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/waiting_room_event#suspended WaitingRoomEvent#suspended}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "suspended", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Suspended
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>If set, the event will override the waiting room's `total_active_users` property while it is active.</summary>
            /// <remarks>
            /// If null, the event will inherit it. This can only be set if the event's <c>new_users_per_minute</c> property is also set.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/waiting_room_event#total_active_users WaitingRoomEvent#total_active_users}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "totalActiveUsers", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TotalActiveUsers
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>If set, the event will override the waiting room's `turnstile_action` property while it is active.</summary>
            /// <remarks>
            /// If null, the event will inherit it.
            /// Available values: "log", "infinite_queue".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/waiting_room_event#turnstile_action WaitingRoomEvent#turnstile_action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "turnstileAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TurnstileAction
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>If set, the event will override the waiting room's `turnstile_mode` property while it is active.</summary>
            /// <remarks>
            /// If null, the event will inherit it.
            /// Available values: "off", "invisible", "visible_non_interactive", "visible_managed".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/waiting_room_event#turnstile_mode WaitingRoomEvent#turnstile_mode}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "turnstileMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TurnstileMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Identifier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/waiting_room_event#zone_id WaitingRoomEvent#zone_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ZoneId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
